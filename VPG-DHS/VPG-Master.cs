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
        private SerialPort serialPort;
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

        private void tbControl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort = new SerialPort();
            serialPort.BaudRate = 115200;
            serialPort.DataReceived += VPGSerialPort_DataReceived;
            try
            {
                var ports = SerialPort.GetPortNames();
                cboportnumWD.DataSource = ports;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error", err.Message.ToString(), MessageBoxButtons.OK);
            }

        }

     
        private void VPGSerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string receivedata = serialPort.ReadExisting();
            this.Invoke(new Action(() =>
            {
                txtWeightWD.AppendText(receivedata);
            }
            ));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void lblBAUDRATE_Click(object sender, EventArgs e)
        {

        }
    }
}
