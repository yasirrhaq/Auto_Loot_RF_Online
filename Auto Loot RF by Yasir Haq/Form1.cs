using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Auto_Loot_RF_by_Yasir_Haq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.images;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("X");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Stop Loot";
                timer1.Enabled = true;
                int interval = 150;
                timer1.Interval = interval;
                timer1.Start();
            }
            else if (!checkBox1.Checked)
            {
                checkBox1.Text = "Start Loot";
                timer1.Stop();
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/yasirrhaq");
            Process.Start(sInfo);
        }
    }
}