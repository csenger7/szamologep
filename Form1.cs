using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teszt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+"; textBox1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7; textBox1.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1; textBox1.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3; textBox1.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2; textBox1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6; textBox1.Refresh();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5; textBox1.Refresh();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4; textBox1.Refresh();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9; textBox1.Refresh();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8; textBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/"; textBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*"; textBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-"; textBox1.Refresh();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            textBox1.Text = dt.Compute(textBox1.Text, "").ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0; textBox1.Refresh();
        }
    }
}

