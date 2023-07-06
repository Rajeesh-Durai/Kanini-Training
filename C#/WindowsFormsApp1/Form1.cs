using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           // Display.Text = "welcome";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int a, b, c;

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox3.Text);
            c = a * b;
            textBox2.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox3.Text);
            if (b == 0)
            {
                MessageBox.Show("enter any valid input");
                textBox3.Focus();
            }
            else
            {
                c = a / b;
                textBox2.Text = c.ToString();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("enter any valid input");
                textBox1.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("enter any valid input");
                textBox3.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)==false)
            {
                MessageBox.Show("Enter inputs only");
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Enter inputs only");
                e.Handled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox3.Text);
            c = a - b;
            textBox2.Text = c.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a=Convert.ToInt32(textBox1.Text);
            b=Convert.ToInt32(textBox3.Text);
            c = a + b;
            textBox2.Text=c.ToString();
        }
    }
}
