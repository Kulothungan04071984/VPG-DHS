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

        private void tbControl_Click(object sender, EventArgs e)
        {

        }
    }
}
