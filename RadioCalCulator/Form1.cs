using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioCalCulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radadd_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToInt32(txtInput1.Text) + Convert.ToInt32(txtInput2.Text)).ToString();
        }

        private void radsub_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToInt32(txtInput1.Text) - Convert.ToInt32(txtInput2.Text)).ToString();
        }

        private void radmul_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToInt32(txtInput1.Text) * Convert.ToInt32(txtInput2.Text)).ToString();
        }

        private void raddiv_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text= (Convert.ToDouble(txtInput1.Text) / Convert.ToDouble(txtInput2.Text)).ToString();
        }
    }
}
