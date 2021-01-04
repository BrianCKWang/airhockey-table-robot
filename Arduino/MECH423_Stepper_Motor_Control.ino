const int pinHigh = 9;
const int pinLow = 8;
const int pinDir = 4;
const int pinPWM = 3;
const int pinLED = 13;
volatile boolean  LED_flag = false;
const int START_SPEED = 2000; // Hz
const int MAX_SPEED = 45000;   // HZ


/*==================== Physical Parameters for converting pixels to count ===================================*/
/*======================== (not necessary if only using pixel for control) ==================================*/
const float pi              = 3.14159;
const float pulleyDiameter  = 19.26;                // [mm] diameter
const float pulleyCirc      = pulleyDiameter * pi;  // [mm] circumference

const float maxDistance     = 230;          // [mm] total physical distance the
                                            // mallet is moving

const int steppingMode      = 8;             // microstepping 1/16th
const int stepPerRev        = 200;           // NEMA 17 stepper motor - steps/revolution
const float countPerLength  = stepPerRev * steppingMode / pulleyCirc; // count(steps) per length [mm]
const int maxCount          = countPerLength * maxDistance;       // maximum number of counts (mapped
// to maxDistance)

const int pixelResolution   = 160;                                 // 160 px (using 40-240 out of 0-240px)
const float lengthPerPixel  = maxDistance / pixelResolution;       // [mm] length per pixel
const int pixelToCount      = lengthPerPixel * countPerLength;     // conversion from px to count

/*==================================== Global Variables for Positioning =====================================*/
volatile int positionIndex      = 40 * pixelToCount;  // Used for tracking number of steps the motor has taken
volatile int positionIndexCam   = 0;
volatile int positionTarget     = 40 * pixelToCount;  // Assume we start in the middle of playing area
volatile int positionTargetlast = 0;

byte b;
byte b1 = 0;
int b_int = 0;
volatile int b2 = 0;
volatile int b3 = 0;
volatile int movingFlag     = 0;                // Flag to determine if system is moving or not
volatile boolean fullPacketFlag     = false;

/*==================================== Control ==============================================================*/
volatile int A              = 50;      // Frequency increment
volatile long timeMicro     = 0;        // Used to keep track of time
float timePeriod            = 0;        // Hold the calculated delay for PWM

volatile int Kp = 200;                  // Proportional Gain
volatile double Ki = 0.0000015;                   // Integrator Gain
volatile int error = 0;                 // Error between target position and current position
volatile int errorThreshold = 180;            // Threshold to begin adding on frequency
volatile double errorSum = 0;

volatile long currentTime = 0;
volatile long lastTime = 0;
volatile long timeChange = 0;

volatile long output = 0;

/*======================================= Circular Buffer Variables =========================================*/
volatile int packetBuffer[10];        // Declare size of buffer array
volatile int bufferMax = 10;          // Maximum size of buffer
volatile int bufferSize = 0;          //
volatile int bufferStart = 0;
volatile int bufferEnd = 0;

volatile int packetStart = 0;         // Index for start of latest packet

/*================================== Timer ==================================================================*/
// Interrupt variables
volatile uint32_t frequency_PWM = START_SPEED; // this value divide by 2 for actual pwm freq
volatile boolean  PWM_flag = false;

/*================================== Timer ISR ==============================================================*/
void TC6_Handler() {  // GPS timer
  TC_GetStatus(TC2, 0); // Accept interrupt

  // Increase speed (PWM frequency)
  if (output > MAX_SPEED) {
    output = MAX_SPEED;
  }
  if ( frequency_PWM >= 0 && frequency_PWM < MAX_SPEED && movingFlag == 1) {
    /*if( output > errorThreshold){      
      frequency_PWM = frequency_PWM + A;
    }
    else {
      */
      frequency_PWM = output;
      //digitalWrite(pinLED, LED_flag = !LED_flag);
    //}
  }
  else {
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
  startTimer(TC2, 0, TC6_IRQn, 10000); // Timer freq is twice PWM freq

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

      /*====================== Update PWM frequency =========================================== */
  if ( timeMicro > micros() ) {  // Deal with overflow
    timeMicro = micros();
  }

  // If the time interval has passed then execute one high/low pulse
  if (frequency_PWM == 0) {
    frequency_PWM = 1;
    timePeriod = (1 / (float)frequency_PWM) * 1000000.0;
  }
  else {
    timePeriod = (1 / (float)frequency_PWM) * 1000000.0;
  }


  if ( (micros() - timeMicro) > timePeriod ) {

    timeMicro = micros();

    if ( positionIndex == positionTarget ) {
      movingFlag = 0;
      //errorSum = 0;
      frequency_PWM = START_SPEED;    // Reset to initial frequency (velocity)
    }

    else if ( positionIndex < positionTarget ) {
      digitalWrite(pinDir, LOW);   // go

      movingFlag = 1;
    }

    else if ( positionIndex > positionTarget ) {
      digitalWrite(pinDir, HIGH);    // go back


      movingFlag = 1;

    }

       /*================ Generate PWM (turn pin HIGH/LOW) ================================*/
    if ( movingFlag == 0 ) {
      digitalWrite(pinPWM, LOW);
    }
    else {
      digitalWrite(pinPWM, HIGH);
      delayMicroseconds(timePeriod);
      digitalWrite(pinPWM, LOW);

    }
    //Serial.print(positionIndex);
    //Serial.print('\n');
  }

      /*==================== Read from serial =============================================*/
  while (Serial.available()) {
    if (bufferSize < bufferMax) {
      b = Serial.read();
      packetBuffer[bufferEnd] = b;

      bufferEnd = (bufferEnd + 1) % bufferMax;
      bufferSize++;
    }
  }

  // Only parse buffer with at least least 3 bytes (start, postionTarget, positionIndex)
  if ( bufferSize >= 3) {

    while ( bufferSize > 0 ) {
      if (packetBuffer[bufferStart] == 255 && ((bufferStart + 2) % bufferMax) <= bufferEnd) {
        // save start index of last complete packet
        packetStart = bufferStart;
      }
      bufferStart = (bufferStart + 1) % bufferMax;
      bufferSize--;

    }

    if (packetBuffer[packetStart] == 255 && ((packetStart + 2) % bufferMax) <= bufferEnd) {
      positionTarget = packetBuffer[(packetStart + 1) % bufferMax];
      positionIndexCam = packetBuffer[(packetStart + 2) % bufferMax];
      //Serial.print(positionTarget);
      fullPacketFlag = 1;
    }

  }

  //b = Serial.read();
  //positionTarget = b;
  //b1 = Serial.read();
  //Serial.println(b1);

/*========================= Update current position and target position =================== */
  if (fullPacketFlag == true) {

    // Update target
    if ( positionTarget > 200) {
      positionTarget = 200;
    }
    else if (positionTarget < 40) {
      positionTarget = 40;
    }
    //positionTarget = pixelToCount * positionTarget;
    positionTarget = positionTarget;

    // Update count index
    if ( positionIndex > 200) {
      positionIndex = 200;
    }
    else if (positionIndex < 40) {
      positionIndex = 40;
    }
    //positionIndex = pixelToCount * positionIndexCam;
    positionIndex = positionIndexCam;

    // Reset flag
    fullPacketFlag = 0;

    // Controller
    currentTime = micros();
    timeChange = currentTime - lastTime;
    
    error = positionTarget - positionIndex;
    errorSum = errorSum + (error * timeChange);
    output = abs( (Kp*error) + (Ki*errorSum) );
    
    lastTime = currentTime;
    
    Serial.print(error);
  }
  
}
