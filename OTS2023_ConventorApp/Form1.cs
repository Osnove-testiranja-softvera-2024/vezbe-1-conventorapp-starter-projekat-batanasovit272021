using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        bool mass = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Pounds";
                label2.Text = "KG";
                mass = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Text = "Feet";
                label2.Text = "Meters";
                mass = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mass)
            {
                ConvertMass m = new ConvertMass();
                double mass = Convert.ToDouble(textBox1.Text);
                textBox2.Text = m.Convert(mass).ToString();
            }
            else
            {
                ConvertLength l = new ConvertLength();
                double length = Convert.ToDouble(textBox1.Text);
                textBox2.Text = l.Convert(length).ToString();
            }
        }
    }
}
