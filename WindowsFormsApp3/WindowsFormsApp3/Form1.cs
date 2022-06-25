using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            int sec = int.Parse(label1.Text);
            int min = int.Parse(label2.Text);
            int mil = int.Parse(label3.Text);
            if(sec == min && sec == mil)
            {
                MessageBox.Show("You Won!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(label1.Text);
            sec++;
            int min = int.Parse(label2.Text);
            label1.Text=sec.ToString(); 
            if(sec == 10)
            {
                label1.Text = Convert.ToString(0);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            int min = int.Parse(label2.Text);
            min++;
            label2.Text = min.ToString();

            if (min == 10)
            {
                label2.Text = Convert.ToString(0);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int mil = int.Parse(label3.Text);
            mil++;
            label3.Text = mil.ToString();
            if (mil == 10)
            {
               label3.Text = Convert.ToString(0);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
