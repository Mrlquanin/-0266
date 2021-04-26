using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第一次作业第二小题
{
    public partial class Form1 : Form
    {
        string s;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;

            int a = Convert.ToInt32(textBox1.Text);

       

            int b = Convert.ToInt32(textBox2.Text);

            if (s == "+")
            {
                num = a + b;
            }
            if (s == "-")
            {
                num = a - b;
            }
            if (s == "*")
            {
                num = a * b;
            }
            if (s == "/")
            {
                num = a / b;
            }
            string D = num.ToString();
            textBox3.Text = D;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             s = comboBox1.Text;
        }
    }
}
