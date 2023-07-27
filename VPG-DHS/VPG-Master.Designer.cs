
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
            this.vpgMenu.SuspendLayout();
            this.tbControl.SuspendLayout();
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
            this.btnActiveadd.Location = new System.Drawing.Point(236, 35);
            this.btnActiveadd.Name = "btnActiveadd";
            this.btnActiveadd.Size = new System.Drawing.Size(124, 23);
            this.btnActiveadd.TabIndex = 1;
            this.btnActiveadd.Text = "Active Address";
            this.btnActiveadd.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(366, 36);
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
            this.tbControl.Size = new System.Drawing.Size(752, 374);
            this.tbControl.TabIndex = 3;
            // 
            // pgWeighing
            // 
            this.pgWeighing.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgWeighing.Location = new System.Drawing.Point(4, 27);
            this.pgWeighing.Name = "pgWeighing";
            this.pgWeighing.Padding = new System.Windows.Forms.Padding(3);
            this.pgWeighing.Size = new System.Drawing.Size(744, 343);
            this.pgWeighing.TabIndex = 0;
            this.pgWeighing.Text = "Weighing Display & Status";
            this.pgWeighing.UseVisualStyleBackColor = true;
            this.pgWeighing.Click += new System.EventHandler(this.pgWeighing_Click);
            // 
            // pgLoadcell
            // 
            this.pgLoadcell.Location = new System.Drawing.Point(4, 22);
            this.pgLoadcell.Name = "pgLoadcell";
            this.pgLoadcell.Padding = new System.Windows.Forms.Padding(3);
            this.pgLoadcell.Size = new System.Drawing.Size(744, 348);
            this.pgLoadcell.TabIndex = 1;
            this.pgLoadcell.Text = "LoadCell Setup";
            this.pgLoadcell.UseVisualStyleBackColor = true;
            // 
            // pgCalibration
            // 
            this.pgCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgCalibration.Location = new System.Drawing.Point(4, 22);
            this.pgCalibration.Name = "pgCalibration";
            this.pgCalibration.Size = new System.Drawing.Size(744, 348);
            this.pgCalibration.TabIndex = 2;
            this.pgCalibration.Text = "Calibration";
            this.pgCalibration.UseVisualStyleBackColor = true;
            // 
            // pgView
            // 
            this.pgView.Location = new System.Drawing.Point(4, 22);
            this.pgView.Name = "pgView";
            this.pgView.Size = new System.Drawing.Size(744, 348);
            this.pgView.TabIndex = 3;
            this.pgView.Text = "View All";
            this.pgView.UseVisualStyleBackColor = true;
            // 
            // pgGraph
            // 
            this.pgGraph.Location = new System.Drawing.Point(4, 22);
            this.pgGraph.Name = "pgGraph";
            this.pgGraph.Size = new System.Drawing.Size(744, 348);
            this.pgGraph.TabIndex = 4;
            this.pgGraph.Text = "Graph";
            this.pgGraph.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnActiveadd);
            this.Controls.Add(this.vpgMenu);
            this.Name = "Form1";
            this.Text = "VPG";
            this.vpgMenu.ResumeLayout(false);
            this.vpgMenu.PerformLayout();
            this.tbControl.ResumeLayout(false);
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
    }
}

