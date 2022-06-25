using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(lblSec.Text);
            if (c == 10)
            {
                lblSec.Text = "0";
                int min = int.Parse(lblMin.Text);
                min++;
                lblMin.Text = min.ToString();
                c = 0;
            }
            sec++;
            c++;
            lblSec.Text = sec.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
