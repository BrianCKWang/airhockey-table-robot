using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;


namespace CameraCapture
{
    public partial class lblConvertTest : Form
    {
        #region Globle Var
        //declaring global variables

        const int frameFps = 60;
        const double interval = 1 / 60.0;
        const int frameWidth = 320;
        const int frameHeight = 240;
        const int MALLET_LIMIT_LOWER = 88;
        const int MALLET_LIMIT_UPPER = 146;
        const int MALLET_LIMIT_CENTER = 120;
        const int ALPHA_PUCK_P = 27;
        const int ALPHA_PUCK_V = 27;
        const int ALPHA_MALLET_P = 27;
        const int BAUDRATE = 57600;
        const int RETURNCOUNTTH = 10;

        int malletDestinationRange = 25;
        int malletCurrentRange = 2;
        double puckJitterRange = 1.5;

        bool isFrameSkipped = false;
        // Saving data to file
        StreamWriter outputFile;
        string pathName = @"C:\Dropbox\Mech 5_2\423\Final Project\Vision\CameraCapture EMGU 3_1\CameraCapture\bin\Debug";
        bool initializeFile = false;

        int upperR = 0,
            upperG = 0,
            upperB = 0,
            lowerR = 0,
            lowerG = 0,
            lowerB = 0;
        Mat mat = new Mat();

        private Capture capture;
        private bool captureInProgress;
        Image<Bgr, Byte> ImageFrame = new Image<Bgr, Byte>(frameWidth, frameHeight);
        Image<Hsv, Byte> hsvImage = new Image<Hsv, Byte>(0, 0);
        Image<Bgr, Byte> ImageHSVwheel = new Image<Bgr, Byte>("HSV-Wheel.png");
        Image<Bgr, Byte> ImageHSVwheel_filtered = new Image<Bgr, Byte>("HSV-Wheel.png");

        Image<Bgr, byte> img_bitmap;
        Image<Bgr, Byte> img = new Image<Bgr, Byte>(frameWidth, frameHeight);
       
        Mat uimage = new Mat();
        Mat rimage = new Mat();
        Mat pyrDown = new Mat();
        static Size frameSize = new Size(frameWidth, frameHeight);
        VideoWriter file_Quarry = new VideoWriter(@"quarry.avi", frameFps, frameSize, true);

        int diff_LH;
        long frameIndex = 1;

        double puckX = 0;
        double puckY = 0;
        double puckX_last = 0;
        double puckY_last = 0;
        double puckX_velocity = 0;
        double puckY_velocity = 0;
        double malletX = 0;
        double malletY = 0;

        double puck_alpha = 0.5;
        double puck_alpha_V = 0.5;
        int framesSkipped = 1;
        int puckRadius = 0;

        int tableBondaryPt1X = 0;
        int tableBondaryPt1Y = 0;
        int tableBondaryPt2X = 0;
        int tableBondaryPt2Y = 0;
        int tableBondaryPt1X_clicked = 0;
        int tableBondaryPt1Y_clicked = 0;
        int tableBondaryPt2X_clicked = 0;
        int tableBondaryPt2Y_clicked = 0;
        int tableBondaryPt1X_puckBounce = 0;
        int tableBondaryPt1Y_puckBounce = 0;
        int tableBondaryPt2X_puckBounce = 0;
        int tableBondaryPt2Y_puckBounce = 0;

        bool pt1_selected = false;
        bool pt2_selected = false;

        bool serialTransmit_flag = false;
        bool serialTransmitSaveData_flag = false;

        bool serialTransmit_flag_timer = false;
        int destinationLocation_int = 0;
        int currentLocation_int = 0;
        byte destinationLocation = 0;
        byte currentLocation = 0;
        byte malletPreviousTargetLocationY = 0;
        byte malletPreviousCurrentLocationY = 0;

        int returnCount = 0;

        bool ib3C;
        int ib3C_HV, ib3C_Lable_X, ib3C_Lable_Y;
        #endregion

        double ms = (DateTime.Now - DateTime.MinValue).TotalMilliseconds;
        //Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(2); // Use only the second core 
        Stopwatch stopWatch = new Stopwatch();
        

        private void CameraCapture_Load(object sender, EventArgs e)
        {
            stopWatch.Start();

            ckbByte1.Checked = false;
            ckbByte2.Checked = false;
            ckbByte3.Checked = false;
            ckbByte4.Checked = false;
            ckbByte5.Checked = false;
            txtByte1.Enabled = false;
            txtByte2.Enabled = false;
            txtByte3.Enabled = false;
            txtByte4.Enabled = false;
            txtByte5.Enabled = false;

            txtBaudRate.Text = BAUDRATE.ToString();

            ckbShowResponse.Checked = true;
            ckbSendByte.Checked = true;
            ckbBackToCenter.Checked = false;
            ckbOverlayPuckDetection.Checked = true;
            ckbOverlayMalletDetection.Checked = true;
            ckbPacketContent.Checked = true;
            ckbUseConstantTargetPos.Checked = false;

            nmc_Puck_Alpha_P.Value = ALPHA_PUCK_P;
            nmc_Puck_Alpha_V.Value = ALPHA_PUCK_V;
            nmc_Mallet_Alpha_P.Value = ALPHA_MALLET_P;

            nmcMalletCenter.Value = MALLET_LIMIT_CENTER;
            nmcMalletLowerLimit.Value = MALLET_LIMIT_LOWER;
            nmcMalletUpperLimit.Value = MALLET_LIMIT_UPPER;

            nmc_returnCountTH.Value = RETURNCOUNTTH;

            ComPortUpdate();
        }

        public lblConvertTest()
        {
            InitializeComponent();
            img_HSVwheel.Image = ImageHSVwheel;
            img_HSVwheel_filtered.Image = ImageHSVwheel_filtered;
            img_HSVwheel_filtered2.Image = ImageHSVwheel_filtered;
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            

            
            mat = capture.QueryFrame();
            ImageFrame = mat.ToImage<Bgr, Byte>();
            img = mat.ToImage<Bgr, Byte>();

            CvInvoke.CvtColor(img, uimage, ColorConversion.Bgr2Gray);

            //use image pyr to remove noise
            
            CvInvoke.PyrDown(uimage, pyrDown);
            CvInvoke.PyrUp(pyrDown, uimage);
            
            Hsv lowerLimit = new Hsv(upperR, upperG, upperB);
            Hsv upperLimit = new Hsv(lowerR, lowerG, lowerB);
            Image<Hsv, byte> hsv = mat.ToImage<Hsv, byte>();
            Image<Gray, byte> imageHSVDest = hsv.InRange(lowerLimit, upperLimit);
            
            img_bitmap = mat.ToImage<Bgr, Byte>();
            //Image <Bgr, byte> blur = img_bitmap.SmoothBlur(10, 10, true);
            //Image<Bgr, byte> mediansmooth = img_bitmap.SmoothMedian(15);
            //Image<Bgr, byte> bilat = img_bitmap.SmoothBilatral(7, 255, 34);
            Image<Bgr, byte> gauss = img_bitmap.SmoothGaussian(3, 3, 34.3, 45.3);
            
            ImageProcessing();

            #region Send Data thru Serial
            if (ckbTransmit.Checked )
            {
                
                if (ckbUseConstantTargetPos.Checked)
                {
                    #region Constant target position
                    // Convert target location
                    destinationLocation = checkBoundary_intToByte(Convert.ToInt16(nmc_malletTargetPosTest.Value));

                    if (txtMalletCurrentY.Text != "")
                    {
                        // Convert current location
                        currentLocation = checkBoundary_intToByte(Convert.ToInt16(txtMalletCurrentY.Text));
                    }

                    if (serialPort1.IsOpen)
                    {
                        if (ckbPacketContent.Checked)   // Send both target and current location
                        {
                            serialTransmit(destinationLocation, currentLocation);
                        }
                        else    // Send only target location
                        {
                            serialTransmit(destinationLocation);
                        }

                        malletPreviousTargetLocationY = destinationLocation;
                        malletPreviousCurrentLocationY = currentLocation;

                    }
                    else
                    {
                        // Commented out for now
                        #region Back to center
                        /*
                        if (ckbBackToCenter.Checked)
                        {
                            destinationLocation = Convert.ToByte(nmcMalletCenter.Value);  // Set target location to be in the center

                            currentLocation = 0;
                            if (txtMalletCurrentY.Text != "")
                            {
                                currentLocation_int = Convert.ToInt16(txtMalletCurrentY.Text);

                                if (currentLocation_int > 0 && currentLocation_int < 255)       // Limit number to byte range
                                {
                                    currentLocation = Convert.ToByte(currentLocation_int);
                                }
                            }

                            if (serialPort1.IsOpen)
                            {
                                if (ckbPacketContent.Checked)   // Send both target and current location
                                {
                                    serialTransmit(destinationLocation, currentLocation);
                                }
                                else   // Send only target location
                                {
                                    serialTransmit(destinationLocation);
                                }
                            }
                            
                            malletPreviousTargetLocationY = destinationLocation;
                            malletPreviousCurrentLocationY = currentLocation;
                        }
                        */
                        #endregion
                    }
                    serialTransmitSaveData_flag = true;
                    serialTransmit_flag_timer = false;
                    #endregion
                }
                else
                {
                    #region Real time target position
                    if (txtMalletTargetY.Text != "")
                    {
                        
                        // Convert target location
                        destinationLocation = checkBoundary_intToByte(Convert.ToInt16(txtMalletTargetY.Text));
                        if (destinationLocation != malletPreviousTargetLocationY)
                        {
                            returnCount = 0;
                        }
                            
                    }
                    if (txtMalletCurrentY.Text != "")
                    {
                        // Convert current location
                        currentLocation = checkBoundary_intToByte(Convert.ToInt16(txtMalletCurrentY.Text));
                    }

                    if (ckbBackToCenter.Checked &&  returnCount >= Convert.ToInt16(nmc_returnCountTH.Value))
                    {
                        destinationLocation = checkBoundary_intToByte(Convert.ToInt16(nmcMalletCenter.Value));  // Set target location to be in the center
                    }

                    if (serialPort1.IsOpen)
                    {
                        if (ckbPacketContent.Checked)   // Send both target and current location
                        {
                            serialTransmit(destinationLocation, currentLocation);
                        }
                        else    // Send only target location
                        {
                            serialTransmit(destinationLocation);
                        }

                        malletPreviousTargetLocationY = destinationLocation;
                        malletPreviousCurrentLocationY = currentLocation;
                    }
                    //txtMalletTargetY.Text = "";
                    
                    serialTransmitSaveData_flag = true;
                    serialTransmit_flag_timer = false;
                    
                    #endregion
                }

            }
            if (serialTransmit_flag)
            {
                serialTransmit();
            }
            #endregion

            #region Elapsed time
            //stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            txtTimeElapsed.AppendText(elapsedTime + "\n");
            #endregion

            #region Saving Data to CSV
            try
            {
                if (ckbSaveData.Checked == true)
                {
                    // Initialize headings in file
                    if (initializeFile == false)
                    {
                        // Setup labels
                        outputFile.Write("Frame Index"); outputFile.Write(",");
                        outputFile.Write("Elapsed Time"); outputFile.Write(",");
                        outputFile.Write("FPS"); outputFile.Write(",");
                        outputFile.Write("Width"); outputFile.Write(",");
                        outputFile.Write("Height"); outputFile.Write(",");

                        outputFile.Write("Puck Position X"); outputFile.Write(",");
                        outputFile.Write("Puck Position Y"); outputFile.Write(",");
                        outputFile.Write("Puck Position Alpha"); outputFile.Write(",");

                        outputFile.Write("Puck Velocity X"); outputFile.Write(",");
                        outputFile.Write("Puck Velocity Y"); outputFile.Write(",");
                        outputFile.Write("Puck Velocity Alpha"); outputFile.Write(",");

                        outputFile.Write("Mallet Position X"); outputFile.Write(",");
                        outputFile.Write("Mallet Position Y"); outputFile.Write(",");
                        outputFile.Write("Mallet Position Alpha"); outputFile.Write(",");

                        outputFile.Write("TableBoundary1X"); outputFile.Write(",");
                        outputFile.Write("TableBoundary1Y"); outputFile.Write(",");
                        outputFile.Write("TableBoundary2X"); outputFile.Write(",");
                        outputFile.Write("TableBoundary2Y"); outputFile.Write(",");
                        outputFile.Write("Boundary Collision X"); outputFile.Write(",");
                        outputFile.Write("Boundary Collision Y"); outputFile.Write(",");
                        outputFile.Write("Mallet Target X"); outputFile.Write(",");
                        outputFile.Write("Mallet Target Y"); outputFile.Write(",");
                        outputFile.Write("Mallet Current X"); outputFile.Write(",");
                        outputFile.Write("Mallet Current Y"); outputFile.Write(",");
                        outputFile.Write("Puck Radius"); outputFile.Write(",");
                        outputFile.Write("Serial - Mallet Target Location"); outputFile.Write(",");
                        outputFile.Write("Serial - Mallet Current Location");
                        outputFile.Write("\n");

                        initializeFile = true;
                    }
                    outputFile.Write(frameIndex.ToString()); outputFile.Write(",");
                    outputFile.Write((DateTime.Now - DateTime.MinValue).TotalMilliseconds.ToString()); outputFile.Write(",");
                    //outputFile.Write(ts.Milliseconds.ToString()); outputFile.Write(",");

                    outputFile.Write(lblfps.Text.ToString()); outputFile.Write(",");
                    outputFile.Write(lblWidth.Text.ToString()); outputFile.Write(",");
                    outputFile.Write(lblHeight.Text.ToString()); outputFile.Write(",");

                    outputFile.Write(txt_Puck_P_X.Text); outputFile.Write(",");
                    outputFile.Write(txt_Puck_P_Y.Text); outputFile.Write(",");
                    outputFile.Write(nmc_Puck_Alpha_P.Value.ToString()); outputFile.Write(",");

                    outputFile.Write(txt_Puck_V_X.Text); outputFile.Write(",");
                    outputFile.Write(txtPUCK_V_Y.Text); outputFile.Write(",");
                    outputFile.Write(nmc_Puck_Alpha_V.Value.ToString()); outputFile.Write(",");

                    outputFile.Write(txt_Mallet_P_X.Text); outputFile.Write(",");
                    outputFile.Write(txt_Mallet_P_Y.Text); outputFile.Write(",");
                    outputFile.Write(nmc_Mallet_Alpha_P.Value.ToString()); outputFile.Write(",");

                    outputFile.Write(nmcTableBoundary1X.Value.ToString()); outputFile.Write(",");
                    outputFile.Write(nmcTableBoundary1Y.Value.ToString()); outputFile.Write(",");
                    outputFile.Write(nmcTableBoundary2X.Value.ToString()); outputFile.Write(",");
                    outputFile.Write(nmcTableBoundary2Y.Value.ToString()); outputFile.Write(",");
                    outputFile.Write(txtBoundaryPtX.Text); outputFile.Write(",");
                    outputFile.Write(txtBoundaryPtY.Text); outputFile.Write(",");
                    outputFile.Write(txtMalletTargetX.Text); outputFile.Write(",");
                    outputFile.Write(txtMalletTargetY.Text); outputFile.Write(",");
                    outputFile.Write(txtMalletCurrentX.Text); outputFile.Write(",");
                    outputFile.Write(txtMalletCurrentY.Text); outputFile.Write(",");
                    outputFile.Write(nmcPuckRadius.Value.ToString());

                    if (serialTransmitSaveData_flag)
                    {
                        outputFile.Write(",");
                        outputFile.Write(destinationLocation.ToString()); outputFile.Write(",");
                        outputFile.Write(currentLocation.ToString());
                    }
                    outputFile.Write("\n");
                }

            }
            catch
            { }
            serialTransmitSaveData_flag = false;
            #endregion

            frameIndex++;
        }

        private void ImageProcessing()
        {
            #region Filter 
            // Filter puck circle
            Image<Bgr, Byte> ImageFrameDetection2 = new Image<Bgr, Byte>(ImageFrame.Size);
            Image<Gray, Byte> ImageFrameDetection = cvAndHsvImage(
            ImageFrame,
            Convert.ToInt32(nmc_HL.Value), Convert.ToInt32(nmc_HH.Value),
            Convert.ToInt32(nmc_SL.Value), Convert.ToInt32(nmc_SH.Value),
            Convert.ToInt32(nmc_VL.Value), Convert.ToInt32(nmc_VH.Value),
            ckb_EH.Checked, ckb_ES.Checked, ckb_EV.Checked, ckb_IV.Checked);
            // Filter HSV
            Image<Gray, Byte> HSVwheel_Detection = cvAndHsvImage(
            ImageHSVwheel_filtered,
            Convert.ToInt32(nmc_HL.Value), Convert.ToInt32(nmc_HH.Value),
            Convert.ToInt32(nmc_SL.Value), Convert.ToInt32(nmc_SH.Value),
            Convert.ToInt32(nmc_VL.Value), Convert.ToInt32(nmc_VH.Value),
            ckb_EH.Checked, ckb_ES.Checked, ckb_EV.Checked, ckb_IV.Checked);


            // Filter mallet circle
            Image<Bgr, Byte> ImageFrameDetection2_mallet = new Image<Bgr, Byte>(ImageFrame.Size);
            Image<Gray, Byte> ImageFrameDetection_mallet = cvAndHsvImage(
            ImageFrame,
            Convert.ToInt32(nmc_HL_mallet.Value), Convert.ToInt32(nmc_HH_mallet.Value),
            Convert.ToInt32(nmc_SL.Value), Convert.ToInt32(nmc_SH.Value),
            Convert.ToInt32(nmc_VL.Value), Convert.ToInt32(nmc_VH.Value),
            ckb_EH.Checked, ckb_ES.Checked, ckb_EV.Checked, ckb_IV.Checked);
            // Filter HSV
            Image<Gray, Byte> HSVwheel_Detection2 = cvAndHsvImage(
            ImageHSVwheel_filtered,
            Convert.ToInt32(nmc_HL_mallet.Value), Convert.ToInt32(nmc_HH_mallet.Value),
            Convert.ToInt32(nmc_SL.Value), Convert.ToInt32(nmc_SH.Value),
            Convert.ToInt32(nmc_VL.Value), Convert.ToInt32(nmc_VH.Value),
            ckb_EH.Checked, ckb_ES.Checked, ckb_EV.Checked, ckb_IV.Checked);

            #endregion

            #region find Hough circles

            double cannyThreshold = Convert.ToDouble(nmc_cannyThreshold.Value);
            double circleAccumulatorThreshold = Convert.ToDouble(nmc_circleAccumulatorThreshold.Value);
            Image<Bgr, Byte> circleImage = ImageFrameDetection2.Copy();

            // Puck
            Image<Gray, byte> gauss = ImageFrameDetection.SmoothGaussian(Convert.ToInt16(txt_kernelWidth.Text), Convert.ToInt16(txt_kernelHeight.Text), Convert.ToDouble(txt_sigma1.Text), Convert.ToDouble(txt_sigma2.Text));
            CvInvoke.CvtColor(ImageFrameDetection, ImageFrameDetection2, ColorConversion.Gray2Bgr);
            CvInvoke.CvtColor(gauss, ImageFrameDetection2, ColorConversion.Gray2Bgr);
            CircleF[] circles = CvInvoke.HoughCircles(gauss, HoughType.Gradient, 2.0, 20.0, cannyThreshold, circleAccumulatorThreshold, Convert.ToInt32(nmcCircleMinRadius.Value), Convert.ToInt32(nmcCircleMaxRadius.Value));

            double circArea = 0;
            CircleF circIndex = new CircleF();

            for (int circ_i = 0; circ_i < circles.Length; circ_i++)
            {
                if (circles[circ_i].Area > circArea)
                {
                    circArea = circles[circ_i].Area;
                    circIndex = circles[circ_i];
                }
            }

            // Mallet
            Image<Gray, byte> gauss_mallet = ImageFrameDetection_mallet.SmoothGaussian(Convert.ToInt16(txt_kernelWidth.Text), Convert.ToInt16(txt_kernelHeight.Text), Convert.ToDouble(txt_sigma1.Text), Convert.ToDouble(txt_sigma2.Text));
            CvInvoke.CvtColor(ImageFrameDetection_mallet, ImageFrameDetection2_mallet, ColorConversion.Gray2Bgr);
            CvInvoke.CvtColor(gauss_mallet, ImageFrameDetection2_mallet, ColorConversion.Gray2Bgr);
            CircleF[] circles_mallet = CvInvoke.HoughCircles(gauss_mallet, HoughType.Gradient, 2.0, 20.0, cannyThreshold, circleAccumulatorThreshold, Convert.ToInt32(nmcCircleMinRadius.Value), Convert.ToInt32(nmcCircleMaxRadius.Value));

            double circArea_mallet = 0;
            CircleF circIndex_mallet = new CircleF();

            for (int circ_i = 0; circ_i < circles_mallet.Length; circ_i++)
            {
                if (circles_mallet[circ_i].Area > circArea_mallet)
                {
                    circArea_mallet = circles_mallet[circ_i].Area;
                    circIndex_mallet = circles_mallet[circ_i];
                }
            }

            #endregion

            #region Circle location smoothening filter
            isFrameSkipped = true;
            if (circIndex.Center.X != 0) {
                isFrameSkipped = false;
                puck_alpha = Convert.ToDouble(nmc_Puck_Alpha_P.Value)/100.0;

                puckX = circIndex.Center.X * puck_alpha + puckX * (1 - puck_alpha);
                puckY = circIndex.Center.Y * puck_alpha + puckY * (1 - puck_alpha);
                framesSkipped = 1;

                txt_Puck_P_X.Text = Convert.ToInt16(puckX).ToString();
                txt_Puck_P_Y.Text = Convert.ToInt16(puckY).ToString();
            }
            else
            {
                framesSkipped++;
            }

            if(circIndex_mallet.Center.X != 0)
            {
                puck_alpha = Convert.ToDouble(nmc_Mallet_Alpha_P.Value) / 100.0;
                malletX = circIndex_mallet.Center.X * puck_alpha + malletX * (1 - puck_alpha);
                malletY = circIndex_mallet.Center.Y * puck_alpha + malletY * (1 - puck_alpha);

                
                txt_Mallet_P_X.Text = Convert.ToInt16(malletX).ToString();
                txt_Mallet_P_Y.Text = Convert.ToInt16(malletY).ToString();
                txtMalletCurrentX.Text = Convert.ToInt16(malletX).ToString();
                txtMalletCurrentY.Text = Convert.ToInt16(malletY).ToString();
            }
            
            #endregion

            #region Calculate velocity vector
            PointF center = new PointF(Convert.ToSingle(puckX), Convert.ToSingle(puckY));
            CircleF circIndex_filter = new CircleF(center, circIndex.Radius);

            if( Math.Abs(puckX - puckX_last) > puckJitterRange) //1.8
            {
                puck_alpha_V = Convert.ToDouble(nmc_Puck_Alpha_V.Value) / 100.0;
                //puckX_velocity = ((puckX - puckX_last) / (framesSkipped * interval)) * puck_alpha_V + puckX_velocity * (1 - puck_alpha_V);
                //puckY_velocity = ((puckY - puckY_last) / (framesSkipped * interval)) * puck_alpha_V + puckY_velocity * (1 - puck_alpha_V);
                puckX_velocity = ((puckX - puckX_last) *10) * puck_alpha_V + puckX_velocity * (1 - puck_alpha_V);
                puckY_velocity = ((puckY - puckY_last) *10) * puck_alpha_V + puckY_velocity * (1 - puck_alpha_V);
            }
            else
            {
                puckX_velocity = 0;
                puckY_velocity = 0;
            }

            txt_Puck_V_X.Text = puckX_velocity.ToString();
            txtPUCK_V_Y.Text = puckY_velocity.ToString();

            Point velocityPt1 = new Point(Convert.ToInt32(circIndex_filter.Center.X), Convert.ToInt32(circIndex_filter.Center.Y));
            Point velocityPt2 = new Point(Convert.ToInt32(circIndex_filter.Center.X + puckX_velocity), Convert.ToInt32(circIndex_filter.Center.Y + puckY_velocity));

            // Save puck location for velocity calculation
            puckX_last = puckX;
            puckY_last = puckY;
            #endregion

            #region Draw boundary rectangles, calculate path, draw vector arrowed lines, and draw circles
            nmcTableBoundary1X.Text = tableBondaryPt1X.ToString();
            nmcTableBoundary1Y.Text = tableBondaryPt1Y.ToString();
            nmcTableBoundary2X.Text = tableBondaryPt2X.ToString();
            nmcTableBoundary2Y.Text = tableBondaryPt2Y.ToString();

            if (pt1_selected && pt2_selected)
            {
                
                // Boundary corner points
                Point boundaryPt1 = new Point(Convert.ToInt32(tableBondaryPt1X), Convert.ToInt32(tableBondaryPt1Y));
                Point boundaryPt2 = new Point(Convert.ToInt32(tableBondaryPt1X), Convert.ToInt32(tableBondaryPt2Y));
                Point boundaryPt3 = new Point(Convert.ToInt32(tableBondaryPt2X), Convert.ToInt32(tableBondaryPt2Y));
                Point boundaryPt4 = new Point(Convert.ToInt32(tableBondaryPt2X), Convert.ToInt32(tableBondaryPt1Y));
                
                // Draw boundary lines on filtered image
                if (ckbFilterDetection.Checked)
                {
                    CvInvoke.Line(circleImage, boundaryPt1, boundaryPt2, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(circleImage, boundaryPt2, boundaryPt3, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(circleImage, boundaryPt3, boundaryPt4, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(circleImage, boundaryPt4, boundaryPt1, new MCvScalar(0, 128, 255, 0));
                }

                // Draw boundary lines on quarry image
                if (ckbQuarryDetection.Checked)
                {
                    CvInvoke.Line(img, boundaryPt1, boundaryPt2, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(img, boundaryPt2, boundaryPt3, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(img, boundaryPt3, boundaryPt4, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(img, boundaryPt4, boundaryPt1, new MCvScalar(0, 128, 255, 0));
                }
                
                // Puck bounce boundary points
                Point boundaryPt1_puckBounce = new Point(Convert.ToInt32(tableBondaryPt1X_puckBounce), Convert.ToInt32(tableBondaryPt1Y_puckBounce));
                Point boundaryPt2_puckBounce = new Point(Convert.ToInt32(tableBondaryPt1X_puckBounce), Convert.ToInt32(tableBondaryPt2Y_puckBounce));
                Point boundaryPt3_puckBounce = new Point(Convert.ToInt32(tableBondaryPt2X_puckBounce), Convert.ToInt32(tableBondaryPt2Y_puckBounce));
                Point boundaryPt4_puckBounce = new Point(Convert.ToInt32(tableBondaryPt2X_puckBounce), Convert.ToInt32(tableBondaryPt1Y_puckBounce));

                // Draw puck bounce boundary lines on filtered image
                if (ckbFilterDetection.Checked)
                {
                    CvInvoke.Line(circleImage, boundaryPt1_puckBounce, boundaryPt2_puckBounce, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(circleImage, boundaryPt2_puckBounce, boundaryPt3_puckBounce, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(circleImage, boundaryPt3_puckBounce, boundaryPt4_puckBounce, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(circleImage, boundaryPt4_puckBounce, boundaryPt1_puckBounce, new MCvScalar(0, 128, 255, 0));
                }

                // Draw puck bounce boundary lines on quarry image
                if (ckbQuarryDetection.Checked)
                {
                    CvInvoke.Line(img, boundaryPt1_puckBounce, boundaryPt2_puckBounce, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(img, boundaryPt2_puckBounce, boundaryPt3_puckBounce, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(img, boundaryPt3_puckBounce, boundaryPt4_puckBounce, new MCvScalar(0, 128, 255, 0));
                    CvInvoke.Line(img, boundaryPt4_puckBounce, boundaryPt1_puckBounce, new MCvScalar(0, 128, 255, 0));
                }


                // Intersection point on boundary
                Point boundaryPt = intersectionBoundaryPoint(velocityPt1, velocityPt2);

                // Calculate collision path
                if (boundaryPt.X != -1 && boundaryPt.Y != -1)
                {
                    
                    if (ckbFilterDetection.Checked)
                        CvInvoke.Line(circleImage, velocityPt1, boundaryPt, new MCvScalar(255, 0, 255, 0));
                    if (ckbQuarryDetection.Checked)
                        CvInvoke.Line(img, velocityPt1, boundaryPt, new MCvScalar(255, 0, 255, 0));
                }

                if(boundaryPt.X < tableBondaryPt2X_puckBounce)
                {
                    Point malletCrossPt = intersectionMallet(velocityPt1, boundaryPt);
                    if (malletCrossPt.Y != -1)
                    {
                        
                        if (ckbFilterDetection.Checked)
                            CvInvoke.Line(circleImage, boundaryPt, malletCrossPt, new MCvScalar(255, 0, 255, 0));
                        if (ckbQuarryDetection.Checked)
                            CvInvoke.Line(img, boundaryPt, malletCrossPt, new MCvScalar(255, 0, 255, 0));

                        txtMalletTargetX.Text = malletCrossPt.X.ToString();
                        txtMalletTargetY.Text = malletCrossPt.Y.ToString();

                    }
                }
                else
                {
                    txtBoundaryPtX.Text = boundaryPt.X.ToString();
                    txtBoundaryPtY.Text = boundaryPt.Y.ToString();
                    txtMalletTargetX.Text = txtBoundaryPtX.Text;
                    txtMalletTargetY.Text = txtBoundaryPtY.Text;
                }
            }

            // Draw Circles
            if (ckbFilterDetection.Checked)
            {
                CvInvoke.ArrowedLine(circleImage, velocityPt1, velocityPt2, new MCvScalar(255, 255, 0, 0));
                circleImage.Draw(circIndex_mallet, new Bgr(Color.Green), 2);
                circleImage.Draw(circIndex, new Bgr(Color.Red), 2);
                circleImage.Draw(circIndex_filter, new Bgr(Color.Blue), 2);
            }
            if (ckbQuarryDetection.Checked)
            {
                CvInvoke.ArrowedLine(img, velocityPt1, velocityPt2, new MCvScalar(255, 255, 0, 0));
                img.Draw(circIndex_mallet, new Bgr(Color.Green), 2);
                img.Draw(circIndex, new Bgr(Color.Red), 2);
                img.Draw(circIndex_filter, new Bgr(Color.Blue), 2);
            }
            if (ckbOverlayPuckDetection.Checked)
            {
                ImageFrameDetection2.Draw(circIndex, new Bgr(Color.Red), 2);
            }
            if (ckbOverlayMalletDetection.Checked)
            {
                ImageFrameDetection2_mallet.Draw(circIndex_mallet, new Bgr(Color.Green), 2);
            }


            if (ckbQuarryDetection.Checked)
            {
                Point malletLower = new Point(tableBondaryPt2X_puckBounce,Convert.ToInt32(nmcMalletLowerLimit.Value));
                Point malletCenter = new Point(tableBondaryPt2X_puckBounce, Convert.ToInt32(nmcMalletCenter.Value));
                Point malletUpper = new Point(tableBondaryPt2X_puckBounce, Convert.ToInt32(nmcMalletUpperLimit.Value));
                Point malletLower2 = new Point(tableBondaryPt2X_puckBounce - 10, Convert.ToInt32(nmcMalletLowerLimit.Value));
                Point malletCenter2 = new Point(tableBondaryPt2X_puckBounce - 10, Convert.ToInt32(nmcMalletCenter.Value));
                Point malletUpper2 = new Point(tableBondaryPt2X_puckBounce - 10, Convert.ToInt32(nmcMalletUpperLimit.Value));

                MCvScalar myYellow = new MCvScalar(0, 255, 255);
                CvInvoke.Line(img, malletLower, malletLower2, myYellow);
                CvInvoke.Line(img, malletCenter, malletCenter2, myYellow);
                CvInvoke.Line(img, malletUpper, malletUpper2, myYellow);
                CvInvoke.Line(img, malletLower, malletUpper, myYellow);
            }
            #endregion

            #region Draw referece frame coord
            Point coordRef_Origin = new Point(10, 10);
            Point coordRef_Origin_X = new Point(30, 10);
            Point coordRef_Origin_Y = new Point(10, 30);

            // Draw reference frame coord
            CvInvoke.ArrowedLine(img, coordRef_Origin, coordRef_Origin_X, new MCvScalar(255, 255, 255));
            CvInvoke.ArrowedLine(img, coordRef_Origin, coordRef_Origin_Y, new MCvScalar(255, 255, 255));
            CvInvoke.PutText(img, "X", new Point(35, 15), FontFace.HersheyComplexSmall, 0.5, new MCvScalar(255, 255, 255));
            CvInvoke.PutText(img, "Y", new Point(10, 40), FontFace.HersheyComplexSmall, 0.5, new MCvScalar(255, 255, 255));
            CvInvoke.PutText(img, frameIndex.ToString(), new Point(45, 15), FontFace.HersheyComplexSmall, 0.5, new MCvScalar(255, 255, 255));
            #endregion

            #region Resize and display images
            // Resize image for imageBox
            Image<Bgr, Byte> circleImage_re = new Image< Bgr, Byte> (camFiltered_Puck.Width, camFiltered_Puck.Height);
            CvInvoke.Resize(circleImage, circleImage_re, new Size(camFiltered_Puck.Width, camFiltered_Puck.Height));

            // Display images it in pictureBox
            CamImageBox.Image = img;  
            camFiltered_Circles.Image = circleImage_re;
            camFiltered_Puck.Image = ImageFrameDetection2;
            camFiltered_Mallet.Image = ImageFrameDetection2_mallet;
            img_HSVwheel_filtered.Image = HSVwheel_Detection;
            img_HSVwheel_filtered2.Image = HSVwheel_Detection2;

            // Save frame in video file
            if (ckbRecordVideo.Checked){
                file_Quarry.Write(img.Mat);
            }
            

            #endregion
        }

        private Point intersectionBoundaryPoint(Point pt1, Point pt2)
        {
            Point ptResult = new Point();

            if(pt1.X > pt2.X) // Vector pointing to player
            {
                ptResult.X = -1;
                ptResult.Y = -1;
                return ptResult;
            }
            if (pt1.X == pt2.X && pt1.Y == pt2.Y) // Zero vector
            {
                ptResult.X = -1;
                ptResult.Y = -1;
                return ptResult;
            }
            if (pt1.X == pt2.X) // Vertical vector
            {
                ptResult.X = -1;
                ptResult.Y = -1;
                return ptResult;
            }

            //calculate line equation
            double pt1X = pt1.X;
            double pt1Y = pt1.Y;
            double pt2X = pt2.X;
            double pt2Y = pt2.Y;
            double pt3X = 0;
            double pt3Y = 0;
            double ptCornerX = 0;
            double ptCornerY = 0;
            double angle_pt1_ptCorner = 0;
            double angle_pt1_Pt2 = 0;

            Point boundaryPt3_puckBounce = new Point(Convert.ToInt32(tableBondaryPt2X_puckBounce), Convert.ToInt32(tableBondaryPt2Y_puckBounce));
            Point boundaryPt4_puckBounce = new Point(Convert.ToInt32(tableBondaryPt2X_puckBounce), Convert.ToInt32(tableBondaryPt1Y_puckBounce));

            /* Region 1    Region 2
            --|--------. <- Corner 4
              |      /  |
              |    /    | Region 3
              |  /      |
              p1 -------| Region 4
              |  \      | 
              |    \    | Region 5
              |      \  |
            --|---------. <- Corner 3
                 Region 7   Region 6
            */

            // Up, middle or down
            if (pt2Y < pt1Y) // Up, Region 1-3
            {
                ptCornerX = boundaryPt4_puckBounce.X;
                ptCornerY = boundaryPt4_puckBounce.Y;
                angle_pt1_ptCorner = Math.Atan(Math.Abs(ptCornerY - pt1Y)/ Math.Abs(ptCornerX - pt1X));
                angle_pt1_Pt2      = Math.Atan(Math.Abs(pt2Y - pt1Y) / Math.Abs(pt2X - pt1X));

                if(angle_pt1_Pt2 > angle_pt1_ptCorner)  // Region 1
                {
                    pt3Y = tableBondaryPt1Y_puckBounce;
                    // Calculate pt3X
                    pt3X = pt1X + (pt2X - pt1X) * ((pt3Y - pt1Y) / (pt2Y - pt1Y));
                }
                else if (angle_pt1_Pt2 < angle_pt1_ptCorner) // Region 3
                {
                    pt3X = tableBondaryPt2X_puckBounce;
                    // Calculate pt3Y
                    pt3Y = pt1Y + (pt2Y - pt1Y) * ((pt3X - pt1X) / (pt2X - pt1X));
                }
                else // Region 2
                {
                    pt3X = ptCornerX;
                    pt3Y = ptCornerY;
                }
            }
            else if(pt2Y > pt1Y) // Down, Region 5-7
            {
                ptCornerX = boundaryPt3_puckBounce.X;
                ptCornerY = boundaryPt3_puckBounce.Y;
                angle_pt1_ptCorner = Math.Atan(Math.Abs(ptCornerY - pt1Y) / Math.Abs(ptCornerX - pt1X));
                angle_pt1_Pt2      = Math.Atan(Math.Abs(pt2Y - pt1Y) / Math.Abs(pt2X - pt1X));

                if (angle_pt1_Pt2 > angle_pt1_ptCorner)  // Region 7
                {
                    pt3Y = tableBondaryPt2Y_puckBounce;
                    // Calculate pt3X
                    pt3X = pt1X + (pt2X - pt1X) * ((pt3Y - pt1Y) / (pt2Y - pt1Y));
                }
                else if (angle_pt1_Pt2 < angle_pt1_ptCorner) // Region 5
                {
                    pt3X = tableBondaryPt2X_puckBounce;
                    // Calculate pt3Y
                    pt3Y = pt1Y + (pt2Y - pt1Y) * ((pt3X - pt1X) / (pt2X - pt1X));
                }
                else // Region 6
                {
                    pt3X = ptCornerX;
                    pt3Y = ptCornerY;
                }
            }
            else  // Middle, Region 4
            {
                pt3X = tableBondaryPt2X_puckBounce;
                pt3Y = pt1Y;
            }
   
            ptResult.X = Convert.ToInt32(pt3X);
            ptResult.Y = Convert.ToInt32(pt3Y);


            txbtest.AppendText(pt1X + "," + pt1Y + "," + pt2X + "," + pt2Y + "," + pt3X + "," + pt3Y + "\n");
            return ptResult;
        }

        private Point intersectionMallet(Point pt1, Point pt2)
        {
            Point ptResult = new Point();

            if (pt1.X > pt2.X) // Vector pointing to player
            {
                ptResult.X = -1;
                ptResult.Y = -1;
                return ptResult;
            }

            //calculate line equation
            double pt1X = pt1.X;
            double pt1Y = pt1.Y;
            double pt2X = pt2.X;
            double pt2Y = pt2.Y;
            double pt3X = 0;
            double pt3Y = 0;


            pt3X = tableBondaryPt2X_puckBounce;

            pt1X = pt1X + (pt2X - pt1X) * 2;

            if(pt2X != pt1X)
            {
                pt3Y = pt1Y + (pt2Y - pt1Y) * ((pt3X - pt1X) / (pt2X - pt1X));
            }
            else
            {
                pt3Y = -1;
                pt3X = -1;
                ptResult.X = Convert.ToInt32(pt3X);
                ptResult.Y = Convert.ToInt32(pt3Y);

                return ptResult;
            }
            
            ptResult.X = Convert.ToInt32(pt3X);
            ptResult.Y = Convert.ToInt32(pt3Y);

            return ptResult;
        }

        private Image<Gray, Byte> cvAndHsvImage(Image<Bgr, Byte> imgFame, int L1, int H1, int L2, int H2, int L3, int H3, bool H, bool S, bool V, bool I)
        {
            Image<Hsv, Byte> hsvImage = imgFame.Convert<Hsv, Byte>();
            Image<Gray, Byte> ResultImage = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height);
            Image<Gray, Byte> ResultImageH = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height);
            Image<Gray, Byte> ResultImageS = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height);
            Image<Gray, Byte> ResultImageV = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height);

            Image<Gray, Byte> img1 = inRangeImage(hsvImage, L1, H1, 0);
            Image<Gray, Byte> img2 = inRangeImage(hsvImage, L2, H2, 1);
            Image<Gray, Byte> img3 = inRangeImage(hsvImage, L3, H3, 2);
            Image<Gray, Byte> img4 = inRangeImage(hsvImage, 0, L1, 0);
            Image<Gray, Byte> img5 = inRangeImage(hsvImage, H1, 180, 0);

            Image<Gray, Byte> img1_re = new Image<Gray, Byte>(imb_1.Width, imb_1.Height);
            Image<Gray, Byte> img2_re = new Image<Gray, Byte>(imb_2.Width, imb_2.Height);
            Image<Gray, Byte> img3_re = new Image<Gray, Byte>(imb_3.Width, imb_3.Height);
            Image<Gray, Byte> img4_re = new Image<Gray, Byte>(imb_4.Width, imb_4.Height);
            Image<Gray, Byte> img5_re = new Image<Gray, Byte>(imb_5.Width, imb_5.Height);

            CvInvoke.Resize(img1, img1_re, new Size(imb_1.Width, imb_1.Height));
            CvInvoke.Resize(img2, img2_re, new Size(imb_2.Width, imb_2.Height));
            CvInvoke.Resize(img3, img3_re, new Size(imb_3.Width, imb_3.Height));
            CvInvoke.Resize(img4, img4_re, new Size(imb_4.Width, imb_4.Height));
            CvInvoke.Resize(img5, img5_re, new Size(imb_5.Width, imb_5.Height));

            imb_1.Image = img1_re;
            imb_2.Image = img2_re;
            imb_3.Image = img3_re;
            imb_4.Image = img4_re;
            imb_5.Image = img5_re;

            #region checkBox Color Mode

            if (H)
            {
                if (I)
                {
                    CvInvoke.BitwiseOr(img4, img5, img4);
                    ResultImageH = img4;
                }
                else { ResultImageH = img1; }
            }

            if (S) ResultImageS = img2;
            if (V) ResultImageV = img3;

            if (H && !S && !V) ResultImage = ResultImageH;
            if (!H && S && !V) ResultImage = ResultImageS;
            if (!H && !S && V) ResultImage = ResultImageV;

            if (H && S && !V)
            {
                CvInvoke.BitwiseAnd(ResultImageH, ResultImageS, ResultImageH);
                ResultImage = ResultImageH;
            }

            if (H && !S && V)
            {
                CvInvoke.BitwiseAnd(ResultImageH, ResultImageV, ResultImageH);
                ResultImage = ResultImageH;
            }

            if (!H && S && V)
            {
                CvInvoke.BitwiseAnd(ResultImageS, ResultImageV, ResultImageS);
                ResultImage = ResultImageS;
            }

            if (H && S && V)
            {
                CvInvoke.BitwiseAnd(ResultImageH, ResultImageS, ResultImageH);
                CvInvoke.BitwiseAnd(ResultImageH, ResultImageV, ResultImageH);
                ResultImage = ResultImageH;
            }
            #endregion
            Point pts = new Point(-1,-1);
            Mat tempMat = new Mat();
            
            CvInvoke.Erode(ResultImage, ResultImage, new Mat(), pts, 1, BorderType.Constant,CvInvoke.MorphologyDefaultBorderValue);
            //CvInvoke.Dilate(ResultImage, ResultImage, new Mat(), pts, 1, BorderType.Constant, CvInvoke.MorphologyDefaultBorderValue);

            return ResultImage;
        }

        private Image<Gray, Byte> inRangeImage(Image<Hsv, Byte> hsvImage, int Lo, int Hi, int con)
        {
            Image<Gray, Byte> ResultImage = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height);
            Image<Gray, Byte> IlowCh = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height, new Gray(Lo));
            Image<Gray, Byte> IHiCh = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height, new Gray(Hi));
            CvInvoke.InRange(hsvImage[con], IlowCh, IHiCh, ResultImage);
            return ResultImage;
        }

        private byte checkBoundary_intToByte(int _int)
        {
            if (_int < 0)
            {
                _int = 0;
            }
            else if (_int > 255)
            {
                _int = 255;
            }

            if (_int < Convert.ToInt16(nmcMalletLowerLimit.Value))
            {
                _int = Convert.ToInt16(nmcMalletLowerLimit.Value);
            }
            else if(_int > Convert.ToInt16(nmcMalletUpperLimit.Value))
            {
                _int = Convert.ToInt16(nmcMalletUpperLimit.Value);
            }

            return Convert.ToByte(_int);
        }

        private bool puckOutOfBound()
        {
            if(pt1_selected && pt2_selected)
            {
                if(puckX < tableBondaryPt1X_puckBounce)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture(Emgu.CV.CvEnum.CaptureType.Any);
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            if (capture != null)
            {
                if (captureInProgress)
                {  //if camera is getting frames then stop the capture and set button Text
                    // "Start" for resuming capture
                    btnStart.Text = "Resume"; //
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    btnStart.Text = "Stop";
                    
                    capture.SetCaptureProperty(CapProp.Fps, frameFps);
                    capture.SetCaptureProperty(CapProp.FrameWidth, frameWidth);
                    capture.SetCaptureProperty(CapProp.FrameHeight, frameHeight);
                    Application.Idle += ProcessFrame;
                    
                }

                captureInProgress = !captureInProgress;
            }
        }

        private void genericTextBoxEventHandler(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            short parseResult;
            if (Int16.TryParse((currentTextBox.Text), out parseResult))
            {
                if (parseResult > 255)
                    parseResult = 255;
                if (parseResult <= 0)
                    parseResult = 0;
                currentTextBox.Text = parseResult.ToString();
            }
            else
                currentTextBox.Text = "0";
        }
     
        private void CamImageBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!pt1_selected)
            {
                double _eX = e.X;
                double _eY = e.Y;
                tableBondaryPt1X_clicked = Convert.ToInt16(_eX / (CamImageBox.Width  / frameWidth ));
                tableBondaryPt1Y_clicked = Convert.ToInt16(_eY / (CamImageBox.Height / frameHeight));
                pt1_selected = true;
            }
            else
            {
                if (!pt2_selected)
                {
                    double _eX = e.X;
                    double _eY = e.Y;
                    tableBondaryPt2X_clicked = Convert.ToInt16(_eX / (CamImageBox.Width  / frameWidth ));
                    tableBondaryPt2Y_clicked = Convert.ToInt16(_eY / (CamImageBox.Height / frameHeight));
                    pt2_selected = true;

                    if (tableBondaryPt2X_clicked > tableBondaryPt1X_clicked)
                    {
                        tableBondaryPt1X = tableBondaryPt1X_clicked;
                        tableBondaryPt2X = tableBondaryPt2X_clicked;
                    }
                    else
                    {
                        tableBondaryPt1X = tableBondaryPt2X_clicked;
                        tableBondaryPt2X = tableBondaryPt1X_clicked;
                    }

                    if (tableBondaryPt2Y_clicked > tableBondaryPt1Y_clicked)
                    {
                        tableBondaryPt1Y = tableBondaryPt1Y_clicked;
                        tableBondaryPt2Y = tableBondaryPt2Y_clicked;
                    }
                    else
                    {
                        tableBondaryPt1Y = tableBondaryPt2Y_clicked;
                        tableBondaryPt2Y = tableBondaryPt1Y_clicked;
                    }
                    puckRadius = Convert.ToInt16(nmcPuckRadius.Value);
                    tableBondaryPt1X_puckBounce = tableBondaryPt1X + puckRadius;
                    tableBondaryPt1Y_puckBounce = tableBondaryPt1Y + puckRadius;
                    tableBondaryPt2X_puckBounce = tableBondaryPt2X - puckRadius;
                    tableBondaryPt2Y_puckBounce = tableBondaryPt2Y - puckRadius;
                }
                else
                {
                    pt1_selected = false;
                    pt2_selected = false;
                }
            }
        }

        private void mncPuckRadius_ValueChanged(object sender, EventArgs e)
        {
            puckRadius = Convert.ToInt16(nmcPuckRadius.Value);
            tableBondaryPt1X_puckBounce = tableBondaryPt1X + puckRadius;
            tableBondaryPt1Y_puckBounce = tableBondaryPt1Y + puckRadius;
            tableBondaryPt2X_puckBounce = tableBondaryPt2X - puckRadius;
            tableBondaryPt2Y_puckBounce = tableBondaryPt2Y - puckRadius;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ckb_EH.Checked = false;
            ckb_ES.Checked = false;
            ckb_EV.Checked = false;

            // H Puck Blue
            nmc_HL.Value = 0;
            nmc_HH.Value = 0;

            // H Mallet green
            nmc_HL_mallet.Value = 0;
            nmc_HH_mallet.Value = 0;

            // S
            nmc_SL.Value = 0;
            nmc_SH.Value = 255;
            //V
            nmc_VL.Value = 0;
            nmc_VH.Value = 255;
        }

        private void btnpreset_Click(object sender, EventArgs e)
        {
            ckb_EH.Checked = true;
            ckb_ES.Checked = true;
            ckb_EV.Checked = true;

            // H Puck Blue
            nmc_HL.Value = 78;
            nmc_HH.Value = 123;

            // H Mallet green
            nmc_HL_mallet.Value = 19;
            nmc_HH_mallet.Value = 102;

            // S
            nmc_SL.Value = 75;
            nmc_SH.Value = 255;
            //V
            nmc_VL.Value = 49;
            nmc_VH.Value = 255;
        }

        private void ComPortUpdate()
        {
            cmbComPort.Items.Clear();
            string[] comPortArray = System.IO.Ports.SerialPort.GetPortNames().ToArray();
            Array.Reverse(comPortArray);
            cmbComPort.Items.AddRange(comPortArray);
            if (cmbComPort.Items.Count != 0)
                cmbComPort.SelectedIndex = 0;
            else
                cmbComPort.Text = "No Ports Found!";
        }

        private void CameraCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen){
                serialPort1.Close();
            }
            // Make sure output file is closed
            if (outputFile != null)
                outputFile.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                if (cmbComPort.Items.Count > 0)
                {
                    try
                    {
                        serialPort1.BaudRate = Convert.ToInt32(txtBaudRate.Text);
                        serialPort1.PortName = cmbComPort.SelectedItem.ToString();
                        serialPort1.Open();
                        btnConnect.Text = "Disconnect";
                        //timer1.Enabled = true;
                        //lblIncomingDataRate.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    serialTransmit(0, 0);
                    serialPort1.Close();
                    btnConnect.Text = "Connect";
                    //timer1.Enabled = false;
                    //lblIncomingDataRate.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ckbByte1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbByte1.Checked == true)
                txtByte1.Enabled = true;
            else
            {
                txtByte1.Clear();
                txtByte1.Enabled = false;
            }
        }

        private void ckbByte2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbByte2.Checked == true)
                txtByte2.Enabled = true;
            else
            {
                txtByte2.Clear();
                txtByte2.Enabled = false;
            }
        }

        private void ckbByte3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbByte3.Checked == true)
                txtByte3.Enabled = true;
            else
            {
                txtByte3.Clear();
                txtByte3.Enabled = false;
            }
        }

        private void ckbByte4_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbByte4.Checked == true)
                txtByte4.Enabled = true;
            else
            {
                txtByte4.Clear();
                txtByte4.Enabled = false;
            }
        }

        private void btnSerialSend_Click(object sender, EventArgs e)
        {
            //serialTransmit_flag = true;
            serialTransmit();
        }

        private void serialTransmit()
        {
            byte[] TxBytes = new Byte[5];

            try
            {
                if (serialPort1.IsOpen)
                {
                    if (ckbByte1.Checked && (txtByte1.Text != ""))
                    {
                        TxBytes[0] = Convert.ToByte(txtByte1.Text);
                        serialPort1.Write(TxBytes, 0, 1);
                    }
                    if (ckbByte2.Checked && (txtByte2.Text != ""))
                    {
                        TxBytes[1] = Convert.ToByte(txtByte2.Text);
                        serialPort1.Write(TxBytes, 1, 1);
                    }
                    if (ckbByte3.Checked && (txtByte3.Text != ""))
                    {
                        TxBytes[2] = Convert.ToByte(txtByte3.Text);
                        serialPort1.Write(TxBytes, 2, 1);
                    }
                    if (ckbByte4.Checked && (txtByte4.Text != ""))
                    {
                        TxBytes[3] = Convert.ToByte(txtByte4.Text);
                        serialPort1.Write(TxBytes, 3, 1);
                    }
                    if (ckbByte4.Checked && (txtByte4.Text != ""))
                    {
                        TxBytes[4] = Convert.ToByte(txtByte5.Text);
                        serialPort1.Write(TxBytes, 4, 1);
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                ckbTransmit.Checked = false;
            }
        }

        private void serialTransmit(Byte byte1)
        {
            byte[] TxBytes = new Byte[1];
            try
            {
                TxBytes[0] = byte1;
                serialPort1.Write(TxBytes, 0, 1);
             }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                ckbTransmit.Checked = false;
            }
        }

        private void serialTransmit(Byte byte1, Byte byte2)
        {
            byte[] TxBytes = new Byte[3];
            try
            {
                TxBytes[0] = 255;
                serialPort1.Write(TxBytes, 0, 1);

                TxBytes[1] = byte1;
                serialPort1.Write(TxBytes, 1, 1);

                TxBytes[2] = byte2;
                serialPort1.Write(TxBytes, 2, 1);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                ckbTransmit.Checked = false;
            }
        }

        private void serialTransmit(Byte byte1, Byte byte2, Byte byte3, Byte byte4, Byte byte5)
        {
            byte[] TxBytes = new Byte[5];
            int MyInt = byte1;
            byte[] b = BitConverter.GetBytes(MyInt);
            serialPort1.Write(b, 0, 4);
            try
            {
                if (serialPort1.IsOpen)
                {

                    if (ckbByte1.Checked && (txtByte1.Text != ""))
                    {
                        TxBytes[0] = byte1;
                        serialPort1.Write(b, 0, 4);
                    }
                    if (ckbByte2.Checked && (txtByte2.Text != ""))
                    {
                        TxBytes[1] = byte2;
                        serialPort1.Write(TxBytes, 1, 1);
                    }
                    if (ckbByte3.Checked && (txtByte3.Text != ""))
                    {
                        TxBytes[2] = byte3;
                        serialPort1.Write(TxBytes, 2, 1);
                    }
                    if (ckbByte4.Checked && (txtByte4.Text != ""))
                    {
                        TxBytes[3] = byte4;
                        serialPort1.Write(TxBytes, 3, 1);
                    }
                    if (ckbByte4.Checked && (txtByte4.Text != ""))
                    {
                        TxBytes[4] = byte5;
                        serialPort1.Write(TxBytes, 4, 1);
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                ckbTransmit.Checked = false;
            }
        }

        private void btnSerialPreset_Click(object sender, EventArgs e)
        {
            ckbByte1.Checked = true;
            txtByte1.Text = "255";
            ckbByte2.Checked = true;
            txtByte2.Text = "0";
            ckbByte3.Checked = true;
            txtByte3.Text = "0";
            /*
            ckbByte4.Checked = true;
            txtByte4.Text = "120";
            ckbByte5.Checked = true;
            txtByte5.Text = "0";
            */
        }

        private void btnSerialReset_Click(object sender, EventArgs e)
        {
            ckbByte1.Checked = false;
            txtByte1.Text = "";
            ckbByte2.Checked = false;
            txtByte2.Text = "";
            ckbByte3.Checked = false;
            txtByte3.Text = "";
            ckbByte4.Checked = false;
            txtByte4.Text = "";
            ckbByte5.Checked = false;
            txtByte5.Text = "";
        }

        private void ckbByte5_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbByte5.Checked == true)
                txtByte5.Enabled = true;
            else
            {
                txtByte5.Clear();
                txtByte5.Enabled = false;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead != 0)
            {
                int currentByte = serialPort1.ReadByte();
                currentByte -= 48;
                if (ckbShowResponse.Checked)
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        txtRawSerial.AppendText(currentByte.ToString() + ", ");
                    }));

            }
        }

        private void ckbSendInt_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbSendInt.Checked == true)
                ckbSendByte.Checked = false;
            else
                ckbSendByte.Checked = true;
        }

        private void ckbSendByte_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSendByte.Checked == true)
                ckbSendInt.Checked = false;
            else
                ckbSendInt.Checked = true;
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtRawSerial.Text = "";
        }

        private void btnCalcualteIntersection_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> img_test = ImageFrame;
          
            Image<Bgr, Byte> img_test_re = new Image<Bgr, Byte>(camTest.Width, camTest.Height);

            PointF center1 = new PointF(Convert.ToSingle(nmcPt1X_test.Value), Convert.ToSingle(nmcPt1Y_test.Value));
            PointF center2 = new PointF(Convert.ToSingle(nmcPt2X_test.Value), Convert.ToSingle(nmcPt2Y_test.Value));
            CircleF circ1 = new CircleF(center1, 2);
            CircleF circ2 = new CircleF(center2, 2);

            

            // Intersection point on boundary
            Point boundaryPt = intersectionBoundaryPoint(
                new Point(Convert.ToInt32(nmcPt1X_test.Value), Convert.ToInt32(nmcPt1Y_test.Value)), 
                new Point(Convert.ToInt32(nmcPt2X_test.Value), Convert.ToInt32(nmcPt2Y_test.Value))
                );

            CircleF circ3 = new CircleF(boundaryPt, 2);

            // Calculate collision path
            if (boundaryPt.X != -1 && boundaryPt.Y != -1)
            {
                txtBoundaryX_test.Text = boundaryPt.X.ToString();
                txtBoundaryY_test.Text = boundaryPt.Y.ToString();
                CvInvoke.Line(img_test, new Point(Convert.ToInt32(nmcPt1X_test.Value), Convert.ToInt32(nmcPt1Y_test.Value)), boundaryPt, new MCvScalar(255, 0, 255, 0));
            }

            img_test.Draw(circ1, new Bgr(Color.Blue), 2);
            img_test.Draw(circ2, new Bgr(Color.Green), 2);
            img_test.Draw(circ3, new Bgr(Color.Red), 2);

            // Boundary corner points
            Point boundaryPt1 = new Point(Convert.ToInt32(tableBondaryPt1X), Convert.ToInt32(tableBondaryPt1Y));
            Point boundaryPt2 = new Point(Convert.ToInt32(tableBondaryPt1X), Convert.ToInt32(tableBondaryPt2Y));
            Point boundaryPt3 = new Point(Convert.ToInt32(tableBondaryPt2X), Convert.ToInt32(tableBondaryPt2Y));
            Point boundaryPt4 = new Point(Convert.ToInt32(tableBondaryPt2X), Convert.ToInt32(tableBondaryPt1Y));

            // Draw boundary lines on quarry image
            CvInvoke.Line(img_test, boundaryPt1, boundaryPt2, new MCvScalar(0, 128, 255, 0));
            CvInvoke.Line(img_test, boundaryPt2, boundaryPt3, new MCvScalar(0, 128, 255, 0));
            CvInvoke.Line(img_test, boundaryPt3, boundaryPt4, new MCvScalar(0, 128, 255, 0));
            CvInvoke.Line(img_test, boundaryPt4, boundaryPt1, new MCvScalar(0, 128, 255, 0));

            // Puck bounce boundary points
            Point boundaryPt1_puckBounce = new Point(Convert.ToInt32(tableBondaryPt1X_puckBounce), Convert.ToInt32(tableBondaryPt1Y_puckBounce));
            Point boundaryPt2_puckBounce = new Point(Convert.ToInt32(tableBondaryPt1X_puckBounce), Convert.ToInt32(tableBondaryPt2Y_puckBounce));
            Point boundaryPt3_puckBounce = new Point(Convert.ToInt32(tableBondaryPt2X_puckBounce), Convert.ToInt32(tableBondaryPt2Y_puckBounce));
            Point boundaryPt4_puckBounce = new Point(Convert.ToInt32(tableBondaryPt2X_puckBounce), Convert.ToInt32(tableBondaryPt1Y_puckBounce));

            // Draw puck bounce boundary lines on quarry image
            CvInvoke.Line(img_test, boundaryPt1_puckBounce, boundaryPt2_puckBounce, new MCvScalar(0, 128, 255, 0));
            CvInvoke.Line(img_test, boundaryPt2_puckBounce, boundaryPt3_puckBounce, new MCvScalar(0, 128, 255, 0));
            CvInvoke.Line(img_test, boundaryPt3_puckBounce, boundaryPt4_puckBounce, new MCvScalar(0, 128, 255, 0));
            CvInvoke.Line(img_test, boundaryPt4_puckBounce, boundaryPt1_puckBounce, new MCvScalar(0, 128, 255, 0));


            CvInvoke.Resize(img_test, img_test_re, new Size(camTest.Width, camTest.Height));
            camTest.Image = img_test_re;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            returnCount++;
        }

        private void ckbPacketContent_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbPacketContent.Checked == true)
            {
                ckbPacketContent.Text = "Puck and mallet";
            }
            else
            {
                ckbPacketContent.Text = "Just Puck";
            }
        }

        private void btnUpdateComPort_Click(object sender, EventArgs e)
        {
            ComPortUpdate();
        }

        private void btnReset_CannyEdge_Click(object sender, EventArgs e)
        {
            nmc_cannyThreshold.Value = 180;
            nmc_circleAccumulatorThreshold.Value = 30;
            nmcCircleMinRadius.Value = 5;
            nmcCircleMaxRadius.Value = 15;
        }

        private void btnReset_GaussFilter_Click(object sender, EventArgs e)
        {
            txt_kernelWidth.Text = "3";
            txt_kernelHeight.Text = "3";
            txt_sigma1.Text = "34.3";
            txt_sigma2.Text = "45.3";
        }

        private void chkSaveData_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // If the field is checked, write to output file
                if (ckbSaveData.Checked == true)
                {
                    outputFile = new StreamWriter(txtFileName.Text);
                }
                else {
                    outputFile.Close();
                    initializeFile = false;
                }
            }
            catch (System.ArgumentException err)
            {
                // Catch exception and display error
                ckbSaveData.Checked = false;
                ckbRecordBoth.Checked = false;
                ckbRecordVideo.Checked = false;
                ckbRecordBoth.Text = "Record both";
                MessageBox.Show("Filename cannot be empty.");
            }
            catch (System.NullReferenceException)
            {
                // Error handling
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("File path invalid.");
            }
        }

        private void btnSelectFileName_Click(object sender, EventArgs e)
        {
            SaveFileDialog myDialogBox = new SaveFileDialog();
            myDialogBox.AutoUpgradeEnabled = false;
            myDialogBox.InitialDirectory = pathName;
            myDialogBox.Filter = "Text files (*.csv)|*.csv|All files (*.*)|*.*";
            myDialogBox.DefaultExt = "csv";
            myDialogBox.ShowDialog();
            txtFileName.Text = myDialogBox.FileName.ToString();
        }

        private void ckbRecordBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRecordBoth.Checked)
            {
                ckbRecordVideo.Checked = true;
                ckbSaveData.Checked = true;
                ckbRecordBoth.Text = "Press to Stop";
            }
            else
            {
                ckbRecordVideo.Checked = false;
                ckbSaveData.Checked = false;
                ckbRecordBoth.Text = "Record both";
            }
        }

        private void btnSetRanges_Click(object sender, EventArgs e)
        {
            malletDestinationRange = Convert.ToInt16(nmc_malletDestinationRange.Value);
            malletCurrentRange = Convert.ToInt16(nmc_malletCurrentRange.Value);
            puckJitterRange = Convert.ToDouble(txt_puckJitterRange.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _int = 340;
            lblTest.Text = checkBoundary_intToByte(_int).ToString();
        }

        private void nmcTableBoundary1X_ValueChanged(object sender, EventArgs e)
        {
            tableBondaryPt1X = Convert.ToInt16(nmcTableBoundary1X.Value);
            puckRadius = Convert.ToInt16(nmcPuckRadius.Value);
            tableBondaryPt1X_puckBounce = tableBondaryPt1X + puckRadius;
        }

        private void nmcTableBoundary1Y_ValueChanged(object sender, EventArgs e)
        {
            tableBondaryPt1Y = Convert.ToInt16(nmcTableBoundary1Y.Value);
            puckRadius = Convert.ToInt16(nmcPuckRadius.Value);
            tableBondaryPt1Y_puckBounce = tableBondaryPt1Y + puckRadius;
        }

        private void nmcTableBoundary2X_ValueChanged(object sender, EventArgs e)
        {
            tableBondaryPt2X = Convert.ToInt16(nmcTableBoundary2X.Value);
            puckRadius = Convert.ToInt16(nmcPuckRadius.Value);
            tableBondaryPt2X_puckBounce = tableBondaryPt2X - puckRadius;
        }

        private void nmcTableBoundary2Y_ValueChanged(object sender, EventArgs e)
        {
            tableBondaryPt2Y = Convert.ToInt16(nmcTableBoundary2Y.Value);
            puckRadius = Convert.ToInt16(nmcPuckRadius.Value);
            tableBondaryPt2Y_puckBounce = tableBondaryPt2Y - puckRadius;
        }
  
        private void img_HSVwheel_MouseClick(object sender, MouseEventArgs e)
        {
            Image<Hsv, Byte> imgHsv = ImageHSVwheel.Convert<Hsv, Byte>();
            Hsv hsv = imgHsv[e.Y, e.X];
            if (!ib3C)
            {
                ib3C_HV = Convert.ToInt32(hsv.Hue);
                ib3C_Lable_X = img_HSVwheel.Location.X + e.X;
                ib3C_Lable_Y = img_HSVwheel.Location.Y + e.Y;
                label_L.Location = new Point(ib3C_Lable_X, ib3C_Lable_Y);
                label_H.Hide();
            }
            if (ib3C)
            {
                label_H.Show();
                if (ib3C_HV < hsv.Hue)
                {
                    nmc_HL.Value = ib3C_HV;
                    nmc_HH.Value = Convert.ToInt32(hsv.Hue);
                    label_H.Location = new Point(img_HSVwheel.Location.X + e.X, img_HSVwheel.Location.Y + e.Y);
                }
                else
                {
                    nmc_HH.Value = ib3C_HV;
                    nmc_HL.Value = Convert.ToInt32(hsv.Hue);
                    ib3C_HV = 0;
                    label_H.Location = new Point(ib3C_Lable_X, ib3C_Lable_Y);
                    label_L.Location = new Point(img_HSVwheel.Location.X + e.X, img_HSVwheel.Location.Y + e.Y);
                }
            }
            ib3C = !ib3C;
        }
        
        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (capture != null)
            {
                try
                {
                    lblWidth.Text = capture.GetCaptureProperty(CapProp.FrameWidth).ToString();
                    lblHeight.Text = capture.GetCaptureProperty(CapProp.FrameHeight).ToString();
                    lblfps.Text = capture.GetCaptureProperty(CapProp.Fps).ToString();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }

        }

    }
}
