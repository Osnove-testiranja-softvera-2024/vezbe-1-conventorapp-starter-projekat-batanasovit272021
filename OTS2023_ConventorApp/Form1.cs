using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        bool mass, length, time, money, customMoney, h, m, s, arr, single;
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
                length = false;
                time = false;
                money = false;
                customMoney = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                arr = false;
                single = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label1.Text = "EUR";
                label2.Text = "RSD";
                mass = false;
                length = false;
                time = false;
                money = true;
                customMoney = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                arr = true;
                single = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                label2.Text = "Hours";
                h = true;
                m = false;
                s = false;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                label2.Text = "Minutes";
                h = false;
                m = true;
                s = false;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                label2.Text = "Seconds";
                h = false;
                m = false;
                s = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Text = "Feet";
                label2.Text = "Meters";
                mass = false;
                length = true;
                time = false;
                money = false;
                customMoney = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (mass)
            {
                ConvertMass m = new ConvertMass();
                if (single)
                {
                    double mass = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = m.Convert(mass).ToString();
                }
                else if (arr)
                {
                    string[] strValueArr = textBox1.Text.Split(',');
                    double[] dblValueArr =  new double[strValueArr.Length];
                    for(int i = 0; i < strValueArr.Length; i++)
                    {
                        dblValueArr[i] = m.Convert(Convert.ToDouble(strValueArr[i]));
                        textBox2.Text += dblValueArr[i].ToString() + ", ";
                    }
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 2, 2);
                }
            }
            else if (length) 
            {
                ConvertLength l = new ConvertLength();
                if (single)
                {
                    double length = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = l.Convert(length).ToString();
                }
                else if (arr)
                {
                    string[] strValueArr = textBox1.Text.Split(',');
                    double[] dblValueArr = new double[strValueArr.Length];
                    for (int i = 0; i < strValueArr.Length; i++)
                    {
                        dblValueArr[i] = l.Convert(Convert.ToDouble(strValueArr[i]));
                        textBox2.Text += dblValueArr[i].ToString() + ", ";
                    }
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 2, 2);
                }
            }
            else if (money)
            {
                ConvertMoney m = new ConvertMoney();
                if (single)
                {
                    double money = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = m.Convert(money).ToString();
                }
                else if (arr)
                {
                    string[] strValueArr = textBox1.Text.Split(',');
                    double[] dblValueArr = new double[strValueArr.Length];
                    for (int i = 0; i < strValueArr.Length; i++)
                    {
                        dblValueArr[i] = m.Convert(Convert.ToDouble(strValueArr[i]));
                        textBox2.Text += dblValueArr[i].ToString() + ", ";
                    }
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 2, 2);
                }
            }
            else if (time)
            {
                double result = 0;
                double days = Convert.ToDouble(textBox1.Text);
                if (h)
                {
                    ConvertToHours hours = new ConvertToHours();
                    result = hours.Convert(days);
                }    
                else if (m)
                {
                    ConvertToMinutes minutes = new ConvertToMinutes();
                    result = minutes.Convert(days);
                }
                else if (s)
                {
                    ConvertToSeconds seconds = new ConvertToSeconds();
                    result = seconds.Convert(days);
                }
                textBox2.Text = result.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                groupBox3.Visible = false;
                groupBox2.Visible = true;
                label1.Text = "Days";
                label2.Text = "";
                mass = false;
                length = false;
                time = true;
                money = false;
                customMoney = false;
            }
        }
    }
}
