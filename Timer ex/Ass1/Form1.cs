using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int l1 = int.Parse(label1.Text);
            l1++;
            if (l1 > 9)
                label1.Text = "0";
            else
                label1.Text = l1.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int l2 = int.Parse(label2.Text);
            l2++;
            if (l2 > 9)
                label2.Text = "0";
            else
                label2.Text = l2.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int l3 = int.Parse(label3.Text);
            l3++;
            if (l3 > 9)
                label3.Text = "0";
            else
                label3.Text = l3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            if (label2.Text == label3.Text)
                if (label1.Text == label2.Text)
                    MessageBox.Show("Winner! Winner! \n Chicken Dinner!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
