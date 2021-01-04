namespace CameraCapture
{
    partial class lblConvertTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblConvertTest));
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblfps = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.camFiltered_Puck = new Emgu.CV.UI.ImageBox();
            this.ckb_EH = new System.Windows.Forms.CheckBox();
            this.ckb_ES = new System.Windows.Forms.CheckBox();
            this.ckb_EV = new System.Windows.Forms.CheckBox();
            this.nmc_HL = new System.Windows.Forms.NumericUpDown();
            this.nmc_SL = new System.Windows.Forms.NumericUpDown();
            this.nmc_VL = new System.Windows.Forms.NumericUpDown();
            this.nmc_HH = new System.Windows.Forms.NumericUpDown();
            this.nmc_SH = new System.Windows.Forms.NumericUpDown();
            this.nmc_VH = new System.Windows.Forms.NumericUpDown();
            this.ckb_LH = new System.Windows.Forms.CheckBox();
            this.ckb_IV = new System.Windows.Forms.CheckBox();
            this.img_HSVwheel_filtered = new Emgu.CV.UI.ImageBox();
            this.img_HSVwheel = new Emgu.CV.UI.ImageBox();
            this.label_L = new System.Windows.Forms.Label();
            this.label_H = new System.Windows.Forms.Label();
            this.imb_1 = new Emgu.CV.UI.ImageBox();
            this.imb_2 = new Emgu.CV.UI.ImageBox();
            this.imb_3 = new Emgu.CV.UI.ImageBox();
            this.imb_4 = new Emgu.CV.UI.ImageBox();
            this.imb_5 = new Emgu.CV.UI.ImageBox();
            this.nmc_cannyThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblcannyThreshold = new System.Windows.Forms.Label();
            this.nmc_circleAccumulatorThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblcircleAccumulatorThreshold = new System.Windows.Forms.Label();
            this.btnpreset = new System.Windows.Forms.Button();
            this.txt_Puck_P_X = new System.Windows.Forms.TextBox();
            this.txt_Puck_P_Y = new System.Windows.Forms.TextBox();
            this.txt_kernelWidth = new System.Windows.Forms.TextBox();
            this.txt_kernelHeight = new System.Windows.Forms.TextBox();
            this.txt_sigma1 = new System.Windows.Forms.TextBox();
            this.txt_sigma2 = new System.Windows.Forms.TextBox();
            this.txbtest = new System.Windows.Forms.TextBox();
            this.nmc_Puck_Alpha_P = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Puck_V_X = new System.Windows.Forms.TextBox();
            this.txtPUCK_V_Y = new System.Windows.Forms.TextBox();
            this.nmc_Puck_Alpha_V = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoundaryPtX = new System.Windows.Forms.TextBox();
            this.txtBoundaryPtY = new System.Windows.Forms.TextBox();
            this.txtMalletTargetX = new System.Windows.Forms.TextBox();
            this.txtMalletTargetY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmcPuckRadius = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmc_HL_mallet = new System.Windows.Forms.NumericUpDown();
            this.nmc_HH_mallet = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlHSV = new System.Windows.Forms.Panel();
            this.pnlGauss = new System.Windows.Forms.Panel();
            this.btnReset_GaussFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlCannyEdge = new System.Windows.Forms.Panel();
            this.btnReset_CannyEdge = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.nmcCircleMaxRadius = new System.Windows.Forms.NumericUpDown();
            this.nmcCircleMinRadius = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.ckbFilterDetection = new System.Windows.Forms.CheckBox();
            this.ckbQuarryDetection = new System.Windows.Forms.CheckBox();
            this.pnlPosition = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtMalletCurrentY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMalletCurrentX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nmcTableBoundary2Y = new System.Windows.Forms.NumericUpDown();
            this.nmcTableBoundary2X = new System.Windows.Forms.NumericUpDown();
            this.nmcTableBoundary1Y = new System.Windows.Forms.NumericUpDown();
            this.nmcTableBoundary1X = new System.Windows.Forms.NumericUpDown();
            this.pnlVelocity = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nmc_Mallet_Alpha_P = new System.Windows.Forms.NumericUpDown();
            this.txt_Mallet_P_X = new System.Windows.Forms.TextBox();
            this.txt_Mallet_P_Y = new System.Windows.Forms.TextBox();
            this.btnSetRanges = new System.Windows.Forms.Button();
            this.txt_puckJitterRange = new System.Windows.Forms.TextBox();
            this.nmc_malletCurrentRange = new System.Windows.Forms.NumericUpDown();
            this.nmc_malletDestinationRange = new System.Windows.Forms.NumericUpDown();
            this.pnlCamera = new System.Windows.Forms.Panel();
            this.ckbRecordBoth = new System.Windows.Forms.CheckBox();
            this.btnSelectFileName = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.ckbSaveData = new System.Windows.Forms.CheckBox();
            this.ckbRecordVideo = new System.Windows.Forms.CheckBox();
            this.img_HSVwheel_filtered2 = new Emgu.CV.UI.ImageBox();
            this.txtTimeElapsed = new System.Windows.Forms.TextBox();
            this.ckbTransmit = new System.Windows.Forms.CheckBox();
            this.pnlSerial = new System.Windows.Forms.Panel();
            this.nmc_returnCountTH = new System.Windows.Forms.NumericUpDown();
            this.lblTest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbUseConstantTargetPos = new System.Windows.Forms.CheckBox();
            this.nmc_malletTargetPosTest = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateComPort = new System.Windows.Forms.Button();
            this.ckbPacketContent = new System.Windows.Forms.CheckBox();
            this.ckbBackToCenter = new System.Windows.Forms.CheckBox();
            this.btnClearText = new System.Windows.Forms.Button();
            this.ckbSendByte = new System.Windows.Forms.CheckBox();
            this.ckbSendInt = new System.Windows.Forms.CheckBox();
            this.ckbShowResponse = new System.Windows.Forms.CheckBox();
            this.txtRawSerial = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSerialPreset = new System.Windows.Forms.Button();
            this.btnSerialSend = new System.Windows.Forms.Button();
            this.btnSerialReset = new System.Windows.Forms.Button();
            this.txtByte5 = new System.Windows.Forms.TextBox();
            this.txtByte4 = new System.Windows.Forms.TextBox();
            this.txtByte3 = new System.Windows.Forms.TextBox();
            this.txtByte2 = new System.Windows.Forms.TextBox();
            this.txtByte1 = new System.Windows.Forms.TextBox();
            this.ckbByte5 = new System.Windows.Forms.CheckBox();
            this.ckbByte4 = new System.Windows.Forms.CheckBox();
            this.ckbByte3 = new System.Windows.Forms.CheckBox();
            this.ckbByte2 = new System.Windows.Forms.CheckBox();
            this.ckbByte1 = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.camTest = new Emgu.CV.UI.ImageBox();
            this.btnCalcualteIntersection = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtMalletY_test = new System.Windows.Forms.TextBox();
            this.txtBoundaryY_test = new System.Windows.Forms.TextBox();
            this.txtMalletX_test = new System.Windows.Forms.TextBox();
            this.txtBoundaryX_test = new System.Windows.Forms.TextBox();
            this.nmcPt2Y_test = new System.Windows.Forms.NumericUpDown();
            this.nmcPt2X_test = new System.Windows.Forms.NumericUpDown();
            this.nmcPt1Y_test = new System.Windows.Forms.NumericUpDown();
            this.nmcPt1X_test = new System.Windows.Forms.NumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.camFiltered_Mallet = new Emgu.CV.UI.ImageBox();
            this.camFiltered_Circles = new Emgu.CV.UI.ImageBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.nmcMalletLowerLimit = new System.Windows.Forms.NumericUpDown();
            this.nmcMalletCenter = new System.Windows.Forms.NumericUpDown();
            this.nmcMalletUpperLimit = new System.Windows.Forms.NumericUpDown();
            this.ckbOverlayMalletDetection = new System.Windows.Forms.CheckBox();
            this.ckbOverlayPuckDetection = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camFiltered_Puck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_HL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_VL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_SH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_VH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_HSVwheel_filtered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_HSVwheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_cannyThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_circleAccumulatorThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Puck_Alpha_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Puck_Alpha_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPuckRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_HL_mallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_HH_mallet)).BeginInit();
            this.pnlHSV.SuspendLayout();
            this.pnlGauss.SuspendLayout();
            this.pnlCannyEdge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCircleMaxRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCircleMinRadius)).BeginInit();
            this.pnlPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTableBoundary2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTableBoundary2X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTableBoundary1Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTableBoundary1X)).BeginInit();
            this.pnlVelocity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Mallet_Alpha_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_malletCurrentRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_malletDestinationRange)).BeginInit();
            this.pnlCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_HSVwheel_filtered2)).BeginInit();
            this.pnlSerial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_returnCountTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_malletTargetPosTest)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPt2Y_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPt2X_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPt1Y_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPt1X_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camFiltered_Mallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camFiltered_Circles)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcMalletLowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcMalletCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcMalletUpperLimit)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(883, 15);
            this.CamImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(853, 590);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            this.CamImageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CamImageBox_MouseClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(4, 4);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 81);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start Camera";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblfps
            // 
            this.lblfps.AutoSize = true;
            this.lblfps.Location = new System.Drawing.Point(9, 123);
            this.lblfps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfps.Name = "lblfps";
            this.lblfps.Size = new System.Drawing.Size(34, 17);
            this.lblfps.TabIndex = 9;
            this.lblfps.Text = "FPS";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(9, 89);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 17);
            this.lblWidth.TabIndex = 11;
            this.lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(9, 105);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 17);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "Height";
            // 
            // camFiltered_Puck
            // 
            this.camFiltered_Puck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camFiltered_Puck.Location = new System.Drawing.Point(883, 612);
            this.camFiltered_Puck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.camFiltered_Puck.Name = "camFiltered_Puck";
            this.camFiltered_Puck.Size = new System.Drawing.Size(426, 295);
            this.camFiltered_Puck.TabIndex = 2;
            this.camFiltered_Puck.TabStop = false;
            // 
            // ckb_EH
            // 
            this.ckb_EH.AutoSize = true;
            this.ckb_EH.Location = new System.Drawing.Point(13, 66);
            this.ckb_EH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckb_EH.Name = "ckb_EH";
            this.ckb_EH.Size = new System.Drawing.Size(48, 21);
            this.ckb_EH.TabIndex = 18;
            this.ckb_EH.Text = "H: ";
            this.ckb_EH.UseVisualStyleBackColor = true;
            // 
            // ckb_ES
            // 
            this.ckb_ES.AutoSize = true;
            this.ckb_ES.Location = new System.Drawing.Point(13, 95);
            this.ckb_ES.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckb_ES.Name = "ckb_ES";
            this.ckb_ES.Size = new System.Drawing.Size(47, 21);
            this.ckb_ES.TabIndex = 18;
            this.ckb_ES.Text = "S: ";
            this.ckb_ES.UseVisualStyleBackColor = true;
            // 
            // ckb_EV
            // 
            this.ckb_EV.AutoSize = true;
            this.ckb_EV.Location = new System.Drawing.Point(13, 123);
            this.ckb_EV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckb_EV.Name = "ckb_EV";
            this.ckb_EV.Size = new System.Drawing.Size(47, 21);
            this.ckb_EV.TabIndex = 18;
            this.ckb_EV.Text = "V: ";
            this.ckb_EV.UseVisualStyleBackColor = true;
            // 
            // nmc_HL
            // 
            this.nmc_HL.Location = new System.Drawing.Point(75, 63);
            this.nmc_HL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_HL.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nmc_HL.Name = "nmc_HL";
            this.nmc_HL.Size = new System.Drawing.Size(69, 22);
            this.nmc_HL.TabIndex = 20;
            // 
            // nmc_SL
            // 
            this.nmc_SL.Location = new System.Drawing.Point(75, 91);
            this.nmc_SL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_SL.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmc_SL.Name = "nmc_SL";
            this.nmc_SL.Size = new System.Drawing.Size(69, 22);
            this.nmc_SL.TabIndex = 20;
            // 
            // nmc_VL
            // 
            this.nmc_VL.Location = new System.Drawing.Point(75, 119);
            this.nmc_VL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_VL.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmc_VL.Name = "nmc_VL";
            this.nmc_VL.Size = new System.Drawing.Size(69, 22);
            this.nmc_VL.TabIndex = 20;
            // 
            // nmc_HH
            // 
            this.nmc_HH.Location = new System.Drawing.Point(152, 63);
            this.nmc_HH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_HH.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nmc_HH.Name = "nmc_HH";
            this.nmc_HH.Size = new System.Drawing.Size(69, 22);
            this.nmc_HH.TabIndex = 20;
            // 
            // nmc_SH
            // 
            this.nmc_SH.Location = new System.Drawing.Point(152, 91);
            this.nmc_SH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_SH.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmc_SH.Name = "nmc_SH";
            this.nmc_SH.Size = new System.Drawing.Size(69, 22);
            this.nmc_SH.TabIndex = 20;
            this.nmc_SH.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // nmc_VH
            // 
            this.nmc_VH.Location = new System.Drawing.Point(152, 119);
            this.nmc_VH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_VH.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmc_VH.Name = "nmc_VH";
            this.nmc_VH.Size = new System.Drawing.Size(69, 22);
            this.nmc_VH.TabIndex = 20;
            this.nmc_VH.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ckb_LH
            // 
            this.ckb_LH.AutoSize = true;
            this.ckb_LH.Location = new System.Drawing.Point(244, 95);
            this.ckb_LH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckb_LH.Name = "ckb_LH";
            this.ckb_LH.Size = new System.Drawing.Size(60, 21);
            this.ckb_LH.TabIndex = 18;
            this.ckb_LH.Text = "Lock";
            this.ckb_LH.UseVisualStyleBackColor = true;
            // 
            // ckb_IV
            // 
            this.ckb_IV.AutoSize = true;
            this.ckb_IV.Location = new System.Drawing.Point(319, 95);
            this.ckb_IV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckb_IV.Name = "ckb_IV";
            this.ckb_IV.Size = new System.Drawing.Size(65, 21);
            this.ckb_IV.TabIndex = 18;
            this.ckb_IV.Text = "Invert";
            this.ckb_IV.UseVisualStyleBackColor = true;
            // 
            // img_HSVwheel_filtered
            // 
            this.img_HSVwheel_filtered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_HSVwheel_filtered.Location = new System.Drawing.Point(16, 780);
            this.img_HSVwheel_filtered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img_HSVwheel_filtered.Name = "img_HSVwheel_filtered";
            this.img_HSVwheel_filtered.Size = new System.Drawing.Size(213, 196);
            this.img_HSVwheel_filtered.TabIndex = 2;
            this.img_HSVwheel_filtered.TabStop = false;
            // 
            // img_HSVwheel
            // 
            this.img_HSVwheel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_HSVwheel.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.img_HSVwheel.Location = new System.Drawing.Point(16, 576);
            this.img_HSVwheel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img_HSVwheel.Name = "img_HSVwheel";
            this.img_HSVwheel.Size = new System.Drawing.Size(213, 196);
            this.img_HSVwheel.TabIndex = 63;
            this.img_HSVwheel.TabStop = false;
            this.img_HSVwheel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.img_HSVwheel_MouseClick);
            // 
            // label_L
            // 
            this.label_L.AutoSize = true;
            this.label_L.BackColor = System.Drawing.Color.White;
            this.label_L.Location = new System.Drawing.Point(63, 594);
            this.label_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_L.Name = "label_L";
            this.label_L.Size = new System.Drawing.Size(16, 17);
            this.label_L.TabIndex = 67;
            this.label_L.Text = "L";
            // 
            // label_H
            // 
            this.label_H.AutoSize = true;
            this.label_H.BackColor = System.Drawing.Color.White;
            this.label_H.Location = new System.Drawing.Point(35, 594);
            this.label_H.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_H.Name = "label_H";
            this.label_H.Size = new System.Drawing.Size(18, 17);
            this.label_H.TabIndex = 66;
            this.label_H.Text = "H";
            // 
            // imb_1
            // 
            this.imb_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imb_1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imb_1.Location = new System.Drawing.Point(245, 415);
            this.imb_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imb_1.Name = "imb_1";
            this.imb_1.Size = new System.Drawing.Size(213, 147);
            this.imb_1.TabIndex = 63;
            this.imb_1.TabStop = false;
            // 
            // imb_2
            // 
            this.imb_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imb_2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imb_2.Location = new System.Drawing.Point(245, 570);
            this.imb_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imb_2.Name = "imb_2";
            this.imb_2.Size = new System.Drawing.Size(213, 147);
            this.imb_2.TabIndex = 63;
            this.imb_2.TabStop = false;
            // 
            // imb_3
            // 
            this.imb_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imb_3.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imb_3.Location = new System.Drawing.Point(245, 725);
            this.imb_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imb_3.Name = "imb_3";
            this.imb_3.Size = new System.Drawing.Size(213, 147);
            this.imb_3.TabIndex = 63;
            this.imb_3.TabStop = false;
            // 
            // imb_4
            // 
            this.imb_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imb_4.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imb_4.Location = new System.Drawing.Point(245, 880);
            this.imb_4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imb_4.Name = "imb_4";
            this.imb_4.Size = new System.Drawing.Size(213, 147);
            this.imb_4.TabIndex = 63;
            this.imb_4.TabStop = false;
            // 
            // imb_5
            // 
            this.imb_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imb_5.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imb_5.Location = new System.Drawing.Point(245, 1035);
            this.imb_5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imb_5.Name = "imb_5";
            this.imb_5.Size = new System.Drawing.Size(213, 147);
            this.imb_5.TabIndex = 63;
            this.imb_5.TabStop = false;
            // 
            // nmc_cannyThreshold
            // 
            this.nmc_cannyThreshold.Location = new System.Drawing.Point(11, 43);
            this.nmc_cannyThreshold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_cannyThreshold.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmc_cannyThreshold.Name = "nmc_cannyThreshold";
            this.nmc_cannyThreshold.Size = new System.Drawing.Size(73, 22);
            this.nmc_cannyThreshold.TabIndex = 45;
            this.nmc_cannyThreshold.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // lblcannyThreshold
            // 
            this.lblcannyThreshold.AutoSize = true;
            this.lblcannyThreshold.Location = new System.Drawing.Point(7, 23);
            this.lblcannyThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcannyThreshold.Name = "lblcannyThreshold";
            this.lblcannyThreshold.Size = new System.Drawing.Size(110, 17);
            this.lblcannyThreshold.TabIndex = 44;
            this.lblcannyThreshold.Text = "cannyThreshold";
            // 
            // nmc_circleAccumulatorThreshold
            // 
            this.nmc_circleAccumulatorThreshold.Location = new System.Drawing.Point(9, 89);
            this.nmc_circleAccumulatorThreshold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_circleAccumulatorThreshold.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmc_circleAccumulatorThreshold.Name = "nmc_circleAccumulatorThreshold";
            this.nmc_circleAccumulatorThreshold.Size = new System.Drawing.Size(73, 22);
            this.nmc_circleAccumulatorThreshold.TabIndex = 45;
            this.nmc_circleAccumulatorThreshold.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblcircleAccumulatorThreshold
            // 
            this.lblcircleAccumulatorThreshold.AutoSize = true;
            this.lblcircleAccumulatorThreshold.Location = new System.Drawing.Point(5, 69);
            this.lblcircleAccumulatorThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcircleAccumulatorThreshold.Name = "lblcircleAccumulatorThreshold";
            this.lblcircleAccumulatorThreshold.Size = new System.Drawing.Size(154, 17);
            this.lblcircleAccumulatorThreshold.TabIndex = 44;
            this.lblcircleAccumulatorThreshold.Text = "Accumulator Threshold";
            // 
            // btnpreset
            // 
            this.btnpreset.Location = new System.Drawing.Point(243, 119);
            this.btnpreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpreset.Name = "btnpreset";
            this.btnpreset.Size = new System.Drawing.Size(68, 28);
            this.btnpreset.TabIndex = 69;
            this.btnpreset.Text = "Preset";
            this.btnpreset.UseVisualStyleBackColor = true;
            this.btnpreset.Click += new System.EventHandler(this.btnpreset_Click);
            // 
            // txt_Puck_P_X
            // 
            this.txt_Puck_P_X.Location = new System.Drawing.Point(103, 49);
            this.txt_Puck_P_X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Puck_P_X.Name = "txt_Puck_P_X";
            this.txt_Puck_P_X.Size = new System.Drawing.Size(79, 22);
            this.txt_Puck_P_X.TabIndex = 72;
            this.txt_Puck_P_X.Tag = "gg";
            // 
            // txt_Puck_P_Y
            // 
            this.txt_Puck_P_Y.Location = new System.Drawing.Point(103, 78);
            this.txt_Puck_P_Y.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Puck_P_Y.Name = "txt_Puck_P_Y";
            this.txt_Puck_P_Y.Size = new System.Drawing.Size(79, 22);
            this.txt_Puck_P_Y.TabIndex = 72;
            // 
            // txt_kernelWidth
            // 
            this.txt_kernelWidth.Location = new System.Drawing.Point(113, 54);
            this.txt_kernelWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_kernelWidth.Name = "txt_kernelWidth";
            this.txt_kernelWidth.Size = new System.Drawing.Size(51, 22);
            this.txt_kernelWidth.TabIndex = 73;
            this.txt_kernelWidth.Text = "3";
            // 
            // txt_kernelHeight
            // 
            this.txt_kernelHeight.Location = new System.Drawing.Point(113, 84);
            this.txt_kernelHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_kernelHeight.Name = "txt_kernelHeight";
            this.txt_kernelHeight.Size = new System.Drawing.Size(51, 22);
            this.txt_kernelHeight.TabIndex = 73;
            this.txt_kernelHeight.Text = "3";
            // 
            // txt_sigma1
            // 
            this.txt_sigma1.Location = new System.Drawing.Point(113, 112);
            this.txt_sigma1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sigma1.Name = "txt_sigma1";
            this.txt_sigma1.Size = new System.Drawing.Size(51, 22);
            this.txt_sigma1.TabIndex = 73;
            this.txt_sigma1.Text = "34.3";
            // 
            // txt_sigma2
            // 
            this.txt_sigma2.Location = new System.Drawing.Point(113, 144);
            this.txt_sigma2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sigma2.Name = "txt_sigma2";
            this.txt_sigma2.Size = new System.Drawing.Size(51, 22);
            this.txt_sigma2.TabIndex = 73;
            this.txt_sigma2.Text = "45.3";
            // 
            // txbtest
            // 
            this.txbtest.Location = new System.Drawing.Point(468, 570);
            this.txbtest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbtest.Multiline = true;
            this.txbtest.Name = "txbtest";
            this.txbtest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbtest.Size = new System.Drawing.Size(407, 302);
            this.txbtest.TabIndex = 74;
            // 
            // nmc_Puck_Alpha_P
            // 
            this.nmc_Puck_Alpha_P.Location = new System.Drawing.Point(103, 110);
            this.nmc_Puck_Alpha_P.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_Puck_Alpha_P.Name = "nmc_Puck_Alpha_P";
            this.nmc_Puck_Alpha_P.Size = new System.Drawing.Size(80, 22);
            this.nmc_Puck_Alpha_P.TabIndex = 20;
            this.nmc_Puck_Alpha_P.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Alpha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Y";
            // 
            // txt_Puck_V_X
            // 
            this.txt_Puck_V_X.Location = new System.Drawing.Point(191, 49);
            this.txt_Puck_V_X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Puck_V_X.Name = "txt_Puck_V_X";
            this.txt_Puck_V_X.Size = new System.Drawing.Size(79, 22);
            this.txt_Puck_V_X.TabIndex = 78;
            // 
            // txtPUCK_V_Y
            // 
            this.txtPUCK_V_Y.Location = new System.Drawing.Point(191, 76);
            this.txtPUCK_V_Y.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPUCK_V_Y.Name = "txtPUCK_V_Y";
            this.txtPUCK_V_Y.Size = new System.Drawing.Size(79, 22);
            this.txtPUCK_V_Y.TabIndex = 78;
            // 
            // nmc_Puck_Alpha_V
            // 
            this.nmc_Puck_Alpha_V.Location = new System.Drawing.Point(191, 108);
            this.nmc_Puck_Alpha_V.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_Puck_Alpha_V.Name = "nmc_Puck_Alpha_V";
            this.nmc_Puck_Alpha_V.Size = new System.Drawing.Size(80, 22);
            this.nmc_Puck_Alpha_V.TabIndex = 20;
            this.nmc_Puck_Alpha_V.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Boundary Coord";
            // 
            // txtBoundaryPtX
            // 
            this.txtBoundaryPtX.Location = new System.Drawing.Point(215, 84);
            this.txtBoundaryPtX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoundaryPtX.Name = "txtBoundaryPtX";
            this.txtBoundaryPtX.Size = new System.Drawing.Size(59, 22);
            this.txtBoundaryPtX.TabIndex = 81;
            // 
            // txtBoundaryPtY
            // 
            this.txtBoundaryPtY.Location = new System.Drawing.Point(215, 114);
            this.txtBoundaryPtY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoundaryPtY.Name = "txtBoundaryPtY";
            this.txtBoundaryPtY.Size = new System.Drawing.Size(59, 22);
            this.txtBoundaryPtY.TabIndex = 81;
            // 
            // txtMalletTargetX
            // 
            this.txtMalletTargetX.Location = new System.Drawing.Point(283, 85);
            this.txtMalletTargetX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMalletTargetX.Name = "txtMalletTargetX";
            this.txtMalletTargetX.Size = new System.Drawing.Size(60, 22);
            this.txtMalletTargetX.TabIndex = 81;
            // 
            // txtMalletTargetY
            // 
            this.txtMalletTargetY.Location = new System.Drawing.Point(283, 114);
            this.txtMalletTargetY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMalletTargetY.Name = "txtMalletTargetY";
            this.txtMalletTargetY.Size = new System.Drawing.Size(60, 22);
            this.txtMalletTargetY.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 82;
            this.label6.Text = "Boundary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "Mallet";
            // 
            // nmcPuckRadius
            // 
            this.nmcPuckRadius.Location = new System.Drawing.Point(127, 151);
            this.nmcPuckRadius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcPuckRadius.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcPuckRadius.Name = "nmcPuckRadius";
            this.nmcPuckRadius.Size = new System.Drawing.Size(80, 22);
            this.nmcPuckRadius.TabIndex = 45;
            this.nmcPuckRadius.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nmcPuckRadius.ValueChanged += new System.EventHandler(this.mncPuckRadius_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "Puck Radius";
            // 
            // nmc_HL_mallet
            // 
            this.nmc_HL_mallet.Location = new System.Drawing.Point(243, 63);
            this.nmc_HL_mallet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_HL_mallet.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nmc_HL_mallet.Name = "nmc_HL_mallet";
            this.nmc_HL_mallet.Size = new System.Drawing.Size(69, 22);
            this.nmc_HL_mallet.TabIndex = 20;
            // 
            // nmc_HH_mallet
            // 
            this.nmc_HH_mallet.Location = new System.Drawing.Point(320, 63);
            this.nmc_HH_mallet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_HH_mallet.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nmc_HH_mallet.Name = "nmc_HH_mallet";
            this.nmc_HH_mallet.Size = new System.Drawing.Size(69, 22);
            this.nmc_HH_mallet.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 17);
            this.label9.TabIndex = 83;
            this.label9.Text = "Puck Detection Setting";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 83;
            this.label10.Text = "Mallet Detection Setting";
            // 
            // pnlHSV
            // 
            this.pnlHSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHSV.Controls.Add(this.pnlGauss);
            this.pnlHSV.Controls.Add(this.pnlCannyEdge);
            this.pnlHSV.Controls.Add(this.ckb_EH);
            this.pnlHSV.Controls.Add(this.label10);
            this.pnlHSV.Controls.Add(this.ckb_LH);
            this.pnlHSV.Controls.Add(this.label9);
            this.pnlHSV.Controls.Add(this.ckb_IV);
            this.pnlHSV.Controls.Add(this.ckb_ES);
            this.pnlHSV.Controls.Add(this.ckb_EV);
            this.pnlHSV.Controls.Add(this.nmc_HL);
            this.pnlHSV.Controls.Add(this.nmc_HL_mallet);
            this.pnlHSV.Controls.Add(this.nmc_HH);
            this.pnlHSV.Controls.Add(this.nmc_HH_mallet);
            this.pnlHSV.Controls.Add(this.nmc_SL);
            this.pnlHSV.Controls.Add(this.nmc_SH);
            this.pnlHSV.Controls.Add(this.nmc_VL);
            this.pnlHSV.Controls.Add(this.label34);
            this.pnlHSV.Controls.Add(this.nmc_VH);
            this.pnlHSV.Controls.Add(this.btnReset);
            this.pnlHSV.Controls.Add(this.btnpreset);
            this.pnlHSV.Location = new System.Drawing.Point(16, 15);
            this.pnlHSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHSV.Name = "pnlHSV";
            this.pnlHSV.Size = new System.Drawing.Size(425, 392);
            this.pnlHSV.TabIndex = 84;
            this.pnlHSV.Tag = "";
            // 
            // pnlGauss
            // 
            this.pnlGauss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGauss.Controls.Add(this.btnReset_GaussFilter);
            this.pnlGauss.Controls.Add(this.label4);
            this.pnlGauss.Controls.Add(this.label23);
            this.pnlGauss.Controls.Add(this.label22);
            this.pnlGauss.Controls.Add(this.label21);
            this.pnlGauss.Controls.Add(this.label20);
            this.pnlGauss.Controls.Add(this.txt_kernelWidth);
            this.pnlGauss.Controls.Add(this.txt_kernelHeight);
            this.pnlGauss.Controls.Add(this.txt_sigma1);
            this.pnlGauss.Controls.Add(this.txt_sigma2);
            this.pnlGauss.Location = new System.Drawing.Point(13, 151);
            this.pnlGauss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGauss.Name = "pnlGauss";
            this.pnlGauss.Size = new System.Drawing.Size(190, 235);
            this.pnlGauss.TabIndex = 88;
            // 
            // btnReset_GaussFilter
            // 
            this.btnReset_GaussFilter.Location = new System.Drawing.Point(35, 176);
            this.btnReset_GaussFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset_GaussFilter.Name = "btnReset_GaussFilter";
            this.btnReset_GaussFilter.Size = new System.Drawing.Size(133, 44);
            this.btnReset_GaussFilter.TabIndex = 74;
            this.btnReset_GaussFilter.Text = "Reset";
            this.btnReset_GaussFilter.UseVisualStyleBackColor = true;
            this.btnReset_GaussFilter.Click += new System.EventHandler(this.btnReset_GaussFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Image Filter Gauss Settings";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 144);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 17);
            this.label23.TabIndex = 44;
            this.label23.Text = "Sigma 2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 116);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 17);
            this.label22.TabIndex = 44;
            this.label22.Text = "Sigma 1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 85);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 17);
            this.label21.TabIndex = 44;
            this.label21.Text = "Kernel Height";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 58);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 17);
            this.label20.TabIndex = 44;
            this.label20.Text = "Kernel Width";
            // 
            // pnlCannyEdge
            // 
            this.pnlCannyEdge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCannyEdge.Controls.Add(this.btnReset_CannyEdge);
            this.pnlCannyEdge.Controls.Add(this.label13);
            this.pnlCannyEdge.Controls.Add(this.nmc_cannyThreshold);
            this.pnlCannyEdge.Controls.Add(this.nmcCircleMaxRadius);
            this.pnlCannyEdge.Controls.Add(this.nmcCircleMinRadius);
            this.pnlCannyEdge.Controls.Add(this.nmc_circleAccumulatorThreshold);
            this.pnlCannyEdge.Controls.Add(this.lblcannyThreshold);
            this.pnlCannyEdge.Controls.Add(this.label42);
            this.pnlCannyEdge.Controls.Add(this.label41);
            this.pnlCannyEdge.Controls.Add(this.lblcircleAccumulatorThreshold);
            this.pnlCannyEdge.Location = new System.Drawing.Point(216, 151);
            this.pnlCannyEdge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCannyEdge.Name = "pnlCannyEdge";
            this.pnlCannyEdge.Size = new System.Drawing.Size(202, 235);
            this.pnlCannyEdge.TabIndex = 88;
            // 
            // btnReset_CannyEdge
            // 
            this.btnReset_CannyEdge.Location = new System.Drawing.Point(100, 95);
            this.btnReset_CannyEdge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset_CannyEdge.Name = "btnReset_CannyEdge";
            this.btnReset_CannyEdge.Size = new System.Drawing.Size(81, 126);
            this.btnReset_CannyEdge.TabIndex = 46;
            this.btnReset_CannyEdge.Text = "Reset";
            this.btnReset_CannyEdge.UseVisualStyleBackColor = true;
            this.btnReset_CannyEdge.Click += new System.EventHandler(this.btnReset_CannyEdge_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Hough Circle Settings";
            // 
            // nmcCircleMaxRadius
            // 
            this.nmcCircleMaxRadius.Location = new System.Drawing.Point(11, 191);
            this.nmcCircleMaxRadius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcCircleMaxRadius.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmcCircleMaxRadius.Name = "nmcCircleMaxRadius";
            this.nmcCircleMaxRadius.Size = new System.Drawing.Size(73, 22);
            this.nmcCircleMaxRadius.TabIndex = 45;
            this.nmcCircleMaxRadius.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // nmcCircleMinRadius
            // 
            this.nmcCircleMinRadius.Location = new System.Drawing.Point(8, 142);
            this.nmcCircleMinRadius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcCircleMinRadius.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmcCircleMinRadius.Name = "nmcCircleMinRadius";
            this.nmcCircleMinRadius.Size = new System.Drawing.Size(73, 22);
            this.nmcCircleMinRadius.TabIndex = 45;
            this.nmcCircleMinRadius.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(7, 171);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(81, 17);
            this.label42.TabIndex = 44;
            this.label42.Text = "Max Radius";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(4, 122);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(78, 17);
            this.label41.TabIndex = 44;
            this.label41.Text = "Min Radius";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label34.Location = new System.Drawing.Point(13, 9);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(162, 19);
            this.label34.TabIndex = 80;
            this.label34.Text = "Color Detection Settings";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(319, 119);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 28);
            this.btnReset.TabIndex = 69;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // ckbFilterDetection
            // 
            this.ckbFilterDetection.AutoSize = true;
            this.ckbFilterDetection.Checked = true;
            this.ckbFilterDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbFilterDetection.Location = new System.Drawing.Point(17, 50);
            this.ckbFilterDetection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbFilterDetection.Name = "ckbFilterDetection";
            this.ckbFilterDetection.Size = new System.Drawing.Size(259, 21);
            this.ckbFilterDetection.TabIndex = 18;
            this.ckbFilterDetection.Text = "Overlay Detection On Filtered Image";
            this.ckbFilterDetection.UseVisualStyleBackColor = true;
            // 
            // ckbQuarryDetection
            // 
            this.ckbQuarryDetection.AutoSize = true;
            this.ckbQuarryDetection.Checked = true;
            this.ckbQuarryDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbQuarryDetection.Location = new System.Drawing.Point(17, 22);
            this.ckbQuarryDetection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbQuarryDetection.Name = "ckbQuarryDetection";
            this.ckbQuarryDetection.Size = new System.Drawing.Size(256, 21);
            this.ckbQuarryDetection.TabIndex = 18;
            this.ckbQuarryDetection.Text = "Overlay Detection On Quarry Image";
            this.ckbQuarryDetection.UseVisualStyleBackColor = true;
            // 
            // pnlPosition
            // 
            this.pnlPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPosition.Controls.Add(this.label33);
            this.pnlPosition.Controls.Add(this.label31);
            this.pnlPosition.Controls.Add(this.label12);
            this.pnlPosition.Controls.Add(this.label15);
            this.pnlPosition.Controls.Add(this.label32);
            this.pnlPosition.Controls.Add(this.label7);
            this.pnlPosition.Controls.Add(this.label8);
            this.pnlPosition.Controls.Add(this.txtMalletCurrentY);
            this.pnlPosition.Controls.Add(this.label6);
            this.pnlPosition.Controls.Add(this.txtMalletTargetY);
            this.pnlPosition.Controls.Add(this.label14);
            this.pnlPosition.Controls.Add(this.txtBoundaryPtY);
            this.pnlPosition.Controls.Add(this.txtMalletCurrentX);
            this.pnlPosition.Controls.Add(this.label11);
            this.pnlPosition.Controls.Add(this.txtMalletTargetX);
            this.pnlPosition.Controls.Add(this.label16);
            this.pnlPosition.Controls.Add(this.label5);
            this.pnlPosition.Controls.Add(this.txtBoundaryPtX);
            this.pnlPosition.Controls.Add(this.nmcTableBoundary2Y);
            this.pnlPosition.Controls.Add(this.nmcTableBoundary2X);
            this.pnlPosition.Controls.Add(this.nmcTableBoundary1Y);
            this.pnlPosition.Controls.Add(this.nmcTableBoundary1X);
            this.pnlPosition.Controls.Add(this.nmcPuckRadius);
            this.pnlPosition.Location = new System.Drawing.Point(449, 15);
            this.pnlPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPosition.Name = "pnlPosition";
            this.pnlPosition.Size = new System.Drawing.Size(426, 209);
            this.pnlPosition.TabIndex = 85;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(356, 148);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 17);
            this.label33.TabIndex = 83;
            this.label33.Text = "Current";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(283, 148);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(50, 17);
            this.label31.TabIndex = 83;
            this.label31.Text = "Target";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(123, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 81;
            this.label12.Text = "Bottom Right";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 116);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 17);
            this.label15.TabIndex = 81;
            this.label15.Text = "Y";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(360, 58);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 17);
            this.label32.TabIndex = 82;
            this.label32.Text = "Mallet";
            // 
            // txtMalletCurrentY
            // 
            this.txtMalletCurrentY.Location = new System.Drawing.Point(351, 114);
            this.txtMalletCurrentY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMalletCurrentY.Name = "txtMalletCurrentY";
            this.txtMalletCurrentY.Size = new System.Drawing.Size(60, 22);
            this.txtMalletCurrentY.TabIndex = 81;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 81;
            this.label14.Text = "X";
            // 
            // txtMalletCurrentX
            // 
            this.txtMalletCurrentX.Location = new System.Drawing.Point(351, 85);
            this.txtMalletCurrentX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMalletCurrentX.Name = "txtMalletCurrentX";
            this.txtMalletCurrentX.Size = new System.Drawing.Size(60, 22);
            this.txtMalletCurrentX.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 81;
            this.label11.Text = "Top Left";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(221, 33);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 17);
            this.label16.TabIndex = 80;
            this.label16.Text = "Intersection Points";
            // 
            // nmcTableBoundary2Y
            // 
            this.nmcTableBoundary2Y.Location = new System.Drawing.Point(133, 113);
            this.nmcTableBoundary2Y.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcTableBoundary2Y.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcTableBoundary2Y.Name = "nmcTableBoundary2Y";
            this.nmcTableBoundary2Y.Size = new System.Drawing.Size(80, 22);
            this.nmcTableBoundary2Y.TabIndex = 45;
            this.nmcTableBoundary2Y.ValueChanged += new System.EventHandler(this.nmcTableBoundary2Y_ValueChanged);
            // 
            // nmcTableBoundary2X
            // 
            this.nmcTableBoundary2X.Location = new System.Drawing.Point(133, 84);
            this.nmcTableBoundary2X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcTableBoundary2X.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcTableBoundary2X.Name = "nmcTableBoundary2X";
            this.nmcTableBoundary2X.Size = new System.Drawing.Size(80, 22);
            this.nmcTableBoundary2X.TabIndex = 45;
            this.nmcTableBoundary2X.ValueChanged += new System.EventHandler(this.nmcTableBoundary2X_ValueChanged);
            // 
            // nmcTableBoundary1Y
            // 
            this.nmcTableBoundary1Y.Location = new System.Drawing.Point(45, 113);
            this.nmcTableBoundary1Y.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcTableBoundary1Y.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcTableBoundary1Y.Name = "nmcTableBoundary1Y";
            this.nmcTableBoundary1Y.Size = new System.Drawing.Size(80, 22);
            this.nmcTableBoundary1Y.TabIndex = 45;
            this.nmcTableBoundary1Y.ValueChanged += new System.EventHandler(this.nmcTableBoundary1Y_ValueChanged);
            // 
            // nmcTableBoundary1X
            // 
            this.nmcTableBoundary1X.Location = new System.Drawing.Point(45, 82);
            this.nmcTableBoundary1X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcTableBoundary1X.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcTableBoundary1X.Name = "nmcTableBoundary1X";
            this.nmcTableBoundary1X.Size = new System.Drawing.Size(80, 22);
            this.nmcTableBoundary1X.TabIndex = 45;
            this.nmcTableBoundary1X.ValueChanged += new System.EventHandler(this.nmcTableBoundary1X_ValueChanged);
            // 
            // pnlVelocity
            // 
            this.pnlVelocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVelocity.Controls.Add(this.label19);
            this.pnlVelocity.Controls.Add(this.label18);
            this.pnlVelocity.Controls.Add(this.label17);
            this.pnlVelocity.Controls.Add(this.label1);
            this.pnlVelocity.Controls.Add(this.nmc_Puck_Alpha_P);
            this.pnlVelocity.Controls.Add(this.nmc_Mallet_Alpha_P);
            this.pnlVelocity.Controls.Add(this.nmc_Puck_Alpha_V);
            this.pnlVelocity.Controls.Add(this.txtPUCK_V_Y);
            this.pnlVelocity.Controls.Add(this.txt_Puck_V_X);
            this.pnlVelocity.Controls.Add(this.label2);
            this.pnlVelocity.Controls.Add(this.txt_Mallet_P_X);
            this.pnlVelocity.Controls.Add(this.label3);
            this.pnlVelocity.Controls.Add(this.txt_Mallet_P_Y);
            this.pnlVelocity.Controls.Add(this.txt_Puck_P_X);
            this.pnlVelocity.Controls.Add(this.txt_Puck_P_Y);
            this.pnlVelocity.Location = new System.Drawing.Point(449, 231);
            this.pnlVelocity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlVelocity.Name = "pnlVelocity";
            this.pnlVelocity.Size = new System.Drawing.Size(426, 174);
            this.pnlVelocity.TabIndex = 86;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(288, 30);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 17);
            this.label19.TabIndex = 79;
            this.label19.Text = "Mallet P";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(108, 30);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 17);
            this.label18.TabIndex = 79;
            this.label18.Text = "Puck P";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(191, 30);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 17);
            this.label17.TabIndex = 79;
            this.label17.Text = "Puck V";
            // 
            // nmc_Mallet_Alpha_P
            // 
            this.nmc_Mallet_Alpha_P.Location = new System.Drawing.Point(283, 110);
            this.nmc_Mallet_Alpha_P.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_Mallet_Alpha_P.Name = "nmc_Mallet_Alpha_P";
            this.nmc_Mallet_Alpha_P.Size = new System.Drawing.Size(80, 22);
            this.nmc_Mallet_Alpha_P.TabIndex = 20;
            this.nmc_Mallet_Alpha_P.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // txt_Mallet_P_X
            // 
            this.txt_Mallet_P_X.Location = new System.Drawing.Point(283, 49);
            this.txt_Mallet_P_X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Mallet_P_X.Name = "txt_Mallet_P_X";
            this.txt_Mallet_P_X.Size = new System.Drawing.Size(79, 22);
            this.txt_Mallet_P_X.TabIndex = 72;
            this.txt_Mallet_P_X.Tag = "gg";
            // 
            // txt_Mallet_P_Y
            // 
            this.txt_Mallet_P_Y.Location = new System.Drawing.Point(283, 78);
            this.txt_Mallet_P_Y.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Mallet_P_Y.Name = "txt_Mallet_P_Y";
            this.txt_Mallet_P_Y.Size = new System.Drawing.Size(79, 22);
            this.txt_Mallet_P_Y.TabIndex = 72;
            // 
            // btnSetRanges
            // 
            this.btnSetRanges.Location = new System.Drawing.Point(264, 9);
            this.btnSetRanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetRanges.Name = "btnSetRanges";
            this.btnSetRanges.Size = new System.Drawing.Size(129, 127);
            this.btnSetRanges.TabIndex = 83;
            this.btnSetRanges.Text = "Set";
            this.btnSetRanges.UseVisualStyleBackColor = true;
            this.btnSetRanges.Click += new System.EventHandler(this.btnSetRanges_Click);
            // 
            // txt_puckJitterRange
            // 
            this.txt_puckJitterRange.Location = new System.Drawing.Point(204, 96);
            this.txt_puckJitterRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_puckJitterRange.Name = "txt_puckJitterRange";
            this.txt_puckJitterRange.Size = new System.Drawing.Size(48, 22);
            this.txt_puckJitterRange.TabIndex = 82;
            this.txt_puckJitterRange.Text = "1.8";
            // 
            // nmc_malletCurrentRange
            // 
            this.nmc_malletCurrentRange.Location = new System.Drawing.Point(204, 64);
            this.nmc_malletCurrentRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_malletCurrentRange.Name = "nmc_malletCurrentRange";
            this.nmc_malletCurrentRange.Size = new System.Drawing.Size(49, 22);
            this.nmc_malletCurrentRange.TabIndex = 81;
            this.nmc_malletCurrentRange.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nmc_malletDestinationRange
            // 
            this.nmc_malletDestinationRange.Location = new System.Drawing.Point(204, 33);
            this.nmc_malletDestinationRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_malletDestinationRange.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmc_malletDestinationRange.Name = "nmc_malletDestinationRange";
            this.nmc_malletDestinationRange.Size = new System.Drawing.Size(53, 22);
            this.nmc_malletDestinationRange.TabIndex = 80;
            this.nmc_malletDestinationRange.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // pnlCamera
            // 
            this.pnlCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCamera.Controls.Add(this.ckbRecordBoth);
            this.pnlCamera.Controls.Add(this.btnSelectFileName);
            this.pnlCamera.Controls.Add(this.txtFileName);
            this.pnlCamera.Controls.Add(this.ckbSaveData);
            this.pnlCamera.Controls.Add(this.ckbRecordVideo);
            this.pnlCamera.Controls.Add(this.btnStart);
            this.pnlCamera.Controls.Add(this.lblfps);
            this.pnlCamera.Controls.Add(this.lblWidth);
            this.pnlCamera.Controls.Add(this.lblHeight);
            this.pnlCamera.Location = new System.Drawing.Point(16, 415);
            this.pnlCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCamera.Name = "pnlCamera";
            this.pnlCamera.Size = new System.Drawing.Size(213, 147);
            this.pnlCamera.TabIndex = 87;
            // 
            // ckbRecordBoth
            // 
            this.ckbRecordBoth.AutoSize = true;
            this.ckbRecordBoth.Location = new System.Drawing.Point(88, 64);
            this.ckbRecordBoth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbRecordBoth.Name = "ckbRecordBoth";
            this.ckbRecordBoth.Size = new System.Drawing.Size(109, 21);
            this.ckbRecordBoth.TabIndex = 17;
            this.ckbRecordBoth.Text = "Record Both";
            this.ckbRecordBoth.UseVisualStyleBackColor = true;
            this.ckbRecordBoth.CheckedChanged += new System.EventHandler(this.ckbRecordBoth_CheckedChanged);
            // 
            // btnSelectFileName
            // 
            this.btnSelectFileName.Location = new System.Drawing.Point(88, 113);
            this.btnSelectFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectFileName.Name = "btnSelectFileName";
            this.btnSelectFileName.Size = new System.Drawing.Size(111, 28);
            this.btnSelectFileName.TabIndex = 16;
            this.btnSelectFileName.Text = "Filename";
            this.btnSelectFileName.UseVisualStyleBackColor = true;
            this.btnSelectFileName.Click += new System.EventHandler(this.btnSelectFileName_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(88, 89);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(109, 22);
            this.txtFileName.TabIndex = 15;
            // 
            // ckbSaveData
            // 
            this.ckbSaveData.AutoSize = true;
            this.ckbSaveData.Location = new System.Drawing.Point(88, 36);
            this.ckbSaveData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbSaveData.Name = "ckbSaveData";
            this.ckbSaveData.Size = new System.Drawing.Size(96, 21);
            this.ckbSaveData.TabIndex = 14;
            this.ckbSaveData.Text = "Save Data";
            this.ckbSaveData.UseVisualStyleBackColor = true;
            this.ckbSaveData.CheckedChanged += new System.EventHandler(this.chkSaveData_CheckedChanged);
            // 
            // ckbRecordVideo
            // 
            this.ckbRecordVideo.AutoSize = true;
            this.ckbRecordVideo.Location = new System.Drawing.Point(88, 7);
            this.ckbRecordVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbRecordVideo.Name = "ckbRecordVideo";
            this.ckbRecordVideo.Size = new System.Drawing.Size(116, 21);
            this.ckbRecordVideo.TabIndex = 13;
            this.ckbRecordVideo.Text = "Record Video";
            this.ckbRecordVideo.UseVisualStyleBackColor = true;
            // 
            // img_HSVwheel_filtered2
            // 
            this.img_HSVwheel_filtered2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_HSVwheel_filtered2.Location = new System.Drawing.Point(16, 985);
            this.img_HSVwheel_filtered2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img_HSVwheel_filtered2.Name = "img_HSVwheel_filtered2";
            this.img_HSVwheel_filtered2.Size = new System.Drawing.Size(213, 196);
            this.img_HSVwheel_filtered2.TabIndex = 2;
            this.img_HSVwheel_filtered2.TabStop = false;
            // 
            // txtTimeElapsed
            // 
            this.txtTimeElapsed.Location = new System.Drawing.Point(467, 880);
            this.txtTimeElapsed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimeElapsed.Multiline = true;
            this.txtTimeElapsed.Name = "txtTimeElapsed";
            this.txtTimeElapsed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTimeElapsed.Size = new System.Drawing.Size(408, 322);
            this.txtTimeElapsed.TabIndex = 74;
            // 
            // ckbTransmit
            // 
            this.ckbTransmit.AutoSize = true;
            this.ckbTransmit.Location = new System.Drawing.Point(167, 107);
            this.ckbTransmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbTransmit.Name = "ckbTransmit";
            this.ckbTransmit.Size = new System.Drawing.Size(85, 21);
            this.ckbTransmit.TabIndex = 88;
            this.ckbTransmit.Text = "Transmit";
            this.ckbTransmit.UseVisualStyleBackColor = true;
            // 
            // pnlSerial
            // 
            this.pnlSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSerial.Controls.Add(this.nmc_returnCountTH);
            this.pnlSerial.Controls.Add(this.lblTest);
            this.pnlSerial.Controls.Add(this.button1);
            this.pnlSerial.Controls.Add(this.ckbUseConstantTargetPos);
            this.pnlSerial.Controls.Add(this.nmc_malletTargetPosTest);
            this.pnlSerial.Controls.Add(this.btnUpdateComPort);
            this.pnlSerial.Controls.Add(this.ckbPacketContent);
            this.pnlSerial.Controls.Add(this.ckbBackToCenter);
            this.pnlSerial.Controls.Add(this.btnClearText);
            this.pnlSerial.Controls.Add(this.ckbSendByte);
            this.pnlSerial.Controls.Add(this.ckbSendInt);
            this.pnlSerial.Controls.Add(this.ckbShowResponse);
            this.pnlSerial.Controls.Add(this.txtRawSerial);
            this.pnlSerial.Controls.Add(this.label24);
            this.pnlSerial.Controls.Add(this.panel1);
            this.pnlSerial.Controls.Add(this.txtByte5);
            this.pnlSerial.Controls.Add(this.txtByte4);
            this.pnlSerial.Controls.Add(this.txtByte3);
            this.pnlSerial.Controls.Add(this.txtByte2);
            this.pnlSerial.Controls.Add(this.txtByte1);
            this.pnlSerial.Controls.Add(this.ckbByte5);
            this.pnlSerial.Controls.Add(this.ckbByte4);
            this.pnlSerial.Controls.Add(this.ckbByte3);
            this.pnlSerial.Controls.Add(this.ckbByte2);
            this.pnlSerial.Controls.Add(this.ckbByte1);
            this.pnlSerial.Controls.Add(this.btnConnect);
            this.pnlSerial.Controls.Add(this.cmbComPort);
            this.pnlSerial.Controls.Add(this.txtBaudRate);
            this.pnlSerial.Controls.Add(this.ckbTransmit);
            this.pnlSerial.Location = new System.Drawing.Point(1743, 15);
            this.pnlSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSerial.Name = "pnlSerial";
            this.pnlSerial.Size = new System.Drawing.Size(407, 816);
            this.pnlSerial.TabIndex = 89;
            // 
            // nmc_returnCountTH
            // 
            this.nmc_returnCountTH.Location = new System.Drawing.Point(216, 480);
            this.nmc_returnCountTH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_returnCountTH.Name = "nmc_returnCountTH";
            this.nmc_returnCountTH.Size = new System.Drawing.Size(80, 22);
            this.nmc_returnCountTH.TabIndex = 109;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(215, 442);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(54, 17);
            this.lblTest.TabIndex = 108;
            this.lblTest.Text = "label43";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 107;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbUseConstantTargetPos
            // 
            this.ckbUseConstantTargetPos.AutoSize = true;
            this.ckbUseConstantTargetPos.Checked = true;
            this.ckbUseConstantTargetPos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseConstantTargetPos.Location = new System.Drawing.Point(117, 149);
            this.ckbUseConstantTargetPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbUseConstantTargetPos.Name = "ckbUseConstantTargetPos";
            this.ckbUseConstantTargetPos.Size = new System.Drawing.Size(132, 21);
            this.ckbUseConstantTargetPos.TabIndex = 106;
            this.ckbUseConstantTargetPos.Text = "Constant Target";
            this.ckbUseConstantTargetPos.UseVisualStyleBackColor = true;
            // 
            // nmc_malletTargetPosTest
            // 
            this.nmc_malletTargetPosTest.Location = new System.Drawing.Point(25, 148);
            this.nmc_malletTargetPosTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmc_malletTargetPosTest.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmc_malletTargetPosTest.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nmc_malletTargetPosTest.Name = "nmc_malletTargetPosTest";
            this.nmc_malletTargetPosTest.Size = new System.Drawing.Size(75, 22);
            this.nmc_malletTargetPosTest.TabIndex = 105;
            this.nmc_malletTargetPosTest.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // btnUpdateComPort
            // 
            this.btnUpdateComPort.Location = new System.Drawing.Point(257, 57);
            this.btnUpdateComPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateComPort.Name = "btnUpdateComPort";
            this.btnUpdateComPort.Size = new System.Drawing.Size(121, 28);
            this.btnUpdateComPort.TabIndex = 104;
            this.btnUpdateComPort.Text = "Update COM";
            this.btnUpdateComPort.UseVisualStyleBackColor = true;
            this.btnUpdateComPort.Click += new System.EventHandler(this.btnUpdateComPort_Click);
            // 
            // ckbPacketContent
            // 
            this.ckbPacketContent.AutoSize = true;
            this.ckbPacketContent.Checked = true;
            this.ckbPacketContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPacketContent.Location = new System.Drawing.Point(263, 108);
            this.ckbPacketContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbPacketContent.Name = "ckbPacketContent";
            this.ckbPacketContent.Size = new System.Drawing.Size(130, 21);
            this.ckbPacketContent.TabIndex = 103;
            this.ckbPacketContent.Text = "Puck and mallet";
            this.ckbPacketContent.UseVisualStyleBackColor = true;
            this.ckbPacketContent.CheckedChanged += new System.EventHandler(this.ckbPacketContent_CheckedChanged);
            // 
            // ckbBackToCenter
            // 
            this.ckbBackToCenter.AutoSize = true;
            this.ckbBackToCenter.Location = new System.Drawing.Point(257, 137);
            this.ckbBackToCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbBackToCenter.Name = "ckbBackToCenter";
            this.ckbBackToCenter.Size = new System.Drawing.Size(143, 21);
            this.ckbBackToCenter.TabIndex = 103;
            this.ckbBackToCenter.Text = "Go back to center";
            this.ckbBackToCenter.UseVisualStyleBackColor = true;
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(236, 518);
            this.btnClearText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(100, 28);
            this.btnClearText.TabIndex = 102;
            this.btnClearText.Text = "Clear Text";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // ckbSendByte
            // 
            this.ckbSendByte.AutoSize = true;
            this.ckbSendByte.Location = new System.Drawing.Point(167, 225);
            this.ckbSendByte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbSendByte.Name = "ckbSendByte";
            this.ckbSendByte.Size = new System.Drawing.Size(95, 21);
            this.ckbSendByte.TabIndex = 101;
            this.ckbSendByte.Text = "Send Byte";
            this.ckbSendByte.UseVisualStyleBackColor = true;
            this.ckbSendByte.CheckedChanged += new System.EventHandler(this.ckbSendByte_CheckedChanged);
            // 
            // ckbSendInt
            // 
            this.ckbSendInt.AutoSize = true;
            this.ckbSendInt.Checked = true;
            this.ckbSendInt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSendInt.Location = new System.Drawing.Point(167, 194);
            this.ckbSendInt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbSendInt.Name = "ckbSendInt";
            this.ckbSendInt.Size = new System.Drawing.Size(82, 21);
            this.ckbSendInt.TabIndex = 101;
            this.ckbSendInt.Text = "Send Int";
            this.ckbSendInt.UseVisualStyleBackColor = true;
            this.ckbSendInt.CheckedChanged += new System.EventHandler(this.ckbSendInt_CheckedChanged);
            // 
            // ckbShowResponse
            // 
            this.ckbShowResponse.AutoSize = true;
            this.ckbShowResponse.Location = new System.Drawing.Point(44, 523);
            this.ckbShowResponse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbShowResponse.Name = "ckbShowResponse";
            this.ckbShowResponse.Size = new System.Drawing.Size(132, 21);
            this.ckbShowResponse.TabIndex = 100;
            this.ckbShowResponse.Text = "Show Response";
            this.ckbShowResponse.UseVisualStyleBackColor = true;
            // 
            // txtRawSerial
            // 
            this.txtRawSerial.Location = new System.Drawing.Point(21, 578);
            this.txtRawSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRawSerial.Multiline = true;
            this.txtRawSerial.Name = "txtRawSerial";
            this.txtRawSerial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRawSerial.Size = new System.Drawing.Size(376, 207);
            this.txtRawSerial.TabIndex = 99;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(24, 12);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(105, 19);
            this.label24.TabIndex = 98;
            this.label24.Text = "Serial Transmit";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSerialPreset);
            this.panel1.Controls.Add(this.btnSerialSend);
            this.panel1.Controls.Add(this.btnSerialReset);
            this.panel1.Location = new System.Drawing.Point(295, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 244);
            this.panel1.TabIndex = 97;
            // 
            // btnSerialPreset
            // 
            this.btnSerialPreset.Location = new System.Drawing.Point(4, 4);
            this.btnSerialPreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSerialPreset.Name = "btnSerialPreset";
            this.btnSerialPreset.Size = new System.Drawing.Size(100, 28);
            this.btnSerialPreset.TabIndex = 95;
            this.btnSerialPreset.Text = "Preset";
            this.btnSerialPreset.UseVisualStyleBackColor = true;
            this.btnSerialPreset.Click += new System.EventHandler(this.btnSerialPreset_Click);
            // 
            // btnSerialSend
            // 
            this.btnSerialSend.Location = new System.Drawing.Point(4, 71);
            this.btnSerialSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSerialSend.Name = "btnSerialSend";
            this.btnSerialSend.Size = new System.Drawing.Size(100, 169);
            this.btnSerialSend.TabIndex = 96;
            this.btnSerialSend.Text = "Send";
            this.btnSerialSend.UseVisualStyleBackColor = true;
            this.btnSerialSend.Click += new System.EventHandler(this.btnSerialSend_Click);
            // 
            // btnSerialReset
            // 
            this.btnSerialReset.Location = new System.Drawing.Point(4, 39);
            this.btnSerialReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSerialReset.Name = "btnSerialReset";
            this.btnSerialReset.Size = new System.Drawing.Size(100, 28);
            this.btnSerialReset.TabIndex = 95;
            this.btnSerialReset.Text = "Reset";
            this.btnSerialReset.UseVisualStyleBackColor = true;
            this.btnSerialReset.Click += new System.EventHandler(this.btnSerialReset_Click);
            // 
            // txtByte5
            // 
            this.txtByte5.Location = new System.Drawing.Point(24, 466);
            this.txtByte5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByte5.Name = "txtByte5";
            this.txtByte5.Size = new System.Drawing.Size(124, 22);
            this.txtByte5.TabIndex = 94;
            this.txtByte5.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte4
            // 
            this.txtByte4.Location = new System.Drawing.Point(24, 405);
            this.txtByte4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByte4.Name = "txtByte4";
            this.txtByte4.Size = new System.Drawing.Size(124, 22);
            this.txtByte4.TabIndex = 94;
            this.txtByte4.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte3
            // 
            this.txtByte3.Location = new System.Drawing.Point(24, 343);
            this.txtByte3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByte3.Name = "txtByte3";
            this.txtByte3.Size = new System.Drawing.Size(124, 22);
            this.txtByte3.TabIndex = 94;
            this.txtByte3.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte2
            // 
            this.txtByte2.Location = new System.Drawing.Point(25, 281);
            this.txtByte2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByte2.Name = "txtByte2";
            this.txtByte2.Size = new System.Drawing.Size(124, 22);
            this.txtByte2.TabIndex = 94;
            this.txtByte2.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // txtByte1
            // 
            this.txtByte1.Location = new System.Drawing.Point(25, 219);
            this.txtByte1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtByte1.Name = "txtByte1";
            this.txtByte1.Size = new System.Drawing.Size(124, 22);
            this.txtByte1.TabIndex = 94;
            this.txtByte1.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // ckbByte5
            // 
            this.ckbByte5.AutoSize = true;
            this.ckbByte5.Location = new System.Drawing.Point(24, 437);
            this.ckbByte5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbByte5.Name = "ckbByte5";
            this.ckbByte5.Size = new System.Drawing.Size(117, 21);
            this.ckbByte5.TabIndex = 92;
            this.ckbByte5.Text = "Byte #5 (End)";
            this.ckbByte5.UseVisualStyleBackColor = true;
            this.ckbByte5.CheckedChanged += new System.EventHandler(this.ckbByte5_CheckedChanged);
            // 
            // ckbByte4
            // 
            this.ckbByte4.AutoSize = true;
            this.ckbByte4.Location = new System.Drawing.Point(24, 375);
            this.ckbByte4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbByte4.Name = "ckbByte4";
            this.ckbByte4.Size = new System.Drawing.Size(221, 21);
            this.ckbByte4.TabIndex = 92;
            this.ckbByte4.Text = "Byte #4 (Destination Location)";
            this.ckbByte4.UseVisualStyleBackColor = true;
            this.ckbByte4.CheckedChanged += new System.EventHandler(this.ckbByte4_CheckedChanged);
            // 
            // ckbByte3
            // 
            this.ckbByte3.AutoSize = true;
            this.ckbByte3.Location = new System.Drawing.Point(24, 314);
            this.ckbByte3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbByte3.Name = "ckbByte3";
            this.ckbByte3.Size = new System.Drawing.Size(197, 21);
            this.ckbByte3.TabIndex = 92;
            this.ckbByte3.Text = "Byte #3 (Current Location)";
            this.ckbByte3.UseVisualStyleBackColor = true;
            this.ckbByte3.CheckedChanged += new System.EventHandler(this.ckbByte3_CheckedChanged);
            // 
            // ckbByte2
            // 
            this.ckbByte2.AutoSize = true;
            this.ckbByte2.Location = new System.Drawing.Point(25, 251);
            this.ckbByte2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbByte2.Name = "ckbByte2";
            this.ckbByte2.Size = new System.Drawing.Size(117, 21);
            this.ckbByte2.TabIndex = 92;
            this.ckbByte2.Text = "Byte #2 Mode";
            this.ckbByte2.UseVisualStyleBackColor = true;
            this.ckbByte2.CheckedChanged += new System.EventHandler(this.ckbByte2_CheckedChanged);
            // 
            // ckbByte1
            // 
            this.ckbByte1.AutoSize = true;
            this.ckbByte1.Location = new System.Drawing.Point(25, 190);
            this.ckbByte1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbByte1.Name = "ckbByte1";
            this.ckbByte1.Size = new System.Drawing.Size(122, 21);
            this.ckbByte1.TabIndex = 92;
            this.ckbByte1.Text = "Byte #1 (Start)";
            this.ckbByte1.UseVisualStyleBackColor = true;
            this.ckbByte1.CheckedChanged += new System.EventHandler(this.ckbByte1_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(149, 57);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 91;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbComPort
            // 
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(24, 59);
            this.cmbComPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(107, 24);
            this.cmbComPort.TabIndex = 90;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(25, 105);
            this.txtBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(123, 22);
            this.txtBaudRate.TabIndex = 89;
            this.txtBaudRate.Text = "9600";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.camTest);
            this.panel2.Controls.Add(this.btnCalcualteIntersection);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.txtMalletY_test);
            this.panel2.Controls.Add(this.txtBoundaryY_test);
            this.panel2.Controls.Add(this.txtMalletX_test);
            this.panel2.Controls.Add(this.txtBoundaryX_test);
            this.panel2.Controls.Add(this.nmcPt2Y_test);
            this.panel2.Controls.Add(this.nmcPt2X_test);
            this.panel2.Controls.Add(this.nmcPt1Y_test);
            this.panel2.Controls.Add(this.nmcPt1X_test);
            this.panel2.Location = new System.Drawing.Point(1744, 838);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 364);
            this.panel2.TabIndex = 90;
            // 
            // camTest
            // 
            this.camTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camTest.Location = new System.Drawing.Point(32, 150);
            this.camTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.camTest.Name = "camTest";
            this.camTest.Size = new System.Drawing.Size(346, 198);
            this.camTest.TabIndex = 2;
            this.camTest.TabStop = false;
            // 
            // btnCalcualteIntersection
            // 
            this.btnCalcualteIntersection.Location = new System.Drawing.Point(32, 114);
            this.btnCalcualteIntersection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcualteIntersection.Name = "btnCalcualteIntersection";
            this.btnCalcualteIntersection.Size = new System.Drawing.Size(347, 28);
            this.btnCalcualteIntersection.TabIndex = 91;
            this.btnCalcualteIntersection.Text = "Calculate Intersection";
            this.btnCalcualteIntersection.UseVisualStyleBackColor = true;
            this.btnCalcualteIntersection.Click += new System.EventHandler(this.btnCalcualteIntersection_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(295, 17);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(45, 17);
            this.label30.TabIndex = 90;
            this.label30.Text = "Mallet";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(213, 17);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 17);
            this.label29.TabIndex = 90;
            this.label29.Text = "Boundary";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(131, 17);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 17);
            this.label28.TabIndex = 90;
            this.label28.Text = "Point 2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(45, 17);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 17);
            this.label27.TabIndex = 90;
            this.label27.Text = "Point 1";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 74);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 17);
            this.label25.TabIndex = 86;
            this.label25.Text = "Y";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 43);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 17);
            this.label26.TabIndex = 87;
            this.label26.Text = "X";
            // 
            // txtMalletY_test
            // 
            this.txtMalletY_test.Location = new System.Drawing.Point(299, 74);
            this.txtMalletY_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMalletY_test.Name = "txtMalletY_test";
            this.txtMalletY_test.Size = new System.Drawing.Size(79, 22);
            this.txtMalletY_test.TabIndex = 88;
            // 
            // txtBoundaryY_test
            // 
            this.txtBoundaryY_test.Location = new System.Drawing.Point(215, 73);
            this.txtBoundaryY_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoundaryY_test.Name = "txtBoundaryY_test";
            this.txtBoundaryY_test.Size = new System.Drawing.Size(79, 22);
            this.txtBoundaryY_test.TabIndex = 88;
            // 
            // txtMalletX_test
            // 
            this.txtMalletX_test.Location = new System.Drawing.Point(299, 43);
            this.txtMalletX_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMalletX_test.Name = "txtMalletX_test";
            this.txtMalletX_test.Size = new System.Drawing.Size(79, 22);
            this.txtMalletX_test.TabIndex = 89;
            // 
            // txtBoundaryX_test
            // 
            this.txtBoundaryX_test.Location = new System.Drawing.Point(215, 42);
            this.txtBoundaryX_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoundaryX_test.Name = "txtBoundaryX_test";
            this.txtBoundaryX_test.Size = new System.Drawing.Size(79, 22);
            this.txtBoundaryX_test.TabIndex = 89;
            // 
            // nmcPt2Y_test
            // 
            this.nmcPt2Y_test.Location = new System.Drawing.Point(133, 71);
            this.nmcPt2Y_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcPt2Y_test.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcPt2Y_test.Name = "nmcPt2Y_test";
            this.nmcPt2Y_test.Size = new System.Drawing.Size(80, 22);
            this.nmcPt2Y_test.TabIndex = 82;
            // 
            // nmcPt2X_test
            // 
            this.nmcPt2X_test.Location = new System.Drawing.Point(133, 42);
            this.nmcPt2X_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcPt2X_test.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcPt2X_test.Name = "nmcPt2X_test";
            this.nmcPt2X_test.Size = new System.Drawing.Size(80, 22);
            this.nmcPt2X_test.TabIndex = 83;
            // 
            // nmcPt1Y_test
            // 
            this.nmcPt1Y_test.Location = new System.Drawing.Point(45, 71);
            this.nmcPt1Y_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcPt1Y_test.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcPt1Y_test.Name = "nmcPt1Y_test";
            this.nmcPt1Y_test.Size = new System.Drawing.Size(80, 22);
            this.nmcPt1Y_test.TabIndex = 84;
            // 
            // nmcPt1X_test
            // 
            this.nmcPt1X_test.Location = new System.Drawing.Point(45, 41);
            this.nmcPt1X_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcPt1X_test.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcPt1X_test.Name = "nmcPt1X_test";
            this.nmcPt1X_test.Size = new System.Drawing.Size(80, 22);
            this.nmcPt1X_test.TabIndex = 85;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // camFiltered_Mallet
            // 
            this.camFiltered_Mallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camFiltered_Mallet.Location = new System.Drawing.Point(883, 907);
            this.camFiltered_Mallet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.camFiltered_Mallet.Name = "camFiltered_Mallet";
            this.camFiltered_Mallet.Size = new System.Drawing.Size(426, 295);
            this.camFiltered_Mallet.TabIndex = 2;
            this.camFiltered_Mallet.TabStop = false;
            // 
            // camFiltered_Circles
            // 
            this.camFiltered_Circles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camFiltered_Circles.Location = new System.Drawing.Point(1309, 612);
            this.camFiltered_Circles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.camFiltered_Circles.Name = "camFiltered_Circles";
            this.camFiltered_Circles.Size = new System.Drawing.Size(426, 295);
            this.camFiltered_Circles.TabIndex = 2;
            this.camFiltered_Circles.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label37);
            this.panel3.Controls.Add(this.label36);
            this.panel3.Controls.Add(this.label35);
            this.panel3.Controls.Add(this.nmcMalletLowerLimit);
            this.panel3.Controls.Add(this.nmcMalletCenter);
            this.panel3.Controls.Add(this.nmcMalletUpperLimit);
            this.panel3.Controls.Add(this.ckbOverlayMalletDetection);
            this.panel3.Controls.Add(this.ckbOverlayPuckDetection);
            this.panel3.Controls.Add(this.ckbFilterDetection);
            this.panel3.Controls.Add(this.ckbQuarryDetection);
            this.panel3.Location = new System.Drawing.Point(1317, 914);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 288);
            this.panel3.TabIndex = 91;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(15, 160);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(120, 17);
            this.label37.TabIndex = 21;
            this.label37.Text = "Mallet Lower Limit";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(15, 192);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(91, 17);
            this.label36.TabIndex = 21;
            this.label36.Text = "Mallet Center";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(15, 224);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(121, 17);
            this.label35.TabIndex = 21;
            this.label35.Text = "Mallet Upper Limit";
            // 
            // nmcMalletLowerLimit
            // 
            this.nmcMalletLowerLimit.Location = new System.Drawing.Point(144, 158);
            this.nmcMalletLowerLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcMalletLowerLimit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmcMalletLowerLimit.Name = "nmcMalletLowerLimit";
            this.nmcMalletLowerLimit.Size = new System.Drawing.Size(88, 22);
            this.nmcMalletLowerLimit.TabIndex = 20;
            // 
            // nmcMalletCenter
            // 
            this.nmcMalletCenter.Location = new System.Drawing.Point(144, 190);
            this.nmcMalletCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcMalletCenter.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmcMalletCenter.Name = "nmcMalletCenter";
            this.nmcMalletCenter.Size = new System.Drawing.Size(88, 22);
            this.nmcMalletCenter.TabIndex = 20;
            // 
            // nmcMalletUpperLimit
            // 
            this.nmcMalletUpperLimit.Location = new System.Drawing.Point(144, 222);
            this.nmcMalletUpperLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcMalletUpperLimit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmcMalletUpperLimit.Name = "nmcMalletUpperLimit";
            this.nmcMalletUpperLimit.Size = new System.Drawing.Size(88, 22);
            this.nmcMalletUpperLimit.TabIndex = 20;
            // 
            // ckbOverlayMalletDetection
            // 
            this.ckbOverlayMalletDetection.AutoSize = true;
            this.ckbOverlayMalletDetection.Checked = true;
            this.ckbOverlayMalletDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOverlayMalletDetection.Location = new System.Drawing.Point(17, 107);
            this.ckbOverlayMalletDetection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbOverlayMalletDetection.Name = "ckbOverlayMalletDetection";
            this.ckbOverlayMalletDetection.Size = new System.Drawing.Size(249, 21);
            this.ckbOverlayMalletDetection.TabIndex = 19;
            this.ckbOverlayMalletDetection.Text = "Overlay Mallet Detection on Gauss";
            this.ckbOverlayMalletDetection.UseVisualStyleBackColor = true;
            // 
            // ckbOverlayPuckDetection
            // 
            this.ckbOverlayPuckDetection.AutoSize = true;
            this.ckbOverlayPuckDetection.Checked = true;
            this.ckbOverlayPuckDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOverlayPuckDetection.Location = new System.Drawing.Point(17, 79);
            this.ckbOverlayPuckDetection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbOverlayPuckDetection.Name = "ckbOverlayPuckDetection";
            this.ckbOverlayPuckDetection.Size = new System.Drawing.Size(243, 21);
            this.ckbOverlayPuckDetection.TabIndex = 19;
            this.ckbOverlayPuckDetection.Text = "Overlay Puck Detection on Gauss";
            this.ckbOverlayPuckDetection.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label40);
            this.panel4.Controls.Add(this.label39);
            this.panel4.Controls.Add(this.label38);
            this.panel4.Controls.Add(this.btnSetRanges);
            this.panel4.Controls.Add(this.txt_puckJitterRange);
            this.panel4.Controls.Add(this.nmc_malletDestinationRange);
            this.panel4.Controls.Add(this.nmc_malletCurrentRange);
            this.panel4.Location = new System.Drawing.Point(468, 415);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 147);
            this.panel4.TabIndex = 92;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(21, 96);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(120, 17);
            this.label40.TabIndex = 84;
            this.label40.Text = "Puck Jitter Range";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(23, 65);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(142, 17);
            this.label39.TabIndex = 84;
            this.label39.Text = "Mallet Current Range";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(23, 37);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(166, 17);
            this.label38.TabIndex = 84;
            this.label38.Text = "Mallet Destination Range";
            // 
            // lblConvertTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1047);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSerial);
            this.Controls.Add(this.pnlCamera);
            this.Controls.Add(this.pnlVelocity);
            this.Controls.Add(this.pnlPosition);
            this.Controls.Add(this.pnlHSV);
            this.Controls.Add(this.txtTimeElapsed);
            this.Controls.Add(this.txbtest);
            this.Controls.Add(this.label_L);
            this.Controls.Add(this.label_H);
            this.Controls.Add(this.imb_5);
            this.Controls.Add(this.imb_4);
            this.Controls.Add(this.imb_3);
            this.Controls.Add(this.imb_2);
            this.Controls.Add(this.imb_1);
            this.Controls.Add(this.img_HSVwheel);
            this.Controls.Add(this.img_HSVwheel_filtered2);
            this.Controls.Add(this.img_HSVwheel_filtered);
            this.Controls.Add(this.camFiltered_Mallet);
            this.Controls.Add(this.camFiltered_Circles);
            this.Controls.Add(this.camFiltered_Puck);
            this.Controls.Add(this.CamImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "lblConvertTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera Output";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraCapture_FormClosing);
            this.Load += new System.EventHandler(this.CameraCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camFiltered_Puck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_HL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_VL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_HH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_SH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_VH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_HSVwheel_filtered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_HSVwheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imb_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_cannyThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_circleAccumulatorThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Puck_Alpha_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Puck_Alpha_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPuckRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_HL_mallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_HH_mallet)).EndInit();
            this.pnlHSV.ResumeLayout(false);
            this.pnlHSV.PerformLayout();
            this.pnlGauss.ResumeLayout(false);
            this.pnlGauss.PerformLayout();
            this.pnlCannyEdge.ResumeLayout(false);
            this.pnlCannyEdge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCircleMaxRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCircleMinRadius)).EndInit();
            this.pnlPosition.ResumeLayout(false);
            this.pnlPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTableBoundary2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTableBoundary2X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTableBoundary1Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTableBoundary1X)).EndInit();
            this.pnlVelocity.ResumeLayout(false);
            this.pnlVelocity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Mallet_Alpha_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_malletCurrentRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_malletDestinationRange)).EndInit();
            this.pnlCamera.ResumeLayout(false);
            this.pnlCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_HSVwheel_filtered2)).EndInit();
            this.pnlSerial.ResumeLayout(false);
            this.pnlSerial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_returnCountTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_malletTargetPosTest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPt2Y_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPt2X_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPt1Y_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPt1X_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camFiltered_Mallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camFiltered_Circles)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcMalletLowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcMalletCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcMalletUpperLimit)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblfps;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private Emgu.CV.UI.ImageBox camFiltered_Puck;
        private System.Windows.Forms.CheckBox ckb_EH;
        private System.Windows.Forms.CheckBox ckb_ES;
        private System.Windows.Forms.CheckBox ckb_EV;
        private System.Windows.Forms.NumericUpDown nmc_HL;
        private System.Windows.Forms.NumericUpDown nmc_SL;
        private System.Windows.Forms.NumericUpDown nmc_VL;
        private System.Windows.Forms.NumericUpDown nmc_HH;
        private System.Windows.Forms.NumericUpDown nmc_SH;
        private System.Windows.Forms.NumericUpDown nmc_VH;
        private System.Windows.Forms.CheckBox ckb_LH;
        private System.Windows.Forms.CheckBox ckb_IV;
        private Emgu.CV.UI.ImageBox img_HSVwheel_filtered;
        private Emgu.CV.UI.ImageBox img_HSVwheel;
        private System.Windows.Forms.Label label_L;
        private System.Windows.Forms.Label label_H;
        private Emgu.CV.UI.ImageBox imb_1;
        private Emgu.CV.UI.ImageBox imb_2;
        private Emgu.CV.UI.ImageBox imb_3;
        private Emgu.CV.UI.ImageBox imb_4;
        private Emgu.CV.UI.ImageBox imb_5;
        private System.Windows.Forms.NumericUpDown nmc_cannyThreshold;
        private System.Windows.Forms.Label lblcannyThreshold;
        private System.Windows.Forms.NumericUpDown nmc_circleAccumulatorThreshold;
        private System.Windows.Forms.Label lblcircleAccumulatorThreshold;
        private System.Windows.Forms.Button btnpreset;
        private System.Windows.Forms.TextBox txt_Puck_P_X;
        private System.Windows.Forms.TextBox txt_Puck_P_Y;
        private System.Windows.Forms.TextBox txt_kernelWidth;
        private System.Windows.Forms.TextBox txt_kernelHeight;
        private System.Windows.Forms.TextBox txt_sigma1;
        private System.Windows.Forms.TextBox txt_sigma2;
        private System.Windows.Forms.TextBox txbtest;
        private System.Windows.Forms.NumericUpDown nmc_Puck_Alpha_P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Puck_V_X;
        private System.Windows.Forms.TextBox txtPUCK_V_Y;
        private System.Windows.Forms.NumericUpDown nmc_Puck_Alpha_V;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoundaryPtX;
        private System.Windows.Forms.TextBox txtBoundaryPtY;
        private System.Windows.Forms.TextBox txtMalletTargetX;
        private System.Windows.Forms.TextBox txtMalletTargetY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmcPuckRadius;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmc_HL_mallet;
        private System.Windows.Forms.NumericUpDown nmc_HH_mallet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlHSV;
        private System.Windows.Forms.Panel pnlPosition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlVelocity;
        private System.Windows.Forms.Panel pnlCamera;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Mallet_P_X;
        private System.Windows.Forms.TextBox txt_Mallet_P_Y;
        private System.Windows.Forms.NumericUpDown nmc_Mallet_Alpha_P;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel pnlGauss;
        private System.Windows.Forms.Panel pnlCannyEdge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ckbQuarryDetection;
        private System.Windows.Forms.CheckBox ckbFilterDetection;
        private System.Windows.Forms.NumericUpDown nmcTableBoundary2Y;
        private System.Windows.Forms.NumericUpDown nmcTableBoundary2X;
        private System.Windows.Forms.NumericUpDown nmcTableBoundary1Y;
        private System.Windows.Forms.NumericUpDown nmcTableBoundary1X;
        private Emgu.CV.UI.ImageBox img_HSVwheel_filtered2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTimeElapsed;
        private System.Windows.Forms.CheckBox ckbTransmit;
        private System.Windows.Forms.Panel pnlSerial;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnSerialSend;
        private System.Windows.Forms.Button btnSerialReset;
        private System.Windows.Forms.Button btnSerialPreset;
        private System.Windows.Forms.TextBox txtByte4;
        private System.Windows.Forms.TextBox txtByte3;
        private System.Windows.Forms.TextBox txtByte2;
        private System.Windows.Forms.TextBox txtByte1;
        private System.Windows.Forms.CheckBox ckbByte4;
        private System.Windows.Forms.CheckBox ckbByte3;
        private System.Windows.Forms.CheckBox ckbByte2;
        private System.Windows.Forms.CheckBox ckbByte1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtByte5;
        private System.Windows.Forms.CheckBox ckbByte5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox ckbRecordVideo;
        private System.Windows.Forms.TextBox txtRawSerial;
        private System.Windows.Forms.CheckBox ckbShowResponse;
        private System.Windows.Forms.CheckBox ckbSendByte;
        private System.Windows.Forms.CheckBox ckbSendInt;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCalcualteIntersection;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtMalletY_test;
        private System.Windows.Forms.TextBox txtBoundaryY_test;
        private System.Windows.Forms.TextBox txtMalletX_test;
        private System.Windows.Forms.TextBox txtBoundaryX_test;
        private System.Windows.Forms.NumericUpDown nmcPt2Y_test;
        private System.Windows.Forms.NumericUpDown nmcPt2X_test;
        private System.Windows.Forms.NumericUpDown nmcPt1Y_test;
        private System.Windows.Forms.NumericUpDown nmcPt1X_test;
        private Emgu.CV.UI.ImageBox camTest;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox ckbBackToCenter;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtMalletCurrentY;
        private System.Windows.Forms.TextBox txtMalletCurrentX;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox ckbPacketContent;
        private Emgu.CV.UI.ImageBox camFiltered_Mallet;
        private Emgu.CV.UI.ImageBox camFiltered_Circles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ckbOverlayMalletDetection;
        private System.Windows.Forms.CheckBox ckbOverlayPuckDetection;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnUpdateComPort;
        private System.Windows.Forms.Button btnReset_CannyEdge;
        private System.Windows.Forms.Button btnReset_GaussFilter;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown nmcMalletLowerLimit;
        private System.Windows.Forms.NumericUpDown nmcMalletCenter;
        private System.Windows.Forms.NumericUpDown nmcMalletUpperLimit;
        private System.Windows.Forms.CheckBox ckbSaveData;
        private System.Windows.Forms.Button btnSelectFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.CheckBox ckbRecordBoth;
        private System.Windows.Forms.NumericUpDown nmc_malletDestinationRange;
        private System.Windows.Forms.Button btnSetRanges;
        private System.Windows.Forms.TextBox txt_puckJitterRange;
        private System.Windows.Forms.NumericUpDown nmc_malletCurrentRange;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown nmcCircleMaxRadius;
        private System.Windows.Forms.NumericUpDown nmcCircleMinRadius;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.CheckBox ckbUseConstantTargetPos;
        private System.Windows.Forms.NumericUpDown nmc_malletTargetPosTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nmc_returnCountTH;
    }
}

