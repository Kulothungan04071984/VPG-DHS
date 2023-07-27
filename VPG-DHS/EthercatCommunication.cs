using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPG_DHS
{
    public partial class EthercatCommunication : Form
    {
        public EthercatCommunication()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeighingDisplayStatus weighingDisplayStatus = new WeighingDisplayStatus();
            weighingDisplayStatus.Show();
        }
    }
}
