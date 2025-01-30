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
    public partial class Form9 : Form
    {
        PictureBox pictureBox1;
        Label label1;
        Point spotClicked;

        public Form9()
        {

            this.Size = new Size(640, 480);
            StartPosition = FormStartPosition.CenterScreen;

            pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("images/choto.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Dock = DockStyle.Fill;

            Button backbtn = new Button();
            backbtn.Text = "<- Back";
            backbtn.Location = new Point(600, 400);
            backbtn.Click += new EventHandler(backbtn_Click);

            label1 = new Label();
            label1.Text = "При нажатой левой кнопке мыши можно рисовать прямоугольники. " +
                "Нажатая правая кнопка изменяет яркость прямоугольника " +
                "Нажав ЅHIFT и перемещая мышь, рисуем голубые круги." + "При нажатии Enter вы вернетесь на предыдущию страницу";
            label1.BackColor = Color.Wheat;
            label1.Dock = DockStyle.Bottom;
            label1.TextAlign = ContentAlignment.MiddleCenter;


            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(backbtn);

            pictureBox1.MouseDown += new MouseEventHandler(MouseButtonsIsDown);
            pictureBox1.MouseUp += new MouseEventHandler(MouseButtonIsUp);
            pictureBox1.MouseMove += new MouseEventHandler(TheMouseMoved);

            InitializeComponent();

            AppStateHandler.AddClosHandler(this);
        }

        private void TheMouseMoved(object? sender, MouseEventArgs e)
        {
            if ((ModifierKeys & Keys.Shift) ==  Keys.Shift)
            {
                Graphics g = pictureBox1.CreateGraphics();  

                Pen yePen = new Pen(Color.Blue, 2);

                g.DrawEllipse(yePen, e.X, e.Y, 10, 10);
                g.Dispose();
            }
        }

        private void MouseButtonIsUp(object? sender, MouseEventArgs e)
        {
            Rectangle r = new Rectangle();
            r.X = spotClicked.X;
            r.Y = spotClicked.Y;

            r.Width = e.X - spotClicked.X;
            r.Height = e.Y - spotClicked.Y;

            if (e.Button == MouseButtons.Left)
            {
                Graphics g = pictureBox1.CreateGraphics();

                Pen gPen = new Pen(Color.Green, 2);
                g.DrawRectangle(gPen, r);
            }
            else { 
                ChangeLightness(r);
            }

        }

        public void ChangeLightness(Rectangle rect)
        {
            int newRed, newGreen, newBlue;
            Color pixel;
            Bitmap picture = new Bitmap(pictureBox1.Image);
            if ((rect.Width > 150) || (rect.Height > 150))
            {
                DialogResult result = MessageBox.Show("Выделенная область велика! " +
                "Изменение яркости может требовать значительного времени!",
                "Warning", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            for (int x = rect.X; x < rect.X + rect.Width; x++)
            {


                for (int y = rect.Y; y < (rect.Y + rect.Height); y++)
                {

                    pixel = picture.GetPixel(x, y);

                    newRed = (int)Math.Round(pixel.R * 2.0, 0);
                    if (newRed > 255) newRed = 255;
                    newGreen = (int)Math.Round(pixel.G * 2.0, 0);
                    if (newGreen > 255) newGreen = 255;
                    newBlue = (int)Math.Round(pixel.B * 2.0, 0);
                    if (newBlue > 255) newBlue = 255;
                    picture.SetPixel(x, y, Color.FromArgb((byte)newRed, (byte)newGreen, (byte)newBlue));
                }
            }
            this.pictureBox1.Image = picture;   
        }

        private void MouseButtonsIsDown(object? sender, MouseEventArgs e)
        {
            spotClicked.X = e.X;
            spotClicked.Y = e.Y;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex - 1);

        }


        private void Form9_Load(object sender, EventArgs e)
        {

           
        }
    }
}
