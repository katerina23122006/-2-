﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_2_формами
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void buttonGetinfoFrm1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = this.Owner as Form1;
            textBox1.Text = frm1.textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = this.Owner as Form1;
            frm1.textBox1.Text = textBox2.Text;
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
