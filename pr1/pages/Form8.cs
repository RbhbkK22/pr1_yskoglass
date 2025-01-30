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
            DrowShpes();
        }

        private void DrowShpes()
        {
            Graphics g = CreateGraphics();
            Pen redPen = new Pen(Color.Red, 3);
            g.DrawLine(redPen, 140,170,170,230);
            g.DrawRectangle(redPen, 50, 60, 150, 60);
            g.DrawEllipse(redPen, 150, 100, 70, 60);
            g.Dispose();
        }
    }
}
