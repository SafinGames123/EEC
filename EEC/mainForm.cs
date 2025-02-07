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
using M64MM.Utils;

namespace ExtraExtraControls
{
    public partial class mainForm : Form
    {

        static readonly Color defLight = Color.FromArgb(255, 255, 255, 255);
        static readonly Color defEnv = Color.FromArgb(255, 127, 127, 127);
        static frmAbout about = new frmAbout();
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnColorLight_Click(object sender, EventArgs e)
        {
            bool editLight = false;
            int offset = 0;
            if (((Control)sender).Name == "btnColorLight")
            {
                editLight = true;
            }

            ColorDialog cd = new ColorDialog();
            cd.Color = ((Button)sender).BackColor;

            if (editLight)
            {
                offset = 8;
            }

            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK) { }
            

            
        }


 

        public static long SegmentedToVirtualPolyfill(uint address, bool useBase = true)
        {
            byte[] byteArray = BitConverter.GetBytes(address);
            if (byteArray.Length == 4)
            {
                uint segment = address >> 24;
                uint segmentedOffset = address & 0x00FFFFFF;
                if (segment <= 0x1F && segment >= 0)
                {
                    long segmentedBase = (BitConverter.ToUInt32(
                    Core.ReadBytes(Core.BaseAddress + 0x33B400 + segment * 4, 4), 0));
                    //MinValue of int just so happens to be 0x80000000 so it's perfect
                    return segmentedBase + segmentedOffset + (useBase ? Core.BaseAddress : 0);
                }
                else
                {
                    throw new ArgumentException("Segments range from 00 to 1F.");
                }
            }
            else
            {
                throw new ArgumentException("Invalid address");
            }
        }





        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }



        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void gbLights_Enter(object sender, EventArgs e)
        {

        }

        private void gbColors_Enter(object sender, EventArgs e)
        {

        }

        private void stunseedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Core.WriteBytes(Core.BaseAddress + 0x20770C, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x20770E, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x20770C, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x207710, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x207712, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x207714, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x207716, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x207718, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x20771A, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x20771C, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x20771E, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x207720, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x207722, BitConverter.GetBytes(0xFFFF));
            Core.WriteBytes(Core.BaseAddress + 0x207724, BitConverter.GetBytes(0xFFFF));

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Core.WriteBytes(Core.BaseAddress + 0x33B21D, new byte[] { 0x64 });
        }


    }
}
