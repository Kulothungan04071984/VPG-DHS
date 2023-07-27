
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActiveadd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.pgWeighing = new System.Windows.Forms.TabPage();
            this.pgLoadcell = new System.Windows.Forms.TabPage();
            this.pgCalibration = new System.Windows.Forms.TabPage();
            this.pgView = new System.Windows.Forms.TabPage();
            this.pgGraph = new System.Windows.Forms.TabPage();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblGrab = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblHysteresis = new System.Windows.Forms.Label();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.vpgMenu.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.pgWeighing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.vpgMenu.Size = new System.Drawing.Size(800, 24);
            this.vpgMenu.TabIndex = 0;
            this.vpgMenu.Text = "Log File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Log File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem3.Text = "Edit";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem2.Text = "About";
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
            this.tbControl.Size = new System.Drawing.Size(760, 374);
            this.tbControl.TabIndex = 3;
            this.tbControl.Click += new System.EventHandler(this.tbControl_Click);
            // 
            // pgWeighing
            // 
            this.pgWeighing.Controls.Add(this.tabControl1);
            this.pgWeighing.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgWeighing.Location = new System.Drawing.Point(4, 27);
            this.pgWeighing.Name = "pgWeighing";
            this.pgWeighing.Padding = new System.Windows.Forms.Padding(3);
            this.pgWeighing.Size = new System.Drawing.Size(752, 343);
            this.pgWeighing.TabIndex = 0;
            this.pgWeighing.Text = "Weighing Display & Status";
            this.pgWeighing.UseVisualStyleBackColor = true;
            this.pgWeighing.Click += new System.EventHandler(this.pgWeighing_Click);
            // 
            // pgLoadcell
            // 
            this.pgLoadcell.Location = new System.Drawing.Point(4, 27);
            this.pgLoadcell.Name = "pgLoadcell";
            this.pgLoadcell.Padding = new System.Windows.Forms.Padding(3);
            this.pgLoadcell.Size = new System.Drawing.Size(744, 343);
            this.pgLoadcell.TabIndex = 1;
            this.pgLoadcell.Text = "LoadCell Setup";
            this.pgLoadcell.UseVisualStyleBackColor = true;
            // 
            // pgCalibration
            // 
            this.pgCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgCalibration.Location = new System.Drawing.Point(4, 27);
            this.pgCalibration.Name = "pgCalibration";
            this.pgCalibration.Size = new System.Drawing.Size(744, 343);
            this.pgCalibration.TabIndex = 2;
            this.pgCalibration.Text = "Calibration";
            this.pgCalibration.UseVisualStyleBackColor = true;
            // 
            // pgView
            // 
            this.pgView.Location = new System.Drawing.Point(4, 27);
            this.pgView.Name = "pgView";
            this.pgView.Size = new System.Drawing.Size(744, 343);
            this.pgView.TabIndex = 3;
            this.pgView.Text = "View All";
            this.pgView.UseVisualStyleBackColor = true;
            // 
            // pgGraph
            // 
            this.pgGraph.Location = new System.Drawing.Point(4, 27);
            this.pgGraph.Name = "pgGraph";
            this.pgGraph.Size = new System.Drawing.Size(752, 343);
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
            this.pictureBox1.Location = new System.Drawing.Point(680, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 304);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Weighing Format/ Zero/ Tare/ Motion ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTrigger);
            this.tabPage2.Controls.Add(this.lblHysteresis);
            this.tabPage2.Controls.Add(this.lblLevel);
            this.tabPage2.Controls.Add(this.lblDelay);
            this.tabPage2.Controls.Add(this.lblMode);
            this.tabPage2.Controls.Add(this.lblGrab);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(495, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filters/ Peak/ Grab/ Setpoints";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblGrab
            // 
            this.lblGrab.AutoSize = true;
            this.lblGrab.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrab.Location = new System.Drawing.Point(10, 12);
            this.lblGrab.Name = "lblGrab";
            this.lblGrab.Size = new System.Drawing.Size(38, 18);
            this.lblGrab.TabIndex = 0;
            this.lblGrab.Text = "Grab";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(13, 44);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(35, 14);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "Mode";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(13, 70);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(36, 14);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(14, 94);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 14);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level";
            // 
            // lblHysteresis
            // 
            this.lblHysteresis.AutoSize = true;
            this.lblHysteresis.Location = new System.Drawing.Point(14, 120);
            this.lblHysteresis.Name = "lblHysteresis";
            this.lblHysteresis.Size = new System.Drawing.Size(59, 14);
            this.lblHysteresis.TabIndex = 4;
            this.lblHysteresis.Text = "Hysteresis";
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Location = new System.Drawing.Point(14, 144);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(41, 14);
            this.lblTrigger.TabIndex = 5;
            this.lblTrigger.Text = "Trigger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.vpgMenu.ResumeLayout(false);
            this.vpgMenu.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.pgWeighing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTrigger;
        private System.Windows.Forms.Label lblHysteresis;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblGrab;
    }
}

