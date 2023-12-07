
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.vpgMenu = new System.Windows.Forms.MenuStrip();
            this.tlLogfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tlAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tlEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboAddress = new System.Windows.Forms.ComboBox();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.pgWeighing = new System.Windows.Forms.TabPage();
            this.grbWStatusError = new System.Windows.Forms.GroupBox();
            this.chkWOvertemperature = new System.Windows.Forms.CheckBox();
            this.chkWNonVolatile = new System.Windows.Forms.CheckBox();
            this.chkWVolatile = new System.Windows.Forms.CheckBox();
            this.chkWNoUser = new System.Windows.Forms.CheckBox();
            this.chkWInvaild = new System.Windows.Forms.CheckBox();
            this.chkWatchDot = new System.Windows.Forms.CheckBox();
            this.chkUnderTemp = new System.Windows.Forms.CheckBox();
            this.chkLoadcelloverload = new System.Windows.Forms.CheckBox();
            this.chkWEprom = new System.Windows.Forms.CheckBox();
            this.lblWNouser = new System.Windows.Forms.Label();
            this.lblWInvalid = new System.Windows.Forms.Label();
            this.lblWWatch = new System.Windows.Forms.Label();
            this.lblWUnder = new System.Windows.Forms.Label();
            this.lblWLoad = new System.Windows.Forms.Label();
            this.lblWOver = new System.Windows.Forms.Label();
            this.lblWNonVolatile = new System.Windows.Forms.Label();
            this.lblWVolatile = new System.Windows.Forms.Label();
            this.lblWEprom = new System.Windows.Forms.Label();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.chkWInput4 = new System.Windows.Forms.CheckBox();
            this.chkWInput3 = new System.Windows.Forms.CheckBox();
            this.chkWInput2 = new System.Windows.Forms.CheckBox();
            this.chkWSet4 = new System.Windows.Forms.CheckBox();
            this.chKWSet3 = new System.Windows.Forms.CheckBox();
            this.chkWSet2 = new System.Windows.Forms.CheckBox();
            this.chkWSet1 = new System.Windows.Forms.CheckBox();
            this.chkWInput1 = new System.Windows.Forms.CheckBox();
            this.lblWInput4 = new System.Windows.Forms.Label();
            this.lblWInput3 = new System.Windows.Forms.Label();
            this.lblWInput2 = new System.Windows.Forms.Label();
            this.lblWSet4 = new System.Windows.Forms.Label();
            this.lblWSet3 = new System.Windows.Forms.Label();
            this.lblWSet2 = new System.Windows.Forms.Label();
            this.lblWSetpoint = new System.Windows.Forms.Label();
            this.lblWInput1 = new System.Windows.Forms.Label();
            this.grbWPccommunication = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboWStopBits = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.cboWDataBits = new System.Windows.Forms.ComboBox();
            this.cboPortNumber = new System.Windows.Forms.ComboBox();
            this.lblWParity = new System.Windows.Forms.Label();
            this.lablWBaud = new System.Windows.Forms.Label();
            this.lblWDataBits = new System.Windows.Forms.Label();
            this.lblWStopBit = new System.Windows.Forms.Label();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.lblWActive = new System.Windows.Forms.Label();
            this.lblWNotActive = new System.Windows.Forms.Label();
            this.grbWWeighingandOperation = new System.Windows.Forms.GroupBox();
            this.grbWWeight = new System.Windows.Forms.GroupBox();
            this.grbWAdditional = new System.Windows.Forms.GroupBox();
            this.txtWGrab = new System.Windows.Forms.TextBox();
            this.txtWmV = new System.Windows.Forms.TextBox();
            this.txtWPeak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWGrab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWResetPeak = new System.Windows.Forms.Button();
            this.btnWTare = new System.Windows.Forms.Button();
            this.btnWZero = new System.Windows.Forms.Button();
            this.txtWWeight = new System.Windows.Forms.TextBox();
            this.lblWKg = new System.Windows.Forms.Label();
            this.btnWResetDevice = new System.Windows.Forms.Button();
            this.lblWZeroTracking = new System.Windows.Forms.Label();
            this.lblWMotion = new System.Windows.Forms.Label();
            this.lblWNet = new System.Windows.Forms.Label();
            this.lblWGross = new System.Windows.Forms.Label();
            this.lblWReady = new System.Windows.Forms.Label();
            this.chkWzeroTracking = new System.Windows.Forms.CheckBox();
            this.chkWMotion = new System.Windows.Forms.CheckBox();
            this.chkWNet = new System.Windows.Forms.CheckBox();
            this.chkWGross = new System.Windows.Forms.CheckBox();
            this.chKWReady = new System.Windows.Forms.CheckBox();
            this.chkWActive2 = new System.Windows.Forms.CheckBox();
            this.chkWActive = new System.Windows.Forms.CheckBox();
            this.chkWNotActive2 = new System.Windows.Forms.CheckBox();
            this.chkWNotActive = new System.Windows.Forms.CheckBox();
            this.pgLoadcell = new System.Windows.Forms.TabPage();
            this.grpLNotes = new System.Windows.Forms.GroupBox();
            this.lblLNotes = new System.Windows.Forms.Label();
            this.btnLsavetodevice = new System.Windows.Forms.Button();
            this.btnLsavetofile = new System.Windows.Forms.Button();
            this.btnLuploadfromfile = new System.Windows.Forms.Button();
            this.btnLdownloadtodevie = new System.Windows.Forms.Button();
            this.btnLupload = new System.Windows.Forms.Button();
            this.lblweightkg = new System.Windows.Forms.Label();
            this.lblkg = new System.Windows.Forms.Label();
            this.txtWeightkg = new System.Windows.Forms.TextBox();
            this.tbWeightfilter = new System.Windows.Forms.TabControl();
            this.tbWeightformat = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblFloating = new System.Windows.Forms.Label();
            this.txtMotiondetectperiod = new System.Windows.Forms.TextBox();
            this.txtMotiondetectband = new System.Windows.Forms.TextBox();
            this.cboMotionDetect = new System.Windows.Forms.ComboBox();
            this.lblMotiondetectperiod = new System.Windows.Forms.Label();
            this.lblMotiondetectband = new System.Windows.Forms.Label();
            this.lblMotionDetect = new System.Windows.Forms.Label();
            this.lblMotion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboWeightunit = new System.Windows.Forms.ComboBox();
            this.lblWeightres = new System.Windows.Forms.Label();
            this.lblWeightuni = new System.Windows.Forms.Label();
            this.lblWeightformat = new System.Windows.Forms.Label();
            this.grpTare = new System.Windows.Forms.GroupBox();
            this.lblTraegroup = new System.Windows.Forms.Label();
            this.grpMeasure = new System.Windows.Forms.GroupBox();
            this.lblPeriodbandtare = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtFixedtare = new System.Windows.Forms.TextBox();
            this.lblFixedtare = new System.Windows.Forms.Label();
            this.lblTare = new System.Windows.Forms.Label();
            this.cboZtrack = new System.Windows.Forms.ComboBox();
            this.txtZtrackperiod = new System.Windows.Forms.TextBox();
            this.txtZtrackband = new System.Windows.Forms.TextBox();
            this.txtPOZB = new System.Windows.Forms.TextBox();
            this.cboPOZ = new System.Windows.Forms.ComboBox();
            this.lblZtrackperiod = new System.Windows.Forms.Label();
            this.lblZtrackband = new System.Windows.Forms.Label();
            this.lblZtrack = new System.Windows.Forms.Label();
            this.lblPOZB = new System.Windows.Forms.Label();
            this.lblPOZ = new System.Windows.Forms.Label();
            this.lblZero = new System.Windows.Forms.Label();
            this.tbFilters = new System.Windows.Forms.TabPage();
            this.grpMeasuring = new System.Windows.Forms.GroupBox();
            this.lblMax2per = new System.Windows.Forms.Label();
            this.lblHysteresisweightunit = new System.Windows.Forms.Label();
            this.lblWeightunit = new System.Windows.Forms.Label();
            this.lblMilli = new System.Windows.Forms.Label();
            this.cboPeak = new System.Windows.Forms.ComboBox();
            this.cboMeasure = new System.Windows.Forms.ComboBox();
            this.lblPeaktrough = new System.Windows.Forms.Label();
            this.lblPeak = new System.Windows.Forms.Label();
            this.lblMeasurate = new System.Windows.Forms.Label();
            this.txtNo4hysteresis = new System.Windows.Forms.TextBox();
            this.txtNo4level = new System.Windows.Forms.TextBox();
            this.txtNo3hysteresis = new System.Windows.Forms.TextBox();
            this.txtNo3level = new System.Windows.Forms.TextBox();
            this.txtNo2hysteresis = new System.Windows.Forms.TextBox();
            this.txtNo2level = new System.Windows.Forms.TextBox();
            this.txtNo1hysteresis = new System.Windows.Forms.TextBox();
            this.txtNo1level = new System.Windows.Forms.TextBox();
            this.cboNo4source = new System.Windows.Forms.ComboBox();
            this.cboNo3source = new System.Windows.Forms.ComboBox();
            this.cboNo2source = new System.Windows.Forms.ComboBox();
            this.cboSource = new System.Windows.Forms.ComboBox();
            this.lblNo4level = new System.Windows.Forms.Label();
            this.lblNo2level = new System.Windows.Forms.Label();
            this.lblNo4hysteresis = new System.Windows.Forms.Label();
            this.lblNo2Hysteresis = new System.Windows.Forms.Label();
            this.lblNo3source = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblNo4source = new System.Windows.Forms.Label();
            this.lblNo2source = new System.Windows.Forms.Label();
            this.lblNo3level = new System.Windows.Forms.Label();
            this.lblNo3hysteresis = new System.Windows.Forms.Label();
            this.lblNo1Hysteresis = new System.Windows.Forms.Label();
            this.lblNo1level = new System.Windows.Forms.Label();
            this.lblNo1source = new System.Windows.Forms.Label();
            this.lblSetpoints = new System.Windows.Forms.Label();
            this.cboFir = new System.Windows.Forms.ComboBox();
            this.cboRecursive = new System.Windows.Forms.ComboBox();
            this.cboFiltertype = new System.Windows.Forms.ComboBox();
            this.lblRecursive = new System.Windows.Forms.Label();
            this.lblFir = new System.Windows.Forms.Label();
            this.lblFiltertype = new System.Windows.Forms.Label();
            this.lblFiltering = new System.Windows.Forms.Label();
            this.txtHysteresis = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.cboTrigger = new System.Windows.Forms.ComboBox();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.lblHysteresis = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblGrab = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkfastfilter = new System.Windows.Forms.CheckBox();
            this.lblFastfilter = new System.Windows.Forms.Label();
            this.chkStandardfilter = new System.Windows.Forms.CheckBox();
            this.lblStandardFilter = new System.Windows.Forms.Label();
            this.lblFilterMode = new System.Windows.Forms.Label();
            this.pgCalibration = new System.Windows.Forms.TabPage();
            this.pnlCalibration = new System.Windows.Forms.Panel();
            this.btnSavecali = new System.Windows.Forms.Button();
            this.txtWeightresolution = new System.Windows.Forms.TextBox();
            this.lblWeightResolution = new System.Windows.Forms.Label();
            this.txtWeightunit = new System.Windows.Forms.TextBox();
            this.lblWeightunitcali = new System.Windows.Forms.Label();
            this.btnAcquirespan = new System.Windows.Forms.Button();
            this.lblmVVHighcali = new System.Windows.Forms.Label();
            this.txtmVVHighcali = new System.Windows.Forms.TextBox();
            this.lblmMVlowCali = new System.Windows.Forms.Label();
            this.txtmvVLowcali = new System.Windows.Forms.TextBox();
            this.lblCaliweighthigh = new System.Windows.Forms.Label();
            this.txtWeightHighcali = new System.Windows.Forms.TextBox();
            this.lblWeightLowcali = new System.Windows.Forms.Label();
            this.txtCaliWeightLow = new System.Windows.Forms.TextBox();
            this.btnAcquirecali = new System.Windows.Forms.Button();
            this.txtmVCali = new System.Windows.Forms.TextBox();
            this.lblmMvCali = new System.Windows.Forms.Label();
            this.txtWcali = new System.Windows.Forms.TextBox();
            this.lblCweighty = new System.Windows.Forms.Label();
            this.grpCalipro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pgView = new System.Windows.Forms.TabPage();
            this.btnFinddevice = new System.Windows.Forms.Button();
            this.grpVnotes = new System.Windows.Forms.GroupBox();
            this.lblVnotes = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.rdP12 = new System.Windows.Forms.RadioButton();
            this.txtP12gross = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtP12Add = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rdP11motion = new System.Windows.Forms.RadioButton();
            this.txtP11gross = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtP11Add = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rdP10motion = new System.Windows.Forms.RadioButton();
            this.txtP10gross = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtP10add = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.rdP9motion = new System.Windows.Forms.RadioButton();
            this.txtP9gross = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtP9add = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdP8motion = new System.Windows.Forms.RadioButton();
            this.txtP8gross = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtP8Add = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdP7motion = new System.Windows.Forms.RadioButton();
            this.txtP7gross = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtP7Add = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rdP6motion = new System.Windows.Forms.RadioButton();
            this.txtP6gross = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtP6add = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rdP5motion = new System.Windows.Forms.RadioButton();
            this.txtP5gross = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtP5add = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdP4motion = new System.Windows.Forms.RadioButton();
            this.txtP4Gross = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtP4add = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdP3motion = new System.Windows.Forms.RadioButton();
            this.txtP3Gross = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtP3Add = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdP2motion = new System.Windows.Forms.RadioButton();
            this.txtP2gross = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtP2add = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdP1motion = new System.Windows.Forms.RadioButton();
            this.txtVp1gross = new System.Windows.Forms.TextBox();
            this.lblP1add = new System.Windows.Forms.Label();
            this.lblP1gross = new System.Windows.Forms.Label();
            this.txtVp1add = new System.Windows.Forms.TextBox();
            this.lblVerror = new System.Windows.Forms.Label();
            this.txtVerror = new System.Windows.Forms.TextBox();
            this.lblVnotactive = new System.Windows.Forms.Label();
            this.lblVactive = new System.Windows.Forms.Label();
            this.txtVnotactive = new System.Windows.Forms.TextBox();
            this.txtVactive = new System.Windows.Forms.TextBox();
            this.pgGraph = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.chtGraphy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkGcursor = new System.Windows.Forms.CheckBox();
            this.lblGraphCursor = new System.Windows.Forms.Label();
            this.btnGstart = new System.Windows.Forms.Button();
            this.lblGnotes = new System.Windows.Forms.Label();
            this.cboSeconds = new System.Windows.Forms.ComboBox();
            this.lblGweightUnit = new System.Windows.Forms.Label();
            this.llbGbuffersize = new System.Windows.Forms.Label();
            this.txtGweightunit = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblCweight = new System.Windows.Forms.Label();
            this.btnCalisave = new System.Windows.Forms.Button();
            this.txtCweight = new System.Windows.Forms.TextBox();
            this.txtCweightres = new System.Windows.Forms.TextBox();
            this.lblCmv = new System.Windows.Forms.Label();
            this.txtCweightunit = new System.Windows.Forms.TextBox();
            this.txtCmv = new System.Windows.Forms.TextBox();
            this.lblCweightres = new System.Windows.Forms.Label();
            this.btnCacquire = new System.Windows.Forms.Button();
            this.lblCweightunit = new System.Windows.Forms.Label();
            this.btnCAcspan = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblCweightlow = new System.Windows.Forms.Label();
            this.lblCmvv = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCweighthigh = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCmvvhigh = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.picSyrma = new System.Windows.Forms.PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblActiveadd = new System.Windows.Forms.Label();
            this.vpgMenu.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.pgWeighing.SuspendLayout();
            this.grbWStatusError.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.grbWPccommunication.SuspendLayout();
            this.grbWWeighingandOperation.SuspendLayout();
            this.grbWWeight.SuspendLayout();
            this.grbWAdditional.SuspendLayout();
            this.pgLoadcell.SuspendLayout();
            this.grpLNotes.SuspendLayout();
            this.tbWeightfilter.SuspendLayout();
            this.tbWeightformat.SuspendLayout();
            this.grpTare.SuspendLayout();
            this.grpMeasure.SuspendLayout();
            this.tbFilters.SuspendLayout();
            this.grpMeasuring.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pgCalibration.SuspendLayout();
            this.pnlCalibration.SuspendLayout();
            this.grpCalipro.SuspendLayout();
            this.pgView.SuspendLayout();
            this.grpVnotes.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pgGraph.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraphy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSyrma)).BeginInit();
            this.SuspendLayout();
            // 
            // vpgMenu
            // 
            this.vpgMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.vpgMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlLogfile,
            this.tlAbout,
            this.tlEdit});
            this.vpgMenu.Location = new System.Drawing.Point(0, 0);
            this.vpgMenu.Name = "vpgMenu";
            this.vpgMenu.Size = new System.Drawing.Size(1283, 24);
            this.vpgMenu.TabIndex = 0;
            this.vpgMenu.Text = "Log File";
            this.vpgMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.vpgMenu_ItemClicked);
            // 
            // tlLogfile
            // 
            this.tlLogfile.BackColor = System.Drawing.Color.Azure;
            this.tlLogfile.Image = ((System.Drawing.Image)(resources.GetObject("tlLogfile.Image")));
            this.tlLogfile.Name = "tlLogfile";
            this.tlLogfile.Size = new System.Drawing.Size(76, 20);
            this.tlLogfile.Text = "Log File";
            this.tlLogfile.Click += new System.EventHandler(this.tlLogfile_Click);
            // 
            // tlAbout
            // 
            this.tlAbout.BackColor = System.Drawing.Color.Azure;
            this.tlAbout.Image = ((System.Drawing.Image)(resources.GetObject("tlAbout.Image")));
            this.tlAbout.Name = "tlAbout";
            this.tlAbout.Size = new System.Drawing.Size(68, 20);
            this.tlAbout.Text = "About";
            this.tlAbout.Click += new System.EventHandler(this.tlAbout_Click);
            // 
            // tlEdit
            // 
            this.tlEdit.BackColor = System.Drawing.Color.Azure;
            this.tlEdit.Image = ((System.Drawing.Image)(resources.GetObject("tlEdit.Image")));
            this.tlEdit.Name = "tlEdit";
            this.tlEdit.Size = new System.Drawing.Size(55, 20);
            this.tlEdit.Text = "Edit";
            this.tlEdit.Click += new System.EventHandler(this.tlEdit_Click);
            // 
            // cboAddress
            // 
            this.cboAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboAddress.FormattingEnabled = true;
            this.cboAddress.Location = new System.Drawing.Point(507, 34);
            this.cboAddress.Name = "cboAddress";
            this.cboAddress.Size = new System.Drawing.Size(40, 21);
            this.cboAddress.TabIndex = 2;
            this.cboAddress.SelectedIndexChanged += new System.EventHandler(this.cboAddress_SelectedIndexChanged);
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
            this.tbControl.Size = new System.Drawing.Size(1296, 510);
            this.tbControl.TabIndex = 3;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // pgWeighing
            // 
            this.pgWeighing.BackColor = System.Drawing.Color.AliceBlue;
            this.pgWeighing.Controls.Add(this.grbWStatusError);
            this.pgWeighing.Controls.Add(this.grbStatus);
            this.pgWeighing.Controls.Add(this.grbWPccommunication);
            this.pgWeighing.Controls.Add(this.lblWActive);
            this.pgWeighing.Controls.Add(this.lblWNotActive);
            this.pgWeighing.Controls.Add(this.grbWWeighingandOperation);
            this.pgWeighing.Controls.Add(this.chkWActive2);
            this.pgWeighing.Controls.Add(this.chkWActive);
            this.pgWeighing.Controls.Add(this.chkWNotActive2);
            this.pgWeighing.Controls.Add(this.chkWNotActive);
            this.pgWeighing.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgWeighing.Location = new System.Drawing.Point(4, 27);
            this.pgWeighing.Name = "pgWeighing";
            this.pgWeighing.Padding = new System.Windows.Forms.Padding(3);
            this.pgWeighing.Size = new System.Drawing.Size(1288, 479);
            this.pgWeighing.TabIndex = 0;
            this.pgWeighing.Text = "Weighing Display & Status";
            this.pgWeighing.Click += new System.EventHandler(this.pgWeighing_Click);
            // 
            // grbWStatusError
            // 
            this.grbWStatusError.BackColor = System.Drawing.Color.LightBlue;
            this.grbWStatusError.Controls.Add(this.chkWOvertemperature);
            this.grbWStatusError.Controls.Add(this.chkWNonVolatile);
            this.grbWStatusError.Controls.Add(this.chkWVolatile);
            this.grbWStatusError.Controls.Add(this.chkWNoUser);
            this.grbWStatusError.Controls.Add(this.chkWInvaild);
            this.grbWStatusError.Controls.Add(this.chkWatchDot);
            this.grbWStatusError.Controls.Add(this.chkUnderTemp);
            this.grbWStatusError.Controls.Add(this.chkLoadcelloverload);
            this.grbWStatusError.Controls.Add(this.chkWEprom);
            this.grbWStatusError.Controls.Add(this.lblWNouser);
            this.grbWStatusError.Controls.Add(this.lblWInvalid);
            this.grbWStatusError.Controls.Add(this.lblWWatch);
            this.grbWStatusError.Controls.Add(this.lblWUnder);
            this.grbWStatusError.Controls.Add(this.lblWLoad);
            this.grbWStatusError.Controls.Add(this.lblWOver);
            this.grbWStatusError.Controls.Add(this.lblWNonVolatile);
            this.grbWStatusError.Controls.Add(this.lblWVolatile);
            this.grbWStatusError.Controls.Add(this.lblWEprom);
            this.grbWStatusError.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbWStatusError.Location = new System.Drawing.Point(838, 190);
            this.grbWStatusError.Name = "grbWStatusError";
            this.grbWStatusError.Size = new System.Drawing.Size(352, 284);
            this.grbWStatusError.TabIndex = 21;
            this.grbWStatusError.TabStop = false;
            this.grbWStatusError.Text = "Status Error";
            this.grbWStatusError.Enter += new System.EventHandler(this.grbWStatusError_Enter);
            // 
            // chkWOvertemperature
            // 
            this.chkWOvertemperature.AutoSize = true;
            this.chkWOvertemperature.Location = new System.Drawing.Point(23, 113);
            this.chkWOvertemperature.Name = "chkWOvertemperature";
            this.chkWOvertemperature.Size = new System.Drawing.Size(15, 14);
            this.chkWOvertemperature.TabIndex = 18;
            this.chkWOvertemperature.UseVisualStyleBackColor = true;
            this.chkWOvertemperature.CheckedChanged += new System.EventHandler(this.chkWOvertemperature_CheckedChanged);
            // 
            // chkWNonVolatile
            // 
            this.chkWNonVolatile.AutoSize = true;
            this.chkWNonVolatile.Location = new System.Drawing.Point(23, 91);
            this.chkWNonVolatile.Name = "chkWNonVolatile";
            this.chkWNonVolatile.Size = new System.Drawing.Size(15, 14);
            this.chkWNonVolatile.TabIndex = 18;
            this.chkWNonVolatile.UseVisualStyleBackColor = true;
            this.chkWNonVolatile.CheckedChanged += new System.EventHandler(this.chkWNonVolatile_CheckedChanged);
            // 
            // chkWVolatile
            // 
            this.chkWVolatile.AutoSize = true;
            this.chkWVolatile.Location = new System.Drawing.Point(23, 66);
            this.chkWVolatile.Name = "chkWVolatile";
            this.chkWVolatile.Size = new System.Drawing.Size(15, 14);
            this.chkWVolatile.TabIndex = 18;
            this.chkWVolatile.UseVisualStyleBackColor = true;
            this.chkWVolatile.CheckedChanged += new System.EventHandler(this.chkWVolatile_CheckedChanged);
            // 
            // chkWNoUser
            // 
            this.chkWNoUser.AutoSize = true;
            this.chkWNoUser.Location = new System.Drawing.Point(23, 237);
            this.chkWNoUser.Name = "chkWNoUser";
            this.chkWNoUser.Size = new System.Drawing.Size(15, 14);
            this.chkWNoUser.TabIndex = 18;
            this.chkWNoUser.UseVisualStyleBackColor = true;
            this.chkWNoUser.CheckedChanged += new System.EventHandler(this.chkWNoUser_CheckedChanged);
            // 
            // chkWInvaild
            // 
            this.chkWInvaild.AutoSize = true;
            this.chkWInvaild.Location = new System.Drawing.Point(23, 212);
            this.chkWInvaild.Name = "chkWInvaild";
            this.chkWInvaild.Size = new System.Drawing.Size(15, 14);
            this.chkWInvaild.TabIndex = 18;
            this.chkWInvaild.UseVisualStyleBackColor = true;
            this.chkWInvaild.CheckedChanged += new System.EventHandler(this.chkWInvaild_CheckedChanged);
            // 
            // chkWatchDot
            // 
            this.chkWatchDot.AutoSize = true;
            this.chkWatchDot.Location = new System.Drawing.Point(23, 186);
            this.chkWatchDot.Name = "chkWatchDot";
            this.chkWatchDot.Size = new System.Drawing.Size(15, 14);
            this.chkWatchDot.TabIndex = 18;
            this.chkWatchDot.UseVisualStyleBackColor = true;
            this.chkWatchDot.CheckedChanged += new System.EventHandler(this.chkWatchDot_CheckedChanged);
            // 
            // chkUnderTemp
            // 
            this.chkUnderTemp.AutoSize = true;
            this.chkUnderTemp.Location = new System.Drawing.Point(23, 162);
            this.chkUnderTemp.Name = "chkUnderTemp";
            this.chkUnderTemp.Size = new System.Drawing.Size(15, 14);
            this.chkUnderTemp.TabIndex = 18;
            this.chkUnderTemp.UseVisualStyleBackColor = true;
            this.chkUnderTemp.CheckedChanged += new System.EventHandler(this.chkUnderTemp_CheckedChanged);
            // 
            // chkLoadcelloverload
            // 
            this.chkLoadcelloverload.AutoSize = true;
            this.chkLoadcelloverload.Location = new System.Drawing.Point(23, 137);
            this.chkLoadcelloverload.Name = "chkLoadcelloverload";
            this.chkLoadcelloverload.Size = new System.Drawing.Size(15, 14);
            this.chkLoadcelloverload.TabIndex = 18;
            this.chkLoadcelloverload.UseVisualStyleBackColor = true;
            this.chkLoadcelloverload.CheckedChanged += new System.EventHandler(this.chkLoadcelloverload_CheckedChanged);
            // 
            // chkWEprom
            // 
            this.chkWEprom.AutoSize = true;
            this.chkWEprom.Location = new System.Drawing.Point(23, 42);
            this.chkWEprom.Name = "chkWEprom";
            this.chkWEprom.Size = new System.Drawing.Size(15, 14);
            this.chkWEprom.TabIndex = 18;
            this.chkWEprom.UseVisualStyleBackColor = true;
            this.chkWEprom.CheckedChanged += new System.EventHandler(this.chkWEprom_CheckedChanged);
            // 
            // lblWNouser
            // 
            this.lblWNouser.AutoSize = true;
            this.lblWNouser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWNouser.Location = new System.Drawing.Point(54, 230);
            this.lblWNouser.Name = "lblWNouser";
            this.lblWNouser.Size = new System.Drawing.Size(132, 23);
            this.lblWNouser.TabIndex = 17;
            this.lblWNouser.Text = "9 - No user data";
            this.lblWNouser.Click += new System.EventHandler(this.lblWNouser_Click);
            // 
            // lblWInvalid
            // 
            this.lblWInvalid.AutoSize = true;
            this.lblWInvalid.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWInvalid.Location = new System.Drawing.Point(54, 204);
            this.lblWInvalid.Name = "lblWInvalid";
            this.lblWInvalid.Size = new System.Drawing.Size(162, 23);
            this.lblWInvalid.TabIndex = 17;
            this.lblWInvalid.Text = "8 - Invalid user data";
            this.lblWInvalid.Click += new System.EventHandler(this.lblWInvalid_Click);
            // 
            // lblWWatch
            // 
            this.lblWWatch.AutoSize = true;
            this.lblWWatch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWWatch.Location = new System.Drawing.Point(54, 179);
            this.lblWWatch.Name = "lblWWatch";
            this.lblWWatch.Size = new System.Drawing.Size(184, 23);
            this.lblWWatch.TabIndex = 17;
            this.lblWWatch.Text = "7 - Watch dot time-out";
            this.lblWWatch.Click += new System.EventHandler(this.lblWWatch_Click);
            // 
            // lblWUnder
            // 
            this.lblWUnder.AutoSize = true;
            this.lblWUnder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWUnder.Location = new System.Drawing.Point(54, 155);
            this.lblWUnder.Name = "lblWUnder";
            this.lblWUnder.Size = new System.Drawing.Size(232, 23);
            this.lblWUnder.TabIndex = 17;
            this.lblWUnder.Text = "6 - Under temperature limits ";
            this.lblWUnder.Click += new System.EventHandler(this.lblWUnder_Click);
            // 
            // lblWLoad
            // 
            this.lblWLoad.AutoSize = true;
            this.lblWLoad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWLoad.Location = new System.Drawing.Point(54, 130);
            this.lblWLoad.Name = "lblWLoad";
            this.lblWLoad.Size = new System.Drawing.Size(168, 23);
            this.lblWLoad.TabIndex = 17;
            this.lblWLoad.Text = "5 - Loadcell overload";
            this.lblWLoad.Click += new System.EventHandler(this.lblWLoad_Click);
            // 
            // lblWOver
            // 
            this.lblWOver.AutoSize = true;
            this.lblWOver.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWOver.Location = new System.Drawing.Point(54, 107);
            this.lblWOver.Name = "lblWOver";
            this.lblWOver.Size = new System.Drawing.Size(218, 23);
            this.lblWOver.TabIndex = 17;
            this.lblWOver.Text = "4 - Over temperature limits";
            this.lblWOver.Click += new System.EventHandler(this.lblWOver_Click);
            // 
            // lblWNonVolatile
            // 
            this.lblWNonVolatile.AutoSize = true;
            this.lblWNonVolatile.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWNonVolatile.Location = new System.Drawing.Point(54, 84);
            this.lblWNonVolatile.Name = "lblWNonVolatile";
            this.lblWNonVolatile.Size = new System.Drawing.Size(260, 23);
            this.lblWNonVolatile.TabIndex = 17;
            this.lblWNonVolatile.Text = "3 - Non-volatile write ram failure";
            this.lblWNonVolatile.Click += new System.EventHandler(this.lblWNonVolatile_Click);
            // 
            // lblWVolatile
            // 
            this.lblWVolatile.AutoSize = true;
            this.lblWVolatile.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWVolatile.Location = new System.Drawing.Point(54, 59);
            this.lblWVolatile.Name = "lblWVolatile";
            this.lblWVolatile.Size = new System.Drawing.Size(223, 23);
            this.lblWVolatile.TabIndex = 17;
            this.lblWVolatile.Text = "2 - Volatile write ram failure";
            this.lblWVolatile.Click += new System.EventHandler(this.lblWVolatile_Click);
            // 
            // lblWEprom
            // 
            this.lblWEprom.AutoSize = true;
            this.lblWEprom.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWEprom.Location = new System.Drawing.Point(54, 35);
            this.lblWEprom.Name = "lblWEprom";
            this.lblWEprom.Size = new System.Drawing.Size(145, 23);
            this.lblWEprom.TabIndex = 17;
            this.lblWEprom.Text = "1 - EPROM failure";
            this.lblWEprom.Click += new System.EventHandler(this.lblWEprom_Click);
            // 
            // grbStatus
            // 
            this.grbStatus.BackColor = System.Drawing.Color.LightBlue;
            this.grbStatus.Controls.Add(this.chkWInput4);
            this.grbStatus.Controls.Add(this.chkWInput3);
            this.grbStatus.Controls.Add(this.chkWInput2);
            this.grbStatus.Controls.Add(this.chkWSet4);
            this.grbStatus.Controls.Add(this.chKWSet3);
            this.grbStatus.Controls.Add(this.chkWSet2);
            this.grbStatus.Controls.Add(this.chkWSet1);
            this.grbStatus.Controls.Add(this.chkWInput1);
            this.grbStatus.Controls.Add(this.lblWInput4);
            this.grbStatus.Controls.Add(this.lblWInput3);
            this.grbStatus.Controls.Add(this.lblWInput2);
            this.grbStatus.Controls.Add(this.lblWSet4);
            this.grbStatus.Controls.Add(this.lblWSet3);
            this.grbStatus.Controls.Add(this.lblWSet2);
            this.grbStatus.Controls.Add(this.lblWSetpoint);
            this.grbStatus.Controls.Add(this.lblWInput1);
            this.grbStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStatus.Location = new System.Drawing.Point(447, 323);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(330, 150);
            this.grbStatus.TabIndex = 20;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Status I/O";
            this.grbStatus.Enter += new System.EventHandler(this.grbStatus_Enter);
            // 
            // chkWInput4
            // 
            this.chkWInput4.AutoSize = true;
            this.chkWInput4.Location = new System.Drawing.Point(9, 102);
            this.chkWInput4.Name = "chkWInput4";
            this.chkWInput4.Size = new System.Drawing.Size(15, 14);
            this.chkWInput4.TabIndex = 18;
            this.chkWInput4.UseVisualStyleBackColor = true;
            this.chkWInput4.CheckedChanged += new System.EventHandler(this.chkWInput4_CheckedChanged);
            // 
            // chkWInput3
            // 
            this.chkWInput3.AutoSize = true;
            this.chkWInput3.Location = new System.Drawing.Point(9, 81);
            this.chkWInput3.Name = "chkWInput3";
            this.chkWInput3.Size = new System.Drawing.Size(15, 14);
            this.chkWInput3.TabIndex = 18;
            this.chkWInput3.UseVisualStyleBackColor = true;
            this.chkWInput3.CheckedChanged += new System.EventHandler(this.chkWInput3_CheckedChanged);
            // 
            // chkWInput2
            // 
            this.chkWInput2.AutoSize = true;
            this.chkWInput2.Location = new System.Drawing.Point(9, 58);
            this.chkWInput2.Name = "chkWInput2";
            this.chkWInput2.Size = new System.Drawing.Size(15, 14);
            this.chkWInput2.TabIndex = 18;
            this.chkWInput2.UseVisualStyleBackColor = true;
            this.chkWInput2.CheckedChanged += new System.EventHandler(this.chkWInput2_CheckedChanged);
            // 
            // chkWSet4
            // 
            this.chkWSet4.AutoSize = true;
            this.chkWSet4.Location = new System.Drawing.Point(104, 104);
            this.chkWSet4.Name = "chkWSet4";
            this.chkWSet4.Size = new System.Drawing.Size(15, 14);
            this.chkWSet4.TabIndex = 18;
            this.chkWSet4.UseVisualStyleBackColor = true;
            this.chkWSet4.CheckedChanged += new System.EventHandler(this.chkWSet4_CheckedChanged);
            // 
            // chKWSet3
            // 
            this.chKWSet3.AutoSize = true;
            this.chKWSet3.Location = new System.Drawing.Point(104, 81);
            this.chKWSet3.Name = "chKWSet3";
            this.chKWSet3.Size = new System.Drawing.Size(15, 14);
            this.chKWSet3.TabIndex = 18;
            this.chKWSet3.UseVisualStyleBackColor = true;
            this.chKWSet3.CheckedChanged += new System.EventHandler(this.chKWSet3_CheckedChanged);
            // 
            // chkWSet2
            // 
            this.chkWSet2.AutoSize = true;
            this.chkWSet2.Location = new System.Drawing.Point(104, 58);
            this.chkWSet2.Name = "chkWSet2";
            this.chkWSet2.Size = new System.Drawing.Size(15, 14);
            this.chkWSet2.TabIndex = 18;
            this.chkWSet2.UseVisualStyleBackColor = true;
            this.chkWSet2.CheckedChanged += new System.EventHandler(this.chkWSet2_CheckedChanged);
            // 
            // chkWSet1
            // 
            this.chkWSet1.AutoSize = true;
            this.chkWSet1.Location = new System.Drawing.Point(104, 37);
            this.chkWSet1.Name = "chkWSet1";
            this.chkWSet1.Size = new System.Drawing.Size(15, 14);
            this.chkWSet1.TabIndex = 18;
            this.chkWSet1.UseVisualStyleBackColor = true;
            this.chkWSet1.CheckedChanged += new System.EventHandler(this.chkWSet1_CheckedChanged);
            // 
            // chkWInput1
            // 
            this.chkWInput1.AutoSize = true;
            this.chkWInput1.Location = new System.Drawing.Point(9, 38);
            this.chkWInput1.Name = "chkWInput1";
            this.chkWInput1.Size = new System.Drawing.Size(15, 14);
            this.chkWInput1.TabIndex = 18;
            this.chkWInput1.UseVisualStyleBackColor = true;
            this.chkWInput1.CheckedChanged += new System.EventHandler(this.chkWInput1_CheckedChanged);
            // 
            // lblWInput4
            // 
            this.lblWInput4.AutoSize = true;
            this.lblWInput4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWInput4.Location = new System.Drawing.Point(30, 98);
            this.lblWInput4.Name = "lblWInput4";
            this.lblWInput4.Size = new System.Drawing.Size(58, 18);
            this.lblWInput4.TabIndex = 17;
            this.lblWInput4.Text = "Input #4";
            this.lblWInput4.Click += new System.EventHandler(this.lblWInput4_Click);
            // 
            // lblWInput3
            // 
            this.lblWInput3.AutoSize = true;
            this.lblWInput3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWInput3.Location = new System.Drawing.Point(30, 76);
            this.lblWInput3.Name = "lblWInput3";
            this.lblWInput3.Size = new System.Drawing.Size(58, 18);
            this.lblWInput3.TabIndex = 17;
            this.lblWInput3.Text = "Input #3";
            this.lblWInput3.Click += new System.EventHandler(this.lblWInput3_Click);
            // 
            // lblWInput2
            // 
            this.lblWInput2.AutoSize = true;
            this.lblWInput2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWInput2.Location = new System.Drawing.Point(30, 54);
            this.lblWInput2.Name = "lblWInput2";
            this.lblWInput2.Size = new System.Drawing.Size(58, 18);
            this.lblWInput2.TabIndex = 17;
            this.lblWInput2.Text = "Input #2";
            this.lblWInput2.Click += new System.EventHandler(this.lblWInput2_Click);
            // 
            // lblWSet4
            // 
            this.lblWSet4.AutoSize = true;
            this.lblWSet4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWSet4.Location = new System.Drawing.Point(125, 101);
            this.lblWSet4.Name = "lblWSet4";
            this.lblWSet4.Size = new System.Drawing.Size(81, 18);
            this.lblWSet4.TabIndex = 17;
            this.lblWSet4.Text = "Set Point #4";
            this.lblWSet4.Click += new System.EventHandler(this.lblWSet4_Click);
            // 
            // lblWSet3
            // 
            this.lblWSet3.AutoSize = true;
            this.lblWSet3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWSet3.Location = new System.Drawing.Point(125, 79);
            this.lblWSet3.Name = "lblWSet3";
            this.lblWSet3.Size = new System.Drawing.Size(81, 18);
            this.lblWSet3.TabIndex = 17;
            this.lblWSet3.Text = "Set Point #3";
            this.lblWSet3.Click += new System.EventHandler(this.lblWSet3_Click);
            // 
            // lblWSet2
            // 
            this.lblWSet2.AutoSize = true;
            this.lblWSet2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWSet2.Location = new System.Drawing.Point(125, 57);
            this.lblWSet2.Name = "lblWSet2";
            this.lblWSet2.Size = new System.Drawing.Size(81, 18);
            this.lblWSet2.TabIndex = 17;
            this.lblWSet2.Text = "Set Point #2";
            this.lblWSet2.Click += new System.EventHandler(this.lblWSet2_Click);
            // 
            // lblWSetpoint
            // 
            this.lblWSetpoint.AutoSize = true;
            this.lblWSetpoint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWSetpoint.Location = new System.Drawing.Point(125, 34);
            this.lblWSetpoint.Name = "lblWSetpoint";
            this.lblWSetpoint.Size = new System.Drawing.Size(78, 18);
            this.lblWSetpoint.TabIndex = 17;
            this.lblWSetpoint.Text = "Set Point#1";
            this.lblWSetpoint.Click += new System.EventHandler(this.lblWSetpoint_Click);
            // 
            // lblWInput1
            // 
            this.lblWInput1.AutoSize = true;
            this.lblWInput1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWInput1.Location = new System.Drawing.Point(30, 34);
            this.lblWInput1.Name = "lblWInput1";
            this.lblWInput1.Size = new System.Drawing.Size(58, 18);
            this.lblWInput1.TabIndex = 17;
            this.lblWInput1.Text = "Input #1";
            this.lblWInput1.Click += new System.EventHandler(this.lblWInput1_Click);
            // 
            // grbWPccommunication
            // 
            this.grbWPccommunication.BackColor = System.Drawing.Color.LightBlue;
            this.grbWPccommunication.Controls.Add(this.btnConnect);
            this.grbWPccommunication.Controls.Add(this.cboWStopBits);
            this.grbWPccommunication.Controls.Add(this.cboParity);
            this.grbWPccommunication.Controls.Add(this.cboBaud);
            this.grbWPccommunication.Controls.Add(this.cboWDataBits);
            this.grbWPccommunication.Controls.Add(this.cboPortNumber);
            this.grbWPccommunication.Controls.Add(this.lblWParity);
            this.grbWPccommunication.Controls.Add(this.lablWBaud);
            this.grbWPccommunication.Controls.Add(this.lblWDataBits);
            this.grbWPccommunication.Controls.Add(this.lblWStopBit);
            this.grbWPccommunication.Controls.Add(this.lblPortNumber);
            this.grbWPccommunication.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbWPccommunication.Location = new System.Drawing.Point(16, 323);
            this.grbWPccommunication.Name = "grbWPccommunication";
            this.grbWPccommunication.Size = new System.Drawing.Size(311, 150);
            this.grbWPccommunication.TabIndex = 19;
            this.grbWPccommunication.TabStop = false;
            this.grbWPccommunication.Text = "PC Communication Setting";
            this.grbWPccommunication.Enter += new System.EventHandler(this.grbWPccommunication_Enter);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Green;
            this.btnConnect.Location = new System.Drawing.Point(170, 95);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 30);
            this.btnConnect.TabIndex = 20;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboWStopBits
            // 
            this.cboWStopBits.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboWStopBits.FormattingEnabled = true;
            this.cboWStopBits.Location = new System.Drawing.Point(99, 98);
            this.cboWStopBits.Name = "cboWStopBits";
            this.cboWStopBits.Size = new System.Drawing.Size(56, 26);
            this.cboWStopBits.TabIndex = 19;
            this.cboWStopBits.SelectedIndexChanged += new System.EventHandler(this.cboWStopBits_SelectedIndexChanged);
            // 
            // cboParity
            // 
            this.cboParity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(13, 98);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(67, 26);
            this.cboParity.TabIndex = 19;
            this.cboParity.SelectedIndexChanged += new System.EventHandler(this.cboParity_SelectedIndexChanged);
            // 
            // cboBaud
            // 
            this.cboBaud.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Location = new System.Drawing.Point(170, 48);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(50, 26);
            this.cboBaud.TabIndex = 19;
            this.cboBaud.SelectedIndexChanged += new System.EventHandler(this.cboBaud_SelectedIndexChanged);
            // 
            // cboWDataBits
            // 
            this.cboWDataBits.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboWDataBits.FormattingEnabled = true;
            this.cboWDataBits.Location = new System.Drawing.Point(99, 48);
            this.cboWDataBits.Name = "cboWDataBits";
            this.cboWDataBits.Size = new System.Drawing.Size(56, 26);
            this.cboWDataBits.TabIndex = 19;
            this.cboWDataBits.SelectedIndexChanged += new System.EventHandler(this.cboWDataBits_SelectedIndexChanged);
            // 
            // cboPortNumber
            // 
            this.cboPortNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboPortNumber.FormattingEnabled = true;
            this.cboPortNumber.Location = new System.Drawing.Point(13, 49);
            this.cboPortNumber.Name = "cboPortNumber";
            this.cboPortNumber.Size = new System.Drawing.Size(67, 26);
            this.cboPortNumber.TabIndex = 19;
            this.cboPortNumber.SelectedIndexChanged += new System.EventHandler(this.cboPortNumber_SelectedIndexChanged);
            // 
            // lblWParity
            // 
            this.lblWParity.AutoSize = true;
            this.lblWParity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWParity.Location = new System.Drawing.Point(11, 79);
            this.lblWParity.Name = "lblWParity";
            this.lblWParity.Size = new System.Drawing.Size(39, 15);
            this.lblWParity.TabIndex = 18;
            this.lblWParity.Text = "Parity";
            this.lblWParity.Click += new System.EventHandler(this.lblWParity_Click);
            // 
            // lablWBaud
            // 
            this.lablWBaud.AutoSize = true;
            this.lablWBaud.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablWBaud.Location = new System.Drawing.Point(167, 29);
            this.lablWBaud.Name = "lablWBaud";
            this.lablWBaud.Size = new System.Drawing.Size(70, 18);
            this.lablWBaud.TabIndex = 18;
            this.lablWBaud.Text = "Baud Rate";
            this.lablWBaud.Click += new System.EventHandler(this.lablWBaud_Click);
            // 
            // lblWDataBits
            // 
            this.lblWDataBits.AutoSize = true;
            this.lblWDataBits.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWDataBits.Location = new System.Drawing.Point(100, 29);
            this.lblWDataBits.Name = "lblWDataBits";
            this.lblWDataBits.Size = new System.Drawing.Size(62, 18);
            this.lblWDataBits.TabIndex = 18;
            this.lblWDataBits.Text = "Data Bits";
            this.lblWDataBits.Click += new System.EventHandler(this.lblWDataBits_Click);
            // 
            // lblWStopBit
            // 
            this.lblWStopBit.AutoSize = true;
            this.lblWStopBit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWStopBit.Location = new System.Drawing.Point(99, 78);
            this.lblWStopBit.Name = "lblWStopBit";
            this.lblWStopBit.Size = new System.Drawing.Size(55, 15);
            this.lblWStopBit.TabIndex = 17;
            this.lblWStopBit.Text = "Stop Bits";
            this.lblWStopBit.Click += new System.EventHandler(this.lblWStopBit_Click);
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.AutoSize = true;
            this.lblPortNumber.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortNumber.Location = new System.Drawing.Point(10, 28);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(88, 18);
            this.lblPortNumber.TabIndex = 17;
            this.lblPortNumber.Text = "Port Number";
            this.lblPortNumber.Click += new System.EventHandler(this.lblPortNumber_Click);
            // 
            // lblWActive
            // 
            this.lblWActive.AutoSize = true;
            this.lblWActive.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWActive.Location = new System.Drawing.Point(910, 63);
            this.lblWActive.Name = "lblWActive";
            this.lblWActive.Size = new System.Drawing.Size(55, 18);
            this.lblWActive.TabIndex = 18;
            this.lblWActive.Text = "- Active";
            this.lblWActive.Click += new System.EventHandler(this.lblWActive_Click);
            // 
            // lblWNotActive
            // 
            this.lblWNotActive.AutoSize = true;
            this.lblWNotActive.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWNotActive.Location = new System.Drawing.Point(910, 35);
            this.lblWNotActive.Name = "lblWNotActive";
            this.lblWNotActive.Size = new System.Drawing.Size(81, 18);
            this.lblWNotActive.TabIndex = 18;
            this.lblWNotActive.Text = "- Not Active";
            this.lblWNotActive.Click += new System.EventHandler(this.lblWNotActive_Click);
            // 
            // grbWWeighingandOperation
            // 
            this.grbWWeighingandOperation.BackColor = System.Drawing.Color.LightBlue;
            this.grbWWeighingandOperation.Controls.Add(this.grbWWeight);
            this.grbWWeighingandOperation.Controls.Add(this.btnWResetDevice);
            this.grbWWeighingandOperation.Controls.Add(this.lblWZeroTracking);
            this.grbWWeighingandOperation.Controls.Add(this.lblWMotion);
            this.grbWWeighingandOperation.Controls.Add(this.lblWNet);
            this.grbWWeighingandOperation.Controls.Add(this.lblWGross);
            this.grbWWeighingandOperation.Controls.Add(this.lblWReady);
            this.grbWWeighingandOperation.Controls.Add(this.chkWzeroTracking);
            this.grbWWeighingandOperation.Controls.Add(this.chkWMotion);
            this.grbWWeighingandOperation.Controls.Add(this.chkWNet);
            this.grbWWeighingandOperation.Controls.Add(this.chkWGross);
            this.grbWWeighingandOperation.Controls.Add(this.chKWReady);
            this.grbWWeighingandOperation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbWWeighingandOperation.Location = new System.Drawing.Point(16, 29);
            this.grbWWeighingandOperation.Name = "grbWWeighingandOperation";
            this.grbWWeighingandOperation.Size = new System.Drawing.Size(761, 281);
            this.grbWWeighingandOperation.TabIndex = 16;
            this.grbWWeighingandOperation.TabStop = false;
            this.grbWWeighingandOperation.Text = "Weighing and Operation";
            this.grbWWeighingandOperation.Enter += new System.EventHandler(this.grbWWeighingandOperation_Enter);
            // 
            // grbWWeight
            // 
            this.grbWWeight.BackColor = System.Drawing.Color.AliceBlue;
            this.grbWWeight.Controls.Add(this.grbWAdditional);
            this.grbWWeight.Controls.Add(this.btnWTare);
            this.grbWWeight.Controls.Add(this.btnWZero);
            this.grbWWeight.Controls.Add(this.txtWWeight);
            this.grbWWeight.Controls.Add(this.lblWKg);
            this.grbWWeight.Location = new System.Drawing.Point(18, 21);
            this.grbWWeight.Name = "grbWWeight";
            this.grbWWeight.Size = new System.Drawing.Size(368, 237);
            this.grbWWeight.TabIndex = 17;
            this.grbWWeight.TabStop = false;
            this.grbWWeight.Text = "Weight";
            this.grbWWeight.Enter += new System.EventHandler(this.grbWWeight_Enter);
            // 
            // grbWAdditional
            // 
            this.grbWAdditional.BackColor = System.Drawing.Color.LightBlue;
            this.grbWAdditional.Controls.Add(this.txtWGrab);
            this.grbWAdditional.Controls.Add(this.txtWmV);
            this.grbWAdditional.Controls.Add(this.txtWPeak);
            this.grbWAdditional.Controls.Add(this.label4);
            this.grbWAdditional.Controls.Add(this.lblWGrab);
            this.grbWAdditional.Controls.Add(this.label2);
            this.grbWAdditional.Controls.Add(this.btnWResetPeak);
            this.grbWAdditional.Location = new System.Drawing.Point(10, 100);
            this.grbWAdditional.Name = "grbWAdditional";
            this.grbWAdditional.Size = new System.Drawing.Size(283, 124);
            this.grbWAdditional.TabIndex = 18;
            this.grbWAdditional.TabStop = false;
            this.grbWAdditional.Text = "Additional";
            this.grbWAdditional.Enter += new System.EventHandler(this.grbWAdditional_Enter);
            // 
            // txtWGrab
            // 
            this.txtWGrab.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWGrab.Location = new System.Drawing.Point(127, 92);
            this.txtWGrab.Multiline = true;
            this.txtWGrab.Name = "txtWGrab";
            this.txtWGrab.Size = new System.Drawing.Size(82, 26);
            this.txtWGrab.TabIndex = 18;
            this.txtWGrab.TextChanged += new System.EventHandler(this.txtWGrab_TextChanged);
            // 
            // txtWmV
            // 
            this.txtWmV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWmV.Location = new System.Drawing.Point(127, 39);
            this.txtWmV.Multiline = true;
            this.txtWmV.Name = "txtWmV";
            this.txtWmV.Size = new System.Drawing.Size(82, 26);
            this.txtWmV.TabIndex = 18;
            this.txtWmV.TextChanged += new System.EventHandler(this.txtWmV_TextChanged);
            // 
            // txtWPeak
            // 
            this.txtWPeak.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWPeak.Location = new System.Drawing.Point(12, 42);
            this.txtWPeak.Multiline = true;
            this.txtWPeak.Name = "txtWPeak";
            this.txtWPeak.Size = new System.Drawing.Size(82, 26);
            this.txtWPeak.TabIndex = 18;
            this.txtWPeak.TextChanged += new System.EventHandler(this.txtWPeak_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "mV/V";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblWGrab
            // 
            this.lblWGrab.AutoSize = true;
            this.lblWGrab.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWGrab.Location = new System.Drawing.Point(124, 71);
            this.lblWGrab.Name = "lblWGrab";
            this.lblWGrab.Size = new System.Drawing.Size(33, 15);
            this.lblWGrab.TabIndex = 17;
            this.lblWGrab.Text = "Grab";
            this.lblWGrab.Click += new System.EventHandler(this.lblWGrab_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Peak";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnWResetPeak
            // 
            this.btnWResetPeak.BackColor = System.Drawing.Color.SteelBlue;
            this.btnWResetPeak.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWResetPeak.Location = new System.Drawing.Point(13, 89);
            this.btnWResetPeak.Name = "btnWResetPeak";
            this.btnWResetPeak.Size = new System.Drawing.Size(94, 34);
            this.btnWResetPeak.TabIndex = 15;
            this.btnWResetPeak.Text = "Reset Peak";
            this.btnWResetPeak.UseVisualStyleBackColor = false;
            this.btnWResetPeak.Click += new System.EventHandler(this.btnWResetPeak_Click);
            // 
            // btnWTare
            // 
            this.btnWTare.BackColor = System.Drawing.Color.SteelBlue;
            this.btnWTare.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWTare.Location = new System.Drawing.Point(93, 53);
            this.btnWTare.Name = "btnWTare";
            this.btnWTare.Size = new System.Drawing.Size(71, 31);
            this.btnWTare.TabIndex = 16;
            this.btnWTare.Text = "Tare";
            this.btnWTare.UseVisualStyleBackColor = false;
            this.btnWTare.Click += new System.EventHandler(this.btnWTare_Click);
            // 
            // btnWZero
            // 
            this.btnWZero.BackColor = System.Drawing.Color.SteelBlue;
            this.btnWZero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWZero.Location = new System.Drawing.Point(10, 53);
            this.btnWZero.Name = "btnWZero";
            this.btnWZero.Size = new System.Drawing.Size(63, 31);
            this.btnWZero.TabIndex = 15;
            this.btnWZero.Text = "Zero";
            this.btnWZero.UseVisualStyleBackColor = false;
            this.btnWZero.Click += new System.EventHandler(this.btnWZero_Click);
            // 
            // txtWWeight
            // 
            this.txtWWeight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWWeight.Location = new System.Drawing.Point(12, 21);
            this.txtWWeight.Multiline = true;
            this.txtWWeight.Name = "txtWWeight";
            this.txtWWeight.Size = new System.Drawing.Size(152, 26);
            this.txtWWeight.TabIndex = 8;
            this.txtWWeight.TextChanged += new System.EventHandler(this.txtWWeight_TextChanged);
            // 
            // lblWKg
            // 
            this.lblWKg.AutoSize = true;
            this.lblWKg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWKg.ForeColor = System.Drawing.Color.Brown;
            this.lblWKg.Location = new System.Drawing.Point(170, 23);
            this.lblWKg.Name = "lblWKg";
            this.lblWKg.Size = new System.Drawing.Size(26, 19);
            this.lblWKg.TabIndex = 0;
            this.lblWKg.Text = "Kg";
            this.lblWKg.Click += new System.EventHandler(this.lblWKg_Click);
            // 
            // btnWResetDevice
            // 
            this.btnWResetDevice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnWResetDevice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWResetDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnWResetDevice.Image")));
            this.btnWResetDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWResetDevice.Location = new System.Drawing.Point(442, 187);
            this.btnWResetDevice.Name = "btnWResetDevice";
            this.btnWResetDevice.Size = new System.Drawing.Size(116, 45);
            this.btnWResetDevice.TabIndex = 15;
            this.btnWResetDevice.Text = "Reset Device";
            this.btnWResetDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWResetDevice.UseVisualStyleBackColor = false;
            this.btnWResetDevice.Click += new System.EventHandler(this.btnWResetDevice_Click);
            // 
            // lblWZeroTracking
            // 
            this.lblWZeroTracking.AutoSize = true;
            this.lblWZeroTracking.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWZeroTracking.Location = new System.Drawing.Point(466, 127);
            this.lblWZeroTracking.Name = "lblWZeroTracking";
            this.lblWZeroTracking.Size = new System.Drawing.Size(89, 18);
            this.lblWZeroTracking.TabIndex = 17;
            this.lblWZeroTracking.Text = "Zero Tracking";
            this.lblWZeroTracking.Click += new System.EventHandler(this.lblWZeroTracking_Click);
            // 
            // lblWMotion
            // 
            this.lblWMotion.AutoSize = true;
            this.lblWMotion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWMotion.Location = new System.Drawing.Point(466, 104);
            this.lblWMotion.Name = "lblWMotion";
            this.lblWMotion.Size = new System.Drawing.Size(54, 18);
            this.lblWMotion.TabIndex = 17;
            this.lblWMotion.Text = "Motion";
            this.lblWMotion.Click += new System.EventHandler(this.lblWMotion_Click);
            // 
            // lblWNet
            // 
            this.lblWNet.AutoSize = true;
            this.lblWNet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWNet.Location = new System.Drawing.Point(466, 82);
            this.lblWNet.Name = "lblWNet";
            this.lblWNet.Size = new System.Drawing.Size(31, 18);
            this.lblWNet.TabIndex = 17;
            this.lblWNet.Text = "Net";
            this.lblWNet.Click += new System.EventHandler(this.lblWNet_Click);
            // 
            // lblWGross
            // 
            this.lblWGross.AutoSize = true;
            this.lblWGross.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWGross.Location = new System.Drawing.Point(466, 58);
            this.lblWGross.Name = "lblWGross";
            this.lblWGross.Size = new System.Drawing.Size(43, 18);
            this.lblWGross.TabIndex = 17;
            this.lblWGross.Text = "Gross";
            this.lblWGross.Click += new System.EventHandler(this.lblWGross_Click);
            // 
            // lblWReady
            // 
            this.lblWReady.AutoSize = true;
            this.lblWReady.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWReady.Location = new System.Drawing.Point(466, 35);
            this.lblWReady.Name = "lblWReady";
            this.lblWReady.Size = new System.Drawing.Size(46, 18);
            this.lblWReady.TabIndex = 17;
            this.lblWReady.Text = "Ready";
            this.lblWReady.Click += new System.EventHandler(this.lblWReady_Click);
            // 
            // chkWzeroTracking
            // 
            this.chkWzeroTracking.AutoSize = true;
            this.chkWzeroTracking.Location = new System.Drawing.Point(445, 128);
            this.chkWzeroTracking.Name = "chkWzeroTracking";
            this.chkWzeroTracking.Size = new System.Drawing.Size(15, 14);
            this.chkWzeroTracking.TabIndex = 18;
            this.chkWzeroTracking.UseVisualStyleBackColor = true;
            this.chkWzeroTracking.CheckedChanged += new System.EventHandler(this.chkWzeroTracking_CheckedChanged);
            // 
            // chkWMotion
            // 
            this.chkWMotion.AutoSize = true;
            this.chkWMotion.Location = new System.Drawing.Point(445, 105);
            this.chkWMotion.Name = "chkWMotion";
            this.chkWMotion.Size = new System.Drawing.Size(15, 14);
            this.chkWMotion.TabIndex = 18;
            this.chkWMotion.UseVisualStyleBackColor = true;
            this.chkWMotion.CheckedChanged += new System.EventHandler(this.chkWMotion_CheckedChanged);
            // 
            // chkWNet
            // 
            this.chkWNet.AutoSize = true;
            this.chkWNet.Location = new System.Drawing.Point(445, 82);
            this.chkWNet.Name = "chkWNet";
            this.chkWNet.Size = new System.Drawing.Size(15, 14);
            this.chkWNet.TabIndex = 18;
            this.chkWNet.UseVisualStyleBackColor = true;
            this.chkWNet.CheckedChanged += new System.EventHandler(this.chkWNet_CheckedChanged);
            // 
            // chkWGross
            // 
            this.chkWGross.AutoSize = true;
            this.chkWGross.Location = new System.Drawing.Point(445, 58);
            this.chkWGross.Name = "chkWGross";
            this.chkWGross.Size = new System.Drawing.Size(15, 14);
            this.chkWGross.TabIndex = 18;
            this.chkWGross.UseVisualStyleBackColor = true;
            this.chkWGross.CheckedChanged += new System.EventHandler(this.chkWGross_CheckedChanged);
            // 
            // chKWReady
            // 
            this.chKWReady.AutoSize = true;
            this.chKWReady.BackColor = System.Drawing.Color.Gainsboro;
            this.chKWReady.Location = new System.Drawing.Point(445, 35);
            this.chKWReady.Name = "chKWReady";
            this.chKWReady.Size = new System.Drawing.Size(15, 14);
            this.chKWReady.TabIndex = 18;
            this.chKWReady.UseVisualStyleBackColor = false;
            this.chKWReady.CheckedChanged += new System.EventHandler(this.chKWReady_CheckedChanged);
            // 
            // chkWActive2
            // 
            this.chkWActive2.AutoSize = true;
            this.chkWActive2.Location = new System.Drawing.Point(885, 68);
            this.chkWActive2.Name = "chkWActive2";
            this.chkWActive2.Size = new System.Drawing.Size(15, 14);
            this.chkWActive2.TabIndex = 18;
            this.chkWActive2.UseVisualStyleBackColor = true;
            this.chkWActive2.CheckedChanged += new System.EventHandler(this.chkWActive2_CheckedChanged);
            // 
            // chkWActive
            // 
            this.chkWActive.AutoSize = true;
            this.chkWActive.Location = new System.Drawing.Point(864, 68);
            this.chkWActive.Name = "chkWActive";
            this.chkWActive.Size = new System.Drawing.Size(15, 14);
            this.chkWActive.TabIndex = 18;
            this.chkWActive.UseVisualStyleBackColor = true;
            this.chkWActive.CheckedChanged += new System.EventHandler(this.chkWActive_CheckedChanged);
            // 
            // chkWNotActive2
            // 
            this.chkWNotActive2.AutoSize = true;
            this.chkWNotActive2.Location = new System.Drawing.Point(885, 38);
            this.chkWNotActive2.Name = "chkWNotActive2";
            this.chkWNotActive2.Size = new System.Drawing.Size(15, 14);
            this.chkWNotActive2.TabIndex = 18;
            this.chkWNotActive2.UseVisualStyleBackColor = true;
            this.chkWNotActive2.CheckedChanged += new System.EventHandler(this.chkWNotActive2_CheckedChanged);
            // 
            // chkWNotActive
            // 
            this.chkWNotActive.AutoSize = true;
            this.chkWNotActive.Location = new System.Drawing.Point(864, 38);
            this.chkWNotActive.Name = "chkWNotActive";
            this.chkWNotActive.Size = new System.Drawing.Size(15, 14);
            this.chkWNotActive.TabIndex = 18;
            this.chkWNotActive.UseVisualStyleBackColor = true;
            this.chkWNotActive.CheckedChanged += new System.EventHandler(this.chkWNotActive_CheckedChanged);
            // 
            // pgLoadcell
            // 
            this.pgLoadcell.BackColor = System.Drawing.Color.AliceBlue;
            this.pgLoadcell.Controls.Add(this.grpLNotes);
            this.pgLoadcell.Controls.Add(this.btnLsavetodevice);
            this.pgLoadcell.Controls.Add(this.btnLsavetofile);
            this.pgLoadcell.Controls.Add(this.btnLuploadfromfile);
            this.pgLoadcell.Controls.Add(this.btnLdownloadtodevie);
            this.pgLoadcell.Controls.Add(this.btnLupload);
            this.pgLoadcell.Controls.Add(this.lblweightkg);
            this.pgLoadcell.Controls.Add(this.lblkg);
            this.pgLoadcell.Controls.Add(this.txtWeightkg);
            this.pgLoadcell.Controls.Add(this.tbWeightfilter);
            this.pgLoadcell.Location = new System.Drawing.Point(4, 27);
            this.pgLoadcell.Name = "pgLoadcell";
            this.pgLoadcell.Padding = new System.Windows.Forms.Padding(3);
            this.pgLoadcell.Size = new System.Drawing.Size(1288, 479);
            this.pgLoadcell.TabIndex = 1;
            this.pgLoadcell.Text = "LoadCell Setup";
            this.pgLoadcell.Click += new System.EventHandler(this.pgLoadcell_Click);
            // 
            // grpLNotes
            // 
            this.grpLNotes.BackColor = System.Drawing.Color.LightBlue;
            this.grpLNotes.Controls.Add(this.lblLNotes);
            this.grpLNotes.Location = new System.Drawing.Point(941, 38);
            this.grpLNotes.Name = "grpLNotes";
            this.grpLNotes.Size = new System.Drawing.Size(213, 195);
            this.grpLNotes.TabIndex = 21;
            this.grpLNotes.TabStop = false;
            this.grpLNotes.Text = "Notes";
            this.grpLNotes.Enter += new System.EventHandler(this.grpLNotes_Enter);
            // 
            // lblLNotes
            // 
            this.lblLNotes.AutoSize = true;
            this.lblLNotes.BackColor = System.Drawing.Color.CadetBlue;
            this.lblLNotes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNotes.Location = new System.Drawing.Point(6, 22);
            this.lblLNotes.Name = "lblLNotes";
            this.lblLNotes.Size = new System.Drawing.Size(135, 165);
            this.lblLNotes.TabIndex = 22;
            this.lblLNotes.Text = resources.GetString("lblLNotes.Text");
            this.lblLNotes.Click += new System.EventHandler(this.lblLNotes_Click);
            // 
            // btnLsavetodevice
            // 
            this.btnLsavetodevice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLsavetodevice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLsavetodevice.Location = new System.Drawing.Point(941, 428);
            this.btnLsavetodevice.Name = "btnLsavetodevice";
            this.btnLsavetodevice.Size = new System.Drawing.Size(144, 36);
            this.btnLsavetodevice.TabIndex = 20;
            this.btnLsavetodevice.Text = "Save To Device";
            this.btnLsavetodevice.UseVisualStyleBackColor = false;
            this.btnLsavetodevice.Click += new System.EventHandler(this.btnLsavetodevice_Click);
            // 
            // btnLsavetofile
            // 
            this.btnLsavetofile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLsavetofile.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLsavetofile.Location = new System.Drawing.Point(941, 382);
            this.btnLsavetofile.Name = "btnLsavetofile";
            this.btnLsavetofile.Size = new System.Drawing.Size(144, 34);
            this.btnLsavetofile.TabIndex = 19;
            this.btnLsavetofile.Text = "Save To a File";
            this.btnLsavetofile.UseVisualStyleBackColor = false;
            this.btnLsavetofile.Click += new System.EventHandler(this.btnLsavetofile_Click);
            // 
            // btnLuploadfromfile
            // 
            this.btnLuploadfromfile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuploadfromfile.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuploadfromfile.Location = new System.Drawing.Point(941, 334);
            this.btnLuploadfromfile.Name = "btnLuploadfromfile";
            this.btnLuploadfromfile.Size = new System.Drawing.Size(144, 42);
            this.btnLuploadfromfile.TabIndex = 18;
            this.btnLuploadfromfile.Text = "Upload From a File";
            this.btnLuploadfromfile.UseVisualStyleBackColor = false;
            this.btnLuploadfromfile.Click += new System.EventHandler(this.btnLuploadfromfile_Click);
            // 
            // btnLdownloadtodevie
            // 
            this.btnLdownloadtodevie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLdownloadtodevie.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLdownloadtodevie.Location = new System.Drawing.Point(941, 291);
            this.btnLdownloadtodevie.Name = "btnLdownloadtodevie";
            this.btnLdownloadtodevie.Size = new System.Drawing.Size(144, 37);
            this.btnLdownloadtodevie.TabIndex = 17;
            this.btnLdownloadtodevie.Text = "Download To Device";
            this.btnLdownloadtodevie.UseVisualStyleBackColor = false;
            this.btnLdownloadtodevie.Click += new System.EventHandler(this.btnLdownloadtodevie_Click);
            // 
            // btnLupload
            // 
            this.btnLupload.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLupload.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLupload.Location = new System.Drawing.Point(941, 239);
            this.btnLupload.Name = "btnLupload";
            this.btnLupload.Size = new System.Drawing.Size(144, 38);
            this.btnLupload.TabIndex = 16;
            this.btnLupload.Text = "Upload From device";
            this.btnLupload.UseVisualStyleBackColor = false;
            this.btnLupload.Click += new System.EventHandler(this.btnLupload_Click);
            // 
            // lblweightkg
            // 
            this.lblweightkg.AutoSize = true;
            this.lblweightkg.BackColor = System.Drawing.Color.AliceBlue;
            this.lblweightkg.Location = new System.Drawing.Point(242, 8);
            this.lblweightkg.Name = "lblweightkg";
            this.lblweightkg.Size = new System.Drawing.Size(53, 18);
            this.lblweightkg.TabIndex = 15;
            this.lblweightkg.Text = "Weight";
            this.lblweightkg.Click += new System.EventHandler(this.lblweightkg_Click);
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Location = new System.Drawing.Point(379, 7);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(22, 18);
            this.lblkg.TabIndex = 3;
            this.lblkg.Text = "kg";
            this.lblkg.Click += new System.EventHandler(this.lblkg_Click);
            // 
            // txtWeightkg
            // 
            this.txtWeightkg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWeightkg.Location = new System.Drawing.Point(295, 5);
            this.txtWeightkg.Name = "txtWeightkg";
            this.txtWeightkg.Size = new System.Drawing.Size(84, 26);
            this.txtWeightkg.TabIndex = 2;
            this.txtWeightkg.TextChanged += new System.EventHandler(this.txtWeightkg_TextChanged);
            // 
            // tbWeightfilter
            // 
            this.tbWeightfilter.Controls.Add(this.tbWeightformat);
            this.tbWeightfilter.Controls.Add(this.tbFilters);
            this.tbWeightfilter.Controls.Add(this.tabPage1);
            this.tbWeightfilter.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbWeightfilter.Location = new System.Drawing.Point(24, 39);
            this.tbWeightfilter.Name = "tbWeightfilter";
            this.tbWeightfilter.SelectedIndex = 0;
            this.tbWeightfilter.Size = new System.Drawing.Size(849, 420);
            this.tbWeightfilter.TabIndex = 0;
            this.tbWeightfilter.SelectedIndexChanged += new System.EventHandler(this.tbWeightfilter_SelectedIndexChanged);
            // 
            // tbWeightformat
            // 
            this.tbWeightformat.BackColor = System.Drawing.Color.LightBlue;
            this.tbWeightformat.Controls.Add(this.textBox6);
            this.tbWeightformat.Controls.Add(this.lblFloating);
            this.tbWeightformat.Controls.Add(this.txtMotiondetectperiod);
            this.tbWeightformat.Controls.Add(this.txtMotiondetectband);
            this.tbWeightformat.Controls.Add(this.cboMotionDetect);
            this.tbWeightformat.Controls.Add(this.lblMotiondetectperiod);
            this.tbWeightformat.Controls.Add(this.lblMotiondetectband);
            this.tbWeightformat.Controls.Add(this.lblMotionDetect);
            this.tbWeightformat.Controls.Add(this.lblMotion);
            this.tbWeightformat.Controls.Add(this.label1);
            this.tbWeightformat.Controls.Add(this.textBox1);
            this.tbWeightformat.Controls.Add(this.cboWeightunit);
            this.tbWeightformat.Controls.Add(this.lblWeightres);
            this.tbWeightformat.Controls.Add(this.lblWeightuni);
            this.tbWeightformat.Controls.Add(this.lblWeightformat);
            this.tbWeightformat.Controls.Add(this.grpTare);
            this.tbWeightformat.Controls.Add(this.grpMeasure);
            this.tbWeightformat.Controls.Add(this.btnDownload);
            this.tbWeightformat.Controls.Add(this.txtFixedtare);
            this.tbWeightformat.Controls.Add(this.lblFixedtare);
            this.tbWeightformat.Controls.Add(this.lblTare);
            this.tbWeightformat.Controls.Add(this.cboZtrack);
            this.tbWeightformat.Controls.Add(this.txtZtrackperiod);
            this.tbWeightformat.Controls.Add(this.txtZtrackband);
            this.tbWeightformat.Controls.Add(this.txtPOZB);
            this.tbWeightformat.Controls.Add(this.cboPOZ);
            this.tbWeightformat.Controls.Add(this.lblZtrackperiod);
            this.tbWeightformat.Controls.Add(this.lblZtrackband);
            this.tbWeightformat.Controls.Add(this.lblZtrack);
            this.tbWeightformat.Controls.Add(this.lblPOZB);
            this.tbWeightformat.Controls.Add(this.lblPOZ);
            this.tbWeightformat.Controls.Add(this.lblZero);
            this.tbWeightformat.Location = new System.Drawing.Point(4, 27);
            this.tbWeightformat.Name = "tbWeightformat";
            this.tbWeightformat.Padding = new System.Windows.Forms.Padding(3);
            this.tbWeightformat.Size = new System.Drawing.Size(841, 389);
            this.tbWeightformat.TabIndex = 0;
            this.tbWeightformat.Text = "Weight Format/Zero/Tare/Motion ";
            this.tbWeightformat.Click += new System.EventHandler(this.tbWeightformat_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox6.Location = new System.Drawing.Point(627, 115);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(90, 20);
            this.textBox6.TabIndex = 31;
            // 
            // lblFloating
            // 
            this.lblFloating.AutoSize = true;
            this.lblFloating.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloating.Location = new System.Drawing.Point(448, 115);
            this.lblFloating.Name = "lblFloating";
            this.lblFloating.Size = new System.Drawing.Size(94, 18);
            this.lblFloating.TabIndex = 30;
            this.lblFloating.Text = "Floating Point";
            // 
            // txtMotiondetectperiod
            // 
            this.txtMotiondetectperiod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMotiondetectperiod.Location = new System.Drawing.Point(628, 235);
            this.txtMotiondetectperiod.Multiline = true;
            this.txtMotiondetectperiod.Name = "txtMotiondetectperiod";
            this.txtMotiondetectperiod.Size = new System.Drawing.Size(90, 20);
            this.txtMotiondetectperiod.TabIndex = 29;
            this.txtMotiondetectperiod.TextChanged += new System.EventHandler(this.txtMotiondetectperiod_TextChanged);
            // 
            // txtMotiondetectband
            // 
            this.txtMotiondetectband.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMotiondetectband.Location = new System.Drawing.Point(628, 204);
            this.txtMotiondetectband.Multiline = true;
            this.txtMotiondetectband.Name = "txtMotiondetectband";
            this.txtMotiondetectband.Size = new System.Drawing.Size(90, 20);
            this.txtMotiondetectband.TabIndex = 28;
            this.txtMotiondetectband.TextChanged += new System.EventHandler(this.txtMotiondetectband_TextChanged);
            // 
            // cboMotionDetect
            // 
            this.cboMotionDetect.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboMotionDetect.FormattingEnabled = true;
            this.cboMotionDetect.Location = new System.Drawing.Point(627, 163);
            this.cboMotionDetect.Name = "cboMotionDetect";
            this.cboMotionDetect.Size = new System.Drawing.Size(90, 26);
            this.cboMotionDetect.TabIndex = 27;
            this.cboMotionDetect.SelectedIndexChanged += new System.EventHandler(this.cboMotionDetect_SelectedIndexChanged);
            // 
            // lblMotiondetectperiod
            // 
            this.lblMotiondetectperiod.AutoSize = true;
            this.lblMotiondetectperiod.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotiondetectperiod.Location = new System.Drawing.Point(448, 237);
            this.lblMotiondetectperiod.Name = "lblMotiondetectperiod";
            this.lblMotiondetectperiod.Size = new System.Drawing.Size(142, 18);
            this.lblMotiondetectperiod.TabIndex = 26;
            this.lblMotiondetectperiod.Text = "Motion Detect Period";
            this.lblMotiondetectperiod.Click += new System.EventHandler(this.lblMotiondetectperiod_Click);
            // 
            // lblMotiondetectband
            // 
            this.lblMotiondetectband.AutoSize = true;
            this.lblMotiondetectband.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotiondetectband.Location = new System.Drawing.Point(447, 207);
            this.lblMotiondetectband.Name = "lblMotiondetectband";
            this.lblMotiondetectband.Size = new System.Drawing.Size(152, 18);
            this.lblMotiondetectband.TabIndex = 25;
            this.lblMotiondetectband.Text = "Motion Detection Band";
            this.lblMotiondetectband.Click += new System.EventHandler(this.lblMotiondetectband_Click);
            // 
            // lblMotionDetect
            // 
            this.lblMotionDetect.AutoSize = true;
            this.lblMotionDetect.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotionDetect.Location = new System.Drawing.Point(448, 178);
            this.lblMotionDetect.Name = "lblMotionDetect";
            this.lblMotionDetect.Size = new System.Drawing.Size(118, 18);
            this.lblMotionDetect.TabIndex = 24;
            this.lblMotionDetect.Text = "Motion Detection";
            this.lblMotionDetect.Click += new System.EventHandler(this.lblMotionDetect_Click);
            // 
            // lblMotion
            // 
            this.lblMotion.AutoSize = true;
            this.lblMotion.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotion.Location = new System.Drawing.Point(448, 155);
            this.lblMotion.Name = "lblMotion";
            this.lblMotion.Size = new System.Drawing.Size(54, 18);
            this.lblMotion.TabIndex = 23;
            this.lblMotion.Text = "Motion";
            this.lblMotion.Click += new System.EventHandler(this.lblMotion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(627, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboWeightunit
            // 
            this.cboWeightunit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboWeightunit.FormattingEnabled = true;
            this.cboWeightunit.Location = new System.Drawing.Point(627, 41);
            this.cboWeightunit.Name = "cboWeightunit";
            this.cboWeightunit.Size = new System.Drawing.Size(90, 26);
            this.cboWeightunit.TabIndex = 20;
            this.cboWeightunit.SelectedIndexChanged += new System.EventHandler(this.cboWeightunit_SelectedIndexChanged);
            // 
            // lblWeightres
            // 
            this.lblWeightres.AutoSize = true;
            this.lblWeightres.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightres.Location = new System.Drawing.Point(448, 79);
            this.lblWeightres.Name = "lblWeightres";
            this.lblWeightres.Size = new System.Drawing.Size(123, 18);
            this.lblWeightres.TabIndex = 19;
            this.lblWeightres.Text = "Weight Resolution";
            this.lblWeightres.Click += new System.EventHandler(this.lblWeightres_Click);
            // 
            // lblWeightuni
            // 
            this.lblWeightuni.AutoSize = true;
            this.lblWeightuni.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightuni.Location = new System.Drawing.Point(448, 46);
            this.lblWeightuni.Name = "lblWeightuni";
            this.lblWeightuni.Size = new System.Drawing.Size(83, 18);
            this.lblWeightuni.TabIndex = 18;
            this.lblWeightuni.Text = "Weight Unit";
            this.lblWeightuni.Click += new System.EventHandler(this.lblWeightuni_Click);
            // 
            // lblWeightformat
            // 
            this.lblWeightformat.AutoSize = true;
            this.lblWeightformat.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightformat.Location = new System.Drawing.Point(447, 22);
            this.lblWeightformat.Name = "lblWeightformat";
            this.lblWeightformat.Size = new System.Drawing.Size(100, 18);
            this.lblWeightformat.TabIndex = 17;
            this.lblWeightformat.Text = "Weight Format";
            this.lblWeightformat.Click += new System.EventHandler(this.lblWeightformat_Click);
            // 
            // grpTare
            // 
            this.grpTare.BackColor = System.Drawing.Color.CadetBlue;
            this.grpTare.Controls.Add(this.lblTraegroup);
            this.grpTare.Location = new System.Drawing.Point(399, 283);
            this.grpTare.Name = "grpTare";
            this.grpTare.Size = new System.Drawing.Size(282, 100);
            this.grpTare.TabIndex = 16;
            this.grpTare.TabStop = false;
            this.grpTare.Text = "Tare";
            this.grpTare.Enter += new System.EventHandler(this.grpTare_Enter);
            // 
            // lblTraegroup
            // 
            this.lblTraegroup.AutoSize = true;
            this.lblTraegroup.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTraegroup.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraegroup.Location = new System.Drawing.Point(3, 27);
            this.lblTraegroup.Name = "lblTraegroup";
            this.lblTraegroup.Size = new System.Drawing.Size(276, 45);
            this.lblTraegroup.TabIndex = 0;
            this.lblTraegroup.Text = "Fixed Tare will be downloaded individually and\r\nonly if the device is in Net mode" +
    ". In addition tare \r\nwill be cancelled in power cycle (reset).\r\n";
            this.lblTraegroup.Click += new System.EventHandler(this.lblTraegroup_Click);
            // 
            // grpMeasure
            // 
            this.grpMeasure.BackColor = System.Drawing.Color.CadetBlue;
            this.grpMeasure.Controls.Add(this.lblPeriodbandtare);
            this.grpMeasure.Location = new System.Drawing.Point(83, 283);
            this.grpMeasure.Name = "grpMeasure";
            this.grpMeasure.Size = new System.Drawing.Size(184, 100);
            this.grpMeasure.TabIndex = 15;
            this.grpMeasure.TabStop = false;
            this.grpMeasure.Text = "Measuring Units";
            this.grpMeasure.Enter += new System.EventHandler(this.grpMeasure_Enter);
            // 
            // lblPeriodbandtare
            // 
            this.lblPeriodbandtare.AutoSize = true;
            this.lblPeriodbandtare.BackColor = System.Drawing.Color.CadetBlue;
            this.lblPeriodbandtare.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodbandtare.Location = new System.Drawing.Point(16, 28);
            this.lblPeriodbandtare.Name = "lblPeriodbandtare";
            this.lblPeriodbandtare.Size = new System.Drawing.Size(135, 45);
            this.lblPeriodbandtare.TabIndex = 0;
            this.lblPeriodbandtare.Text = "Period - In milliseconds.\r\nBand - In Weight Unit.\r\nTare - In Weight Unit.\r\n";
            this.lblPeriodbandtare.Click += new System.EventHandler(this.lblPeriodbandtare_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDownload.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(245, 232);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(73, 25);
            this.btnDownload.TabIndex = 14;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtFixedtare
            // 
            this.txtFixedtare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFixedtare.Location = new System.Drawing.Point(148, 235);
            this.txtFixedtare.Multiline = true;
            this.txtFixedtare.Name = "txtFixedtare";
            this.txtFixedtare.Size = new System.Drawing.Size(91, 20);
            this.txtFixedtare.TabIndex = 13;
            this.txtFixedtare.TextChanged += new System.EventHandler(this.txtFixedtare_TextChanged);
            // 
            // lblFixedtare
            // 
            this.lblFixedtare.AutoSize = true;
            this.lblFixedtare.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixedtare.Location = new System.Drawing.Point(80, 238);
            this.lblFixedtare.Name = "lblFixedtare";
            this.lblFixedtare.Size = new System.Drawing.Size(71, 18);
            this.lblFixedtare.TabIndex = 12;
            this.lblFixedtare.Text = "Fixed Tare";
            this.lblFixedtare.Click += new System.EventHandler(this.lblFixedtare_Click);
            // 
            // lblTare
            // 
            this.lblTare.AutoSize = true;
            this.lblTare.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTare.Location = new System.Drawing.Point(74, 207);
            this.lblTare.Name = "lblTare";
            this.lblTare.Size = new System.Drawing.Size(34, 18);
            this.lblTare.TabIndex = 11;
            this.lblTare.Text = "Tare";
            this.lblTare.Click += new System.EventHandler(this.lblTare_Click);
            // 
            // cboZtrack
            // 
            this.cboZtrack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboZtrack.FormattingEnabled = true;
            this.cboZtrack.Location = new System.Drawing.Point(226, 101);
            this.cboZtrack.Name = "cboZtrack";
            this.cboZtrack.Size = new System.Drawing.Size(92, 26);
            this.cboZtrack.TabIndex = 10;
            this.cboZtrack.SelectedIndexChanged += new System.EventHandler(this.cboZtrack_SelectedIndexChanged);
            // 
            // txtZtrackperiod
            // 
            this.txtZtrackperiod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtZtrackperiod.Location = new System.Drawing.Point(226, 157);
            this.txtZtrackperiod.Multiline = true;
            this.txtZtrackperiod.Name = "txtZtrackperiod";
            this.txtZtrackperiod.Size = new System.Drawing.Size(92, 20);
            this.txtZtrackperiod.TabIndex = 9;
            this.txtZtrackperiod.TextChanged += new System.EventHandler(this.txtZtrackperiod_TextChanged);
            // 
            // txtZtrackband
            // 
            this.txtZtrackband.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtZtrackband.Location = new System.Drawing.Point(226, 131);
            this.txtZtrackband.Multiline = true;
            this.txtZtrackband.Name = "txtZtrackband";
            this.txtZtrackband.Size = new System.Drawing.Size(92, 20);
            this.txtZtrackband.TabIndex = 8;
            this.txtZtrackband.TextChanged += new System.EventHandler(this.txtZtrackband_TextChanged);
            // 
            // txtPOZB
            // 
            this.txtPOZB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPOZB.Location = new System.Drawing.Point(226, 75);
            this.txtPOZB.Multiline = true;
            this.txtPOZB.Name = "txtPOZB";
            this.txtPOZB.Size = new System.Drawing.Size(92, 20);
            this.txtPOZB.TabIndex = 7;
            this.txtPOZB.TextChanged += new System.EventHandler(this.txtPOZB_TextChanged);
            // 
            // cboPOZ
            // 
            this.cboPOZ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboPOZ.FormattingEnabled = true;
            this.cboPOZ.Location = new System.Drawing.Point(226, 41);
            this.cboPOZ.Name = "cboPOZ";
            this.cboPOZ.Size = new System.Drawing.Size(92, 26);
            this.cboPOZ.TabIndex = 6;
            this.cboPOZ.SelectedIndexChanged += new System.EventHandler(this.cboPOZ_SelectedIndexChanged);
            // 
            // lblZtrackperiod
            // 
            this.lblZtrackperiod.AutoSize = true;
            this.lblZtrackperiod.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZtrackperiod.Location = new System.Drawing.Point(80, 163);
            this.lblZtrackperiod.Name = "lblZtrackperiod";
            this.lblZtrackperiod.Size = new System.Drawing.Size(133, 18);
            this.lblZtrackperiod.TabIndex = 5;
            this.lblZtrackperiod.Text = "Zero Tracking Period";
            this.lblZtrackperiod.Click += new System.EventHandler(this.lblZtrackperiod_Click);
            // 
            // lblZtrackband
            // 
            this.lblZtrackband.AutoSize = true;
            this.lblZtrackband.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZtrackband.Location = new System.Drawing.Point(80, 136);
            this.lblZtrackband.Name = "lblZtrackband";
            this.lblZtrackband.Size = new System.Drawing.Size(123, 18);
            this.lblZtrackband.TabIndex = 4;
            this.lblZtrackband.Text = "Zero Tracking Band";
            this.lblZtrackband.Click += new System.EventHandler(this.lblZtrackband_Click);
            // 
            // lblZtrack
            // 
            this.lblZtrack.AutoSize = true;
            this.lblZtrack.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZtrack.Location = new System.Drawing.Point(80, 109);
            this.lblZtrack.Name = "lblZtrack";
            this.lblZtrack.Size = new System.Drawing.Size(89, 18);
            this.lblZtrack.TabIndex = 3;
            this.lblZtrack.Text = "Zero Tracking";
            this.lblZtrack.Click += new System.EventHandler(this.lblZtrack_Click);
            // 
            // lblPOZB
            // 
            this.lblPOZB.AutoSize = true;
            this.lblPOZB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOZB.Location = new System.Drawing.Point(80, 79);
            this.lblPOZB.Name = "lblPOZB";
            this.lblPOZB.Size = new System.Drawing.Size(134, 18);
            this.lblPOZB.TabIndex = 2;
            this.lblPOZB.Text = "Power On Zero Band";
            this.lblPOZB.Click += new System.EventHandler(this.lblPOZB_Click);
            // 
            // lblPOZ
            // 
            this.lblPOZ.AutoSize = true;
            this.lblPOZ.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOZ.Location = new System.Drawing.Point(80, 48);
            this.lblPOZ.Name = "lblPOZ";
            this.lblPOZ.Size = new System.Drawing.Size(100, 18);
            this.lblPOZ.TabIndex = 1;
            this.lblPOZ.Text = "Power On Zero";
            this.lblPOZ.Click += new System.EventHandler(this.lblPOZ_Click);
            // 
            // lblZero
            // 
            this.lblZero.AutoSize = true;
            this.lblZero.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZero.Location = new System.Drawing.Point(74, 22);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(36, 18);
            this.lblZero.TabIndex = 0;
            this.lblZero.Text = "Zero";
            this.lblZero.Click += new System.EventHandler(this.lblZero_Click);
            // 
            // tbFilters
            // 
            this.tbFilters.BackColor = System.Drawing.Color.LightBlue;
            this.tbFilters.Controls.Add(this.grpMeasuring);
            this.tbFilters.Controls.Add(this.cboPeak);
            this.tbFilters.Controls.Add(this.cboMeasure);
            this.tbFilters.Controls.Add(this.lblPeaktrough);
            this.tbFilters.Controls.Add(this.lblPeak);
            this.tbFilters.Controls.Add(this.lblMeasurate);
            this.tbFilters.Controls.Add(this.txtNo4hysteresis);
            this.tbFilters.Controls.Add(this.txtNo4level);
            this.tbFilters.Controls.Add(this.txtNo3hysteresis);
            this.tbFilters.Controls.Add(this.txtNo3level);
            this.tbFilters.Controls.Add(this.txtNo2hysteresis);
            this.tbFilters.Controls.Add(this.txtNo2level);
            this.tbFilters.Controls.Add(this.txtNo1hysteresis);
            this.tbFilters.Controls.Add(this.txtNo1level);
            this.tbFilters.Controls.Add(this.cboNo4source);
            this.tbFilters.Controls.Add(this.cboNo3source);
            this.tbFilters.Controls.Add(this.cboNo2source);
            this.tbFilters.Controls.Add(this.cboSource);
            this.tbFilters.Controls.Add(this.lblNo4level);
            this.tbFilters.Controls.Add(this.lblNo2level);
            this.tbFilters.Controls.Add(this.lblNo4hysteresis);
            this.tbFilters.Controls.Add(this.lblNo2Hysteresis);
            this.tbFilters.Controls.Add(this.lblNo3source);
            this.tbFilters.Controls.Add(this.label18);
            this.tbFilters.Controls.Add(this.lblNo4source);
            this.tbFilters.Controls.Add(this.lblNo2source);
            this.tbFilters.Controls.Add(this.lblNo3level);
            this.tbFilters.Controls.Add(this.lblNo3hysteresis);
            this.tbFilters.Controls.Add(this.lblNo1Hysteresis);
            this.tbFilters.Controls.Add(this.lblNo1level);
            this.tbFilters.Controls.Add(this.lblNo1source);
            this.tbFilters.Controls.Add(this.lblSetpoints);
            this.tbFilters.Controls.Add(this.cboFir);
            this.tbFilters.Controls.Add(this.cboRecursive);
            this.tbFilters.Controls.Add(this.cboFiltertype);
            this.tbFilters.Controls.Add(this.lblRecursive);
            this.tbFilters.Controls.Add(this.lblFir);
            this.tbFilters.Controls.Add(this.lblFiltertype);
            this.tbFilters.Controls.Add(this.lblFiltering);
            this.tbFilters.Controls.Add(this.txtHysteresis);
            this.tbFilters.Controls.Add(this.txtLevel);
            this.tbFilters.Controls.Add(this.txtDelay);
            this.tbFilters.Controls.Add(this.cboTrigger);
            this.tbFilters.Controls.Add(this.cboMode);
            this.tbFilters.Controls.Add(this.lblTrigger);
            this.tbFilters.Controls.Add(this.lblHysteresis);
            this.tbFilters.Controls.Add(this.lblLevel);
            this.tbFilters.Controls.Add(this.lblDelay);
            this.tbFilters.Controls.Add(this.lblMode);
            this.tbFilters.Controls.Add(this.lblGrab);
            this.tbFilters.Location = new System.Drawing.Point(4, 27);
            this.tbFilters.Name = "tbFilters";
            this.tbFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tbFilters.Size = new System.Drawing.Size(841, 389);
            this.tbFilters.TabIndex = 1;
            this.tbFilters.Text = "Filters/Peak/Grab/Setpoints";
            this.tbFilters.Click += new System.EventHandler(this.tbFilters_Click);
            // 
            // grpMeasuring
            // 
            this.grpMeasuring.BackColor = System.Drawing.Color.CadetBlue;
            this.grpMeasuring.Controls.Add(this.lblMax2per);
            this.grpMeasuring.Controls.Add(this.lblHysteresisweightunit);
            this.grpMeasuring.Controls.Add(this.lblWeightunit);
            this.grpMeasuring.Controls.Add(this.lblMilli);
            this.grpMeasuring.Location = new System.Drawing.Point(555, 236);
            this.grpMeasuring.Name = "grpMeasuring";
            this.grpMeasuring.Size = new System.Drawing.Size(176, 124);
            this.grpMeasuring.TabIndex = 43;
            this.grpMeasuring.TabStop = false;
            this.grpMeasuring.Text = "Measuring Units";
            this.grpMeasuring.Enter += new System.EventHandler(this.grpMeasuring_Enter);
            // 
            // lblMax2per
            // 
            this.lblMax2per.AutoSize = true;
            this.lblMax2per.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax2per.Location = new System.Drawing.Point(6, 79);
            this.lblMax2per.Name = "lblMax2per";
            this.lblMax2per.Size = new System.Drawing.Size(147, 15);
            this.lblMax2per.TabIndex = 0;
            this.lblMax2per.Text = "maximum 2% of full scale.";
            this.lblMax2per.Click += new System.EventHandler(this.lblMax2per_Click);
            // 
            // lblHysteresisweightunit
            // 
            this.lblHysteresisweightunit.AutoSize = true;
            this.lblHysteresisweightunit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHysteresisweightunit.Location = new System.Drawing.Point(6, 63);
            this.lblHysteresisweightunit.Name = "lblHysteresisweightunit";
            this.lblHysteresisweightunit.Size = new System.Drawing.Size(155, 15);
            this.lblHysteresisweightunit.TabIndex = 0;
            this.lblHysteresisweightunit.Text = "Hysteresis - In Weight Unit.";
            this.lblHysteresisweightunit.Click += new System.EventHandler(this.lblHysteresisweightunit_Click);
            // 
            // lblWeightunit
            // 
            this.lblWeightunit.AutoSize = true;
            this.lblWeightunit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightunit.Location = new System.Drawing.Point(6, 46);
            this.lblWeightunit.Name = "lblWeightunit";
            this.lblWeightunit.Size = new System.Drawing.Size(125, 15);
            this.lblWeightunit.TabIndex = 0;
            this.lblWeightunit.Text = "Level- In Weight Unit.";
            this.lblWeightunit.Click += new System.EventHandler(this.lblWeightunit_Click);
            // 
            // lblMilli
            // 
            this.lblMilli.AutoSize = true;
            this.lblMilli.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilli.Location = new System.Drawing.Point(6, 29);
            this.lblMilli.Name = "lblMilli";
            this.lblMilli.Size = new System.Drawing.Size(123, 15);
            this.lblMilli.TabIndex = 0;
            this.lblMilli.Text = "Delay-In milliseconds.";
            this.lblMilli.Click += new System.EventHandler(this.lblMilli_Click);
            // 
            // cboPeak
            // 
            this.cboPeak.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboPeak.FormattingEnabled = true;
            this.cboPeak.Location = new System.Drawing.Point(649, 113);
            this.cboPeak.Name = "cboPeak";
            this.cboPeak.Size = new System.Drawing.Size(82, 26);
            this.cboPeak.TabIndex = 42;
            this.cboPeak.SelectedIndexChanged += new System.EventHandler(this.cboPeak_SelectedIndexChanged);
            // 
            // cboMeasure
            // 
            this.cboMeasure.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboMeasure.FormattingEnabled = true;
            this.cboMeasure.Location = new System.Drawing.Point(649, 31);
            this.cboMeasure.Name = "cboMeasure";
            this.cboMeasure.Size = new System.Drawing.Size(82, 26);
            this.cboMeasure.TabIndex = 41;
            this.cboMeasure.SelectedIndexChanged += new System.EventHandler(this.cboMeasure_SelectedIndexChanged);
            // 
            // lblPeaktrough
            // 
            this.lblPeaktrough.AutoSize = true;
            this.lblPeaktrough.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeaktrough.Location = new System.Drawing.Point(555, 113);
            this.lblPeaktrough.Name = "lblPeaktrough";
            this.lblPeaktrough.Size = new System.Drawing.Size(86, 36);
            this.lblPeaktrough.TabIndex = 40;
            this.lblPeaktrough.Text = "Peak Trough \r\nSource";
            this.lblPeaktrough.Click += new System.EventHandler(this.lblPeaktrough_Click);
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeak.Location = new System.Drawing.Point(555, 85);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(38, 18);
            this.lblPeak.TabIndex = 39;
            this.lblPeak.Text = "Peak";
            this.lblPeak.Click += new System.EventHandler(this.lblPeak_Click);
            // 
            // lblMeasurate
            // 
            this.lblMeasurate.AutoSize = true;
            this.lblMeasurate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasurate.Location = new System.Drawing.Point(555, 31);
            this.lblMeasurate.Name = "lblMeasurate";
            this.lblMeasurate.Size = new System.Drawing.Size(99, 36);
            this.lblMeasurate.TabIndex = 38;
            this.lblMeasurate.Text = "Measurement \r\nRate";
            this.lblMeasurate.Click += new System.EventHandler(this.lblMeasurate_Click);
            // 
            // txtNo4hysteresis
            // 
            this.txtNo4hysteresis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNo4hysteresis.Location = new System.Drawing.Point(404, 340);
            this.txtNo4hysteresis.Multiline = true;
            this.txtNo4hysteresis.Name = "txtNo4hysteresis";
            this.txtNo4hysteresis.Size = new System.Drawing.Size(84, 20);
            this.txtNo4hysteresis.TabIndex = 37;
            this.txtNo4hysteresis.TextChanged += new System.EventHandler(this.txtNo4hysteresis_TextChanged);
            // 
            // txtNo4level
            // 
            this.txtNo4level.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNo4level.Location = new System.Drawing.Point(404, 316);
            this.txtNo4level.Multiline = true;
            this.txtNo4level.Name = "txtNo4level";
            this.txtNo4level.Size = new System.Drawing.Size(84, 20);
            this.txtNo4level.TabIndex = 36;
            this.txtNo4level.TextChanged += new System.EventHandler(this.txtNo4level_TextChanged);
            // 
            // txtNo3hysteresis
            // 
            this.txtNo3hysteresis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNo3hysteresis.Location = new System.Drawing.Point(404, 255);
            this.txtNo3hysteresis.Multiline = true;
            this.txtNo3hysteresis.Name = "txtNo3hysteresis";
            this.txtNo3hysteresis.Size = new System.Drawing.Size(84, 20);
            this.txtNo3hysteresis.TabIndex = 35;
            this.txtNo3hysteresis.TextChanged += new System.EventHandler(this.txtNo3hysteresis_TextChanged);
            // 
            // txtNo3level
            // 
            this.txtNo3level.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNo3level.Location = new System.Drawing.Point(404, 230);
            this.txtNo3level.Multiline = true;
            this.txtNo3level.Name = "txtNo3level";
            this.txtNo3level.Size = new System.Drawing.Size(84, 20);
            this.txtNo3level.TabIndex = 34;
            this.txtNo3level.TextChanged += new System.EventHandler(this.txtNo3level_TextChanged);
            // 
            // txtNo2hysteresis
            // 
            this.txtNo2hysteresis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNo2hysteresis.Location = new System.Drawing.Point(404, 171);
            this.txtNo2hysteresis.Multiline = true;
            this.txtNo2hysteresis.Name = "txtNo2hysteresis";
            this.txtNo2hysteresis.Size = new System.Drawing.Size(84, 20);
            this.txtNo2hysteresis.TabIndex = 33;
            this.txtNo2hysteresis.TextChanged += new System.EventHandler(this.txtNo2hysteresis_TextChanged);
            // 
            // txtNo2level
            // 
            this.txtNo2level.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNo2level.Location = new System.Drawing.Point(404, 147);
            this.txtNo2level.Multiline = true;
            this.txtNo2level.Name = "txtNo2level";
            this.txtNo2level.Size = new System.Drawing.Size(84, 20);
            this.txtNo2level.TabIndex = 32;
            this.txtNo2level.TextChanged += new System.EventHandler(this.txtNo2level_TextChanged);
            // 
            // txtNo1hysteresis
            // 
            this.txtNo1hysteresis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNo1hysteresis.Location = new System.Drawing.Point(404, 89);
            this.txtNo1hysteresis.Multiline = true;
            this.txtNo1hysteresis.Name = "txtNo1hysteresis";
            this.txtNo1hysteresis.Size = new System.Drawing.Size(84, 20);
            this.txtNo1hysteresis.TabIndex = 31;
            this.txtNo1hysteresis.TextChanged += new System.EventHandler(this.txtNo1hysteresis_TextChanged);
            // 
            // txtNo1level
            // 
            this.txtNo1level.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNo1level.Location = new System.Drawing.Point(404, 63);
            this.txtNo1level.Multiline = true;
            this.txtNo1level.Name = "txtNo1level";
            this.txtNo1level.Size = new System.Drawing.Size(84, 20);
            this.txtNo1level.TabIndex = 30;
            this.txtNo1level.TextChanged += new System.EventHandler(this.txtNo1level_TextChanged);
            // 
            // cboNo4source
            // 
            this.cboNo4source.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboNo4source.FormattingEnabled = true;
            this.cboNo4source.Location = new System.Drawing.Point(404, 284);
            this.cboNo4source.Name = "cboNo4source";
            this.cboNo4source.Size = new System.Drawing.Size(84, 26);
            this.cboNo4source.TabIndex = 29;
            this.cboNo4source.SelectedIndexChanged += new System.EventHandler(this.cboNo4source_SelectedIndexChanged);
            // 
            // cboNo3source
            // 
            this.cboNo3source.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboNo3source.FormattingEnabled = true;
            this.cboNo3source.Location = new System.Drawing.Point(404, 200);
            this.cboNo3source.Name = "cboNo3source";
            this.cboNo3source.Size = new System.Drawing.Size(84, 26);
            this.cboNo3source.TabIndex = 28;
            this.cboNo3source.SelectedIndexChanged += new System.EventHandler(this.cboNo3source_SelectedIndexChanged);
            // 
            // cboNo2source
            // 
            this.cboNo2source.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboNo2source.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNo2source.FormattingEnabled = true;
            this.cboNo2source.Location = new System.Drawing.Point(404, 117);
            this.cboNo2source.Name = "cboNo2source";
            this.cboNo2source.Size = new System.Drawing.Size(84, 23);
            this.cboNo2source.TabIndex = 27;
            this.cboNo2source.SelectedIndexChanged += new System.EventHandler(this.cboNo2source_SelectedIndexChanged);
            // 
            // cboSource
            // 
            this.cboSource.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboSource.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSource.FormattingEnabled = true;
            this.cboSource.Location = new System.Drawing.Point(404, 31);
            this.cboSource.Name = "cboSource";
            this.cboSource.Size = new System.Drawing.Size(84, 23);
            this.cboSource.TabIndex = 26;
            this.cboSource.SelectedIndexChanged += new System.EventHandler(this.cboSource_SelectedIndexChanged);
            // 
            // lblNo4level
            // 
            this.lblNo4level.AutoSize = true;
            this.lblNo4level.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo4level.Location = new System.Drawing.Point(302, 316);
            this.lblNo4level.Name = "lblNo4level";
            this.lblNo4level.Size = new System.Drawing.Size(58, 18);
            this.lblNo4level.TabIndex = 25;
            this.lblNo4level.Text = "#4 Level";
            this.lblNo4level.Click += new System.EventHandler(this.lblNo4level_Click);
            // 
            // lblNo2level
            // 
            this.lblNo2level.AutoSize = true;
            this.lblNo2level.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo2level.Location = new System.Drawing.Point(302, 147);
            this.lblNo2level.Name = "lblNo2level";
            this.lblNo2level.Size = new System.Drawing.Size(58, 18);
            this.lblNo2level.TabIndex = 25;
            this.lblNo2level.Text = "#2 Level";
            this.lblNo2level.Click += new System.EventHandler(this.lblNo2level_Click);
            // 
            // lblNo4hysteresis
            // 
            this.lblNo4hysteresis.AutoSize = true;
            this.lblNo4hysteresis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo4hysteresis.Location = new System.Drawing.Point(302, 340);
            this.lblNo4hysteresis.Name = "lblNo4hysteresis";
            this.lblNo4hysteresis.Size = new System.Drawing.Size(89, 18);
            this.lblNo4hysteresis.TabIndex = 24;
            this.lblNo4hysteresis.Text = "#4 Hysteresis";
            this.lblNo4hysteresis.Click += new System.EventHandler(this.lblNo4hysteresis_Click);
            // 
            // lblNo2Hysteresis
            // 
            this.lblNo2Hysteresis.AutoSize = true;
            this.lblNo2Hysteresis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo2Hysteresis.Location = new System.Drawing.Point(302, 171);
            this.lblNo2Hysteresis.Name = "lblNo2Hysteresis";
            this.lblNo2Hysteresis.Size = new System.Drawing.Size(89, 18);
            this.lblNo2Hysteresis.TabIndex = 24;
            this.lblNo2Hysteresis.Text = "#2 Hysteresis";
            this.lblNo2Hysteresis.Click += new System.EventHandler(this.lblNo2Hysteresis_Click);
            // 
            // lblNo3source
            // 
            this.lblNo3source.AutoSize = true;
            this.lblNo3source.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo3source.Location = new System.Drawing.Point(301, 204);
            this.lblNo3source.Name = "lblNo3source";
            this.lblNo3source.Size = new System.Drawing.Size(67, 18);
            this.lblNo3source.TabIndex = 23;
            this.lblNo3source.Text = "#3 Source";
            this.lblNo3source.Click += new System.EventHandler(this.lblNo3source_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(183, 460);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 15);
            this.label18.TabIndex = 23;
            this.label18.Text = "#1 Source";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // lblNo4source
            // 
            this.lblNo4source.AutoSize = true;
            this.lblNo4source.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo4source.Location = new System.Drawing.Point(302, 291);
            this.lblNo4source.Name = "lblNo4source";
            this.lblNo4source.Size = new System.Drawing.Size(67, 18);
            this.lblNo4source.TabIndex = 23;
            this.lblNo4source.Text = "#4 Source";
            this.lblNo4source.Click += new System.EventHandler(this.lblNo4source_Click);
            // 
            // lblNo2source
            // 
            this.lblNo2source.AutoSize = true;
            this.lblNo2source.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo2source.Location = new System.Drawing.Point(302, 122);
            this.lblNo2source.Name = "lblNo2source";
            this.lblNo2source.Size = new System.Drawing.Size(67, 18);
            this.lblNo2source.TabIndex = 23;
            this.lblNo2source.Text = "#2 Source";
            this.lblNo2source.Click += new System.EventHandler(this.lblNo2source_Click);
            // 
            // lblNo3level
            // 
            this.lblNo3level.AutoSize = true;
            this.lblNo3level.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo3level.Location = new System.Drawing.Point(301, 230);
            this.lblNo3level.Name = "lblNo3level";
            this.lblNo3level.Size = new System.Drawing.Size(58, 18);
            this.lblNo3level.TabIndex = 20;
            this.lblNo3level.Text = "#3 Level";
            this.lblNo3level.Click += new System.EventHandler(this.lblNo3level_Click);
            // 
            // lblNo3hysteresis
            // 
            this.lblNo3hysteresis.AutoSize = true;
            this.lblNo3hysteresis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo3hysteresis.Location = new System.Drawing.Point(301, 255);
            this.lblNo3hysteresis.Name = "lblNo3hysteresis";
            this.lblNo3hysteresis.Size = new System.Drawing.Size(89, 18);
            this.lblNo3hysteresis.TabIndex = 21;
            this.lblNo3hysteresis.Text = "#3 Hysteresis";
            this.lblNo3hysteresis.Click += new System.EventHandler(this.lblNo3hysteresis_Click);
            // 
            // lblNo1Hysteresis
            // 
            this.lblNo1Hysteresis.AutoSize = true;
            this.lblNo1Hysteresis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo1Hysteresis.Location = new System.Drawing.Point(301, 87);
            this.lblNo1Hysteresis.Name = "lblNo1Hysteresis";
            this.lblNo1Hysteresis.Size = new System.Drawing.Size(89, 18);
            this.lblNo1Hysteresis.TabIndex = 21;
            this.lblNo1Hysteresis.Text = "#1 Hysteresis";
            this.lblNo1Hysteresis.Click += new System.EventHandler(this.lblNo1Hysteresis_Click);
            // 
            // lblNo1level
            // 
            this.lblNo1level.AutoSize = true;
            this.lblNo1level.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo1level.Location = new System.Drawing.Point(301, 62);
            this.lblNo1level.Name = "lblNo1level";
            this.lblNo1level.Size = new System.Drawing.Size(58, 18);
            this.lblNo1level.TabIndex = 20;
            this.lblNo1level.Text = "#1 Level";
            this.lblNo1level.Click += new System.EventHandler(this.lblNo1level_Click);
            // 
            // lblNo1source
            // 
            this.lblNo1source.AutoSize = true;
            this.lblNo1source.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo1source.Location = new System.Drawing.Point(302, 36);
            this.lblNo1source.Name = "lblNo1source";
            this.lblNo1source.Size = new System.Drawing.Size(67, 18);
            this.lblNo1source.TabIndex = 19;
            this.lblNo1source.Text = "#1 Source";
            this.lblNo1source.Click += new System.EventHandler(this.lblNo1source_Click);
            // 
            // lblSetpoints
            // 
            this.lblSetpoints.AutoSize = true;
            this.lblSetpoints.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetpoints.Location = new System.Drawing.Point(301, 7);
            this.lblSetpoints.Name = "lblSetpoints";
            this.lblSetpoints.Size = new System.Drawing.Size(67, 18);
            this.lblSetpoints.TabIndex = 18;
            this.lblSetpoints.Text = "SetPoints";
            this.lblSetpoints.Click += new System.EventHandler(this.lblSetpoints_Click);
            // 
            // cboFir
            // 
            this.cboFir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboFir.FormattingEnabled = true;
            this.cboFir.Location = new System.Drawing.Point(99, 291);
            this.cboFir.Name = "cboFir";
            this.cboFir.Size = new System.Drawing.Size(71, 26);
            this.cboFir.TabIndex = 17;
            this.cboFir.SelectedIndexChanged += new System.EventHandler(this.cboFir_SelectedIndexChanged);
            // 
            // cboRecursive
            // 
            this.cboRecursive.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboRecursive.FormattingEnabled = true;
            this.cboRecursive.Location = new System.Drawing.Point(99, 329);
            this.cboRecursive.Name = "cboRecursive";
            this.cboRecursive.Size = new System.Drawing.Size(71, 26);
            this.cboRecursive.TabIndex = 16;
            this.cboRecursive.SelectedIndexChanged += new System.EventHandler(this.cboRecursive_SelectedIndexChanged);
            // 
            // cboFiltertype
            // 
            this.cboFiltertype.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboFiltertype.FormattingEnabled = true;
            this.cboFiltertype.Location = new System.Drawing.Point(99, 255);
            this.cboFiltertype.Name = "cboFiltertype";
            this.cboFiltertype.Size = new System.Drawing.Size(71, 26);
            this.cboFiltertype.TabIndex = 15;
            this.cboFiltertype.SelectedIndexChanged += new System.EventHandler(this.cboFiltertype_SelectedIndexChanged);
            // 
            // lblRecursive
            // 
            this.lblRecursive.AutoSize = true;
            this.lblRecursive.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecursive.Location = new System.Drawing.Point(14, 324);
            this.lblRecursive.Name = "lblRecursive";
            this.lblRecursive.Size = new System.Drawing.Size(73, 36);
            this.lblRecursive.TabIndex = 14;
            this.lblRecursive.Text = "Recursive\r\nFrequency";
            this.lblRecursive.Click += new System.EventHandler(this.lblRecursive_Click);
            // 
            // lblFir
            // 
            this.lblFir.AutoSize = true;
            this.lblFir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFir.Location = new System.Drawing.Point(14, 286);
            this.lblFir.Name = "lblFir";
            this.lblFir.Size = new System.Drawing.Size(73, 36);
            this.lblFir.TabIndex = 13;
            this.lblFir.Text = "FIR \r\nFrequency";
            this.lblFir.Click += new System.EventHandler(this.lblFir_Click);
            // 
            // lblFiltertype
            // 
            this.lblFiltertype.AutoSize = true;
            this.lblFiltertype.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltertype.Location = new System.Drawing.Point(14, 260);
            this.lblFiltertype.Name = "lblFiltertype";
            this.lblFiltertype.Size = new System.Drawing.Size(74, 18);
            this.lblFiltertype.TabIndex = 12;
            this.lblFiltertype.Text = "Filter Type";
            this.lblFiltertype.Click += new System.EventHandler(this.lblFiltertype_Click);
            // 
            // lblFiltering
            // 
            this.lblFiltering.AutoSize = true;
            this.lblFiltering.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltering.Location = new System.Drawing.Point(14, 233);
            this.lblFiltering.Name = "lblFiltering";
            this.lblFiltering.Size = new System.Drawing.Size(60, 18);
            this.lblFiltering.TabIndex = 11;
            this.lblFiltering.Text = "Filtering";
            this.lblFiltering.Click += new System.EventHandler(this.lblFiltering_Click);
            // 
            // txtHysteresis
            // 
            this.txtHysteresis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHysteresis.Location = new System.Drawing.Point(99, 115);
            this.txtHysteresis.Multiline = true;
            this.txtHysteresis.Name = "txtHysteresis";
            this.txtHysteresis.Size = new System.Drawing.Size(71, 20);
            this.txtHysteresis.TabIndex = 10;
            this.txtHysteresis.TextChanged += new System.EventHandler(this.txtHysteresis_TextChanged);
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLevel.Location = new System.Drawing.Point(99, 89);
            this.txtLevel.Multiline = true;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(71, 20);
            this.txtLevel.TabIndex = 9;
            this.txtLevel.TextChanged += new System.EventHandler(this.txtLevel_TextChanged);
            // 
            // txtDelay
            // 
            this.txtDelay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDelay.Location = new System.Drawing.Point(99, 63);
            this.txtDelay.Multiline = true;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(71, 20);
            this.txtDelay.TabIndex = 8;
            this.txtDelay.TextChanged += new System.EventHandler(this.txtDelay_TextChanged);
            // 
            // cboTrigger
            // 
            this.cboTrigger.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboTrigger.FormattingEnabled = true;
            this.cboTrigger.Location = new System.Drawing.Point(99, 144);
            this.cboTrigger.Name = "cboTrigger";
            this.cboTrigger.Size = new System.Drawing.Size(71, 26);
            this.cboTrigger.TabIndex = 7;
            this.cboTrigger.SelectedIndexChanged += new System.EventHandler(this.cboTrigger_SelectedIndexChanged);
            // 
            // cboMode
            // 
            this.cboMode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.IntegralHeight = false;
            this.cboMode.Location = new System.Drawing.Point(99, 31);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(71, 26);
            this.cboMode.TabIndex = 6;
            this.cboMode.SelectedIndexChanged += new System.EventHandler(this.cboMode_SelectedIndexChanged);
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrigger.Location = new System.Drawing.Point(14, 147);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(50, 18);
            this.lblTrigger.TabIndex = 5;
            this.lblTrigger.Text = "Trigger";
            this.lblTrigger.Click += new System.EventHandler(this.lblTrigger_Click);
            // 
            // lblHysteresis
            // 
            this.lblHysteresis.AutoSize = true;
            this.lblHysteresis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHysteresis.Location = new System.Drawing.Point(14, 116);
            this.lblHysteresis.Name = "lblHysteresis";
            this.lblHysteresis.Size = new System.Drawing.Size(72, 18);
            this.lblHysteresis.TabIndex = 4;
            this.lblHysteresis.Text = "Hysteresis";
            this.lblHysteresis.Click += new System.EventHandler(this.lblHysteresis_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(14, 90);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(41, 18);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level";
            this.lblLevel.Click += new System.EventHandler(this.lblLevel_Click);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelay.Location = new System.Drawing.Point(14, 64);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(43, 18);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay";
            this.lblDelay.Click += new System.EventHandler(this.lblDelay_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(14, 36);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(45, 18);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "Mode";
            this.lblMode.Click += new System.EventHandler(this.lblMode_Click);
            // 
            // lblGrab
            // 
            this.lblGrab.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrab.Location = new System.Drawing.Point(14, 7);
            this.lblGrab.Name = "lblGrab";
            this.lblGrab.Size = new System.Drawing.Size(50, 23);
            this.lblGrab.TabIndex = 44;
            this.lblGrab.Text = "Grab";
            this.lblGrab.Click += new System.EventHandler(this.lblGrab_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.chkfastfilter);
            this.tabPage1.Controls.Add(this.lblFastfilter);
            this.tabPage1.Controls.Add(this.chkStandardfilter);
            this.tabPage1.Controls.Add(this.lblStandardFilter);
            this.tabPage1.Controls.Add(this.lblFilterMode);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(841, 389);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Modes";
            // 
            // chkfastfilter
            // 
            this.chkfastfilter.AutoSize = true;
            this.chkfastfilter.Location = new System.Drawing.Point(147, 109);
            this.chkfastfilter.Name = "chkfastfilter";
            this.chkfastfilter.Size = new System.Drawing.Size(15, 14);
            this.chkfastfilter.TabIndex = 16;
            this.chkfastfilter.UseVisualStyleBackColor = true;
            // 
            // lblFastfilter
            // 
            this.lblFastfilter.AutoSize = true;
            this.lblFastfilter.Location = new System.Drawing.Point(41, 106);
            this.lblFastfilter.Name = "lblFastfilter";
            this.lblFastfilter.Size = new System.Drawing.Size(69, 18);
            this.lblFastfilter.TabIndex = 15;
            this.lblFastfilter.Text = "Fast Filter";
            // 
            // chkStandardfilter
            // 
            this.chkStandardfilter.AutoSize = true;
            this.chkStandardfilter.Location = new System.Drawing.Point(147, 72);
            this.chkStandardfilter.Name = "chkStandardfilter";
            this.chkStandardfilter.Size = new System.Drawing.Size(15, 14);
            this.chkStandardfilter.TabIndex = 14;
            this.chkStandardfilter.UseVisualStyleBackColor = true;
            // 
            // lblStandardFilter
            // 
            this.lblStandardFilter.AutoSize = true;
            this.lblStandardFilter.Location = new System.Drawing.Point(41, 69);
            this.lblStandardFilter.Name = "lblStandardFilter";
            this.lblStandardFilter.Size = new System.Drawing.Size(99, 18);
            this.lblStandardFilter.TabIndex = 13;
            this.lblStandardFilter.Text = "Standard Filter";
            // 
            // lblFilterMode
            // 
            this.lblFilterMode.AutoSize = true;
            this.lblFilterMode.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterMode.Location = new System.Drawing.Point(41, 34);
            this.lblFilterMode.Name = "lblFilterMode";
            this.lblFilterMode.Size = new System.Drawing.Size(85, 18);
            this.lblFilterMode.TabIndex = 12;
            this.lblFilterMode.Text = "Filter Mode:";
            // 
            // pgCalibration
            // 
            this.pgCalibration.BackColor = System.Drawing.Color.AliceBlue;
            this.pgCalibration.Controls.Add(this.pnlCalibration);
            this.pgCalibration.Controls.Add(this.grpCalipro);
            this.pgCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgCalibration.Location = new System.Drawing.Point(4, 27);
            this.pgCalibration.Name = "pgCalibration";
            this.pgCalibration.Size = new System.Drawing.Size(1288, 479);
            this.pgCalibration.TabIndex = 2;
            this.pgCalibration.Text = "Calibration";
            this.pgCalibration.Click += new System.EventHandler(this.pgCalibration_Click);
            // 
            // pnlCalibration
            // 
            this.pnlCalibration.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCalibration.Controls.Add(this.btnSavecali);
            this.pnlCalibration.Controls.Add(this.txtWeightresolution);
            this.pnlCalibration.Controls.Add(this.lblWeightResolution);
            this.pnlCalibration.Controls.Add(this.txtWeightunit);
            this.pnlCalibration.Controls.Add(this.lblWeightunitcali);
            this.pnlCalibration.Controls.Add(this.btnAcquirespan);
            this.pnlCalibration.Controls.Add(this.lblmVVHighcali);
            this.pnlCalibration.Controls.Add(this.txtmVVHighcali);
            this.pnlCalibration.Controls.Add(this.lblmMVlowCali);
            this.pnlCalibration.Controls.Add(this.txtmvVLowcali);
            this.pnlCalibration.Controls.Add(this.lblCaliweighthigh);
            this.pnlCalibration.Controls.Add(this.txtWeightHighcali);
            this.pnlCalibration.Controls.Add(this.lblWeightLowcali);
            this.pnlCalibration.Controls.Add(this.txtCaliWeightLow);
            this.pnlCalibration.Controls.Add(this.btnAcquirecali);
            this.pnlCalibration.Controls.Add(this.txtmVCali);
            this.pnlCalibration.Controls.Add(this.lblmMvCali);
            this.pnlCalibration.Controls.Add(this.txtWcali);
            this.pnlCalibration.Controls.Add(this.lblCweighty);
            this.pnlCalibration.Location = new System.Drawing.Point(39, 36);
            this.pnlCalibration.Name = "pnlCalibration";
            this.pnlCalibration.Size = new System.Drawing.Size(724, 434);
            this.pnlCalibration.TabIndex = 22;
            // 
            // btnSavecali
            // 
            this.btnSavecali.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSavecali.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavecali.Location = new System.Drawing.Point(295, 391);
            this.btnSavecali.Name = "btnSavecali";
            this.btnSavecali.Size = new System.Drawing.Size(100, 34);
            this.btnSavecali.TabIndex = 38;
            this.btnSavecali.Text = "Save";
            this.btnSavecali.UseVisualStyleBackColor = false;
            // 
            // txtWeightresolution
            // 
            this.txtWeightresolution.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWeightresolution.Location = new System.Drawing.Point(295, 337);
            this.txtWeightresolution.Multiline = true;
            this.txtWeightresolution.Name = "txtWeightresolution";
            this.txtWeightresolution.Size = new System.Drawing.Size(100, 30);
            this.txtWeightresolution.TabIndex = 37;
            // 
            // lblWeightResolution
            // 
            this.lblWeightResolution.AutoSize = true;
            this.lblWeightResolution.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightResolution.Location = new System.Drawing.Point(146, 342);
            this.lblWeightResolution.Name = "lblWeightResolution";
            this.lblWeightResolution.Size = new System.Drawing.Size(123, 18);
            this.lblWeightResolution.TabIndex = 36;
            this.lblWeightResolution.Text = "Weight Resolution";
            // 
            // txtWeightunit
            // 
            this.txtWeightunit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWeightunit.Location = new System.Drawing.Point(295, 289);
            this.txtWeightunit.Multiline = true;
            this.txtWeightunit.Name = "txtWeightunit";
            this.txtWeightunit.Size = new System.Drawing.Size(100, 30);
            this.txtWeightunit.TabIndex = 35;
            // 
            // lblWeightunitcali
            // 
            this.lblWeightunitcali.AutoSize = true;
            this.lblWeightunitcali.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightunitcali.Location = new System.Drawing.Point(184, 293);
            this.lblWeightunitcali.Name = "lblWeightunitcali";
            this.lblWeightunitcali.Size = new System.Drawing.Size(83, 18);
            this.lblWeightunitcali.TabIndex = 34;
            this.lblWeightunitcali.Text = "Weight Unit";
            // 
            // btnAcquirespan
            // 
            this.btnAcquirespan.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcquirespan.Location = new System.Drawing.Point(115, 228);
            this.btnAcquirespan.Name = "btnAcquirespan";
            this.btnAcquirespan.Size = new System.Drawing.Size(147, 34);
            this.btnAcquirespan.TabIndex = 33;
            this.btnAcquirespan.Text = "Acquire Span";
            this.btnAcquirespan.UseVisualStyleBackColor = true;
            // 
            // lblmVVHighcali
            // 
            this.lblmVVHighcali.AutoSize = true;
            this.lblmVVHighcali.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmVVHighcali.Location = new System.Drawing.Point(432, 202);
            this.lblmVVHighcali.Name = "lblmVVHighcali";
            this.lblmVVHighcali.Size = new System.Drawing.Size(74, 18);
            this.lblmVVHighcali.TabIndex = 32;
            this.lblmVVHighcali.Text = "mV/V High";
            // 
            // txtmVVHighcali
            // 
            this.txtmVVHighcali.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmVVHighcali.Location = new System.Drawing.Point(426, 233);
            this.txtmVVHighcali.Multiline = true;
            this.txtmVVHighcali.Name = "txtmVVHighcali";
            this.txtmVVHighcali.Size = new System.Drawing.Size(100, 26);
            this.txtmVVHighcali.TabIndex = 31;
            // 
            // lblmMVlowCali
            // 
            this.lblmMVlowCali.AutoSize = true;
            this.lblmMVlowCali.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmMVlowCali.Location = new System.Drawing.Point(432, 118);
            this.lblmMVlowCali.Name = "lblmMVlowCali";
            this.lblmMVlowCali.Size = new System.Drawing.Size(71, 18);
            this.lblmMVlowCali.TabIndex = 30;
            this.lblmMVlowCali.Text = "mV/V Low";
            // 
            // txtmvVLowcali
            // 
            this.txtmvVLowcali.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmvVLowcali.Location = new System.Drawing.Point(426, 149);
            this.txtmvVLowcali.Multiline = true;
            this.txtmvVLowcali.Name = "txtmvVLowcali";
            this.txtmvVLowcali.Size = new System.Drawing.Size(100, 26);
            this.txtmvVLowcali.TabIndex = 29;
            // 
            // lblCaliweighthigh
            // 
            this.lblCaliweighthigh.AutoSize = true;
            this.lblCaliweighthigh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaliweighthigh.Location = new System.Drawing.Point(301, 202);
            this.lblCaliweighthigh.Name = "lblCaliweighthigh";
            this.lblCaliweighthigh.Size = new System.Drawing.Size(84, 18);
            this.lblCaliweighthigh.TabIndex = 28;
            this.lblCaliweighthigh.Text = "Weight High";
            // 
            // txtWeightHighcali
            // 
            this.txtWeightHighcali.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWeightHighcali.Location = new System.Drawing.Point(295, 233);
            this.txtWeightHighcali.Multiline = true;
            this.txtWeightHighcali.Name = "txtWeightHighcali";
            this.txtWeightHighcali.Size = new System.Drawing.Size(100, 26);
            this.txtWeightHighcali.TabIndex = 27;
            // 
            // lblWeightLowcali
            // 
            this.lblWeightLowcali.AutoSize = true;
            this.lblWeightLowcali.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightLowcali.Location = new System.Drawing.Point(301, 118);
            this.lblWeightLowcali.Name = "lblWeightLowcali";
            this.lblWeightLowcali.Size = new System.Drawing.Size(81, 18);
            this.lblWeightLowcali.TabIndex = 26;
            this.lblWeightLowcali.Text = "Weight Low";
            // 
            // txtCaliWeightLow
            // 
            this.txtCaliWeightLow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCaliWeightLow.Location = new System.Drawing.Point(295, 149);
            this.txtCaliWeightLow.Multiline = true;
            this.txtCaliWeightLow.Name = "txtCaliWeightLow";
            this.txtCaliWeightLow.Size = new System.Drawing.Size(100, 26);
            this.txtCaliWeightLow.TabIndex = 25;
            // 
            // btnAcquirecali
            // 
            this.btnAcquirecali.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcquirecali.Location = new System.Drawing.Point(115, 146);
            this.btnAcquirecali.Name = "btnAcquirecali";
            this.btnAcquirecali.Size = new System.Drawing.Size(147, 34);
            this.btnAcquirecali.TabIndex = 24;
            this.btnAcquirecali.Text = "Acquire Deadload";
            this.btnAcquirecali.UseVisualStyleBackColor = true;
            // 
            // txtmVCali
            // 
            this.txtmVCali.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmVCali.Location = new System.Drawing.Point(295, 54);
            this.txtmVCali.Multiline = true;
            this.txtmVCali.Name = "txtmVCali";
            this.txtmVCali.Size = new System.Drawing.Size(100, 30);
            this.txtmVCali.TabIndex = 23;
            // 
            // lblmMvCali
            // 
            this.lblmMvCali.AutoSize = true;
            this.lblmMvCali.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmMvCali.Location = new System.Drawing.Point(209, 56);
            this.lblmMvCali.Name = "lblmMvCali";
            this.lblmMvCali.Size = new System.Drawing.Size(43, 18);
            this.lblmMvCali.TabIndex = 22;
            this.lblmMvCali.Text = "mV/V";
            // 
            // txtWcali
            // 
            this.txtWcali.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWcali.Location = new System.Drawing.Point(295, 7);
            this.txtWcali.Multiline = true;
            this.txtWcali.Name = "txtWcali";
            this.txtWcali.Size = new System.Drawing.Size(100, 30);
            this.txtWcali.TabIndex = 21;
            // 
            // lblCweighty
            // 
            this.lblCweighty.AutoSize = true;
            this.lblCweighty.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCweighty.Location = new System.Drawing.Point(209, 11);
            this.lblCweighty.Name = "lblCweighty";
            this.lblCweighty.Size = new System.Drawing.Size(53, 18);
            this.lblCweighty.TabIndex = 20;
            this.lblCweighty.Text = "Weight";
            // 
            // grpCalipro
            // 
            this.grpCalipro.BackColor = System.Drawing.Color.LightBlue;
            this.grpCalipro.Controls.Add(this.label3);
            this.grpCalipro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCalipro.Location = new System.Drawing.Point(839, 36);
            this.grpCalipro.Name = "grpCalipro";
            this.grpCalipro.Size = new System.Drawing.Size(308, 434);
            this.grpCalipro.TabIndex = 19;
            this.grpCalipro.TabStop = false;
            this.grpCalipro.Text = "Calibration Process";
            this.grpCalipro.Enter += new System.EventHandler(this.grpCalipro_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 345);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pgView
            // 
            this.pgView.BackColor = System.Drawing.Color.AliceBlue;
            this.pgView.Controls.Add(this.btnFinddevice);
            this.pgView.Controls.Add(this.grpVnotes);
            this.pgView.Controls.Add(this.panel9);
            this.pgView.Controls.Add(this.panel10);
            this.pgView.Controls.Add(this.panel11);
            this.pgView.Controls.Add(this.panel12);
            this.pgView.Controls.Add(this.panel5);
            this.pgView.Controls.Add(this.panel6);
            this.pgView.Controls.Add(this.panel7);
            this.pgView.Controls.Add(this.panel8);
            this.pgView.Controls.Add(this.panel4);
            this.pgView.Controls.Add(this.panel3);
            this.pgView.Controls.Add(this.panel2);
            this.pgView.Controls.Add(this.panel1);
            this.pgView.Controls.Add(this.lblVerror);
            this.pgView.Controls.Add(this.txtVerror);
            this.pgView.Controls.Add(this.lblVnotactive);
            this.pgView.Controls.Add(this.lblVactive);
            this.pgView.Controls.Add(this.txtVnotactive);
            this.pgView.Controls.Add(this.txtVactive);
            this.pgView.Location = new System.Drawing.Point(4, 27);
            this.pgView.Name = "pgView";
            this.pgView.Size = new System.Drawing.Size(1288, 479);
            this.pgView.TabIndex = 3;
            this.pgView.Text = "View All";
            this.pgView.Click += new System.EventHandler(this.pgView_Click);
            // 
            // btnFinddevice
            // 
            this.btnFinddevice.BackColor = System.Drawing.Color.LightBlue;
            this.btnFinddevice.Location = new System.Drawing.Point(104, 22);
            this.btnFinddevice.Name = "btnFinddevice";
            this.btnFinddevice.Size = new System.Drawing.Size(125, 29);
            this.btnFinddevice.TabIndex = 20;
            this.btnFinddevice.Text = "Find Device/s";
            this.btnFinddevice.UseVisualStyleBackColor = false;
            this.btnFinddevice.Click += new System.EventHandler(this.btnFinddevice_Click);
            // 
            // grpVnotes
            // 
            this.grpVnotes.BackColor = System.Drawing.Color.LightBlue;
            this.grpVnotes.Controls.Add(this.lblVnotes);
            this.grpVnotes.Location = new System.Drawing.Point(933, 43);
            this.grpVnotes.Name = "grpVnotes";
            this.grpVnotes.Size = new System.Drawing.Size(227, 415);
            this.grpVnotes.TabIndex = 19;
            this.grpVnotes.TabStop = false;
            this.grpVnotes.Text = "Notes";
            this.grpVnotes.Enter += new System.EventHandler(this.grpVnotes_Enter);
            // 
            // lblVnotes
            // 
            this.lblVnotes.AutoSize = true;
            this.lblVnotes.BackColor = System.Drawing.Color.CadetBlue;
            this.lblVnotes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVnotes.Location = new System.Drawing.Point(18, 22);
            this.lblVnotes.Name = "lblVnotes";
            this.lblVnotes.Size = new System.Drawing.Size(154, 375);
            this.lblVnotes.TabIndex = 0;
            this.lblVnotes.Text = resources.GetString("lblVnotes.Text");
            this.lblVnotes.Click += new System.EventHandler(this.lblVnotes_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightBlue;
            this.panel9.Controls.Add(this.rdP12);
            this.panel9.Controls.Add(this.txtP12gross);
            this.panel9.Controls.Add(this.label20);
            this.panel9.Controls.Add(this.label21);
            this.panel9.Controls.Add(this.txtP12Add);
            this.panel9.Location = new System.Drawing.Point(635, 340);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(151, 109);
            this.panel9.TabIndex = 18;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // rdP12
            // 
            this.rdP12.AutoSize = true;
            this.rdP12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP12.Location = new System.Drawing.Point(4, 20);
            this.rdP12.Name = "rdP12";
            this.rdP12.Size = new System.Drawing.Size(65, 19);
            this.rdP12.TabIndex = 8;
            this.rdP12.TabStop = true;
            this.rdP12.Text = "Motion";
            this.rdP12.UseVisualStyleBackColor = true;
            this.rdP12.CheckedChanged += new System.EventHandler(this.rdP12_CheckedChanged);
            // 
            // txtP12gross
            // 
            this.txtP12gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP12gross.Location = new System.Drawing.Point(6, 64);
            this.txtP12gross.Multiline = true;
            this.txtP12gross.Name = "txtP12gross";
            this.txtP12gross.Size = new System.Drawing.Size(56, 20);
            this.txtP12gross.TabIndex = 9;
            this.txtP12gross.TextChanged += new System.EventHandler(this.txtP12gross_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(54, 1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "Address";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 15);
            this.label21.TabIndex = 8;
            this.label21.Text = "Gross";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // txtP12Add
            // 
            this.txtP12Add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP12Add.Location = new System.Drawing.Point(69, 17);
            this.txtP12Add.Multiline = true;
            this.txtP12Add.Name = "txtP12Add";
            this.txtP12Add.Size = new System.Drawing.Size(25, 22);
            this.txtP12Add.TabIndex = 8;
            this.txtP12Add.TextChanged += new System.EventHandler(this.txtP12Add_TextChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightBlue;
            this.panel10.Controls.Add(this.rdP11motion);
            this.panel10.Controls.Add(this.txtP11gross);
            this.panel10.Controls.Add(this.label22);
            this.panel10.Controls.Add(this.label23);
            this.panel10.Controls.Add(this.txtP11Add);
            this.panel10.Location = new System.Drawing.Point(443, 342);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(151, 109);
            this.panel10.TabIndex = 17;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // rdP11motion
            // 
            this.rdP11motion.AutoSize = true;
            this.rdP11motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP11motion.Location = new System.Drawing.Point(4, 20);
            this.rdP11motion.Name = "rdP11motion";
            this.rdP11motion.Size = new System.Drawing.Size(65, 19);
            this.rdP11motion.TabIndex = 8;
            this.rdP11motion.TabStop = true;
            this.rdP11motion.Text = "Motion";
            this.rdP11motion.UseVisualStyleBackColor = true;
            this.rdP11motion.CheckedChanged += new System.EventHandler(this.rdP11motion_CheckedChanged);
            // 
            // txtP11gross
            // 
            this.txtP11gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP11gross.Location = new System.Drawing.Point(6, 64);
            this.txtP11gross.Multiline = true;
            this.txtP11gross.Name = "txtP11gross";
            this.txtP11gross.Size = new System.Drawing.Size(56, 20);
            this.txtP11gross.TabIndex = 9;
            this.txtP11gross.TextChanged += new System.EventHandler(this.txtP11gross_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(54, 1);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 15);
            this.label22.TabIndex = 9;
            this.label22.Text = "Address";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 15);
            this.label23.TabIndex = 8;
            this.label23.Text = "Gross";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // txtP11Add
            // 
            this.txtP11Add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP11Add.Location = new System.Drawing.Point(69, 17);
            this.txtP11Add.Multiline = true;
            this.txtP11Add.Name = "txtP11Add";
            this.txtP11Add.Size = new System.Drawing.Size(25, 22);
            this.txtP11Add.TabIndex = 8;
            this.txtP11Add.TextChanged += new System.EventHandler(this.txtP11Add_TextChanged);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightBlue;
            this.panel11.Controls.Add(this.rdP10motion);
            this.panel11.Controls.Add(this.txtP10gross);
            this.panel11.Controls.Add(this.label24);
            this.panel11.Controls.Add(this.label25);
            this.panel11.Controls.Add(this.txtP10add);
            this.panel11.Location = new System.Drawing.Point(260, 341);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(151, 109);
            this.panel11.TabIndex = 16;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // rdP10motion
            // 
            this.rdP10motion.AutoSize = true;
            this.rdP10motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP10motion.Location = new System.Drawing.Point(4, 20);
            this.rdP10motion.Name = "rdP10motion";
            this.rdP10motion.Size = new System.Drawing.Size(65, 19);
            this.rdP10motion.TabIndex = 8;
            this.rdP10motion.TabStop = true;
            this.rdP10motion.Text = "Motion";
            this.rdP10motion.UseVisualStyleBackColor = true;
            this.rdP10motion.CheckedChanged += new System.EventHandler(this.rdP10motion_CheckedChanged);
            // 
            // txtP10gross
            // 
            this.txtP10gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP10gross.Location = new System.Drawing.Point(6, 64);
            this.txtP10gross.Multiline = true;
            this.txtP10gross.Name = "txtP10gross";
            this.txtP10gross.Size = new System.Drawing.Size(56, 20);
            this.txtP10gross.TabIndex = 9;
            this.txtP10gross.TextChanged += new System.EventHandler(this.txtP10gross_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(54, 1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 15);
            this.label24.TabIndex = 9;
            this.label24.Text = "Address";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 15);
            this.label25.TabIndex = 8;
            this.label25.Text = "Gross";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // txtP10add
            // 
            this.txtP10add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP10add.Location = new System.Drawing.Point(69, 17);
            this.txtP10add.Multiline = true;
            this.txtP10add.Name = "txtP10add";
            this.txtP10add.Size = new System.Drawing.Size(25, 22);
            this.txtP10add.TabIndex = 8;
            this.txtP10add.TextChanged += new System.EventHandler(this.txtP10add_TextChanged);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightBlue;
            this.panel12.Controls.Add(this.rdP9motion);
            this.panel12.Controls.Add(this.txtP9gross);
            this.panel12.Controls.Add(this.label26);
            this.panel12.Controls.Add(this.label27);
            this.panel12.Controls.Add(this.txtP9add);
            this.panel12.Location = new System.Drawing.Point(66, 341);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(151, 109);
            this.panel12.TabIndex = 15;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // rdP9motion
            // 
            this.rdP9motion.AutoSize = true;
            this.rdP9motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP9motion.Location = new System.Drawing.Point(4, 20);
            this.rdP9motion.Name = "rdP9motion";
            this.rdP9motion.Size = new System.Drawing.Size(65, 19);
            this.rdP9motion.TabIndex = 8;
            this.rdP9motion.TabStop = true;
            this.rdP9motion.Text = "Motion";
            this.rdP9motion.UseVisualStyleBackColor = true;
            this.rdP9motion.CheckedChanged += new System.EventHandler(this.rdP9motion_CheckedChanged);
            // 
            // txtP9gross
            // 
            this.txtP9gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP9gross.Location = new System.Drawing.Point(6, 64);
            this.txtP9gross.Multiline = true;
            this.txtP9gross.Name = "txtP9gross";
            this.txtP9gross.Size = new System.Drawing.Size(56, 20);
            this.txtP9gross.TabIndex = 9;
            this.txtP9gross.TextChanged += new System.EventHandler(this.txtP9gross_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(54, 1);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 15);
            this.label26.TabIndex = 9;
            this.label26.Text = "Address";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 15);
            this.label27.TabIndex = 8;
            this.label27.Text = "Gross";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // txtP9add
            // 
            this.txtP9add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP9add.Location = new System.Drawing.Point(69, 17);
            this.txtP9add.Multiline = true;
            this.txtP9add.Name = "txtP9add";
            this.txtP9add.Size = new System.Drawing.Size(25, 22);
            this.txtP9add.TabIndex = 8;
            this.txtP9add.TextChanged += new System.EventHandler(this.txtP9add_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.Controls.Add(this.rdP8motion);
            this.panel5.Controls.Add(this.txtP8gross);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txtP8Add);
            this.panel5.Location = new System.Drawing.Point(635, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 109);
            this.panel5.TabIndex = 14;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // rdP8motion
            // 
            this.rdP8motion.AutoSize = true;
            this.rdP8motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP8motion.Location = new System.Drawing.Point(4, 20);
            this.rdP8motion.Name = "rdP8motion";
            this.rdP8motion.Size = new System.Drawing.Size(65, 19);
            this.rdP8motion.TabIndex = 8;
            this.rdP8motion.TabStop = true;
            this.rdP8motion.Text = "Motion";
            this.rdP8motion.UseVisualStyleBackColor = true;
            this.rdP8motion.CheckedChanged += new System.EventHandler(this.rdP8motion_CheckedChanged);
            // 
            // txtP8gross
            // 
            this.txtP8gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP8gross.Location = new System.Drawing.Point(6, 64);
            this.txtP8gross.Multiline = true;
            this.txtP8gross.Name = "txtP8gross";
            this.txtP8gross.Size = new System.Drawing.Size(56, 20);
            this.txtP8gross.TabIndex = 9;
            this.txtP8gross.TextChanged += new System.EventHandler(this.txtP8gross_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Address";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Gross";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtP8Add
            // 
            this.txtP8Add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP8Add.Location = new System.Drawing.Point(69, 17);
            this.txtP8Add.Multiline = true;
            this.txtP8Add.Name = "txtP8Add";
            this.txtP8Add.Size = new System.Drawing.Size(25, 22);
            this.txtP8Add.TabIndex = 8;
            this.txtP8Add.TextChanged += new System.EventHandler(this.txtP8Add_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightBlue;
            this.panel6.Controls.Add(this.rdP7motion);
            this.panel6.Controls.Add(this.txtP7gross);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.txtP7Add);
            this.panel6.Location = new System.Drawing.Point(443, 209);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(151, 109);
            this.panel6.TabIndex = 13;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // rdP7motion
            // 
            this.rdP7motion.AutoSize = true;
            this.rdP7motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP7motion.Location = new System.Drawing.Point(4, 20);
            this.rdP7motion.Name = "rdP7motion";
            this.rdP7motion.Size = new System.Drawing.Size(65, 19);
            this.rdP7motion.TabIndex = 8;
            this.rdP7motion.TabStop = true;
            this.rdP7motion.Text = "Motion";
            this.rdP7motion.UseVisualStyleBackColor = true;
            this.rdP7motion.CheckedChanged += new System.EventHandler(this.rdP7motion_CheckedChanged);
            // 
            // txtP7gross
            // 
            this.txtP7gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP7gross.Location = new System.Drawing.Point(6, 64);
            this.txtP7gross.Multiline = true;
            this.txtP7gross.Name = "txtP7gross";
            this.txtP7gross.Size = new System.Drawing.Size(56, 20);
            this.txtP7gross.TabIndex = 9;
            this.txtP7gross.TextChanged += new System.EventHandler(this.txtP7gross_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Address";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Gross";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtP7Add
            // 
            this.txtP7Add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP7Add.Location = new System.Drawing.Point(69, 17);
            this.txtP7Add.Multiline = true;
            this.txtP7Add.Name = "txtP7Add";
            this.txtP7Add.Size = new System.Drawing.Size(25, 22);
            this.txtP7Add.TabIndex = 8;
            this.txtP7Add.TextChanged += new System.EventHandler(this.txtP7Add_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightBlue;
            this.panel7.Controls.Add(this.rdP6motion);
            this.panel7.Controls.Add(this.txtP6gross);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.txtP6add);
            this.panel7.Location = new System.Drawing.Point(260, 207);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(151, 109);
            this.panel7.TabIndex = 12;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // rdP6motion
            // 
            this.rdP6motion.AutoSize = true;
            this.rdP6motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP6motion.Location = new System.Drawing.Point(4, 20);
            this.rdP6motion.Name = "rdP6motion";
            this.rdP6motion.Size = new System.Drawing.Size(65, 19);
            this.rdP6motion.TabIndex = 8;
            this.rdP6motion.TabStop = true;
            this.rdP6motion.Text = "Motion";
            this.rdP6motion.UseVisualStyleBackColor = true;
            this.rdP6motion.CheckedChanged += new System.EventHandler(this.rdP6motion_CheckedChanged);
            // 
            // txtP6gross
            // 
            this.txtP6gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP6gross.Location = new System.Drawing.Point(6, 64);
            this.txtP6gross.Multiline = true;
            this.txtP6gross.Name = "txtP6gross";
            this.txtP6gross.Size = new System.Drawing.Size(56, 20);
            this.txtP6gross.TabIndex = 9;
            this.txtP6gross.TextChanged += new System.EventHandler(this.txtP6gross_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(54, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Address";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "Gross";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtP6add
            // 
            this.txtP6add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP6add.Location = new System.Drawing.Point(69, 17);
            this.txtP6add.Multiline = true;
            this.txtP6add.Name = "txtP6add";
            this.txtP6add.Size = new System.Drawing.Size(25, 22);
            this.txtP6add.TabIndex = 8;
            this.txtP6add.TextChanged += new System.EventHandler(this.txtP6add_TextChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightBlue;
            this.panel8.Controls.Add(this.rdP5motion);
            this.panel8.Controls.Add(this.txtP5gross);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.txtP5add);
            this.panel8.Location = new System.Drawing.Point(66, 207);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(151, 109);
            this.panel8.TabIndex = 11;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // rdP5motion
            // 
            this.rdP5motion.AutoSize = true;
            this.rdP5motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP5motion.Location = new System.Drawing.Point(4, 20);
            this.rdP5motion.Name = "rdP5motion";
            this.rdP5motion.Size = new System.Drawing.Size(65, 19);
            this.rdP5motion.TabIndex = 8;
            this.rdP5motion.TabStop = true;
            this.rdP5motion.Text = "Motion";
            this.rdP5motion.UseVisualStyleBackColor = true;
            this.rdP5motion.CheckedChanged += new System.EventHandler(this.rdP5motion_CheckedChanged);
            // 
            // txtP5gross
            // 
            this.txtP5gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP5gross.Location = new System.Drawing.Point(6, 64);
            this.txtP5gross.Multiline = true;
            this.txtP5gross.Name = "txtP5gross";
            this.txtP5gross.Size = new System.Drawing.Size(56, 20);
            this.txtP5gross.TabIndex = 9;
            this.txtP5gross.TextChanged += new System.EventHandler(this.txtP5gross_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(54, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = "Address";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "Gross";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txtP5add
            // 
            this.txtP5add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP5add.Location = new System.Drawing.Point(69, 17);
            this.txtP5add.Multiline = true;
            this.txtP5add.Name = "txtP5add";
            this.txtP5add.Size = new System.Drawing.Size(25, 22);
            this.txtP5add.TabIndex = 8;
            this.txtP5add.TextChanged += new System.EventHandler(this.txtP5add_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.rdP4motion);
            this.panel4.Controls.Add(this.txtP4Gross);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtP4add);
            this.panel4.Location = new System.Drawing.Point(635, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 109);
            this.panel4.TabIndex = 10;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // rdP4motion
            // 
            this.rdP4motion.AutoSize = true;
            this.rdP4motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP4motion.Location = new System.Drawing.Point(4, 20);
            this.rdP4motion.Name = "rdP4motion";
            this.rdP4motion.Size = new System.Drawing.Size(65, 19);
            this.rdP4motion.TabIndex = 8;
            this.rdP4motion.TabStop = true;
            this.rdP4motion.Text = "Motion";
            this.rdP4motion.UseVisualStyleBackColor = true;
            this.rdP4motion.CheckedChanged += new System.EventHandler(this.rdP4motion_CheckedChanged);
            // 
            // txtP4Gross
            // 
            this.txtP4Gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP4Gross.Location = new System.Drawing.Point(6, 64);
            this.txtP4Gross.Multiline = true;
            this.txtP4Gross.Name = "txtP4Gross";
            this.txtP4Gross.Size = new System.Drawing.Size(56, 20);
            this.txtP4Gross.TabIndex = 9;
            this.txtP4Gross.TextChanged += new System.EventHandler(this.txtP4Gross_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Address";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Gross";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtP4add
            // 
            this.txtP4add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP4add.Location = new System.Drawing.Point(69, 17);
            this.txtP4add.Multiline = true;
            this.txtP4add.Name = "txtP4add";
            this.txtP4add.Size = new System.Drawing.Size(25, 22);
            this.txtP4add.TabIndex = 8;
            this.txtP4add.TextChanged += new System.EventHandler(this.txtP4add_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.rdP3motion);
            this.panel3.Controls.Add(this.txtP3Gross);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtP3Add);
            this.panel3.Location = new System.Drawing.Point(443, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 109);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // rdP3motion
            // 
            this.rdP3motion.AutoSize = true;
            this.rdP3motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP3motion.Location = new System.Drawing.Point(4, 20);
            this.rdP3motion.Name = "rdP3motion";
            this.rdP3motion.Size = new System.Drawing.Size(65, 19);
            this.rdP3motion.TabIndex = 8;
            this.rdP3motion.TabStop = true;
            this.rdP3motion.Text = "Motion";
            this.rdP3motion.UseVisualStyleBackColor = true;
            this.rdP3motion.CheckedChanged += new System.EventHandler(this.rdP3motion_CheckedChanged);
            // 
            // txtP3Gross
            // 
            this.txtP3Gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP3Gross.Location = new System.Drawing.Point(6, 64);
            this.txtP3Gross.Multiline = true;
            this.txtP3Gross.Name = "txtP3Gross";
            this.txtP3Gross.Size = new System.Drawing.Size(56, 20);
            this.txtP3Gross.TabIndex = 9;
            this.txtP3Gross.TextChanged += new System.EventHandler(this.txtP3Gross_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Gross";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtP3Add
            // 
            this.txtP3Add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP3Add.Location = new System.Drawing.Point(69, 17);
            this.txtP3Add.Multiline = true;
            this.txtP3Add.Name = "txtP3Add";
            this.txtP3Add.Size = new System.Drawing.Size(25, 22);
            this.txtP3Add.TabIndex = 8;
            this.txtP3Add.TextChanged += new System.EventHandler(this.txtP3Add_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.rdP2motion);
            this.panel2.Controls.Add(this.txtP2gross);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtP2add);
            this.panel2.Location = new System.Drawing.Point(260, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 109);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rdP2motion
            // 
            this.rdP2motion.AutoSize = true;
            this.rdP2motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP2motion.Location = new System.Drawing.Point(4, 20);
            this.rdP2motion.Name = "rdP2motion";
            this.rdP2motion.Size = new System.Drawing.Size(65, 19);
            this.rdP2motion.TabIndex = 8;
            this.rdP2motion.TabStop = true;
            this.rdP2motion.Text = "Motion";
            this.rdP2motion.UseVisualStyleBackColor = true;
            this.rdP2motion.CheckedChanged += new System.EventHandler(this.rdP2motion_CheckedChanged);
            // 
            // txtP2gross
            // 
            this.txtP2gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP2gross.Location = new System.Drawing.Point(6, 64);
            this.txtP2gross.Multiline = true;
            this.txtP2gross.Name = "txtP2gross";
            this.txtP2gross.Size = new System.Drawing.Size(56, 20);
            this.txtP2gross.TabIndex = 9;
            this.txtP2gross.TextChanged += new System.EventHandler(this.txtP2gross_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gross";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtP2add
            // 
            this.txtP2add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtP2add.Location = new System.Drawing.Point(69, 17);
            this.txtP2add.Multiline = true;
            this.txtP2add.Name = "txtP2add";
            this.txtP2add.Size = new System.Drawing.Size(25, 22);
            this.txtP2add.TabIndex = 8;
            this.txtP2add.TextChanged += new System.EventHandler(this.txtP2add_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.rdP1motion);
            this.panel1.Controls.Add(this.txtVp1gross);
            this.panel1.Controls.Add(this.lblP1add);
            this.panel1.Controls.Add(this.lblP1gross);
            this.panel1.Controls.Add(this.txtVp1add);
            this.panel1.Location = new System.Drawing.Point(66, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 109);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rdP1motion
            // 
            this.rdP1motion.AutoSize = true;
            this.rdP1motion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdP1motion.Location = new System.Drawing.Point(4, 20);
            this.rdP1motion.Name = "rdP1motion";
            this.rdP1motion.Size = new System.Drawing.Size(65, 19);
            this.rdP1motion.TabIndex = 8;
            this.rdP1motion.TabStop = true;
            this.rdP1motion.Text = "Motion";
            this.rdP1motion.UseVisualStyleBackColor = true;
            this.rdP1motion.CheckedChanged += new System.EventHandler(this.rdP1motion_CheckedChanged);
            // 
            // txtVp1gross
            // 
            this.txtVp1gross.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtVp1gross.Location = new System.Drawing.Point(6, 64);
            this.txtVp1gross.Multiline = true;
            this.txtVp1gross.Name = "txtVp1gross";
            this.txtVp1gross.Size = new System.Drawing.Size(56, 20);
            this.txtVp1gross.TabIndex = 9;
            this.txtVp1gross.TextChanged += new System.EventHandler(this.txtVp1gross_TextChanged);
            // 
            // lblP1add
            // 
            this.lblP1add.AutoSize = true;
            this.lblP1add.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1add.Location = new System.Drawing.Point(54, 1);
            this.lblP1add.Name = "lblP1add";
            this.lblP1add.Size = new System.Drawing.Size(51, 15);
            this.lblP1add.TabIndex = 9;
            this.lblP1add.Text = "Address";
            this.lblP1add.Click += new System.EventHandler(this.lblP1add_Click);
            // 
            // lblP1gross
            // 
            this.lblP1gross.AutoSize = true;
            this.lblP1gross.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1gross.Location = new System.Drawing.Point(3, 48);
            this.lblP1gross.Name = "lblP1gross";
            this.lblP1gross.Size = new System.Drawing.Size(37, 15);
            this.lblP1gross.TabIndex = 8;
            this.lblP1gross.Text = "Gross";
            this.lblP1gross.Click += new System.EventHandler(this.lblP1gross_Click);
            // 
            // txtVp1add
            // 
            this.txtVp1add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtVp1add.Location = new System.Drawing.Point(69, 17);
            this.txtVp1add.Multiline = true;
            this.txtVp1add.Name = "txtVp1add";
            this.txtVp1add.Size = new System.Drawing.Size(25, 22);
            this.txtVp1add.TabIndex = 8;
            this.txtVp1add.TextChanged += new System.EventHandler(this.txtVp1add_TextChanged);
            // 
            // lblVerror
            // 
            this.lblVerror.AutoSize = true;
            this.lblVerror.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerror.Location = new System.Drawing.Point(425, 16);
            this.lblVerror.Name = "lblVerror";
            this.lblVerror.Size = new System.Drawing.Size(39, 15);
            this.lblVerror.TabIndex = 6;
            this.lblVerror.Text = "-Error";
            this.lblVerror.Click += new System.EventHandler(this.lblVerror_Click);
            // 
            // txtVerror
            // 
            this.txtVerror.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtVerror.Location = new System.Drawing.Point(370, 16);
            this.txtVerror.Multiline = true;
            this.txtVerror.Name = "txtVerror";
            this.txtVerror.Size = new System.Drawing.Size(55, 15);
            this.txtVerror.TabIndex = 5;
            this.txtVerror.TextChanged += new System.EventHandler(this.txtVerror_TextChanged);
            // 
            // lblVnotactive
            // 
            this.lblVnotactive.AutoSize = true;
            this.lblVnotactive.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVnotactive.Location = new System.Drawing.Point(272, 40);
            this.lblVnotactive.Name = "lblVnotactive";
            this.lblVnotactive.Size = new System.Drawing.Size(69, 15);
            this.lblVnotactive.TabIndex = 4;
            this.lblVnotactive.Text = "-Not Active";
            this.lblVnotactive.Click += new System.EventHandler(this.lblVnotactive_Click);
            // 
            // lblVactive
            // 
            this.lblVactive.AutoSize = true;
            this.lblVactive.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVactive.Location = new System.Drawing.Point(272, 18);
            this.lblVactive.Name = "lblVactive";
            this.lblVactive.Size = new System.Drawing.Size(45, 15);
            this.lblVactive.TabIndex = 3;
            this.lblVactive.Text = "-Active";
            this.lblVactive.Click += new System.EventHandler(this.lblVactive_Click);
            // 
            // txtVnotactive
            // 
            this.txtVnotactive.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtVnotactive.Location = new System.Drawing.Point(260, 43);
            this.txtVnotactive.Multiline = true;
            this.txtVnotactive.Name = "txtVnotactive";
            this.txtVnotactive.Size = new System.Drawing.Size(12, 10);
            this.txtVnotactive.TabIndex = 2;
            this.txtVnotactive.TextChanged += new System.EventHandler(this.txtVnotactive_TextChanged);
            // 
            // txtVactive
            // 
            this.txtVactive.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtVactive.Location = new System.Drawing.Point(260, 21);
            this.txtVactive.Multiline = true;
            this.txtVactive.Name = "txtVactive";
            this.txtVactive.Size = new System.Drawing.Size(12, 10);
            this.txtVactive.TabIndex = 1;
            this.txtVactive.TextChanged += new System.EventHandler(this.txtVactive_TextChanged);
            // 
            // pgGraph
            // 
            this.pgGraph.Controls.Add(this.panel13);
            this.pgGraph.Location = new System.Drawing.Point(4, 27);
            this.pgGraph.Name = "pgGraph";
            this.pgGraph.Size = new System.Drawing.Size(1288, 479);
            this.pgGraph.TabIndex = 4;
            this.pgGraph.Text = "Graph";
            this.pgGraph.UseVisualStyleBackColor = true;
            this.pgGraph.Click += new System.EventHandler(this.pgGraph_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.LightBlue;
            this.panel13.Controls.Add(this.chtGraphy);
            this.panel13.Controls.Add(this.chkGcursor);
            this.panel13.Controls.Add(this.lblGraphCursor);
            this.panel13.Controls.Add(this.btnGstart);
            this.panel13.Controls.Add(this.lblGnotes);
            this.panel13.Controls.Add(this.cboSeconds);
            this.panel13.Controls.Add(this.lblGweightUnit);
            this.panel13.Controls.Add(this.llbGbuffersize);
            this.panel13.Controls.Add(this.txtGweightunit);
            this.panel13.Location = new System.Drawing.Point(16, 15);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1161, 448);
            this.panel13.TabIndex = 7;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // chtGraphy
            // 
            this.chtGraphy.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            this.chtGraphy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtGraphy.Legends.Add(legend1);
            this.chtGraphy.Location = new System.Drawing.Point(35, 28);
            this.chtGraphy.Name = "chtGraphy";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "graphy";
            this.chtGraphy.Series.Add(series1);
            this.chtGraphy.Size = new System.Drawing.Size(1089, 327);
            this.chtGraphy.TabIndex = 10;
            this.chtGraphy.Text = "chart1";
            // 
            // chkGcursor
            // 
            this.chkGcursor.AutoSize = true;
            this.chkGcursor.Location = new System.Drawing.Point(344, 10);
            this.chkGcursor.Name = "chkGcursor";
            this.chkGcursor.Size = new System.Drawing.Size(15, 14);
            this.chkGcursor.TabIndex = 9;
            this.chkGcursor.UseVisualStyleBackColor = true;
            this.chkGcursor.CheckedChanged += new System.EventHandler(this.chkGcursor_CheckedChanged);
            // 
            // lblGraphCursor
            // 
            this.lblGraphCursor.AutoSize = true;
            this.lblGraphCursor.Location = new System.Drawing.Point(212, 7);
            this.lblGraphCursor.Name = "lblGraphCursor";
            this.lblGraphCursor.Size = new System.Drawing.Size(126, 18);
            this.lblGraphCursor.TabIndex = 7;
            this.lblGraphCursor.Text = "Cursor Coordinates";
            this.lblGraphCursor.Click += new System.EventHandler(this.lblGraphCursor_Click);
            // 
            // btnGstart
            // 
            this.btnGstart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGstart.Location = new System.Drawing.Point(611, 361);
            this.btnGstart.Name = "btnGstart";
            this.btnGstart.Size = new System.Drawing.Size(85, 26);
            this.btnGstart.TabIndex = 4;
            this.btnGstart.Text = "Start";
            this.btnGstart.UseVisualStyleBackColor = false;
            this.btnGstart.Click += new System.EventHandler(this.btnGstart_Click);
            // 
            // lblGnotes
            // 
            this.lblGnotes.AutoSize = true;
            this.lblGnotes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGnotes.Location = new System.Drawing.Point(12, 414);
            this.lblGnotes.Name = "lblGnotes";
            this.lblGnotes.Size = new System.Drawing.Size(328, 14);
            this.lblGnotes.TabIndex = 5;
            this.lblGnotes.Text = "Note: Manipulating the Graph requires minimum baud rate 9600.";
            this.lblGnotes.Click += new System.EventHandler(this.lblGnotes_Click);
            // 
            // cboSeconds
            // 
            this.cboSeconds.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboSeconds.FormattingEnabled = true;
            this.cboSeconds.Location = new System.Drawing.Point(482, 361);
            this.cboSeconds.Name = "cboSeconds";
            this.cboSeconds.Size = new System.Drawing.Size(121, 26);
            this.cboSeconds.TabIndex = 3;
            this.cboSeconds.SelectedIndexChanged += new System.EventHandler(this.cboSeconds_SelectedIndexChanged);
            // 
            // lblGweightUnit
            // 
            this.lblGweightUnit.AutoSize = true;
            this.lblGweightUnit.Location = new System.Drawing.Point(22, 366);
            this.lblGweightUnit.Name = "lblGweightUnit";
            this.lblGweightUnit.Size = new System.Drawing.Size(80, 18);
            this.lblGweightUnit.TabIndex = 0;
            this.lblGweightUnit.Text = "WeightUnit";
            this.lblGweightUnit.Click += new System.EventHandler(this.lblGweightUnit_Click);
            // 
            // llbGbuffersize
            // 
            this.llbGbuffersize.AutoSize = true;
            this.llbGbuffersize.Location = new System.Drawing.Point(402, 366);
            this.llbGbuffersize.Name = "llbGbuffersize";
            this.llbGbuffersize.Size = new System.Drawing.Size(74, 18);
            this.llbGbuffersize.TabIndex = 1;
            this.llbGbuffersize.Text = "Buffer Size";
            this.llbGbuffersize.Click += new System.EventHandler(this.llbGbuffersize_Click);
            // 
            // txtGweightunit
            // 
            this.txtGweightunit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGweightunit.Location = new System.Drawing.Point(108, 361);
            this.txtGweightunit.Name = "txtGweightunit";
            this.txtGweightunit.Size = new System.Drawing.Size(100, 26);
            this.txtGweightunit.TabIndex = 2;
            this.txtGweightunit.TextChanged += new System.EventHandler(this.txtGweightunit_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Location = new System.Drawing.Point(197, 190);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblCweight
            // 
            this.lblCweight.AutoSize = true;
            this.lblCweight.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCweight.Location = new System.Drawing.Point(138, 25);
            this.lblCweight.Name = "lblCweight";
            this.lblCweight.Size = new System.Drawing.Size(53, 18);
            this.lblCweight.TabIndex = 0;
            this.lblCweight.Text = "Weight";
            this.lblCweight.Click += new System.EventHandler(this.lblCweight_Click);
            // 
            // btnCalisave
            // 
            this.btnCalisave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalisave.Location = new System.Drawing.Point(197, 309);
            this.btnCalisave.Name = "btnCalisave";
            this.btnCalisave.Size = new System.Drawing.Size(75, 23);
            this.btnCalisave.TabIndex = 18;
            this.btnCalisave.Text = "Save";
            this.btnCalisave.UseVisualStyleBackColor = false;
            this.btnCalisave.Click += new System.EventHandler(this.btnCalisave_Click);
            // 
            // txtCweight
            // 
            this.txtCweight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCweight.Location = new System.Drawing.Point(197, 26);
            this.txtCweight.Multiline = true;
            this.txtCweight.Name = "txtCweight";
            this.txtCweight.Size = new System.Drawing.Size(81, 20);
            this.txtCweight.TabIndex = 1;
            this.txtCweight.TextChanged += new System.EventHandler(this.txtCweight_TextChanged);
            // 
            // txtCweightres
            // 
            this.txtCweightres.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCweightres.Location = new System.Drawing.Point(197, 271);
            this.txtCweightres.Name = "txtCweightres";
            this.txtCweightres.Size = new System.Drawing.Size(81, 20);
            this.txtCweightres.TabIndex = 17;
            this.txtCweightres.TextChanged += new System.EventHandler(this.txtCweightres_TextChanged);
            // 
            // lblCmv
            // 
            this.lblCmv.AutoSize = true;
            this.lblCmv.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmv.Location = new System.Drawing.Point(138, 68);
            this.lblCmv.Name = "lblCmv";
            this.lblCmv.Size = new System.Drawing.Size(43, 18);
            this.lblCmv.TabIndex = 2;
            this.lblCmv.Text = "mV/V";
            this.lblCmv.Click += new System.EventHandler(this.lblCmv_Click);
            // 
            // txtCweightunit
            // 
            this.txtCweightunit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCweightunit.Location = new System.Drawing.Point(197, 240);
            this.txtCweightunit.Name = "txtCweightunit";
            this.txtCweightunit.Size = new System.Drawing.Size(81, 20);
            this.txtCweightunit.TabIndex = 16;
            this.txtCweightunit.TextChanged += new System.EventHandler(this.txtCweightunit_TextChanged);
            // 
            // txtCmv
            // 
            this.txtCmv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCmv.Location = new System.Drawing.Point(197, 68);
            this.txtCmv.Multiline = true;
            this.txtCmv.Name = "txtCmv";
            this.txtCmv.Size = new System.Drawing.Size(81, 20);
            this.txtCmv.TabIndex = 3;
            this.txtCmv.TextChanged += new System.EventHandler(this.txtCmv_TextChanged);
            // 
            // lblCweightres
            // 
            this.lblCweightres.AutoSize = true;
            this.lblCweightres.Location = new System.Drawing.Point(64, 274);
            this.lblCweightres.Name = "lblCweightres";
            this.lblCweightres.Size = new System.Drawing.Size(108, 15);
            this.lblCweightres.TabIndex = 15;
            this.lblCweightres.Text = "Weight Resolution";
            this.lblCweightres.Click += new System.EventHandler(this.lblCweightres_Click);
            // 
            // btnCacquire
            // 
            this.btnCacquire.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCacquire.Location = new System.Drawing.Point(67, 136);
            this.btnCacquire.Name = "btnCacquire";
            this.btnCacquire.Size = new System.Drawing.Size(114, 23);
            this.btnCacquire.TabIndex = 4;
            this.btnCacquire.Text = "Aquire Deadload";
            this.btnCacquire.UseVisualStyleBackColor = false;
            this.btnCacquire.Click += new System.EventHandler(this.btnCacquire_Click);
            // 
            // lblCweightunit
            // 
            this.lblCweightunit.AutoSize = true;
            this.lblCweightunit.Location = new System.Drawing.Point(64, 247);
            this.lblCweightunit.Name = "lblCweightunit";
            this.lblCweightunit.Size = new System.Drawing.Size(73, 15);
            this.lblCweightunit.TabIndex = 14;
            this.lblCweightunit.Text = "Weight Unit";
            this.lblCweightunit.Click += new System.EventHandler(this.lblCweightunit_Click);
            // 
            // btnCAcspan
            // 
            this.btnCAcspan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCAcspan.Location = new System.Drawing.Point(67, 187);
            this.btnCAcspan.Name = "btnCAcspan";
            this.btnCAcspan.Size = new System.Drawing.Size(112, 23);
            this.btnCAcspan.TabIndex = 5;
            this.btnCAcspan.Text = "Acquire Span";
            this.btnCAcspan.UseVisualStyleBackColor = false;
            this.btnCAcspan.Click += new System.EventHandler(this.btnCAcspan_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Location = new System.Drawing.Point(307, 190);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(77, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblCweightlow
            // 
            this.lblCweightlow.AutoSize = true;
            this.lblCweightlow.Location = new System.Drawing.Point(194, 119);
            this.lblCweightlow.Name = "lblCweightlow";
            this.lblCweightlow.Size = new System.Drawing.Size(73, 15);
            this.lblCweightlow.TabIndex = 6;
            this.lblCweightlow.Text = "Weight Low";
            this.lblCweightlow.Click += new System.EventHandler(this.lblCweightlow_Click);
            // 
            // lblCmvv
            // 
            this.lblCmvv.AutoSize = true;
            this.lblCmvv.Location = new System.Drawing.Point(304, 119);
            this.lblCmvv.Name = "lblCmvv";
            this.lblCmvv.Size = new System.Drawing.Size(65, 15);
            this.lblCmvv.TabIndex = 7;
            this.lblCmvv.Text = "mV/V Low";
            this.lblCmvv.Click += new System.EventHandler(this.lblCmvv_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(307, 139);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblCweighthigh
            // 
            this.lblCweighthigh.AutoSize = true;
            this.lblCweighthigh.Location = new System.Drawing.Point(194, 171);
            this.lblCweighthigh.Name = "lblCweighthigh";
            this.lblCweighthigh.Size = new System.Drawing.Size(74, 15);
            this.lblCweighthigh.TabIndex = 8;
            this.lblCweighthigh.Text = "Weight High";
            this.lblCweighthigh.Click += new System.EventHandler(this.lblCweighthigh_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(197, 139);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblCmvvhigh
            // 
            this.lblCmvvhigh.AutoSize = true;
            this.lblCmvvhigh.Location = new System.Drawing.Point(304, 171);
            this.lblCmvvhigh.Name = "lblCmvvhigh";
            this.lblCmvvhigh.Size = new System.Drawing.Size(66, 15);
            this.lblCmvvhigh.TabIndex = 9;
            this.lblCmvvhigh.Text = "mV/V High";
            this.lblCmvvhigh.Click += new System.EventHandler(this.lblCmvvhigh_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(572, 35);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(97, 19);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "Temperature";
            this.lblTemp.Click += new System.EventHandler(this.lblTemp_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(666, 34);
            this.txtTemp.Multiline = true;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(103, 22);
            this.txtTemp.TabIndex = 5;
            this.txtTemp.TextChanged += new System.EventHandler(this.txtTemp_TextChanged);
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(772, 32);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(21, 25);
            this.lblDegree.TabIndex = 6;
            this.lblDegree.Text = "°";
            this.lblDegree.Click += new System.EventHandler(this.lblDegree_Click);
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(788, 37);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(18, 16);
            this.lblCel.TabIndex = 7;
            this.lblCel.Text = "C";
            this.lblCel.Click += new System.EventHandler(this.lblCel_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(830, 29);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(92, 39);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // picSyrma
            // 
            this.picSyrma.Image = ((System.Drawing.Image)(resources.GetObject("picSyrma.Image")));
            this.picSyrma.Location = new System.Drawing.Point(1152, 27);
            this.picSyrma.Name = "picSyrma";
            this.picSyrma.Size = new System.Drawing.Size(124, 58);
            this.picSyrma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSyrma.TabIndex = 1;
            this.picSyrma.TabStop = false;
            this.picSyrma.Click += new System.EventHandler(this.picSyrma_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(-3, 35);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblActiveadd
            // 
            this.lblActiveadd.AutoSize = true;
            this.lblActiveadd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveadd.Location = new System.Drawing.Point(393, 35);
            this.lblActiveadd.Name = "lblActiveadd";
            this.lblActiveadd.Size = new System.Drawing.Size(109, 19);
            this.lblActiveadd.TabIndex = 9;
            this.lblActiveadd.Text = "Active Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1283, 573);
            this.Controls.Add(this.lblActiveadd);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.picSyrma);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.cboAddress);
            this.Controls.Add(this.vpgMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.vpgMenu.ResumeLayout(false);
            this.vpgMenu.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.pgWeighing.ResumeLayout(false);
            this.pgWeighing.PerformLayout();
            this.grbWStatusError.ResumeLayout(false);
            this.grbWStatusError.PerformLayout();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.grbWPccommunication.ResumeLayout(false);
            this.grbWPccommunication.PerformLayout();
            this.grbWWeighingandOperation.ResumeLayout(false);
            this.grbWWeighingandOperation.PerformLayout();
            this.grbWWeight.ResumeLayout(false);
            this.grbWWeight.PerformLayout();
            this.grbWAdditional.ResumeLayout(false);
            this.grbWAdditional.PerformLayout();
            this.pgLoadcell.ResumeLayout(false);
            this.pgLoadcell.PerformLayout();
            this.grpLNotes.ResumeLayout(false);
            this.grpLNotes.PerformLayout();
            this.tbWeightfilter.ResumeLayout(false);
            this.tbWeightformat.ResumeLayout(false);
            this.tbWeightformat.PerformLayout();
            this.grpTare.ResumeLayout(false);
            this.grpTare.PerformLayout();
            this.grpMeasure.ResumeLayout(false);
            this.grpMeasure.PerformLayout();
            this.tbFilters.ResumeLayout(false);
            this.tbFilters.PerformLayout();
            this.grpMeasuring.ResumeLayout(false);
            this.grpMeasuring.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pgCalibration.ResumeLayout(false);
            this.pnlCalibration.ResumeLayout(false);
            this.pnlCalibration.PerformLayout();
            this.grpCalipro.ResumeLayout(false);
            this.grpCalipro.PerformLayout();
            this.pgView.ResumeLayout(false);
            this.pgView.PerformLayout();
            this.grpVnotes.ResumeLayout(false);
            this.grpVnotes.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pgGraph.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraphy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSyrma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip vpgMenu;
        private System.Windows.Forms.ToolStripMenuItem tlLogfile;
        private System.Windows.Forms.ToolStripMenuItem tlAbout;
        private System.Windows.Forms.ToolStripMenuItem tlEdit;
        private System.Windows.Forms.ComboBox cboAddress;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage pgWeighing;
        private System.Windows.Forms.TabPage pgLoadcell;
        private System.Windows.Forms.TabPage pgView;
        private System.Windows.Forms.TabPage pgGraph;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox picSyrma;
        private System.Windows.Forms.TabControl tbWeightfilter;
        private System.Windows.Forms.TabPage tbWeightformat;
        private System.Windows.Forms.TabPage tbFilters;
        private System.Windows.Forms.Label lblGrab;
        private System.Windows.Forms.Label lblkg;
        private System.Windows.Forms.TextBox txtWeightkg;
        private System.Windows.Forms.Label lblRecursive;
        private System.Windows.Forms.Label lblFir;
        private System.Windows.Forms.Label lblFiltertype;
        private System.Windows.Forms.Label lblFiltering;
        private System.Windows.Forms.TextBox txtHysteresis;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.ComboBox cboTrigger;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Label lblTrigger;
        private System.Windows.Forms.Label lblHysteresis;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNo2level;
        private System.Windows.Forms.Label lblNo2Hysteresis;
        private System.Windows.Forms.Label lblNo2source;
        private System.Windows.Forms.Label lblNo1Hysteresis;
        private System.Windows.Forms.Label lblNo1level;
        private System.Windows.Forms.Label lblNo1source;
        private System.Windows.Forms.Label lblSetpoints;
        private System.Windows.Forms.ComboBox cboFir;
        private System.Windows.Forms.ComboBox cboRecursive;
        private System.Windows.Forms.ComboBox cboFiltertype;
        private System.Windows.Forms.GroupBox grpMeasuring;
        private System.Windows.Forms.ComboBox cboPeak;
        private System.Windows.Forms.ComboBox cboMeasure;
        private System.Windows.Forms.Label lblPeaktrough;
        private System.Windows.Forms.Label lblPeak;
        private System.Windows.Forms.Label lblMeasurate;
        private System.Windows.Forms.TextBox txtNo4hysteresis;
        private System.Windows.Forms.TextBox txtNo4level;
        private System.Windows.Forms.TextBox txtNo3hysteresis;
        private System.Windows.Forms.TextBox txtNo3level;
        private System.Windows.Forms.TextBox txtNo2hysteresis;
        private System.Windows.Forms.TextBox txtNo2level;
        private System.Windows.Forms.TextBox txtNo1hysteresis;
        private System.Windows.Forms.TextBox txtNo1level;
        private System.Windows.Forms.ComboBox cboNo4source;
        private System.Windows.Forms.ComboBox cboNo3source;
        private System.Windows.Forms.ComboBox cboNo2source;
        private System.Windows.Forms.ComboBox cboSource;
        private System.Windows.Forms.Label lblNo4level;
        private System.Windows.Forms.Label lblNo4hysteresis;
        private System.Windows.Forms.Label lblNo3source;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblNo4source;
        private System.Windows.Forms.Label lblNo3level;
        private System.Windows.Forms.Label lblNo3hysteresis;
        private System.Windows.Forms.Label lblMax2per;
        private System.Windows.Forms.Label lblHysteresisweightunit;
        private System.Windows.Forms.Label lblWeightunit;
        private System.Windows.Forms.Label lblMilli;
        private System.Windows.Forms.TabPage pgCalibration;
        private System.Windows.Forms.Label lblweightkg;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtFixedtare;
        private System.Windows.Forms.Label lblFixedtare;
        private System.Windows.Forms.Label lblTare;
        private System.Windows.Forms.ComboBox cboZtrack;
        private System.Windows.Forms.TextBox txtZtrackperiod;
        private System.Windows.Forms.TextBox txtZtrackband;
        private System.Windows.Forms.TextBox txtPOZB;
        private System.Windows.Forms.ComboBox cboPOZ;
        private System.Windows.Forms.Label lblZtrackperiod;
        private System.Windows.Forms.Label lblZtrackband;
        private System.Windows.Forms.Label lblZtrack;
        private System.Windows.Forms.Label lblPOZB;
        private System.Windows.Forms.Label lblPOZ;
        private System.Windows.Forms.Label lblZero;
        private System.Windows.Forms.TextBox txtMotiondetectperiod;
        private System.Windows.Forms.TextBox txtMotiondetectband;
        private System.Windows.Forms.ComboBox cboMotionDetect;
        private System.Windows.Forms.Label lblMotiondetectperiod;
        private System.Windows.Forms.Label lblMotiondetectband;
        private System.Windows.Forms.Label lblMotionDetect;
        private System.Windows.Forms.Label lblMotion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboWeightunit;
        private System.Windows.Forms.Label lblWeightres;
        private System.Windows.Forms.Label lblWeightuni;
        private System.Windows.Forms.Label lblWeightformat;
        private System.Windows.Forms.GroupBox grpTare;
        private System.Windows.Forms.Label lblTraegroup;
        private System.Windows.Forms.GroupBox grpMeasure;
        private System.Windows.Forms.Label lblPeriodbandtare;
        private System.Windows.Forms.Label lblWNotActive;
        private System.Windows.Forms.Label lblWReady;
        private System.Windows.Forms.GroupBox grbWWeighingandOperation;
        private System.Windows.Forms.GroupBox grbWWeight;
        private System.Windows.Forms.GroupBox grbWAdditional;
        private System.Windows.Forms.Button btnWTare;
        private System.Windows.Forms.Button btnWZero;
        private System.Windows.Forms.TextBox txtWWeight;
        private System.Windows.Forms.Label lblWKg;
        private System.Windows.Forms.TextBox txtWGrab;
        private System.Windows.Forms.TextBox txtWmV;
        private System.Windows.Forms.TextBox txtWPeak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWGrab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWResetPeak;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.CheckBox chkWInput4;
        private System.Windows.Forms.CheckBox chkWInput3;
        private System.Windows.Forms.CheckBox chkWInput2;
        private System.Windows.Forms.CheckBox chkWSet4;
        private System.Windows.Forms.CheckBox chKWSet3;
        private System.Windows.Forms.CheckBox chkWSet2;
        private System.Windows.Forms.CheckBox chkWSet1;
        private System.Windows.Forms.CheckBox chkWInput1;
        private System.Windows.Forms.Label lblWInput4;
        private System.Windows.Forms.Label lblWInput3;
        private System.Windows.Forms.Label lblWInput2;
        private System.Windows.Forms.Label lblWSet4;
        private System.Windows.Forms.Label lblWSet3;
        private System.Windows.Forms.Label lblWSet2;
        private System.Windows.Forms.Label lblWSetpoint;
        private System.Windows.Forms.Label lblWInput1;
        private System.Windows.Forms.GroupBox grbWPccommunication;
        private System.Windows.Forms.ComboBox cboWStopBits;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.ComboBox cboWDataBits;
        private System.Windows.Forms.ComboBox cboPortNumber;
        private System.Windows.Forms.Label lblWParity;
        private System.Windows.Forms.Label lablWBaud;
        private System.Windows.Forms.Label lblWDataBits;
        private System.Windows.Forms.Label lblWStopBit;
        private System.Windows.Forms.Label lblPortNumber;
        private System.Windows.Forms.Button btnWResetDevice;
        private System.Windows.Forms.Label lblWZeroTracking;
        private System.Windows.Forms.Label lblWMotion;
        private System.Windows.Forms.Label lblWNet;
        private System.Windows.Forms.Label lblWGross;
        private System.Windows.Forms.Label lblWActive;
        private System.Windows.Forms.CheckBox chkWzeroTracking;
        private System.Windows.Forms.CheckBox chkWMotion;
        private System.Windows.Forms.CheckBox chkWNet;
        private System.Windows.Forms.CheckBox chkWGross;
        private System.Windows.Forms.CheckBox chKWReady;
        private System.Windows.Forms.CheckBox chkWActive2;
        private System.Windows.Forms.CheckBox chkWActive;
        private System.Windows.Forms.CheckBox chkWNotActive2;
        private System.Windows.Forms.CheckBox chkWNotActive;
        private System.Windows.Forms.GroupBox grbWStatusError;
        private System.Windows.Forms.CheckBox chkWOvertemperature;
        private System.Windows.Forms.CheckBox chkWNonVolatile;
        private System.Windows.Forms.CheckBox chkWVolatile;
        private System.Windows.Forms.CheckBox chkWNoUser;
        private System.Windows.Forms.CheckBox chkWInvaild;
        private System.Windows.Forms.CheckBox chkWatchDot;
        private System.Windows.Forms.CheckBox chkUnderTemp;
        private System.Windows.Forms.CheckBox chkLoadcelloverload;
        private System.Windows.Forms.CheckBox chkWEprom;
        private System.Windows.Forms.Label lblWNouser;
        private System.Windows.Forms.Label lblWInvalid;
        private System.Windows.Forms.Label lblWWatch;
        private System.Windows.Forms.Label lblWUnder;
        private System.Windows.Forms.Label lblWLoad;
        private System.Windows.Forms.Label lblWOver;
        private System.Windows.Forms.Label lblWNonVolatile;
        private System.Windows.Forms.Label lblWVolatile;
        private System.Windows.Forms.Label lblWEprom;
        private System.Windows.Forms.GroupBox grpCalipro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalisave;
        private System.Windows.Forms.TextBox txtCweightres;
        private System.Windows.Forms.TextBox txtCweightunit;
        private System.Windows.Forms.Label lblCweightres;
        private System.Windows.Forms.Label lblCweightunit;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCmvvhigh;
        private System.Windows.Forms.Label lblCweighthigh;
        private System.Windows.Forms.Label lblCmvv;
        private System.Windows.Forms.Label lblCweightlow;
        private System.Windows.Forms.Button btnCAcspan;
        private System.Windows.Forms.Button btnCacquire;
        private System.Windows.Forms.TextBox txtCmv;
        private System.Windows.Forms.Label lblCmv;
        private System.Windows.Forms.TextBox txtCweight;
        private System.Windows.Forms.Label lblCweight;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdP4motion;
        private System.Windows.Forms.TextBox txtP4Gross;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtP4add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdP3motion;
        private System.Windows.Forms.TextBox txtP3Gross;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtP3Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdP2motion;
        private System.Windows.Forms.TextBox txtP2gross;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtP2add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdP1motion;
        private System.Windows.Forms.TextBox txtVp1gross;
        private System.Windows.Forms.Label lblP1add;
        private System.Windows.Forms.Label lblP1gross;
        private System.Windows.Forms.TextBox txtVp1add;
        private System.Windows.Forms.Label lblVerror;
        private System.Windows.Forms.TextBox txtVerror;
        private System.Windows.Forms.Label lblVnotactive;
        private System.Windows.Forms.Label lblVactive;
        private System.Windows.Forms.TextBox txtVnotactive;
        private System.Windows.Forms.TextBox txtVactive;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton rdP12;
        private System.Windows.Forms.TextBox txtP12gross;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtP12Add;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton rdP11motion;
        private System.Windows.Forms.TextBox txtP11gross;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtP11Add;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton rdP10motion;
        private System.Windows.Forms.TextBox txtP10gross;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtP10add;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton rdP9motion;
        private System.Windows.Forms.TextBox txtP9gross;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtP9add;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdP8motion;
        private System.Windows.Forms.TextBox txtP8gross;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtP8Add;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdP7motion;
        private System.Windows.Forms.TextBox txtP7gross;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtP7Add;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rdP6motion;
        private System.Windows.Forms.TextBox txtP6gross;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtP6add;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton rdP5motion;
        private System.Windows.Forms.TextBox txtP5gross;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtP5add;
        private System.Windows.Forms.GroupBox grpVnotes;
        private System.Windows.Forms.Label lblVnotes;
        private System.Windows.Forms.GroupBox grpLNotes;
        private System.Windows.Forms.Label lblLNotes;
        private System.Windows.Forms.Button btnLsavetodevice;
        private System.Windows.Forms.Button btnLsavetofile;
        private System.Windows.Forms.Button btnLuploadfromfile;
        private System.Windows.Forms.Button btnLdownloadtodevie;
        private System.Windows.Forms.Button btnLupload;
        private System.Windows.Forms.Button btnFinddevice;
        private System.Windows.Forms.Label lblGnotes;
        private System.Windows.Forms.Button btnGstart;
        private System.Windows.Forms.ComboBox cboSeconds;
        private System.Windows.Forms.TextBox txtGweightunit;
        private System.Windows.Forms.Label llbGbuffersize;
        private System.Windows.Forms.Label lblGweightUnit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraph;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.CheckBox chkGcursor;
        private System.Windows.Forms.Label lblGraphCursor;
        private System.IO.Ports.SerialPort VPGSerialPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnIndicator;
        private System.Windows.Forms.Label lblActiveadd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraphy;
        private System.Windows.Forms.Panel pnlCalibration;
        private System.Windows.Forms.Button btnSavecali;
        private System.Windows.Forms.TextBox txtWeightresolution;
        private System.Windows.Forms.Label lblWeightResolution;
        private System.Windows.Forms.TextBox txtWeightunit;
        private System.Windows.Forms.Label lblWeightunitcali;
        private System.Windows.Forms.Button btnAcquirespan;
        private System.Windows.Forms.Label lblmVVHighcali;
        private System.Windows.Forms.TextBox txtmVVHighcali;
        private System.Windows.Forms.Label lblmMVlowCali;
        private System.Windows.Forms.TextBox txtmvVLowcali;
        private System.Windows.Forms.Label lblCaliweighthigh;
        private System.Windows.Forms.TextBox txtWeightHighcali;
        private System.Windows.Forms.Label lblWeightLowcali;
        private System.Windows.Forms.TextBox txtCaliWeightLow;
        private System.Windows.Forms.Button btnAcquirecali;
        private System.Windows.Forms.TextBox txtmVCali;
        private System.Windows.Forms.Label lblmMvCali;
        private System.Windows.Forms.TextBox txtWcali;
        private System.Windows.Forms.Label lblCweighty;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblFloating;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkfastfilter;
        private System.Windows.Forms.Label lblFastfilter;
        private System.Windows.Forms.CheckBox chkStandardfilter;
        private System.Windows.Forms.Label lblStandardFilter;
        private System.Windows.Forms.Label lblFilterMode;
    }
}

