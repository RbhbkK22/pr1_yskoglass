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
    public partial class Form5 : Form
    {
        CheckBox checkBox1;
        CheckBox checkBox2;
        RadioButton radioButton1;
RadioButton radioButton2;
        ListBox listBox1;

        public Form5()
        {
            InitializeComponent();
            AppStateHandler.AddClosHandler(this);
            treeView1.BackColor = Color.BurlyWood;
            panel1.Width = this.Width - treeView1.Width;

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex - 1);

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex + 1);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode("Элименты");
            tn.Expand();

            tn.Nodes.Add(new TreeNode("[Очистить]"));
            tn.Nodes.Add(new TreeNode("Label"));
            tn.Nodes.Add(new TreeNode("Button"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("RadioButton"));
            tn.Nodes.Add(new TreeNode("ListBox"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("TabControl"));
            tn.Nodes.Add(new TreeNode("DataGridView"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("RichTextBox"));

            treeView1.Nodes.Add(tn);

            Button nextbtn = new Button();
            nextbtn.Text = "Next ->";
            nextbtn.Location = new Point(690, 726);
            nextbtn.Click += new EventHandler(nextbtn_Click);

            Button backbtn = new Button();
            backbtn.Text = "<- Back";
            backbtn.Location = new Point(610, 726);
            backbtn.Click += new EventHandler(backbtn_Click);
            panel1.Controls.Add(nextbtn);
            panel1.Controls.Add(backbtn);

        }

        private void Form5_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = this.Width - treeView1.Width;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "[Очистить]")
            {
                panel1.Controls.Clear();
            }
            else if (e.Node.Text == "Button")
            {
                Button btn1 = new Button();
                btn1.Text = "Нажми на меня!";
                btn1.Location = new Point(300, 20);
                btn1.Height = 40;
                btn1.Width = 120;
                btn1.Click += new EventHandler(button1_Click);
                panel1.Controls.Add(btn1);
            }
            else if (e.Node.Text == "Label")
            {
                Label label1 = new Label();
                label1.Text =
                "Это надпись. Используется для вывода текста на экран";
                label1.Location = new Point(180, 70);
                label1.Width = 400;
                label1.Click += new EventHandler(label1_Click);
                panel1.Controls.Add(label1);
            }
            else if (e.Node.Text == "CheckBox")
            {
                checkBox1 = new CheckBox();
                checkBox1 = new CheckBox();
                checkBox1.Text = "я способный";
                checkBox1.Location = new Point(20, 40);
                checkBox1.Width = 150;
                checkBox1.CheckedChanged +=
                new EventHandler(CheckBox_CheckedChanged);
                panel1.Controls.Add(checkBox1);
                 checkBox2 = new CheckBox();
                checkBox2.Text = "я скромный";
                checkBox2.Location = new Point(20, 80);
                checkBox2.Width = 150;
                checkBox2.CheckedChanged +=
                new EventHandler(CheckBox_CheckedChanged);
                panel1.Controls.Add(checkBox2);
            }
            else if (e.Node.Text == "RadioButton")
            {
                radioButton1 = new RadioButton();
                radioButton1.Text = "Я добрый";
                radioButton1.Location = new Point(20, 120);
                radioButton1.Width = 150;
                radioButton1.CheckedChanged +=
                new EventHandler(RadioButton_CheckedChanged);

                panel1.Controls.Add(radioButton1);

                radioButton2 = new RadioButton();
                radioButton2.Text = "я трудолюбивый!";
                radioButton2.Location = new Point(20, 160);
                radioButton2.Width = 150;
                radioButton2.CheckedChanged +=
                new EventHandler(RadioButton_CheckedChanged);
                panel1.Controls.Add(radioButton2);

            }
            else if (e.Node.Text == "ListBox")
            {
                listBox1 = new ListBox();
                listBox1.Items.Add("Зеленый");
                listBox1.Items.Add("Желтый");
                listBox1.Items.Add("Голубой");
                listBox1.Items.Add("Серый");

                listBox1.Location = new Point(20, 250);
                listBox1.Width = 100; listBox1.Height = 100;
                listBox1.SelectedIndexChanged +=
                new EventHandler(listBox1_SelectedIndexChanged);

                panel1.Controls.Add(listBox1);
            }
            else if (e.Node.Text == "TextBox")
            {
               

                TextBox textBox1 = new TextBox();
                textBox1.Multiline = true;
                textBox1.Text = "Сюда можно воводить текст";
                textBox1.Location = new Point(180, 100);
                textBox1.Width = 400; textBox1.Height = 40;
                panel1.Controls.Add(textBox1);
            }
            else if (e.Node.Text == "DataGridView")
            {
                DataSet dataSet1 = new DataSet("#@8<5@ DataSet");
                dataSet1.ReadXml("..//..//images//marks.xml");

                DataGridView dataGridView1 = new DataGridView();
                dataGridView1.Width = 250;
                dataGridView1.Height = 150;
                dataGridView1.Location = new Point(20, 500);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dataSet1;
                dataGridView1.DataMember = "предметы";
                dataGridView1.DataMember = "оценка";
                dataGridView1.ColumnCount = 2;
                panel1.Controls.Add(dataGridView1);
            }
            else if (e.Node.Text == "TabControl")
            {
              
                TabControl tabControl1 = new TabControl();
                tabControl1.Location = new Point(190, 150);
                tabControl1.Size = new Size(300, 300);

                TabPage tabPage1 = new TabPage("ктото");
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap("images/ktoto.jpg");

                pictureBox1.Size = new Size(300, 200);
                tabPage1.Controls.Add(pictureBox1);
                Label labelV = new Label();
                labelV.Top = 200;
                labelV.Size = new Size(300, 50);
                labelV.Text = "это ктото и от чтото любит";
                tabPage1.Controls.Add(labelV);
                tabControl1.TabPages.Add(tabPage1);

                TabPage tabPage2 = new TabPage("чтото");
                PictureBox pictureBox2 = new PictureBox();
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = new Bitmap("images/choto.jpg");
                pictureBox2.Size = new Size(300, 200);
                tabPage2.Controls.Add(pictureBox2);
                Label labelС = new Label();
                labelС.Top = 200;
                labelС.Size = new Size(300, 50);
                labelС.Text = "это чтото когото";
                tabPage2.Controls.Add(labelС);
                tabControl1.TabPages.Add(tabPage2);

                TabPage tabPage3 = new TabPage("гдето");
                PictureBox pictureBox3 = new PictureBox();
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = new Bitmap("images/peyzagh.jpg");
                pictureBox3.Size = new Size(300, 200);
                tabPage3.Controls.Add(pictureBox3);
                Label labelT = new Label();
                labelT.Top = 200;
                labelT.Size = new Size(300, 50);
                labelT.Text = "это гдето";
                tabPage3.Controls.Add(labelT);
                tabControl1.TabPages.Add(tabPage3);

                panel1.Controls.Add(tabControl1);
            }
            else if (e.Node.Text == "PictureBox")
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Image = new Bitmap("images/peyzagh.jpg");
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.Location = new Point(500, 250);
                pictureBox1.Size = new Size(250, 200);

                panel1.Controls.Add(pictureBox1);
            }
            else if (e.Node.Text == "RichTextBox")
            {
                RichTextBox richTextBox1 = new RichTextBox();
                richTextBox1.LoadFile("..//..//images//marks.xml",
                RichTextBoxStreamType.UnicodePlainText);
                richTextBox1.WordWrap = false;
                richTextBox1.BorderStyle = BorderStyle.Fixed3D;
                richTextBox1.BackColor = Color.Beige;
                richTextBox1.Size = new Size(250, 150);
                richTextBox1.Location = new Point(300, 500);
               
                panel1.Controls.Add(richTextBox1);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Событие на метке");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("вы нажали на кнопку");
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                
                MessageBox.Show("У Вас все получится!");
            }
            else if (checkBox1.Checked)
            {
                MessageBox.Show("Не здорово быть умным и не скромным!");
            }
            else if (checkBox2.Checked)
            {
                MessageBox.Show("Скромность украшает. Хорошо бы еще быть умным!");
            }
            else
            {
                MessageBox.Show("Ни скромности, ни таланта?");
            }
        }
        private void RadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Доброту все любят!");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Это замечательно!");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)

        {
            switch (listBox1.SelectedItem.ToString())
            {
                case ("Зеленый"): treeView1.BackColor = Color.Green; break;
                case ("Желтый"): treeView1.BackColor = Color.Yellow; break;
                case ("Голубой"): treeView1.BackColor = Color.Blue; break;
                case ("Серый"): treeView1.BackColor = Color.Gray; break;
            }
        }
    }
 }

