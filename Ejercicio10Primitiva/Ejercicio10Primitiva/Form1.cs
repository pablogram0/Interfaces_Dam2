﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10Primitiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for(int i = 1; i < 49; i++)
            {
                checkedListBox1.Items.Add(i.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 6)
            {
                MessageBox.Show("Selecciona 6 numeros para jugar");
            }
            else
            {
                checkedListBox1.Enabled = false;

            }
                
        }
    }
}