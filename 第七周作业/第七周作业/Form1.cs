using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第七周作业
{
    public partial class Form1 : Form
    {
        private double length = 100;
        private int n = 10;
        private Graphics gra;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private string pen = null;
        public Form1()
        {
            InitializeComponent();
        }


        public void drawline(double x0, double y0, double x1, double y1)
        {
            switch (pen)
            {
                case "red": gra.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "blue": gra.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "yellow": gra.DrawLine(Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "purple": gra.DrawLine(Pens.Purple, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "black": gra.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "green": gra.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "brown": gra.DrawLine(Pens.Brown, (int)x0, (int)y0, (int)x1, (int)y1); break;
                default: throw new Exception("颜色错误");
            }
        }



        //七个输入框




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.n = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.length = Convert.ToDouble(textBox2.Text);
        }
    


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.per1 = Convert.ToDouble(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.per2 = Convert.ToDouble(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.th1 = Convert.ToDouble(textBox5.Text);
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.th2 = Convert.ToDouble(textBox6.Text);
        }
        
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.pen = Convert.ToString(textBox7.Text);
        }
        //按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (gra == null) 
                gra= this.CreateGraphics();
            else gra.Clear(BackColor);
            var p_right = this.button1.Location;
            drawCaleyTree(n, p_right.X + this.button1.Size.Width / 2, p_right.Y - 50, length, -1 * Math.PI / 2);

        }

         void drawCaleyTree(int step, double x0, double y0, double length, double th)
        {
            if (step == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            drawline(x0, y0, x1, y1);
            drawCaleyTree(step - 1, x1, y1, per1 * length, th + th1);
            drawCaleyTree(step - 1, x1, y1, per2 * length, th - th2);
        }




    }

}
