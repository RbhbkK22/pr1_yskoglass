﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pr1.core;

namespace pr1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            AppStateHandler.AddClosHandler(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Кнопка нажата";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex - 1);

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex + 1);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
