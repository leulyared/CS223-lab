﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5th_july
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username =uu.Text;
            string password =pp.Text;
            if(username == "kaka" && password == "popo")
            {
               Form1 form1 = new Form1(username);
                Hide();
                form1.Show();

            }
            else
            {
                MessageBox.Show("incorrect user or password");
            }

        }
    }
}
