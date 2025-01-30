using System;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            AppStateHandler.AddClosHandler(this);
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex - 1);

        }

        private void nextbtn_Click(object? sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex + 1);
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            backbtn.Click += backbtn_Click;
            nextbtn.Click += nextbtn_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DrowShpes()
        {
            
        }
    }
}
