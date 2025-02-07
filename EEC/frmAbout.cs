using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraExtraControls
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            lbVer.Text = $"Version: {ProductVersion}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@supermariopixel1");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
