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
    public partial class Form7 : Form
    {
        private Image image = new Bitmap("images/ktoto.jpg");
        public Form7()
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

        private void reversePhoto(object sender, EventArgs e)
        {
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = image;
            button1.Text = "Рисунок после поворота!";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            button1.Text = "Рисунок до поворота!";
            backbtn.Click += backbtn_Click;
            nextbtn.Click += nextbtn_Click;
            button1.Click += reversePhoto;
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
