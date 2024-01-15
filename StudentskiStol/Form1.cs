using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiStol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            
            if (double.Parse(textBox1.Text)!=0)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    sum += 4.20 * double.Parse(textBox1.Text);
                    label3.Text = double.Parse(textBox1.Text) * 4.20 + "лв.";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    sum += 4.70 * double.Parse(textBox1.Text);
                    label3.Text = double.Parse(textBox1.Text) * 4.70 + "лв.";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    sum += 6.70 * double.Parse(textBox1.Text);
                    label3.Text = double.Parse(textBox1.Text) * 6.70 + "лв.";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    sum += 4.30 * double.Parse(textBox1.Text);
                    label3.Text = double.Parse(textBox1.Text) * 4.30 + "лв.";
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    sum += 4.00 * double.Parse(textBox1.Text);
                    label3.Text = double.Parse(textBox1.Text) * 4.00 + "лв.";
                }
            }
            if (double.Parse(textBox2.Text) != 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    sum += 7.10 * double.Parse(textBox2.Text);
                    label4.Text = double.Parse(textBox2.Text) * 7.10 + "лв.";
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    sum += 6.70 * double.Parse(textBox2.Text);
                    label4.Text = double.Parse(textBox2.Text) * 6.70 + "лв.";
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    sum += 8.00 * double.Parse(textBox2.Text);
                    label4.Text = double.Parse(textBox2.Text) * 8.00 + "лв.";
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    sum += 8.40 * double.Parse(textBox2.Text);
                    label4.Text = double.Parse(textBox2.Text) * 8.40 + "лв.";
                }
                else if (comboBox2.SelectedIndex == 4)
                {
                    sum += 6.50 * double.Parse(textBox2.Text);
                    label4.Text = double.Parse(textBox2.Text) * 6.50 + "лв.";
                }
            }
            if (double.Parse(textBox3.Text) != 0)
            {
                if (comboBox3.SelectedIndex == 0)
                {
                    sum += 4.40 * double.Parse(textBox3.Text);
                    label7.Text = double.Parse(textBox3.Text) * 4.40 + "лв.";
                }
                else if (comboBox3.SelectedIndex == 1)
                {
                    sum += 5.70 * double.Parse(textBox3.Text);
                    label7.Text = double.Parse(textBox3.Text) * 5.70 + "лв.";
                }
                else if (comboBox3.SelectedIndex == 2)
                {
                    sum += 4.70 * double.Parse(textBox3.Text);
                    label7.Text = double.Parse(textBox3.Text) * 4.70 + "лв.";
                }
                else if (comboBox3.SelectedIndex == 3)
                {
                    sum += 3.80 * double.Parse(textBox3.Text);
                    label7.Text = double.Parse(textBox3.Text) * 3.80 + "лв.";
                }
                else if (comboBox3.SelectedIndex == 4)
                {
                    sum += 4.00 * double.Parse(textBox3.Text);
                    label7.Text = double.Parse(textBox3.Text) * 4.00 + "лв.";
                }
            }
            if (double.Parse(textBox4.Text) != 0)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    sum += 3.00 * double.Parse(textBox4.Text);
                    label10.Text = double.Parse(textBox4.Text) * 3.00 + "лв.";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    sum += 3.00 * double.Parse(textBox4.Text);
                    label10.Text = double.Parse(textBox4.Text) * 3.00 + "лв.";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    sum += 2.80 * double.Parse(textBox4.Text);
                    label10.Text = double.Parse(textBox4.Text) * 2.80 + "лв.";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    sum += 2.50 * double.Parse(textBox4.Text);
                    label10.Text = double.Parse(textBox4.Text) * 2.50 + "лв.";
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    sum += 2.70 * double.Parse(textBox4.Text);
                    label10.Text = double.Parse(textBox4.Text) * 2.70 + "лв.";
                }
            }
            
            MessageBox.Show("Ти дължиш: " + sum + "лв.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
            textBox4.Text = "1";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }
    }
}
