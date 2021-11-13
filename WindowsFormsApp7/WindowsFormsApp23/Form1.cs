using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        int pr = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void стопToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pr = 0;
            progressBar1.Value = pr;
            toolStripStatusLabel1.Text = pr + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pr = pr + 1;
            progressBar1.Value = pr;
            toolStripStatusLabel1.Text = pr + "%";
        }
    }
}
