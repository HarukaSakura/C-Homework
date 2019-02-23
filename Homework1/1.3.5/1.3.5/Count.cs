using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._3._5
{
    public partial class Count : Form
    {

        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Button btn = new Button();
        Label lb1 = new Label();
        public Count()
        {
            InitializeComponent();
        }
        public void button_Click(object sender, EventArgs e)
        {
            string s = txt1.Text;
            double n1 = double.Parse(s);
            s = txt2.Text;
            double n2 = double.Parse(s);
            double result = n1 * n2;
            lb1.Text = n1 + "和" + n2 + "的乘积是:" + result;
        }
    }
}
