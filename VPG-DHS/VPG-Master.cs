using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPG_DHS
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void pgWeighing_Click(object sender, EventArgs e)
        {
          
            if (tbControl.SelectedTab == pgWeighing)
            {
                //Test test = new Test();
                //test.Show();
            }
        }    
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var ports = SerialPort.GetPortNames();
                cboPortNumber.DataSource = ports;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error", err.Message.ToString(), MessageBoxButtons.OK);
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cboPortNumber.Items.Count == 0 || cboPortNumber.SelectedItem == null)
            {
                MessageBox.Show("Please select the Port");
            }
            try
            {
                VPGSerialPort.PortName = cboPortNumber.SelectedItem.ToString();
                VPGSerialPort.Open();
                MessageBox.Show("Serial Port is Open");
                chKWReady.Checked = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error", err.Message.ToString());
                if(VPGSerialPort.IsOpen)
                {
                    VPGSerialPort.Close();
                }
            }
        }

        private void VPGSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(VPGSerialPort.IsOpen)
            {
               
                var data = VPGSerialPort.ReadByte();
                byte[] arrdata = new byte[data + 3];
                arrdata[0] = Convert.ToByte(data);

                btnIndicator.Visible = true;

                this.BeginInvoke((MethodInvoker)delegate {
                    txtWWeight.AppendText(arrdata[0].ToString());
                   
                });
               



            }
        }

       
    }
}
