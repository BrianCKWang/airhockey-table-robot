const int pinHigh = 9;
const int pinLow = 8;
const int pinDir = 4;
const int pinPWM = 3;
const int pinLED = 13;
volatile boolean  LED_flag = false;

/* Adjust these as necessary */

// Physical Parameters
const float pi              = 3.14159;
const float pulleyDiameter  = 19.26;            // [mm] diameter
const float pulleyCirc      = pulleyDiameter * pi; // [mm] circumference

const float maxDistance     = 230;          // [mm] total physical distance the
// mallet is moving

const int steppingMode      = 8;             // microstepping 1/16th
const int stepPerRev        = 200;            // NEMA 17 stepper motor - steps/revolution
const float countPerLength  = stepPerRev * steppingMode / pulleyCirc; // count(steps) per length [mm]
const int maxCount          = countPerLength * maxDistance;       // maximum number of counts (mapped
                                                                  // to maxDistance)

const int pixelResolution   = 160;            // 160 px (using 40-240 out of 0-240px)
const float lengthPerPixel  = maxDistance / pixelResolution;       // [mm] length per pixel
const int pixelToCount      = lengthPerPixel * countPerLength;     // conversion from px to count

// Global Variables for Positioning
volatile int positionIndex  = 40*pixelToCount;    // Used for tracking number of steps the motor has taken
volatile int positionTarget = 40*pixelToCount;    // Assume we start in the middle of playing area
        byte b;
volatile int movingFlag     = 0;                // Flag to determine if system is moving or not

// Trajectory Generation
volatile int A              = 100;          // Frequency increment
volatile long timeMicro     = 0;        // Used to keep track of time
float timePeriod            = 0;            // Hold the calculated delay for PWM

/*================================== Timer ==================================*/
// Interrupt variables
volatile uint32_t frequency_PWM = 10000; // this value divide by 2 for actual pwm freq
volatile boolean  PWM_flag = false;

/*================================== Timer ISR ==================================*/
void TC6_Handler() {  // GPS timer
  TC_GetStatus(TC2, 0); // Accept interrupt
/*  
  // LED for testing
  
    if(movingFlag == 0){
    digitalWrite(pinLED, HIGH);
    movingFlag = 1;
    }
    else if(movingFlag == 1){
      digitalWrite(pinLED, LOW);
      movingFlag = 0;
    }
*/  
 
    // Increase speed (PWM frequency)
    if( frequency_PWM >= 0 && frequency_PWM < 60000 && movingFlag == 1){
      frequency_PWM = frequency_PWM + 500;
      //digitalWrite(pinLED, LED_flag = !LED_flag);
    }
    else{
      // do not change frequency
    }
}


/*================================== Timer setup ==================================*/
void startTimer(Tc *tc, uint32_t channel, IRQn_Type irq, uint32_t frequency) {
  pmc_set_writeprotect(false);
  pmc_enable_periph_clk((uint32_t)irq);
  TC_Configure(tc, channel, TC_CMR_WAVE | TC_CMR_WAVSEL_UP_RC | TC_CMR_TCCLKS_TIMER_CLOCK4);
  uint32_t rc = VARIANT_MCK / 128 / frequency; //128 because we selected TIMER_CLOCK4 above
  TC_SetRA(tc, channel, rc / 2); //50% high, 50% low
  TC_SetRC(tc, channel, rc);
  TC_Start(tc, channel);
  tc->TC_CHANNEL[channel].TC_IER = TC_IER_CPCS;
  tc->TC_CHANNEL[channel].TC_IDR = ~TC_IER_CPCS;
  NVIC_EnableIRQ(irq);
}


void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(57600);

  // Set modes for digital pins
  // Pins for turning on DRV884 chip on MECH423 Motor Board
  pinMode(pinHigh, OUTPUT);   // HIGH
  pinMode(pinLow, OUTPUT);   // LOW
  pinMode(pinDir, OUTPUT);   // DIRECTION
  pinMode(pinPWM, OUTPUT);   // PWM
  pinMode(pinLED, OUTPUT);   // LED for blinking

  // Initialize pins
  digitalWrite(pinHigh, HIGH);
  digitalWrite(pinLow, LOW);
  digitalWrite(pinDir, HIGH);  // DIR = 1
  //digitalWrite(pinLED, HIGH);

  // Timer Setup
  startTimer(TC2, 0, TC6_IRQn, 1000); // Timer freq is twice PWM freq

}

void loop() {
/*
  // Read value from serial and set as PWM frequency
  if(Serial.available()){
    frequency_PWM = Serial.parseInt();
    Serial.println(frequency_PWM);
    startTimer(TC2, 0, TC6_IRQn, frequency_PWM);
    //movingFlag = 1; // set flag to zero to see if motor stops
    //digitalWrite(pinDir, LOW);  // change from HIGH to LOW
  }
*/
  // Update frequency /////////////////////////////////////////////
  if( timeMicro > micros() ){    // Deal with overflow
    timeMicro = micros();
  }

  // If the time interval has passed then execute one high/low pulse
  timePeriod = (1/(float)frequency_PWM)*1000000.0;
  
  if( (micros() - timeMicro) > timePeriod ){
    
    timeMicro = micros();
    
    if ( positionIndex == positionTarget ) { // missed one step?
      movingFlag = 0;
      frequency_PWM = 10000;    // Reset to initial frequency (velocity)
    }
  
    else if ( positionIndex < positionTarget ) {
      digitalWrite(pinDir, LOW);   // go
      
      if ( movingFlag == 0) {
        movingFlag = 1;
      }
      
      positionIndex++;
    }

    else if ( positionIndex > positionTarget ) { 
      digitalWrite(pinDir, HIGH);    // go back
      
      if ( movingFlag == 0) {
        movingFlag = 1;
      }
      
      positionIndex--;
    }

  // Generate PWM (turn pin HIGH/LOW) ///////////////////////////////
    if ( movingFlag == 0 ) {
      digitalWrite(pinPWM, LOW);
    }
    else {
      digitalWrite(pinPWM, PWM_flag = !PWM_flag); 
      delayMicroseconds(timePeriod);
      digitalWrite(pinPWM, PWM_flag = !PWM_flag);

    }
  }

  // Read position from serial /////////////////////////////////////
  if (Serial.available()) {
    b = Serial.read();
    positionTarget = b;
    //positionTarget = Serial.parseInt();
    //Serial.println(positionTarget);

    if ( positionTarget > 200) {
      positionTarget = 200;
    }
    else if (positionTarget < 40) {
      positionTarget = 40;
    }

    positionTarget = pixelToCount * positionTarget;
  }


}
