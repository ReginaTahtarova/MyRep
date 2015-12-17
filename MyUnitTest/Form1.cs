using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyUnitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                var a = Convert.ToDouble(textBox1.Text);
                var b = Convert.ToDouble(textBox2.Text);
                var result = Class1.Function(a, b);
                if (result.Length == 1)
                    textBox3.Text = result[0].ToString();
                else
                    MessageBox.Show("Недостаточно средств на счете");
            }
            else
                MessageBox.Show("Не все данные введены");
        }
    }
}