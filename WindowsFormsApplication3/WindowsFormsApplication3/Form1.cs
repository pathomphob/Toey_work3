using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = a + b;
            textBox3.Text = Convert.ToString(c);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = a - b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = a * b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = a / b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = Math.Pow(a,b);
            textBox3.Text = Convert.ToString(c);
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.SettextBox1 = textBox3.Text;
            frm.Show();

        }      
        }
    }


    

