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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s=textBox1.Text+ " hobbies are :";
            foreach(Control x in this.Controls)
            {
                if(x is CheckBox) {
                    CheckBox c= (CheckBox)x;
                    if(c.Checked == true)
                    {
                        s = s + c.Text + " ";
                    }
                }
            }
            label3.Text = s;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
