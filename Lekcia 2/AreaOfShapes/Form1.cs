using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = PlochaObdlznika(double.Parse
            (textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }
        public double PlochaObdlznika(double a, double b)
        {
            return a * b;
        }
        public double PlochaKruhu(double r)
        {
            return Math.PI * r * r;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = PlochaKruhu(double.Parse(textBox3.Text)).ToString();
        }
        public double PlochaStvorca(double a)
        {
            return a * a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = PlochaStvorca(double.Parse(textBox4.Text)).ToString();
        }
    }
}
