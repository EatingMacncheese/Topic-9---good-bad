using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___good___bad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            imgYippee.Visible = true;
            btnGood.Enabled = false;
            btnBad.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            imgRickroll.Visible = true;
            btnGood.Enabled = false;
            btnBad.Enabled = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
