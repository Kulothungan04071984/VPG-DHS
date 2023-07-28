﻿
namespace VPG_DHS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vpgMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActiveadd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.pgWeighing = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkred = new System.Windows.Forms.CheckBox();
            this.chkblack = new System.Windows.Forms.CheckBox();
            this.chkgreen = new System.Windows.Forms.CheckBox();
            this.chkwhite = new System.Windows.Forms.CheckBox();
            this.grpError = new System.Windows.Forms.GroupBox();
            this.chkZerolimit = new System.Windows.Forms.CheckBox();
            this.chkZerofailed = new System.Windows.Forms.CheckBox();
            this.chkPowerfailed = new System.Windows.Forms.CheckBox();
            this.chktarefailed = new System.Windows.Forms.CheckBox();
            this.chkexcitiation = new System.Windows.Forms.CheckBox();
            this.chkloadcellunder = new System.Windows.Forms.CheckBox();
            this.chkloadcellintegrity = new System.Windows.Forms.CheckBox();
            this.chkhardwarefailure = new System.Windows.Forms.CheckBox();
            this.chknofactory = new System.Windows.Forms.CheckBox();
            this.chkinvalidcalib = new System.Windows.Forms.CheckBox();
            this.chknouserdata = new System.Windows.Forms.CheckBox();
            this.chkInvaliddata = new System.Windows.Forms.CheckBox();
            this.chkTimeout = new System.Windows.Forms.CheckBox();
            this.chkUndertemp = new System.Windows.Forms.CheckBox();
            this.chkloadcell = new System.Windows.Forms.CheckBox();
            this.chlTempLimit = new System.Windows.Forms.CheckBox();
            this.chkNonvolatile = new System.Windows.Forms.CheckBox();
            this.chkVolatileramfailure = new System.Windows.Forms.CheckBox();
            this.chkEpromFailure = new System.Windows.Forms.CheckBox();
            this.grpStatusIO = new System.Windows.Forms.GroupBox();
            this.chkset4WD = new System.Windows.Forms.CheckBox();
            this.chkset3WD = new System.Windows.Forms.CheckBox();
            this.chkset2WD = new System.Windows.Forms.CheckBox();
            this.chkset1WD = new System.Windows.Forms.CheckBox();
            this.chkin4WD = new System.Windows.Forms.CheckBox();
            this.chkin3WD = new System.Windows.Forms.CheckBox();
            this.chkin2WD = new System.Windows.Forms.CheckBox();
            this.chkin1WD = new System.Windows.Forms.CheckBox();
            this.grbEthercat = new System.Windows.Forms.GroupBox();
            this.pnlStopbits = new System.Windows.Forms.Panel();
            this.lblStopBITS = new System.Windows.Forms.Label();
            this.pnlPort = new System.Windows.Forms.Panel();
            this.lblport = new System.Windows.Forms.Label();
            this.pnlParity = new System.Windows.Forms.Panel();
            this.lblPARITY = new System.Windows.Forms.Label();
            this.pnlBaudrate = new System.Windows.Forms.Panel();
            this.lblBAUDRATE = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblDataBIts = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbostopbitsWD = new System.Windows.Forms.ComboBox();
            this.cboparityWD = new System.Windows.Forms.ComboBox();
            this.cboBaudrateWD = new System.Windows.Forms.ComboBox();
            this.cbodatabitsWD = new System.Windows.Forms.ComboBox();
            this.cboportnumWD = new System.Windows.Forms.ComboBox();
            this.GroupWeighingDispalyWD = new System.Windows.Forms.GroupBox();
            this.pnlWeighOperation = new System.Windows.Forms.Panel();
            this.pnlWeight = new System.Windows.Forms.Panel();
            this.lblweightWD = new System.Windows.Forms.Label();
            this.txtWeightWD = new System.Windows.Forms.TextBox();
            this.chkZeroTrack = new System.Windows.Forms.CheckBox();
            this.lblKG = new System.Windows.Forms.Label();
            this.chkMotion = new System.Windows.Forms.CheckBox();
            this.btnzero = new System.Windows.Forms.Button();
            this.btnTare = new System.Windows.Forms.Button();
            this.chkNet = new System.Windows.Forms.CheckBox();
            this.grpAdditional = new System.Windows.Forms.GroupBox();
            this.pnlGrab = new System.Windows.Forms.Panel();
            this.lblGrab = new System.Windows.Forms.Label();
            this.pnlPeak = new System.Windows.Forms.Panel();
            this.lblPEAK = new System.Windows.Forms.Label();
            this.btnResetPeak = new System.Windows.Forms.Button();
            this.pnlmVV = new System.Windows.Forms.Panel();
            this.llbMVV = new System.Windows.Forms.Label();
            this.txtGrab = new System.Windows.Forms.TextBox();
            this.txtmVV = new System.Windows.Forms.TextBox();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.chkreadyWD = new System.Windows.Forms.CheckBox();
            this.chkGross = new System.Windows.Forms.CheckBox();
            this.btnResetDevice = new System.Windows.Forms.Button();
            this.pgLoadcell = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbWeightformat = new System.Windows.Forms.TabPage();
            this.tbFilters = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pgCalibration = new System.Windows.Forms.TabPage();
            this.pgView = new System.Windows.Forms.TabPage();
            this.pgGraph = new System.Windows.Forms.TabPage();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VPGSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.vpgMenu.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.pgWeighing.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpError.SuspendLayout();
            this.grpStatusIO.SuspendLayout();
            this.grbEthercat.SuspendLayout();
            this.pnlStopbits.SuspendLayout();
            this.pnlPort.SuspendLayout();
            this.pnlParity.SuspendLayout();
            this.pnlBaudrate.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.GroupWeighingDispalyWD.SuspendLayout();
            this.pnlWeighOperation.SuspendLayout();
            this.pnlWeight.SuspendLayout();
            this.grpAdditional.SuspendLayout();
            this.pnlGrab.SuspendLayout();
            this.pnlPeak.SuspendLayout();
            this.pnlmVV.SuspendLayout();
            this.pgLoadcell.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vpgMenu
            // 
            this.vpgMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.vpgMenu.Location = new System.Drawing.Point(0, 0);
            this.vpgMenu.Name = "vpgMenu";
            this.vpgMenu.Size = new System.Drawing.Size(822, 24);
            this.vpgMenu.TabIndex = 0;
            this.vpgMenu.Text = "Log File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Log File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem2.Text = "About";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem3.Text = "Edit";
            // 
            // btnActiveadd
            // 
            this.btnActiveadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiveadd.Location = new System.Drawing.Point(208, 31);
            this.btnActiveadd.Name = "btnActiveadd";
            this.btnActiveadd.Size = new System.Drawing.Size(124, 23);
            this.btnActiveadd.TabIndex = 1;
            this.btnActiveadd.Text = "Active Address";
            this.btnActiveadd.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(335, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(40, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.pgWeighing);
            this.tbControl.Controls.Add(this.pgLoadcell);
            this.tbControl.Controls.Add(this.pgCalibration);
            this.tbControl.Controls.Add(this.pgView);
            this.tbControl.Controls.Add(this.pgGraph);
            this.tbControl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControl.Location = new System.Drawing.Point(12, 64);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(792, 510);
            this.tbControl.TabIndex = 3;
            this.tbControl.Click += new System.EventHandler(this.tbControl_Click);
            // 
            // pgWeighing
            // 
            this.pgWeighing.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pgWeighing.Controls.Add(this.panel1);
            this.pgWeighing.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgWeighing.Location = new System.Drawing.Point(4, 27);
            this.pgWeighing.Name = "pgWeighing";
            this.pgWeighing.Padding = new System.Windows.Forms.Padding(3);
            this.pgWeighing.Size = new System.Drawing.Size(784, 479);
            this.pgWeighing.TabIndex = 0;
            this.pgWeighing.Text = "Weighing Display & Status";
            this.pgWeighing.Click += new System.EventHandler(this.pgWeighing_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.chkred);
            this.panel1.Controls.Add(this.chkblack);
            this.panel1.Controls.Add(this.chkgreen);
            this.panel1.Controls.Add(this.chkwhite);
            this.panel1.Controls.Add(this.grpError);
            this.panel1.Controls.Add(this.grpStatusIO);
            this.panel1.Controls.Add(this.grbEthercat);
            this.panel1.Controls.Add(this.GroupWeighingDispalyWD);
            this.panel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 479);
            this.panel1.TabIndex = 1;
            // 
            // chkred
            // 
            this.chkred.AutoSize = true;
            this.chkred.Location = new System.Drawing.Point(582, 34);
            this.chkred.Name = "chkred";
            this.chkred.Size = new System.Drawing.Size(64, 19);
            this.chkred.TabIndex = 8;
            this.chkred.Text = "-Active";
            this.chkred.UseVisualStyleBackColor = true;
            // 
            // chkblack
            // 
            this.chkblack.AutoSize = true;
            this.chkblack.Location = new System.Drawing.Point(582, 18);
            this.chkblack.Name = "chkblack";
            this.chkblack.Size = new System.Drawing.Size(88, 19);
            this.chkblack.TabIndex = 7;
            this.chkblack.Text = "-Not Active";
            this.chkblack.UseVisualStyleBackColor = true;
            // 
            // chkgreen
            // 
            this.chkgreen.AutoSize = true;
            this.chkgreen.Location = new System.Drawing.Point(561, 36);
            this.chkgreen.Name = "chkgreen";
            this.chkgreen.Size = new System.Drawing.Size(15, 14);
            this.chkgreen.TabIndex = 6;
            this.chkgreen.UseVisualStyleBackColor = true;
            // 
            // chkwhite
            // 
            this.chkwhite.AutoSize = true;
            this.chkwhite.Location = new System.Drawing.Point(561, 20);
            this.chkwhite.Name = "chkwhite";
            this.chkwhite.Size = new System.Drawing.Size(15, 14);
            this.chkwhite.TabIndex = 5;
            this.chkwhite.UseVisualStyleBackColor = true;
            // 
            // grpError
            // 
            this.grpError.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpError.Controls.Add(this.chkZerolimit);
            this.grpError.Controls.Add(this.chkZerofailed);
            this.grpError.Controls.Add(this.chkPowerfailed);
            this.grpError.Controls.Add(this.chktarefailed);
            this.grpError.Controls.Add(this.chkexcitiation);
            this.grpError.Controls.Add(this.chkloadcellunder);
            this.grpError.Controls.Add(this.chkloadcellintegrity);
            this.grpError.Controls.Add(this.chkhardwarefailure);
            this.grpError.Controls.Add(this.chknofactory);
            this.grpError.Controls.Add(this.chkinvalidcalib);
            this.grpError.Controls.Add(this.chknouserdata);
            this.grpError.Controls.Add(this.chkInvaliddata);
            this.grpError.Controls.Add(this.chkTimeout);
            this.grpError.Controls.Add(this.chkUndertemp);
            this.grpError.Controls.Add(this.chkloadcell);
            this.grpError.Controls.Add(this.chlTempLimit);
            this.grpError.Controls.Add(this.chkNonvolatile);
            this.grpError.Controls.Add(this.chkVolatileramfailure);
            this.grpError.Controls.Add(this.chkEpromFailure);
            this.grpError.ForeColor = System.Drawing.Color.Black;
            this.grpError.Location = new System.Drawing.Point(552, 57);
            this.grpError.Name = "grpError";
            this.grpError.Size = new System.Drawing.Size(210, 413);
            this.grpError.TabIndex = 4;
            this.grpError.TabStop = false;
            this.grpError.Text = "Status Error";
            // 
            // chkZerolimit
            // 
            this.chkZerolimit.AutoSize = true;
            this.chkZerolimit.Location = new System.Drawing.Point(9, 380);
            this.chkZerolimit.Name = "chkZerolimit";
            this.chkZerolimit.Size = new System.Drawing.Size(179, 19);
            this.chkZerolimit.TabIndex = 18;
            this.chkZerolimit.Text = "19-Zero Failed due to Limits";
            this.chkZerolimit.UseVisualStyleBackColor = true;
            // 
            // chkZerofailed
            // 
            this.chkZerofailed.AutoSize = true;
            this.chkZerofailed.Location = new System.Drawing.Point(9, 358);
            this.chkZerofailed.Name = "chkZerofailed";
            this.chkZerofailed.Size = new System.Drawing.Size(186, 19);
            this.chkZerofailed.TabIndex = 17;
            this.chkZerofailed.Text = "18-Zero Failed due to Motion";
            this.chkZerofailed.UseVisualStyleBackColor = true;
            // 
            // chkPowerfailed
            // 
            this.chkPowerfailed.AutoSize = true;
            this.chkPowerfailed.Location = new System.Drawing.Point(9, 337);
            this.chkPowerfailed.Name = "chkPowerfailed";
            this.chkPowerfailed.Size = new System.Drawing.Size(195, 19);
            this.chkPowerfailed.TabIndex = 16;
            this.chkPowerfailed.Text = "17-Power failed due to motion";
            this.chkPowerfailed.UseVisualStyleBackColor = true;
            // 
            // chktarefailed
            // 
            this.chktarefailed.AutoSize = true;
            this.chktarefailed.Location = new System.Drawing.Point(9, 315);
            this.chktarefailed.Name = "chktarefailed";
            this.chktarefailed.Size = new System.Drawing.Size(182, 19);
            this.chktarefailed.TabIndex = 15;
            this.chktarefailed.Text = "16-Tare failed due to motion";
            this.chktarefailed.UseVisualStyleBackColor = true;
            // 
            // chkexcitiation
            // 
            this.chkexcitiation.AutoSize = true;
            this.chkexcitiation.Location = new System.Drawing.Point(9, 294);
            this.chkexcitiation.Name = "chkexcitiation";
            this.chkexcitiation.Size = new System.Drawing.Size(130, 19);
            this.chkexcitiation.TabIndex = 14;
            this.chkexcitiation.Text = "15-Excitation Short";
            this.chkexcitiation.UseVisualStyleBackColor = true;
            // 
            // chkloadcellunder
            // 
            this.chkloadcellunder.AutoSize = true;
            this.chkloadcellunder.Location = new System.Drawing.Point(9, 275);
            this.chkloadcellunder.Name = "chkloadcellunder";
            this.chkloadcellunder.Size = new System.Drawing.Size(151, 19);
            this.chkloadcellunder.TabIndex = 13;
            this.chkloadcellunder.Text = "14-Loadcell UnderLoad";
            this.chkloadcellunder.UseVisualStyleBackColor = true;
            // 
            // chkloadcellintegrity
            // 
            this.chkloadcellintegrity.AutoSize = true;
            this.chkloadcellintegrity.Location = new System.Drawing.Point(9, 256);
            this.chkloadcellintegrity.Name = "chkloadcellintegrity";
            this.chkloadcellintegrity.Size = new System.Drawing.Size(140, 19);
            this.chkloadcellintegrity.TabIndex = 12;
            this.chkloadcellintegrity.Text = "13-LoadCell Integrity";
            this.chkloadcellintegrity.UseVisualStyleBackColor = true;
            // 
            // chkhardwarefailure
            // 
            this.chkhardwarefailure.AutoSize = true;
            this.chkhardwarefailure.Location = new System.Drawing.Point(9, 237);
            this.chkhardwarefailure.Name = "chkhardwarefailure";
            this.chkhardwarefailure.Size = new System.Drawing.Size(138, 19);
            this.chkhardwarefailure.TabIndex = 11;
            this.chkhardwarefailure.Text = "12-Hardware Failure";
            this.chkhardwarefailure.UseVisualStyleBackColor = true;
            // 
            // chknofactory
            // 
            this.chknofactory.AutoSize = true;
            this.chknofactory.Location = new System.Drawing.Point(8, 216);
            this.chknofactory.Name = "chknofactory";
            this.chknofactory.Size = new System.Drawing.Size(163, 19);
            this.chknofactory.TabIndex = 10;
            this.chknofactory.Text = "11-No factory Calibration";
            this.chknofactory.UseVisualStyleBackColor = true;
            // 
            // chkinvalidcalib
            // 
            this.chkinvalidcalib.AutoSize = true;
            this.chkinvalidcalib.Location = new System.Drawing.Point(8, 196);
            this.chkinvalidcalib.Name = "chkinvalidcalib";
            this.chkinvalidcalib.Size = new System.Drawing.Size(197, 19);
            this.chkinvalidcalib.TabIndex = 9;
            this.chkinvalidcalib.Text = "10-Invalid Data User Calibration";
            this.chkinvalidcalib.UseVisualStyleBackColor = true;
            // 
            // chknouserdata
            // 
            this.chknouserdata.AutoSize = true;
            this.chknouserdata.Location = new System.Drawing.Point(9, 177);
            this.chknouserdata.Name = "chknouserdata";
            this.chknouserdata.Size = new System.Drawing.Size(109, 19);
            this.chknouserdata.TabIndex = 8;
            this.chknouserdata.Text = "9-No User Data";
            this.chknouserdata.UseVisualStyleBackColor = true;
            // 
            // chkInvaliddata
            // 
            this.chkInvaliddata.AutoSize = true;
            this.chkInvaliddata.Location = new System.Drawing.Point(8, 157);
            this.chkInvaliddata.Name = "chkInvaliddata";
            this.chkInvaliddata.Size = new System.Drawing.Size(125, 19);
            this.chkInvaliddata.TabIndex = 7;
            this.chkInvaliddata.Text = "8-Invalid UserData";
            this.chkInvaliddata.UseVisualStyleBackColor = true;
            // 
            // chkTimeout
            // 
            this.chkTimeout.AutoSize = true;
            this.chkTimeout.Location = new System.Drawing.Point(8, 137);
            this.chkTimeout.Name = "chkTimeout";
            this.chkTimeout.Size = new System.Drawing.Size(143, 19);
            this.chkTimeout.TabIndex = 6;
            this.chkTimeout.Text = "7-Watch dot Timeout";
            this.chkTimeout.UseVisualStyleBackColor = true;
            // 
            // chkUndertemp
            // 
            this.chkUndertemp.AutoSize = true;
            this.chkUndertemp.Location = new System.Drawing.Point(8, 116);
            this.chkUndertemp.Name = "chkUndertemp";
            this.chkUndertemp.Size = new System.Drawing.Size(177, 19);
            this.chkUndertemp.TabIndex = 5;
            this.chkUndertemp.Text = "6-Under Temperature Limit";
            this.chkUndertemp.UseVisualStyleBackColor = true;
            // 
            // chkloadcell
            // 
            this.chkloadcell.AutoSize = true;
            this.chkloadcell.Location = new System.Drawing.Point(8, 96);
            this.chkloadcell.Name = "chkloadcell";
            this.chkloadcell.Size = new System.Drawing.Size(150, 19);
            this.chkloadcell.TabIndex = 4;
            this.chkloadcell.Text = "5-LoadCell Overloaded";
            this.chkloadcell.UseVisualStyleBackColor = true;
            // 
            // chlTempLimit
            // 
            this.chlTempLimit.AutoSize = true;
            this.chlTempLimit.Location = new System.Drawing.Point(7, 77);
            this.chlTempLimit.Name = "chlTempLimit";
            this.chlTempLimit.Size = new System.Drawing.Size(175, 19);
            this.chlTempLimit.TabIndex = 3;
            this.chlTempLimit.Text = "4-Over Temperature Limits";
            this.chlTempLimit.UseVisualStyleBackColor = true;
            // 
            // chkNonvolatile
            // 
            this.chkNonvolatile.AutoSize = true;
            this.chkNonvolatile.Location = new System.Drawing.Point(6, 57);
            this.chkNonvolatile.Name = "chkNonvolatile";
            this.chkNonvolatile.Size = new System.Drawing.Size(170, 19);
            this.chkNonvolatile.TabIndex = 2;
            this.chkNonvolatile.Text = "3-Non-Volatile ram Failure";
            this.chkNonvolatile.UseVisualStyleBackColor = true;
            // 
            // chkVolatileramfailure
            // 
            this.chkVolatileramfailure.AutoSize = true;
            this.chkVolatileramfailure.Location = new System.Drawing.Point(6, 36);
            this.chkVolatileramfailure.Name = "chkVolatileramfailure";
            this.chkVolatileramfailure.Size = new System.Drawing.Size(176, 19);
            this.chkVolatileramfailure.TabIndex = 1;
            this.chkVolatileramfailure.Text = "2-Volatile write ram Failure";
            this.chkVolatileramfailure.UseVisualStyleBackColor = true;
            // 
            // chkEpromFailure
            // 
            this.chkEpromFailure.AutoSize = true;
            this.chkEpromFailure.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkEpromFailure.Location = new System.Drawing.Point(6, 17);
            this.chkEpromFailure.Name = "chkEpromFailure";
            this.chkEpromFailure.Size = new System.Drawing.Size(113, 19);
            this.chkEpromFailure.TabIndex = 0;
            this.chkEpromFailure.Text = "1-Eprom Failure";
            this.chkEpromFailure.UseVisualStyleBackColor = false;
            // 
            // grpStatusIO
            // 
            this.grpStatusIO.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpStatusIO.Controls.Add(this.chkset4WD);
            this.grpStatusIO.Controls.Add(this.chkset3WD);
            this.grpStatusIO.Controls.Add(this.chkset2WD);
            this.grpStatusIO.Controls.Add(this.chkset1WD);
            this.grpStatusIO.Controls.Add(this.chkin4WD);
            this.grpStatusIO.Controls.Add(this.chkin3WD);
            this.grpStatusIO.Controls.Add(this.chkin2WD);
            this.grpStatusIO.Controls.Add(this.chkin1WD);
            this.grpStatusIO.Location = new System.Drawing.Point(332, 292);
            this.grpStatusIO.Name = "grpStatusIO";
            this.grpStatusIO.Size = new System.Drawing.Size(198, 165);
            this.grpStatusIO.TabIndex = 3;
            this.grpStatusIO.TabStop = false;
            this.grpStatusIO.Text = "Status I/O";
            // 
            // chkset4WD
            // 
            this.chkset4WD.AutoSize = true;
            this.chkset4WD.Location = new System.Drawing.Point(92, 136);
            this.chkset4WD.Name = "chkset4WD";
            this.chkset4WD.Size = new System.Drawing.Size(89, 19);
            this.chkset4WD.TabIndex = 7;
            this.chkset4WD.Text = "SetPoint #4";
            this.chkset4WD.UseVisualStyleBackColor = true;
            // 
            // chkset3WD
            // 
            this.chkset3WD.AutoSize = true;
            this.chkset3WD.Location = new System.Drawing.Point(92, 99);
            this.chkset3WD.Name = "chkset3WD";
            this.chkset3WD.Size = new System.Drawing.Size(89, 19);
            this.chkset3WD.TabIndex = 6;
            this.chkset3WD.Text = "SetPoint #3";
            this.chkset3WD.UseVisualStyleBackColor = true;
            // 
            // chkset2WD
            // 
            this.chkset2WD.AutoSize = true;
            this.chkset2WD.Location = new System.Drawing.Point(92, 61);
            this.chkset2WD.Name = "chkset2WD";
            this.chkset2WD.Size = new System.Drawing.Size(89, 19);
            this.chkset2WD.TabIndex = 5;
            this.chkset2WD.Text = "SetPoint #2";
            this.chkset2WD.UseVisualStyleBackColor = true;
            // 
            // chkset1WD
            // 
            this.chkset1WD.AutoSize = true;
            this.chkset1WD.Location = new System.Drawing.Point(92, 26);
            this.chkset1WD.Name = "chkset1WD";
            this.chkset1WD.Size = new System.Drawing.Size(89, 19);
            this.chkset1WD.TabIndex = 4;
            this.chkset1WD.Text = "SetPoint #1";
            this.chkset1WD.UseVisualStyleBackColor = true;
            // 
            // chkin4WD
            // 
            this.chkin4WD.AutoSize = true;
            this.chkin4WD.Location = new System.Drawing.Point(6, 136);
            this.chkin4WD.Name = "chkin4WD";
            this.chkin4WD.Size = new System.Drawing.Size(71, 19);
            this.chkin4WD.TabIndex = 3;
            this.chkin4WD.Text = "Input #4";
            this.chkin4WD.UseVisualStyleBackColor = true;
            // 
            // chkin3WD
            // 
            this.chkin3WD.AutoSize = true;
            this.chkin3WD.Location = new System.Drawing.Point(6, 99);
            this.chkin3WD.Name = "chkin3WD";
            this.chkin3WD.Size = new System.Drawing.Size(71, 19);
            this.chkin3WD.TabIndex = 2;
            this.chkin3WD.Text = "Input #3";
            this.chkin3WD.UseVisualStyleBackColor = true;
            // 
            // chkin2WD
            // 
            this.chkin2WD.AutoSize = true;
            this.chkin2WD.Location = new System.Drawing.Point(6, 61);
            this.chkin2WD.Name = "chkin2WD";
            this.chkin2WD.Size = new System.Drawing.Size(71, 19);
            this.chkin2WD.TabIndex = 1;
            this.chkin2WD.Text = "Input #2";
            this.chkin2WD.UseVisualStyleBackColor = true;
            // 
            // chkin1WD
            // 
            this.chkin1WD.AutoSize = true;
            this.chkin1WD.Location = new System.Drawing.Point(6, 26);
            this.chkin1WD.Name = "chkin1WD";
            this.chkin1WD.Size = new System.Drawing.Size(71, 19);
            this.chkin1WD.TabIndex = 0;
            this.chkin1WD.Text = "Input #1";
            this.chkin1WD.UseVisualStyleBackColor = true;
            // 
            // grbEthercat
            // 
            this.grbEthercat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grbEthercat.Controls.Add(this.pnlStopbits);
            this.grbEthercat.Controls.Add(this.pnlPort);
            this.grbEthercat.Controls.Add(this.pnlParity);
            this.grbEthercat.Controls.Add(this.pnlBaudrate);
            this.grbEthercat.Controls.Add(this.pnlData);
            this.grbEthercat.Controls.Add(this.btnConnect);
            this.grbEthercat.Controls.Add(this.cbostopbitsWD);
            this.grbEthercat.Controls.Add(this.cboparityWD);
            this.grbEthercat.Controls.Add(this.cboBaudrateWD);
            this.grbEthercat.Controls.Add(this.cbodatabitsWD);
            this.grbEthercat.Controls.Add(this.cboportnumWD);
            this.grbEthercat.Location = new System.Drawing.Point(0, 292);
            this.grbEthercat.Name = "grbEthercat";
            this.grbEthercat.Size = new System.Drawing.Size(323, 165);
            this.grbEthercat.TabIndex = 2;
            this.grbEthercat.TabStop = false;
            this.grbEthercat.Text = "Ethercat Setting";
            // 
            // pnlStopbits
            // 
            this.pnlStopbits.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlStopbits.Controls.Add(this.lblStopBITS);
            this.pnlStopbits.Location = new System.Drawing.Point(121, 89);
            this.pnlStopbits.Name = "pnlStopbits";
            this.pnlStopbits.Size = new System.Drawing.Size(88, 25);
            this.pnlStopbits.TabIndex = 14;
            // 
            // lblStopBITS
            // 
            this.lblStopBITS.AutoSize = true;
            this.lblStopBITS.Location = new System.Drawing.Point(3, 7);
            this.lblStopBITS.Name = "lblStopBITS";
            this.lblStopBITS.Size = new System.Drawing.Size(55, 15);
            this.lblStopBITS.TabIndex = 9;
            this.lblStopBITS.Text = "Stop Bits";
            // 
            // pnlPort
            // 
            this.pnlPort.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlPort.Controls.Add(this.lblport);
            this.pnlPort.Location = new System.Drawing.Point(14, 27);
            this.pnlPort.Name = "pnlPort";
            this.pnlPort.Size = new System.Drawing.Size(88, 25);
            this.pnlPort.TabIndex = 11;
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(4, 6);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(83, 15);
            this.lblport.TabIndex = 5;
            this.lblport.Text = "Port  Number";
            // 
            // pnlParity
            // 
            this.pnlParity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlParity.Controls.Add(this.lblPARITY);
            this.pnlParity.Location = new System.Drawing.Point(13, 89);
            this.pnlParity.Name = "pnlParity";
            this.pnlParity.Size = new System.Drawing.Size(88, 25);
            this.pnlParity.TabIndex = 13;
            // 
            // lblPARITY
            // 
            this.lblPARITY.AutoSize = true;
            this.lblPARITY.Location = new System.Drawing.Point(5, 6);
            this.lblPARITY.Name = "lblPARITY";
            this.lblPARITY.Size = new System.Drawing.Size(39, 15);
            this.lblPARITY.TabIndex = 8;
            this.lblPARITY.Text = "Parity";
            // 
            // pnlBaudrate
            // 
            this.pnlBaudrate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlBaudrate.Controls.Add(this.lblBAUDRATE);
            this.pnlBaudrate.Location = new System.Drawing.Point(226, 26);
            this.pnlBaudrate.Name = "pnlBaudrate";
            this.pnlBaudrate.Size = new System.Drawing.Size(83, 25);
            this.pnlBaudrate.TabIndex = 12;
            // 
            // lblBAUDRATE
            // 
            this.lblBAUDRATE.AutoSize = true;
            this.lblBAUDRATE.Location = new System.Drawing.Point(3, 6);
            this.lblBAUDRATE.Name = "lblBAUDRATE";
            this.lblBAUDRATE.Size = new System.Drawing.Size(62, 15);
            this.lblBAUDRATE.TabIndex = 7;
            this.lblBAUDRATE.Text = "Baud Rate";
            this.lblBAUDRATE.Click += new System.EventHandler(this.lblBAUDRATE_Click);
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlData.Controls.Add(this.lblDataBIts);
            this.pnlData.Location = new System.Drawing.Point(121, 26);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(90, 25);
            this.pnlData.TabIndex = 13;
            // 
            // lblDataBIts
            // 
            this.lblDataBIts.AutoSize = true;
            this.lblDataBIts.Location = new System.Drawing.Point(3, 6);
            this.lblDataBIts.Name = "lblDataBIts";
            this.lblDataBIts.Size = new System.Drawing.Size(55, 15);
            this.lblDataBIts.TabIndex = 6;
            this.lblDataBIts.Text = "Data Bits";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConnect.Location = new System.Drawing.Point(226, 117);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 24);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbostopbitsWD
            // 
            this.cbostopbitsWD.FormattingEnabled = true;
            this.cbostopbitsWD.Location = new System.Drawing.Point(117, 119);
            this.cbostopbitsWD.Name = "cbostopbitsWD";
            this.cbostopbitsWD.Size = new System.Drawing.Size(94, 23);
            this.cbostopbitsWD.TabIndex = 4;
            // 
            // cboparityWD
            // 
            this.cboparityWD.FormattingEnabled = true;
            this.cboparityWD.Location = new System.Drawing.Point(6, 120);
            this.cboparityWD.Name = "cboparityWD";
            this.cboparityWD.Size = new System.Drawing.Size(96, 23);
            this.cboparityWD.TabIndex = 3;
            // 
            // cboBaudrateWD
            // 
            this.cboBaudrateWD.FormattingEnabled = true;
            this.cboBaudrateWD.Location = new System.Drawing.Point(222, 58);
            this.cboBaudrateWD.Name = "cboBaudrateWD";
            this.cboBaudrateWD.Size = new System.Drawing.Size(89, 23);
            this.cboBaudrateWD.TabIndex = 2;
            // 
            // cbodatabitsWD
            // 
            this.cbodatabitsWD.FormattingEnabled = true;
            this.cbodatabitsWD.Location = new System.Drawing.Point(117, 58);
            this.cbodatabitsWD.Name = "cbodatabitsWD";
            this.cbodatabitsWD.Size = new System.Drawing.Size(94, 23);
            this.cbodatabitsWD.TabIndex = 1;
            // 
            // cboportnumWD
            // 
            this.cboportnumWD.FormattingEnabled = true;
            this.cboportnumWD.Location = new System.Drawing.Point(7, 58);
            this.cboportnumWD.Name = "cboportnumWD";
            this.cboportnumWD.Size = new System.Drawing.Size(95, 23);
            this.cboportnumWD.TabIndex = 0;
            // 
            // GroupWeighingDispalyWD
            // 
            this.GroupWeighingDispalyWD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GroupWeighingDispalyWD.Controls.Add(this.pnlWeighOperation);
            this.GroupWeighingDispalyWD.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupWeighingDispalyWD.Location = new System.Drawing.Point(7, 18);
            this.GroupWeighingDispalyWD.Name = "GroupWeighingDispalyWD";
            this.GroupWeighingDispalyWD.Size = new System.Drawing.Size(524, 268);
            this.GroupWeighingDispalyWD.TabIndex = 0;
            this.GroupWeighingDispalyWD.TabStop = false;
            this.GroupWeighingDispalyWD.Text = "Weighing and Operations";
            // 
            // pnlWeighOperation
            // 
            this.pnlWeighOperation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlWeighOperation.Controls.Add(this.pnlWeight);
            this.pnlWeighOperation.Controls.Add(this.chkZeroTrack);
            this.pnlWeighOperation.Controls.Add(this.lblKG);
            this.pnlWeighOperation.Controls.Add(this.chkMotion);
            this.pnlWeighOperation.Controls.Add(this.btnzero);
            this.pnlWeighOperation.Controls.Add(this.btnTare);
            this.pnlWeighOperation.Controls.Add(this.chkNet);
            this.pnlWeighOperation.Controls.Add(this.grpAdditional);
            this.pnlWeighOperation.Controls.Add(this.chkreadyWD);
            this.pnlWeighOperation.Controls.Add(this.chkGross);
            this.pnlWeighOperation.Controls.Add(this.btnResetDevice);
            this.pnlWeighOperation.Location = new System.Drawing.Point(0, 24);
            this.pnlWeighOperation.Name = "pnlWeighOperation";
            this.pnlWeighOperation.Size = new System.Drawing.Size(518, 230);
            this.pnlWeighOperation.TabIndex = 12;
            // 
            // pnlWeight
            // 
            this.pnlWeight.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlWeight.Controls.Add(this.lblweightWD);
            this.pnlWeight.Controls.Add(this.txtWeightWD);
            this.pnlWeight.Location = new System.Drawing.Point(13, 3);
            this.pnlWeight.Name = "pnlWeight";
            this.pnlWeight.Size = new System.Drawing.Size(207, 37);
            this.pnlWeight.TabIndex = 10;
            // 
            // lblweightWD
            // 
            this.lblweightWD.AutoSize = true;
            this.lblweightWD.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweightWD.Location = new System.Drawing.Point(7, 7);
            this.lblweightWD.Name = "lblweightWD";
            this.lblweightWD.Size = new System.Drawing.Size(58, 19);
            this.lblweightWD.TabIndex = 0;
            this.lblweightWD.Text = "Weight";
            // 
            // txtWeightWD
            // 
            this.txtWeightWD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtWeightWD.Location = new System.Drawing.Point(71, 0);
            this.txtWeightWD.Multiline = true;
            this.txtWeightWD.Name = "txtWeightWD";
            this.txtWeightWD.Size = new System.Drawing.Size(136, 37);
            this.txtWeightWD.TabIndex = 1;
            // 
            // chkZeroTrack
            // 
            this.chkZeroTrack.AutoSize = true;
            this.chkZeroTrack.Location = new System.Drawing.Point(313, 137);
            this.chkZeroTrack.Name = "chkZeroTrack";
            this.chkZeroTrack.Size = new System.Drawing.Size(97, 19);
            this.chkZeroTrack.TabIndex = 11;
            this.chkZeroTrack.Text = "Zero Tracking";
            this.chkZeroTrack.UseVisualStyleBackColor = true;
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKG.Location = new System.Drawing.Point(222, 18);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(25, 19);
            this.lblKG.TabIndex = 2;
            this.lblKG.Text = "kg";
            // 
            // chkMotion
            // 
            this.chkMotion.AutoSize = true;
            this.chkMotion.Location = new System.Drawing.Point(313, 108);
            this.chkMotion.Name = "chkMotion";
            this.chkMotion.Size = new System.Drawing.Size(66, 19);
            this.chkMotion.TabIndex = 10;
            this.chkMotion.Text = "Motion";
            this.chkMotion.UseVisualStyleBackColor = true;
            // 
            // btnzero
            // 
            this.btnzero.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnzero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnzero.Location = new System.Drawing.Point(13, 46);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(87, 27);
            this.btnzero.TabIndex = 3;
            this.btnzero.Text = "Zero";
            this.btnzero.UseVisualStyleBackColor = false;
            // 
            // btnTare
            // 
            this.btnTare.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTare.Location = new System.Drawing.Point(125, 46);
            this.btnTare.Name = "btnTare";
            this.btnTare.Size = new System.Drawing.Size(94, 27);
            this.btnTare.TabIndex = 4;
            this.btnTare.Text = "Tare";
            this.btnTare.UseVisualStyleBackColor = false;
            // 
            // chkNet
            // 
            this.chkNet.AutoSize = true;
            this.chkNet.Location = new System.Drawing.Point(313, 79);
            this.chkNet.Name = "chkNet";
            this.chkNet.Size = new System.Drawing.Size(47, 19);
            this.chkNet.TabIndex = 9;
            this.chkNet.Text = "Net";
            this.chkNet.UseVisualStyleBackColor = true;
            // 
            // grpAdditional
            // 
            this.grpAdditional.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpAdditional.Controls.Add(this.pnlGrab);
            this.grpAdditional.Controls.Add(this.pnlPeak);
            this.grpAdditional.Controls.Add(this.btnResetPeak);
            this.grpAdditional.Controls.Add(this.pnlmVV);
            this.grpAdditional.Controls.Add(this.txtGrab);
            this.grpAdditional.Controls.Add(this.txtmVV);
            this.grpAdditional.Controls.Add(this.txtPeak);
            this.grpAdditional.Location = new System.Drawing.Point(7, 86);
            this.grpAdditional.Name = "grpAdditional";
            this.grpAdditional.Size = new System.Drawing.Size(248, 139);
            this.grpAdditional.TabIndex = 5;
            this.grpAdditional.TabStop = false;
            this.grpAdditional.Text = "Additional";
            // 
            // pnlGrab
            // 
            this.pnlGrab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlGrab.Controls.Add(this.lblGrab);
            this.pnlGrab.Location = new System.Drawing.Point(119, 70);
            this.pnlGrab.Name = "pnlGrab";
            this.pnlGrab.Size = new System.Drawing.Size(54, 25);
            this.pnlGrab.TabIndex = 15;
            // 
            // lblGrab
            // 
            this.lblGrab.AutoSize = true;
            this.lblGrab.Location = new System.Drawing.Point(2, 6);
            this.lblGrab.Name = "lblGrab";
            this.lblGrab.Size = new System.Drawing.Size(33, 15);
            this.lblGrab.TabIndex = 2;
            this.lblGrab.Text = "Grab";
            // 
            // pnlPeak
            // 
            this.pnlPeak.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlPeak.Controls.Add(this.lblPEAK);
            this.pnlPeak.Location = new System.Drawing.Point(14, 16);
            this.pnlPeak.Name = "pnlPeak";
            this.pnlPeak.Size = new System.Drawing.Size(73, 25);
            this.pnlPeak.TabIndex = 15;
            // 
            // lblPEAK
            // 
            this.lblPEAK.AutoSize = true;
            this.lblPEAK.Location = new System.Drawing.Point(3, 6);
            this.lblPEAK.Name = "lblPEAK";
            this.lblPEAK.Size = new System.Drawing.Size(33, 15);
            this.lblPEAK.TabIndex = 0;
            this.lblPEAK.Text = "Peak";
            // 
            // btnResetPeak
            // 
            this.btnResetPeak.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnResetPeak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetPeak.Location = new System.Drawing.Point(12, 70);
            this.btnResetPeak.Name = "btnResetPeak";
            this.btnResetPeak.Size = new System.Drawing.Size(87, 27);
            this.btnResetPeak.TabIndex = 6;
            this.btnResetPeak.Text = "Reset Peak";
            this.btnResetPeak.UseVisualStyleBackColor = false;
            // 
            // pnlmVV
            // 
            this.pnlmVV.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlmVV.Controls.Add(this.llbMVV);
            this.pnlmVV.Location = new System.Drawing.Point(119, 16);
            this.pnlmVV.Name = "pnlmVV";
            this.pnlmVV.Size = new System.Drawing.Size(54, 25);
            this.pnlmVV.TabIndex = 14;
            // 
            // llbMVV
            // 
            this.llbMVV.AutoSize = true;
            this.llbMVV.Location = new System.Drawing.Point(3, 7);
            this.llbMVV.Name = "llbMVV";
            this.llbMVV.Size = new System.Drawing.Size(39, 15);
            this.llbMVV.TabIndex = 1;
            this.llbMVV.Text = "mV/V";
            // 
            // txtGrab
            // 
            this.txtGrab.Location = new System.Drawing.Point(119, 98);
            this.txtGrab.Name = "txtGrab";
            this.txtGrab.Size = new System.Drawing.Size(94, 23);
            this.txtGrab.TabIndex = 5;
            // 
            // txtmVV
            // 
            this.txtmVV.Location = new System.Drawing.Point(120, 43);
            this.txtmVV.Name = "txtmVV";
            this.txtmVV.Size = new System.Drawing.Size(94, 23);
            this.txtmVV.TabIndex = 4;
            // 
            // txtPeak
            // 
            this.txtPeak.Location = new System.Drawing.Point(13, 43);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(94, 23);
            this.txtPeak.TabIndex = 3;
            // 
            // chkreadyWD
            // 
            this.chkreadyWD.AutoSize = true;
            this.chkreadyWD.Location = new System.Drawing.Point(313, 21);
            this.chkreadyWD.Name = "chkreadyWD";
            this.chkreadyWD.Size = new System.Drawing.Size(59, 19);
            this.chkreadyWD.TabIndex = 7;
            this.chkreadyWD.Text = "Ready";
            this.chkreadyWD.UseVisualStyleBackColor = true;
            // 
            // chkGross
            // 
            this.chkGross.AutoSize = true;
            this.chkGross.Location = new System.Drawing.Point(313, 50);
            this.chkGross.Name = "chkGross";
            this.chkGross.Size = new System.Drawing.Size(56, 19);
            this.chkGross.TabIndex = 8;
            this.chkGross.Text = "Gross";
            this.chkGross.UseVisualStyleBackColor = true;
            // 
            // btnResetDevice
            // 
            this.btnResetDevice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnResetDevice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetDevice.Location = new System.Drawing.Point(296, 183);
            this.btnResetDevice.Name = "btnResetDevice";
            this.btnResetDevice.Size = new System.Drawing.Size(150, 28);
            this.btnResetDevice.TabIndex = 6;
            this.btnResetDevice.Text = "Reset Device";
            this.btnResetDevice.UseVisualStyleBackColor = false;
            // 
            // pgLoadcell
            // 
            this.pgLoadcell.Controls.Add(this.tabControl1);
            this.pgLoadcell.Location = new System.Drawing.Point(4, 27);
            this.pgLoadcell.Name = "pgLoadcell";
            this.pgLoadcell.Padding = new System.Windows.Forms.Padding(3);
            this.pgLoadcell.Size = new System.Drawing.Size(784, 479);
            this.pgLoadcell.TabIndex = 1;
            this.pgLoadcell.Text = "LoadCell Setup";
            this.pgLoadcell.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbWeightformat);
            this.tabControl1.Controls.Add(this.tbFilters);
            this.tabControl1.Location = new System.Drawing.Point(24, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tbWeightformat
            // 
            this.tbWeightformat.Location = new System.Drawing.Point(4, 27);
            this.tbWeightformat.Name = "tbWeightformat";
            this.tbWeightformat.Padding = new System.Windows.Forms.Padding(3);
            this.tbWeightformat.Size = new System.Drawing.Size(550, 389);
            this.tbWeightformat.TabIndex = 0;
            this.tbWeightformat.Text = "Weight Format/Zero/Tare/Motion ";
            this.tbWeightformat.UseVisualStyleBackColor = true;
            // 
            // tbFilters
            // 
            this.tbFilters.Controls.Add(this.label3);
            this.tbFilters.Location = new System.Drawing.Point(4, 27);
            this.tbFilters.Name = "tbFilters";
            this.tbFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tbFilters.Size = new System.Drawing.Size(550, 389);
            this.tbFilters.TabIndex = 1;
            this.tbFilters.Text = "Filters/Peak/Grab/Setpoints";
            this.tbFilters.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Grab";
            // 
            // pgCalibration
            // 
            this.pgCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgCalibration.Location = new System.Drawing.Point(4, 27);
            this.pgCalibration.Name = "pgCalibration";
            this.pgCalibration.Size = new System.Drawing.Size(784, 479);
            this.pgCalibration.TabIndex = 2;
            this.pgCalibration.Text = "Calibration";
            this.pgCalibration.UseVisualStyleBackColor = true;
            // 
            // pgView
            // 
            this.pgView.Location = new System.Drawing.Point(4, 27);
            this.pgView.Name = "pgView";
            this.pgView.Size = new System.Drawing.Size(784, 479);
            this.pgView.TabIndex = 3;
            this.pgView.Text = "View All";
            this.pgView.UseVisualStyleBackColor = true;
            // 
            // pgGraph
            // 
            this.pgGraph.Location = new System.Drawing.Point(4, 27);
            this.pgGraph.Name = "pgGraph";
            this.pgGraph.Size = new System.Drawing.Size(784, 479);
            this.pgGraph.TabIndex = 4;
            this.pgGraph.Text = "Graph";
            this.pgGraph.UseVisualStyleBackColor = true;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(380, 35);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(89, 15);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "Temperature";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(475, 33);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(90, 20);
            this.txtTemp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "C";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(605, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // VPGSerialPort
            // 
            this.VPGSerialPort.BaudRate = 112500;
            this.VPGSerialPort.PortName = "COM9";
            this.VPGSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.VPGSerialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnActiveadd);
            this.Controls.Add(this.vpgMenu);
            this.Name = "Form1";
            this.Text = "VPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.vpgMenu.ResumeLayout(false);
            this.vpgMenu.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.pgWeighing.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpError.ResumeLayout(false);
            this.grpError.PerformLayout();
            this.grpStatusIO.ResumeLayout(false);
            this.grpStatusIO.PerformLayout();
            this.grbEthercat.ResumeLayout(false);
            this.pnlStopbits.ResumeLayout(false);
            this.pnlStopbits.PerformLayout();
            this.pnlPort.ResumeLayout(false);
            this.pnlPort.PerformLayout();
            this.pnlParity.ResumeLayout(false);
            this.pnlParity.PerformLayout();
            this.pnlBaudrate.ResumeLayout(false);
            this.pnlBaudrate.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.GroupWeighingDispalyWD.ResumeLayout(false);
            this.pnlWeighOperation.ResumeLayout(false);
            this.pnlWeighOperation.PerformLayout();
            this.pnlWeight.ResumeLayout(false);
            this.pnlWeight.PerformLayout();
            this.grpAdditional.ResumeLayout(false);
            this.grpAdditional.PerformLayout();
            this.pnlGrab.ResumeLayout(false);
            this.pnlGrab.PerformLayout();
            this.pnlPeak.ResumeLayout(false);
            this.pnlPeak.PerformLayout();
            this.pnlmVV.ResumeLayout(false);
            this.pnlmVV.PerformLayout();
            this.pgLoadcell.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbFilters.ResumeLayout(false);
            this.tbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip vpgMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button btnActiveadd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage pgWeighing;
        private System.Windows.Forms.TabPage pgLoadcell;
        private System.Windows.Forms.TabPage pgCalibration;
        private System.Windows.Forms.TabPage pgView;
        private System.Windows.Forms.TabPage pgGraph;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbWeightformat;
        private System.Windows.Forms.TabPage tbFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpError;
        private System.Windows.Forms.CheckBox chkZerolimit;
        private System.Windows.Forms.CheckBox chkZerofailed;
        private System.Windows.Forms.CheckBox chkPowerfailed;
        private System.Windows.Forms.CheckBox chktarefailed;
        private System.Windows.Forms.CheckBox chkexcitiation;
        private System.Windows.Forms.CheckBox chkloadcellunder;
        private System.Windows.Forms.CheckBox chkloadcellintegrity;
        private System.Windows.Forms.CheckBox chkhardwarefailure;
        private System.Windows.Forms.CheckBox chknofactory;
        private System.Windows.Forms.CheckBox chkinvalidcalib;
        private System.Windows.Forms.CheckBox chknouserdata;
        private System.Windows.Forms.CheckBox chkInvaliddata;
        private System.Windows.Forms.CheckBox chkTimeout;
        private System.Windows.Forms.CheckBox chkUndertemp;
        private System.Windows.Forms.CheckBox chkloadcell;
        private System.Windows.Forms.CheckBox chlTempLimit;
        private System.Windows.Forms.CheckBox chkNonvolatile;
        private System.Windows.Forms.CheckBox chkVolatileramfailure;
        private System.Windows.Forms.CheckBox chkEpromFailure;
        private System.Windows.Forms.GroupBox grpStatusIO;
        private System.Windows.Forms.CheckBox chkset4WD;
        private System.Windows.Forms.CheckBox chkset3WD;
        private System.Windows.Forms.CheckBox chkset2WD;
        private System.Windows.Forms.CheckBox chkset1WD;
        private System.Windows.Forms.CheckBox chkin4WD;
        private System.Windows.Forms.CheckBox chkin3WD;
        private System.Windows.Forms.CheckBox chkin2WD;
        private System.Windows.Forms.CheckBox chkin1WD;
        private System.Windows.Forms.GroupBox grbEthercat;
        private System.Windows.Forms.Label lblStopBITS;
        private System.Windows.Forms.Label lblPARITY;
        private System.Windows.Forms.Label lblBAUDRATE;
        private System.Windows.Forms.Label lblDataBIts;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.ComboBox cbostopbitsWD;
        private System.Windows.Forms.ComboBox cboparityWD;
        private System.Windows.Forms.ComboBox cboBaudrateWD;
        private System.Windows.Forms.ComboBox cbodatabitsWD;
        private System.Windows.Forms.ComboBox cboportnumWD;
        private System.Windows.Forms.GroupBox GroupWeighingDispalyWD;
        private System.Windows.Forms.CheckBox chkZeroTrack;
        private System.Windows.Forms.CheckBox chkMotion;
        private System.Windows.Forms.CheckBox chkNet;
        private System.Windows.Forms.CheckBox chkGross;
        private System.Windows.Forms.CheckBox chkreadyWD;
        private System.Windows.Forms.Button btnResetDevice;
        private System.Windows.Forms.GroupBox grpAdditional;
        private System.Windows.Forms.Button btnResetPeak;
        private System.Windows.Forms.TextBox txtGrab;
        private System.Windows.Forms.TextBox txtmVV;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.Label lblGrab;
        private System.Windows.Forms.Label llbMVV;
        private System.Windows.Forms.Label lblPEAK;
        private System.Windows.Forms.Button btnTare;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.TextBox txtWeightWD;
        private System.Windows.Forms.Label lblweightWD;
        private System.Windows.Forms.CheckBox chkred;
        private System.Windows.Forms.CheckBox chkblack;
        private System.Windows.Forms.CheckBox chkgreen;
        private System.Windows.Forms.CheckBox chkwhite;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pnlWeighOperation;
        private System.Windows.Forms.Panel pnlWeight;
        private System.Windows.Forms.Panel pnlPort;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlBaudrate;
        private System.Windows.Forms.Panel pnlParity;
        private System.Windows.Forms.Panel pnlStopbits;
        private System.Windows.Forms.Panel pnlGrab;
        private System.Windows.Forms.Panel pnlPeak;
        private System.Windows.Forms.Panel pnlmVV;
        private System.IO.Ports.SerialPort VPGSerialPort;
    }
}

