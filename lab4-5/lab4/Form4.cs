﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            double b, c;

            textBox1.Text = textBox1.Text.Replace(",", "");
            string[] textArray = textBox1.Text.Split(new char[] { ' ', '.', ',' });
            a  = (textArray.Length);
            label6.Text = a.ToString();
            b = Convert.ToDouble(textBox2.Text);
            c = a * b;
            label7.Text = c.ToString();





        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
