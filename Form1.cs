﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programowanie_wizualne_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DateTime.Now.ToString();
            label1.Text = DateTime.Now.ToString(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime.Now.ToString();
            label1.Text = DateTime.Now.ToString();
        }

        private void Form1_Tick(object sender, EventArgs e)
        {
            DateTime.Now.ToString();
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
