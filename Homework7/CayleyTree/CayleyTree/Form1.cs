using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;

        int degree1, degree2;
        double k = 1;
        double th1 = 20;
        double th2 = 30;
        double per1 = 0.6;
        double per2 = 0.7;

        private void drawCayLeyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + k * leng * Math.Cos(th);
            double y2 = y0 + k * leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayLeyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayLeyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }

        private void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(this.BackColor);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = this.CreateGraphics();
            degree1 = Convert.ToInt32(textBox1.Text);
            degree2 = Convert.ToInt32(textBox2.Text);
            per1 = Convert.ToDouble(textBox4.Text);
            per2 = Convert.ToDouble(textBox5.Text);
            k = Convert.ToDouble(textBox3.Text);
            th1 = degree1 * Math.PI / 180;
            th2= degree2 * Math.PI / 180;
            drawCayLeyTree(10, 200, 310, 100, -Math.PI /2);
        }
    }
}
