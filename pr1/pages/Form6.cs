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
    public partial class Form6 : Form
    {
        public Form6()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            AppStateHandler.AddClosHandler(this);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex - 1);

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex + 1);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("images/peyzagh.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
