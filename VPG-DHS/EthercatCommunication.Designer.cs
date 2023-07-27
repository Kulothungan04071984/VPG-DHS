
namespace VPG_DHS
{
    partial class EthercatCommunication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbochange = new System.Windows.Forms.ComboBox();
            this.btnchange = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnunlock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcommand = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboComTermination = new System.Windows.Forms.ComboBox();
            this.cboComstopbit = new System.Windows.Forms.ComboBox();
            this.cboComParity = new System.Windows.Forms.ComboBox();
            this.cboComdata = new System.Windows.Forms.ComboBox();
            this.cboCombaud = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkset4 = new System.Windows.Forms.CheckBox();
            this.chkset3 = new System.Windows.Forms.CheckBox();
            this.chkset2 = new System.Windows.Forms.CheckBox();
            this.chkset1 = new System.Windows.Forms.CheckBox();
            this.chkin4 = new System.Windows.Forms.CheckBox();
            this.chkin3 = new System.Windows.Forms.CheckBox();
            this.chkin2 = new System.Windows.Forms.CheckBox();
            this.chkin1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblport = new System.Windows.Forms.Label();
            this.cbostopbits = new System.Windows.Forms.ComboBox();
            this.cboparity = new System.Windows.Forms.ComboBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.cbodatabits = new System.Windows.Forms.ComboBox();
            this.cboportnum = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 512);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.cboComTermination);
            this.panel2.Controls.Add(this.cboComstopbit);
            this.panel2.Controls.Add(this.cboComParity);
            this.panel2.Controls.Add(this.cboComdata);
            this.panel2.Controls.Add(this.cboCombaud);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(29, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 446);
            this.panel2.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConnect.Location = new System.Drawing.Point(514, 398);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 26);
            this.btnConnect.TabIndex = 16;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbochange);
            this.groupBox4.Controls.Add(this.btnchange);
            this.groupBox4.Location = new System.Drawing.Point(593, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 70);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Device Address";
            // 
            // cbochange
            // 
            this.cbochange.FormattingEnabled = true;
            this.cbochange.Location = new System.Drawing.Point(91, 33);
            this.cbochange.Name = "cbochange";
            this.cbochange.Size = new System.Drawing.Size(93, 23);
            this.cbochange.TabIndex = 1;
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(17, 33);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(68, 23);
            this.btnchange.TabIndex = 0;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btnunlock);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtcommand);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(287, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 138);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual Commands";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 16;
            // 
            // btnunlock
            // 
            this.btnunlock.BackColor = System.Drawing.Color.LimeGreen;
            this.btnunlock.Location = new System.Drawing.Point(112, 59);
            this.btnunlock.Name = "btnunlock";
            this.btnunlock.Size = new System.Drawing.Size(66, 44);
            this.btnunlock.TabIndex = 15;
            this.btnunlock.Text = "Unlock Security";
            this.btnunlock.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtcommand
            // 
            this.txtcommand.Location = new System.Drawing.Point(112, 30);
            this.txtcommand.Name = "txtcommand";
            this.txtcommand.Size = new System.Drawing.Size(132, 23);
            this.txtcommand.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "Enter a command";
            // 
            // cboComTermination
            // 
            this.cboComTermination.FormattingEnabled = true;
            this.cboComTermination.Location = new System.Drawing.Point(106, 381);
            this.cboComTermination.Name = "cboComTermination";
            this.cboComTermination.Size = new System.Drawing.Size(121, 23);
            this.cboComTermination.TabIndex = 13;
            // 
            // cboComstopbit
            // 
            this.cboComstopbit.FormattingEnabled = true;
            this.cboComstopbit.Location = new System.Drawing.Point(106, 350);
            this.cboComstopbit.Name = "cboComstopbit";
            this.cboComstopbit.Size = new System.Drawing.Size(121, 23);
            this.cboComstopbit.TabIndex = 12;
            // 
            // cboComParity
            // 
            this.cboComParity.FormattingEnabled = true;
            this.cboComParity.Location = new System.Drawing.Point(106, 317);
            this.cboComParity.Name = "cboComParity";
            this.cboComParity.Size = new System.Drawing.Size(121, 23);
            this.cboComParity.TabIndex = 11;
            // 
            // cboComdata
            // 
            this.cboComdata.FormattingEnabled = true;
            this.cboComdata.Location = new System.Drawing.Point(106, 283);
            this.cboComdata.Name = "cboComdata";
            this.cboComdata.Size = new System.Drawing.Size(121, 23);
            this.cboComdata.TabIndex = 10;
            // 
            // cboCombaud
            // 
            this.cboCombaud.FormattingEnabled = true;
            this.cboCombaud.Location = new System.Drawing.Point(106, 249);
            this.cboCombaud.Name = "cboCombaud";
            this.cboCombaud.Size = new System.Drawing.Size(121, 23);
            this.cboCombaud.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 374);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 30);
            this.label15.TabIndex = 7;
            this.label15.Text = "Termination\r\n Resistor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "Stop Bits:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Parity:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Data Bits:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Baud Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "COM Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkset4);
            this.groupBox2.Controls.Add(this.chkset3);
            this.groupBox2.Controls.Add(this.chkset2);
            this.groupBox2.Controls.Add(this.chkset1);
            this.groupBox2.Controls.Add(this.chkin4);
            this.groupBox2.Controls.Add(this.chkin3);
            this.groupBox2.Controls.Add(this.chkin2);
            this.groupBox2.Controls.Add(this.chkin1);
            this.groupBox2.Location = new System.Drawing.Point(373, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status I/O";
            // 
            // chkset4
            // 
            this.chkset4.AutoSize = true;
            this.chkset4.Location = new System.Drawing.Point(92, 136);
            this.chkset4.Name = "chkset4";
            this.chkset4.Size = new System.Drawing.Size(89, 19);
            this.chkset4.TabIndex = 7;
            this.chkset4.Text = "SetPoint #4";
            this.chkset4.UseVisualStyleBackColor = true;
            // 
            // chkset3
            // 
            this.chkset3.AutoSize = true;
            this.chkset3.Location = new System.Drawing.Point(92, 99);
            this.chkset3.Name = "chkset3";
            this.chkset3.Size = new System.Drawing.Size(89, 19);
            this.chkset3.TabIndex = 6;
            this.chkset3.Text = "SetPoint #3";
            this.chkset3.UseVisualStyleBackColor = true;
            // 
            // chkset2
            // 
            this.chkset2.AutoSize = true;
            this.chkset2.Location = new System.Drawing.Point(92, 61);
            this.chkset2.Name = "chkset2";
            this.chkset2.Size = new System.Drawing.Size(89, 19);
            this.chkset2.TabIndex = 5;
            this.chkset2.Text = "SetPoint #2";
            this.chkset2.UseVisualStyleBackColor = true;
            // 
            // chkset1
            // 
            this.chkset1.AutoSize = true;
            this.chkset1.Location = new System.Drawing.Point(92, 26);
            this.chkset1.Name = "chkset1";
            this.chkset1.Size = new System.Drawing.Size(89, 19);
            this.chkset1.TabIndex = 4;
            this.chkset1.Text = "SetPoint #1";
            this.chkset1.UseVisualStyleBackColor = true;
            // 
            // chkin4
            // 
            this.chkin4.AutoSize = true;
            this.chkin4.Location = new System.Drawing.Point(6, 136);
            this.chkin4.Name = "chkin4";
            this.chkin4.Size = new System.Drawing.Size(71, 19);
            this.chkin4.TabIndex = 3;
            this.chkin4.Text = "Input #4";
            this.chkin4.UseVisualStyleBackColor = true;
            // 
            // chkin3
            // 
            this.chkin3.AutoSize = true;
            this.chkin3.Location = new System.Drawing.Point(6, 99);
            this.chkin3.Name = "chkin3";
            this.chkin3.Size = new System.Drawing.Size(71, 19);
            this.chkin3.TabIndex = 2;
            this.chkin3.Text = "Input #3";
            this.chkin3.UseVisualStyleBackColor = true;
            // 
            // chkin2
            // 
            this.chkin2.AutoSize = true;
            this.chkin2.Location = new System.Drawing.Point(6, 61);
            this.chkin2.Name = "chkin2";
            this.chkin2.Size = new System.Drawing.Size(71, 19);
            this.chkin2.TabIndex = 1;
            this.chkin2.Text = "Input #2";
            this.chkin2.UseVisualStyleBackColor = true;
            // 
            // chkin1
            // 
            this.chkin1.AutoSize = true;
            this.chkin1.Location = new System.Drawing.Point(6, 26);
            this.chkin1.Name = "chkin1";
            this.chkin1.Size = new System.Drawing.Size(71, 19);
            this.chkin1.TabIndex = 0;
            this.chkin1.Text = "Input #1";
            this.chkin1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblport);
            this.groupBox1.Controls.Add(this.cbostopbits);
            this.groupBox1.Controls.Add(this.cboparity);
            this.groupBox1.Controls.Add(this.cboBaudrate);
            this.groupBox1.Controls.Add(this.cbodatabits);
            this.groupBox1.Controls.Add(this.cboportnum);
            this.groupBox1.Location = new System.Drawing.Point(19, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ethercat Setting";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Stop Bits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Parity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Baud Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data Bits";
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(6, 30);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(83, 15);
            this.lblport.TabIndex = 5;
            this.lblport.Text = "Port  Number";
            // 
            // cbostopbits
            // 
            this.cbostopbits.FormattingEnabled = true;
            this.cbostopbits.Location = new System.Drawing.Point(116, 120);
            this.cbostopbits.Name = "cbostopbits";
            this.cbostopbits.Size = new System.Drawing.Size(92, 23);
            this.cbostopbits.TabIndex = 4;
            // 
            // cboparity
            // 
            this.cboparity.FormattingEnabled = true;
            this.cboparity.Location = new System.Drawing.Point(6, 120);
            this.cboparity.Name = "cboparity";
            this.cboparity.Size = new System.Drawing.Size(84, 23);
            this.cboparity.TabIndex = 3;
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Location = new System.Drawing.Point(228, 57);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(83, 23);
            this.cboBaudrate.TabIndex = 2;
            // 
            // cbodatabits
            // 
            this.cbodatabits.FormattingEnabled = true;
            this.cbodatabits.Location = new System.Drawing.Point(116, 57);
            this.cbodatabits.Name = "cbodatabits";
            this.cbodatabits.Size = new System.Drawing.Size(92, 23);
            this.cbodatabits.TabIndex = 1;
            // 
            // cboportnum
            // 
            this.cboportnum.FormattingEnabled = true;
            this.cboportnum.Location = new System.Drawing.Point(6, 57);
            this.cboportnum.Name = "cboportnum";
            this.cboportnum.Size = new System.Drawing.Size(84, 23);
            this.cboportnum.TabIndex = 0;
            // 
            // EthercatCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 594);
            this.Controls.Add(this.panel1);
            this.Name = "EthercatCommunication";
            this.Text = "EthercatCommunication";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbochange;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnunlock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcommand;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboComTermination;
        private System.Windows.Forms.ComboBox cboComstopbit;
        private System.Windows.Forms.ComboBox cboComParity;
        private System.Windows.Forms.ComboBox cboComdata;
        private System.Windows.Forms.ComboBox cboCombaud;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkset4;
        private System.Windows.Forms.CheckBox chkset3;
        private System.Windows.Forms.CheckBox chkset2;
        private System.Windows.Forms.CheckBox chkset1;
        private System.Windows.Forms.CheckBox chkin4;
        private System.Windows.Forms.CheckBox chkin3;
        private System.Windows.Forms.CheckBox chkin2;
        private System.Windows.Forms.CheckBox chkin1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.ComboBox cbostopbits;
        private System.Windows.Forms.ComboBox cboparity;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.ComboBox cbodatabits;
        private System.Windows.Forms.ComboBox cboportnum;
    }
}

