
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
            this.vpgMenu = new System.Windows.Forms.MenuStrip();
            this.tlLogfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tlAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tlEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboAddress = new System.Windows.Forms.ComboBox();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.pgWeighing = new System.Windows.Forms.TabPage();
            this.pgLoadcell = new System.Windows.Forms.TabPage();
            this.pnlWeightkg = new System.Windows.Forms.Panel();
            this.lblweightkg = new System.Windows.Forms.Label();
            this.lblkg = new System.Windows.Forms.Label();
            this.txtWeightkg = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbWeightformat = new System.Windows.Forms.TabPage();
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
            this.pgView = new System.Windows.Forms.TabPage();
            this.pgGraph = new System.Windows.Forms.TabPage();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.picSyrma = new System.Windows.Forms.PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.pgCalibration = new System.Windows.Forms.TabPage();
            this.vpgMenu.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.pgLoadcell.SuspendLayout();
            this.pnlWeightkg.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbFilters.SuspendLayout();
            this.grpMeasuring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSyrma)).BeginInit();
            this.pnlAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // vpgMenu
            // 
            this.vpgMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlLogfile,
            this.tlAbout,
            this.tlEdit});
            this.vpgMenu.Location = new System.Drawing.Point(0, 0);
            this.vpgMenu.Name = "vpgMenu";
            this.vpgMenu.Size = new System.Drawing.Size(800, 24);
            this.vpgMenu.TabIndex = 0;
            this.vpgMenu.Text = "Log File";
            // 
            // tlLogfile
            // 
            this.tlLogfile.Name = "tlLogfile";
            this.tlLogfile.Size = new System.Drawing.Size(60, 20);
            this.tlLogfile.Text = "Log File";
            // 
            // tlAbout
            // 
            this.tlAbout.Name = "tlAbout";
            this.tlAbout.Size = new System.Drawing.Size(52, 20);
            this.tlAbout.Text = "About";
            // 
            // tlEdit
            // 
            this.tlEdit.Name = "tlEdit";
            this.tlEdit.Size = new System.Drawing.Size(39, 20);
            this.tlEdit.Text = "Edit";
            // 
            // cboAddress
            // 
            this.cboAddress.FormattingEnabled = true;
            this.cboAddress.Location = new System.Drawing.Point(335, 32);
            this.cboAddress.Name = "cboAddress";
            this.cboAddress.Size = new System.Drawing.Size(40, 21);
            this.cboAddress.TabIndex = 2;
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
            this.tbControl.Size = new System.Drawing.Size(760, 497);
            this.tbControl.TabIndex = 3;
            // 
            // pgWeighing
            // 
            this.pgWeighing.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgWeighing.Location = new System.Drawing.Point(4, 27);
            this.pgWeighing.Name = "pgWeighing";
            this.pgWeighing.Padding = new System.Windows.Forms.Padding(3);
            this.pgWeighing.Size = new System.Drawing.Size(752, 466);
            this.pgWeighing.TabIndex = 0;
            this.pgWeighing.Text = "Weighing Display & Status";
            this.pgWeighing.UseVisualStyleBackColor = true;
            this.pgWeighing.Click += new System.EventHandler(this.pgWeighing_Click);
            // 
            // pgLoadcell
            // 
            this.pgLoadcell.Controls.Add(this.pnlWeightkg);
            this.pgLoadcell.Controls.Add(this.lblkg);
            this.pgLoadcell.Controls.Add(this.txtWeightkg);
            this.pgLoadcell.Controls.Add(this.tabControl1);
            this.pgLoadcell.Location = new System.Drawing.Point(4, 27);
            this.pgLoadcell.Name = "pgLoadcell";
            this.pgLoadcell.Padding = new System.Windows.Forms.Padding(3);
            this.pgLoadcell.Size = new System.Drawing.Size(752, 466);
            this.pgLoadcell.TabIndex = 1;
            this.pgLoadcell.Text = "LoadCell Setup";
            this.pgLoadcell.UseVisualStyleBackColor = true;
            // 
            // pnlWeightkg
            // 
            this.pnlWeightkg.Controls.Add(this.lblweightkg);
            this.pnlWeightkg.Location = new System.Drawing.Point(205, 5);
            this.pnlWeightkg.Name = "pnlWeightkg";
            this.pnlWeightkg.Size = new System.Drawing.Size(89, 28);
            this.pnlWeightkg.TabIndex = 15;
            // 
            // lblweightkg
            // 
            this.lblweightkg.AutoSize = true;
            this.lblweightkg.Location = new System.Drawing.Point(32, 4);
            this.lblweightkg.Name = "lblweightkg";
            this.lblweightkg.Size = new System.Drawing.Size(53, 18);
            this.lblweightkg.TabIndex = 15;
            this.lblweightkg.Text = "Weight";
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Location = new System.Drawing.Point(379, 7);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(22, 18);
            this.lblkg.TabIndex = 3;
            this.lblkg.Text = "kg";
            // 
            // txtWeightkg
            // 
            this.txtWeightkg.Location = new System.Drawing.Point(295, 5);
            this.txtWeightkg.Name = "txtWeightkg";
            this.txtWeightkg.Size = new System.Drawing.Size(84, 26);
            this.txtWeightkg.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbWeightformat);
            this.tabControl1.Controls.Add(this.tbFilters);
            this.tabControl1.Location = new System.Drawing.Point(24, 39);
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
            this.tbFilters.Size = new System.Drawing.Size(550, 389);
            this.tbFilters.TabIndex = 1;
            this.tbFilters.Text = "Filters/Peak/Grab/Setpoints";
            this.tbFilters.UseVisualStyleBackColor = true;
            // 
            // grpMeasuring
            // 
            this.grpMeasuring.Controls.Add(this.lblMax2per);
            this.grpMeasuring.Controls.Add(this.lblHysteresisweightunit);
            this.grpMeasuring.Controls.Add(this.lblWeightunit);
            this.grpMeasuring.Controls.Add(this.lblMilli);
            this.grpMeasuring.Location = new System.Drawing.Point(366, 236);
            this.grpMeasuring.Name = "grpMeasuring";
            this.grpMeasuring.Size = new System.Drawing.Size(173, 108);
            this.grpMeasuring.TabIndex = 43;
            this.grpMeasuring.TabStop = false;
            this.grpMeasuring.Text = "Measuring Units";
            // 
            // lblMax2per
            // 
            this.lblMax2per.AutoSize = true;
            this.lblMax2per.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax2per.Location = new System.Drawing.Point(6, 73);
            this.lblMax2per.Name = "lblMax2per";
            this.lblMax2per.Size = new System.Drawing.Size(147, 15);
            this.lblMax2per.TabIndex = 0;
            this.lblMax2per.Text = "maximum 2% of full scale.";
            // 
            // lblHysteresisweightunit
            // 
            this.lblHysteresisweightunit.AutoSize = true;
            this.lblHysteresisweightunit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHysteresisweightunit.Location = new System.Drawing.Point(6, 57);
            this.lblHysteresisweightunit.Name = "lblHysteresisweightunit";
            this.lblHysteresisweightunit.Size = new System.Drawing.Size(155, 15);
            this.lblHysteresisweightunit.TabIndex = 0;
            this.lblHysteresisweightunit.Text = "Hysteresis - In Weight Unit.";
            // 
            // lblWeightunit
            // 
            this.lblWeightunit.AutoSize = true;
            this.lblWeightunit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightunit.Location = new System.Drawing.Point(6, 40);
            this.lblWeightunit.Name = "lblWeightunit";
            this.lblWeightunit.Size = new System.Drawing.Size(125, 15);
            this.lblWeightunit.TabIndex = 0;
            this.lblWeightunit.Text = "Level- In Weight Unit.";
            // 
            // lblMilli
            // 
            this.lblMilli.AutoSize = true;
            this.lblMilli.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilli.Location = new System.Drawing.Point(6, 23);
            this.lblMilli.Name = "lblMilli";
            this.lblMilli.Size = new System.Drawing.Size(123, 15);
            this.lblMilli.TabIndex = 0;
            this.lblMilli.Text = "Delay-In milliseconds.";
            // 
            // cboPeak
            // 
            this.cboPeak.FormattingEnabled = true;
            this.cboPeak.Location = new System.Drawing.Point(460, 113);
            this.cboPeak.Name = "cboPeak";
            this.cboPeak.Size = new System.Drawing.Size(82, 26);
            this.cboPeak.TabIndex = 42;
            // 
            // cboMeasure
            // 
            this.cboMeasure.FormattingEnabled = true;
            this.cboMeasure.Location = new System.Drawing.Point(460, 31);
            this.cboMeasure.Name = "cboMeasure";
            this.cboMeasure.Size = new System.Drawing.Size(82, 26);
            this.cboMeasure.TabIndex = 41;
            // 
            // lblPeaktrough
            // 
            this.lblPeaktrough.AutoSize = true;
            this.lblPeaktrough.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeaktrough.Location = new System.Drawing.Point(366, 113);
            this.lblPeaktrough.Name = "lblPeaktrough";
            this.lblPeaktrough.Size = new System.Drawing.Size(76, 30);
            this.lblPeaktrough.TabIndex = 40;
            this.lblPeaktrough.Text = "Peak Trough \r\nSource";
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeak.Location = new System.Drawing.Point(366, 85);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(38, 18);
            this.lblPeak.TabIndex = 39;
            this.lblPeak.Text = "Peak";
            // 
            // lblMeasurate
            // 
            this.lblMeasurate.AutoSize = true;
            this.lblMeasurate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasurate.Location = new System.Drawing.Point(366, 31);
            this.lblMeasurate.Name = "lblMeasurate";
            this.lblMeasurate.Size = new System.Drawing.Size(88, 30);
            this.lblMeasurate.TabIndex = 38;
            this.lblMeasurate.Text = "Measurement \r\nRate";
            // 
            // txtNo4hysteresis
            // 
            this.txtNo4hysteresis.Location = new System.Drawing.Point(276, 340);
            this.txtNo4hysteresis.Multiline = true;
            this.txtNo4hysteresis.Name = "txtNo4hysteresis";
            this.txtNo4hysteresis.Size = new System.Drawing.Size(84, 20);
            this.txtNo4hysteresis.TabIndex = 37;
            // 
            // txtNo4level
            // 
            this.txtNo4level.Location = new System.Drawing.Point(276, 316);
            this.txtNo4level.Multiline = true;
            this.txtNo4level.Name = "txtNo4level";
            this.txtNo4level.Size = new System.Drawing.Size(84, 20);
            this.txtNo4level.TabIndex = 36;
            // 
            // txtNo3hysteresis
            // 
            this.txtNo3hysteresis.Location = new System.Drawing.Point(276, 255);
            this.txtNo3hysteresis.Multiline = true;
            this.txtNo3hysteresis.Name = "txtNo3hysteresis";
            this.txtNo3hysteresis.Size = new System.Drawing.Size(84, 20);
            this.txtNo3hysteresis.TabIndex = 35;
            // 
            // txtNo3level
            // 
            this.txtNo3level.Location = new System.Drawing.Point(276, 230);
            this.txtNo3level.Multiline = true;
            this.txtNo3level.Name = "txtNo3level";
            this.txtNo3level.Size = new System.Drawing.Size(84, 20);
            this.txtNo3level.TabIndex = 34;
            // 
            // txtNo2hysteresis
            // 
            this.txtNo2hysteresis.Location = new System.Drawing.Point(276, 171);
            this.txtNo2hysteresis.Multiline = true;
            this.txtNo2hysteresis.Name = "txtNo2hysteresis";
            this.txtNo2hysteresis.Size = new System.Drawing.Size(84, 20);
            this.txtNo2hysteresis.TabIndex = 33;
            // 
            // txtNo2level
            // 
            this.txtNo2level.Location = new System.Drawing.Point(276, 147);
            this.txtNo2level.Multiline = true;
            this.txtNo2level.Name = "txtNo2level";
            this.txtNo2level.Size = new System.Drawing.Size(84, 20);
            this.txtNo2level.TabIndex = 32;
            // 
            // txtNo1hysteresis
            // 
            this.txtNo1hysteresis.Location = new System.Drawing.Point(276, 89);
            this.txtNo1hysteresis.Multiline = true;
            this.txtNo1hysteresis.Name = "txtNo1hysteresis";
            this.txtNo1hysteresis.Size = new System.Drawing.Size(84, 20);
            this.txtNo1hysteresis.TabIndex = 31;
            // 
            // txtNo1level
            // 
            this.txtNo1level.Location = new System.Drawing.Point(276, 63);
            this.txtNo1level.Multiline = true;
            this.txtNo1level.Name = "txtNo1level";
            this.txtNo1level.Size = new System.Drawing.Size(84, 20);
            this.txtNo1level.TabIndex = 30;
            // 
            // cboNo4source
            // 
            this.cboNo4source.FormattingEnabled = true;
            this.cboNo4source.Location = new System.Drawing.Point(276, 284);
            this.cboNo4source.Name = "cboNo4source";
            this.cboNo4source.Size = new System.Drawing.Size(84, 26);
            this.cboNo4source.TabIndex = 29;
            // 
            // cboNo3source
            // 
            this.cboNo3source.FormattingEnabled = true;
            this.cboNo3source.Location = new System.Drawing.Point(276, 200);
            this.cboNo3source.Name = "cboNo3source";
            this.cboNo3source.Size = new System.Drawing.Size(84, 26);
            this.cboNo3source.TabIndex = 28;
            // 
            // cboNo2source
            // 
            this.cboNo2source.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNo2source.FormattingEnabled = true;
            this.cboNo2source.Location = new System.Drawing.Point(276, 117);
            this.cboNo2source.Name = "cboNo2source";
            this.cboNo2source.Size = new System.Drawing.Size(84, 23);
            this.cboNo2source.TabIndex = 27;
            // 
            // cboSource
            // 
            this.cboSource.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSource.FormattingEnabled = true;
            this.cboSource.Location = new System.Drawing.Point(276, 31);
            this.cboSource.Name = "cboSource";
            this.cboSource.Size = new System.Drawing.Size(84, 23);
            this.cboSource.TabIndex = 26;
            // 
            // lblNo4level
            // 
            this.lblNo4level.AutoSize = true;
            this.lblNo4level.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo4level.Location = new System.Drawing.Point(183, 316);
            this.lblNo4level.Name = "lblNo4level";
            this.lblNo4level.Size = new System.Drawing.Size(52, 15);
            this.lblNo4level.TabIndex = 25;
            this.lblNo4level.Text = "#4 Level";
            // 
            // lblNo2level
            // 
            this.lblNo2level.AutoSize = true;
            this.lblNo2level.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo2level.Location = new System.Drawing.Point(183, 147);
            this.lblNo2level.Name = "lblNo2level";
            this.lblNo2level.Size = new System.Drawing.Size(52, 15);
            this.lblNo2level.TabIndex = 25;
            this.lblNo2level.Text = "#2 Level";
            // 
            // lblNo4hysteresis
            // 
            this.lblNo4hysteresis.AutoSize = true;
            this.lblNo4hysteresis.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo4hysteresis.Location = new System.Drawing.Point(183, 340);
            this.lblNo4hysteresis.Name = "lblNo4hysteresis";
            this.lblNo4hysteresis.Size = new System.Drawing.Size(79, 15);
            this.lblNo4hysteresis.TabIndex = 24;
            this.lblNo4hysteresis.Text = "#4 Hysteresis";
            // 
            // lblNo2Hysteresis
            // 
            this.lblNo2Hysteresis.AutoSize = true;
            this.lblNo2Hysteresis.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo2Hysteresis.Location = new System.Drawing.Point(183, 171);
            this.lblNo2Hysteresis.Name = "lblNo2Hysteresis";
            this.lblNo2Hysteresis.Size = new System.Drawing.Size(79, 15);
            this.lblNo2Hysteresis.TabIndex = 24;
            this.lblNo2Hysteresis.Text = "#2 Hysteresis";
            // 
            // lblNo3source
            // 
            this.lblNo3source.AutoSize = true;
            this.lblNo3source.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo3source.Location = new System.Drawing.Point(182, 204);
            this.lblNo3source.Name = "lblNo3source";
            this.lblNo3source.Size = new System.Drawing.Size(60, 15);
            this.lblNo3source.TabIndex = 23;
            this.lblNo3source.Text = "#3 Source";
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
            // 
            // lblNo4source
            // 
            this.lblNo4source.AutoSize = true;
            this.lblNo4source.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo4source.Location = new System.Drawing.Point(183, 291);
            this.lblNo4source.Name = "lblNo4source";
            this.lblNo4source.Size = new System.Drawing.Size(60, 15);
            this.lblNo4source.TabIndex = 23;
            this.lblNo4source.Text = "#4 Source";
            // 
            // lblNo2source
            // 
            this.lblNo2source.AutoSize = true;
            this.lblNo2source.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo2source.Location = new System.Drawing.Point(183, 122);
            this.lblNo2source.Name = "lblNo2source";
            this.lblNo2source.Size = new System.Drawing.Size(60, 15);
            this.lblNo2source.TabIndex = 23;
            this.lblNo2source.Text = "#2 Source";
            // 
            // lblNo3level
            // 
            this.lblNo3level.AutoSize = true;
            this.lblNo3level.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo3level.Location = new System.Drawing.Point(182, 230);
            this.lblNo3level.Name = "lblNo3level";
            this.lblNo3level.Size = new System.Drawing.Size(52, 15);
            this.lblNo3level.TabIndex = 20;
            this.lblNo3level.Text = "#3 Level";
            // 
            // lblNo3hysteresis
            // 
            this.lblNo3hysteresis.AutoSize = true;
            this.lblNo3hysteresis.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo3hysteresis.Location = new System.Drawing.Point(182, 255);
            this.lblNo3hysteresis.Name = "lblNo3hysteresis";
            this.lblNo3hysteresis.Size = new System.Drawing.Size(79, 15);
            this.lblNo3hysteresis.TabIndex = 21;
            this.lblNo3hysteresis.Text = "#3 Hysteresis";
            // 
            // lblNo1Hysteresis
            // 
            this.lblNo1Hysteresis.AutoSize = true;
            this.lblNo1Hysteresis.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo1Hysteresis.Location = new System.Drawing.Point(182, 87);
            this.lblNo1Hysteresis.Name = "lblNo1Hysteresis";
            this.lblNo1Hysteresis.Size = new System.Drawing.Size(79, 15);
            this.lblNo1Hysteresis.TabIndex = 21;
            this.lblNo1Hysteresis.Text = "#1 Hysteresis";
            // 
            // lblNo1level
            // 
            this.lblNo1level.AutoSize = true;
            this.lblNo1level.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo1level.Location = new System.Drawing.Point(182, 62);
            this.lblNo1level.Name = "lblNo1level";
            this.lblNo1level.Size = new System.Drawing.Size(52, 15);
            this.lblNo1level.TabIndex = 20;
            this.lblNo1level.Text = "#1 Level";
            // 
            // lblNo1source
            // 
            this.lblNo1source.AutoSize = true;
            this.lblNo1source.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo1source.Location = new System.Drawing.Point(183, 36);
            this.lblNo1source.Name = "lblNo1source";
            this.lblNo1source.Size = new System.Drawing.Size(60, 15);
            this.lblNo1source.TabIndex = 19;
            this.lblNo1source.Text = "#1 Source";
            // 
            // lblSetpoints
            // 
            this.lblSetpoints.AutoSize = true;
            this.lblSetpoints.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetpoints.Location = new System.Drawing.Point(182, 7);
            this.lblSetpoints.Name = "lblSetpoints";
            this.lblSetpoints.Size = new System.Drawing.Size(67, 18);
            this.lblSetpoints.TabIndex = 18;
            this.lblSetpoints.Text = "SetPoints";
            // 
            // cboFir
            // 
            this.cboFir.FormattingEnabled = true;
            this.cboFir.Location = new System.Drawing.Point(99, 291);
            this.cboFir.Name = "cboFir";
            this.cboFir.Size = new System.Drawing.Size(71, 26);
            this.cboFir.TabIndex = 17;
            // 
            // cboRecursive
            // 
            this.cboRecursive.FormattingEnabled = true;
            this.cboRecursive.Location = new System.Drawing.Point(99, 329);
            this.cboRecursive.Name = "cboRecursive";
            this.cboRecursive.Size = new System.Drawing.Size(71, 26);
            this.cboRecursive.TabIndex = 16;
            // 
            // cboFiltertype
            // 
            this.cboFiltertype.FormattingEnabled = true;
            this.cboFiltertype.Location = new System.Drawing.Point(99, 255);
            this.cboFiltertype.Name = "cboFiltertype";
            this.cboFiltertype.Size = new System.Drawing.Size(71, 26);
            this.cboFiltertype.TabIndex = 15;
            // 
            // lblRecursive
            // 
            this.lblRecursive.AutoSize = true;
            this.lblRecursive.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecursive.Location = new System.Drawing.Point(14, 324);
            this.lblRecursive.Name = "lblRecursive";
            this.lblRecursive.Size = new System.Drawing.Size(64, 30);
            this.lblRecursive.TabIndex = 14;
            this.lblRecursive.Text = "Recursive\r\nFrequency";
            // 
            // lblFir
            // 
            this.lblFir.AutoSize = true;
            this.lblFir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFir.Location = new System.Drawing.Point(14, 286);
            this.lblFir.Name = "lblFir";
            this.lblFir.Size = new System.Drawing.Size(64, 30);
            this.lblFir.TabIndex = 13;
            this.lblFir.Text = "FIR \r\nFrequency";
            // 
            // lblFiltertype
            // 
            this.lblFiltertype.AutoSize = true;
            this.lblFiltertype.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltertype.Location = new System.Drawing.Point(14, 260);
            this.lblFiltertype.Name = "lblFiltertype";
            this.lblFiltertype.Size = new System.Drawing.Size(65, 15);
            this.lblFiltertype.TabIndex = 12;
            this.lblFiltertype.Text = "Filter Type";
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
            // 
            // txtHysteresis
            // 
            this.txtHysteresis.Location = new System.Drawing.Point(99, 115);
            this.txtHysteresis.Multiline = true;
            this.txtHysteresis.Name = "txtHysteresis";
            this.txtHysteresis.Size = new System.Drawing.Size(71, 20);
            this.txtHysteresis.TabIndex = 10;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(99, 89);
            this.txtLevel.Multiline = true;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(71, 20);
            this.txtLevel.TabIndex = 9;
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(99, 63);
            this.txtDelay.Multiline = true;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(71, 20);
            this.txtDelay.TabIndex = 8;
            // 
            // cboTrigger
            // 
            this.cboTrigger.FormattingEnabled = true;
            this.cboTrigger.Location = new System.Drawing.Point(99, 144);
            this.cboTrigger.Name = "cboTrigger";
            this.cboTrigger.Size = new System.Drawing.Size(71, 26);
            this.cboTrigger.TabIndex = 7;
            // 
            // cboMode
            // 
            this.cboMode.FormattingEnabled = true;
            this.cboMode.IntegralHeight = false;
            this.cboMode.Location = new System.Drawing.Point(99, 31);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(71, 26);
            this.cboMode.TabIndex = 6;
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrigger.Location = new System.Drawing.Point(14, 147);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(44, 15);
            this.lblTrigger.TabIndex = 5;
            this.lblTrigger.Text = "Trigger";
            // 
            // lblHysteresis
            // 
            this.lblHysteresis.AutoSize = true;
            this.lblHysteresis.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHysteresis.Location = new System.Drawing.Point(14, 116);
            this.lblHysteresis.Name = "lblHysteresis";
            this.lblHysteresis.Size = new System.Drawing.Size(63, 15);
            this.lblHysteresis.TabIndex = 4;
            this.lblHysteresis.Text = "Hysteresis";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(14, 90);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 15);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelay.Location = new System.Drawing.Point(14, 64);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(37, 15);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(14, 36);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(39, 15);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "Mode";
            // 
            // lblGrab
            // 
            this.lblGrab.AutoSize = true;
            this.lblGrab.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrab.Location = new System.Drawing.Point(14, 7);
            this.lblGrab.Name = "lblGrab";
            this.lblGrab.Size = new System.Drawing.Size(38, 18);
            this.lblGrab.TabIndex = 0;
            this.lblGrab.Text = "Grab";
            // 
            // pgView
            // 
            this.pgView.Location = new System.Drawing.Point(4, 27);
            this.pgView.Name = "pgView";
            this.pgView.Size = new System.Drawing.Size(752, 466);
            this.pgView.TabIndex = 3;
            this.pgView.Text = "View All";
            this.pgView.UseVisualStyleBackColor = true;
            // 
            // pgGraph
            // 
            this.pgGraph.Location = new System.Drawing.Point(4, 27);
            this.pgGraph.Name = "pgGraph";
            this.pgGraph.Size = new System.Drawing.Size(752, 466);
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
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(565, 32);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(21, 25);
            this.lblDegree.TabIndex = 6;
            this.lblDegree.Text = "°";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(580, 37);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(18, 16);
            this.lblCel.TabIndex = 7;
            this.lblCel.Text = "C";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(605, 31);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(69, 25);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // picSyrma
            // 
            this.picSyrma.Image = ((System.Drawing.Image)(resources.GetObject("picSyrma.Image")));
            this.picSyrma.Location = new System.Drawing.Point(680, 27);
            this.picSyrma.Name = "picSyrma";
            this.picSyrma.Size = new System.Drawing.Size(92, 41);
            this.picSyrma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSyrma.TabIndex = 9;
            this.picSyrma.TabStop = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 5);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(119, 18);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Active Address";
            // 
            // pnlAddress
            // 
            this.pnlAddress.Controls.Add(this.lblAddress);
            this.pnlAddress.Location = new System.Drawing.Point(192, 27);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(137, 29);
            this.pnlAddress.TabIndex = 15;
            // 
            // pgCalibration
            // 
            this.pgCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgCalibration.Location = new System.Drawing.Point(4, 27);
            this.pgCalibration.Name = "pgCalibration";
            this.pgCalibration.Size = new System.Drawing.Size(752, 466);
            this.pgCalibration.TabIndex = 2;
            this.pgCalibration.Text = "Calibration";
            this.pgCalibration.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.picSyrma);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.cboAddress);
            this.Controls.Add(this.vpgMenu);
            this.Name = "Form1";
            this.Text = "VPG";
            this.vpgMenu.ResumeLayout(false);
            this.vpgMenu.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.pgLoadcell.ResumeLayout(false);
            this.pgLoadcell.PerformLayout();
            this.pnlWeightkg.ResumeLayout(false);
            this.pnlWeightkg.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbFilters.ResumeLayout(false);
            this.tbFilters.PerformLayout();
            this.grpMeasuring.ResumeLayout(false);
            this.grpMeasuring.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSyrma)).EndInit();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.Panel pnlWeightkg;
        private System.Windows.Forms.Label lblweightkg;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel pnlAddress;
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
    }
}

