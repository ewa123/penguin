using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            label1.Text = (((Math.Pow(Double.Parse(textBox1.Text),2)) / (19.6)) + (Double.Parse(textBox3.Text)) / (Double.Parse(textBox4.Text)) + (Double.Parse(textBox5.Text)) - ((Math.Pow(Double.Parse(textBox6.Text),2))  / (19.6)) - (Double.Parse(textBox8.Text)) / (Double.Parse(textBox4.Text)) - (Double.Parse(textBox10.Text))).ToString();
            label2.Text = (Double.Parse(textBox1.Text) - Double.Parse(textBox3.Text)-Double.Parse(textBox4.Text)).ToString();
            label3.Text = ((Math.Pow(Double.Parse(textBox1.Text), 2))/19.6).ToString();
            //label1.Text = ((Double.Parse(textBox1.Text) * Double.Parse(textBox1.Text)) / (2 * (Double.Parse(textBox2.Text))) + (Double.Parse(textBox3.Text) / (Double.Parse(textBox4.Text)) + (Double.Parse(textBox5.Text)) - ((Double.Parse(textBox6.Text)*Double.Parse(textBox6.Text)) / (2 * (Double.Parse(textBox7.Text))) + (Double.Parse(textBox8.Text)) / (Double.Parse(textBox4.Text)) + (Double.Parse(textBox10.Text))))).ToString();
           // label1.Text=(Double.Parse(textBox1.Text)/(2*(Double.Parse(textBox2.Text))))+Double.Parse(textBox3.Text)/Double.Parse(textBox4.Text)+Double.Parse(textBox5.Text)-(Double.Parse(textBox6.Text)/(2*(Double.Parse(textBox7.Text))))+(Double.Parse(textBox8.Text)/Double.Parse(textBox9.Text))+Double.Parse(textBox10.Text).ToString();
           // label2.Text = ((Double.Parse(textBox1.Text) * Double.Parse(textBox2.Text)) - (Double.Parse(textBox3.Text) * Double.Parse(textBox4.Text))).ToString();
        }
    }}
