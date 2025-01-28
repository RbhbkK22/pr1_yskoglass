namespace pr1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            backbtn = new Button();
            nextbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(215, 188);
            button1.Name = "button1";
            button1.Size = new Size(90, 62);
            button1.TabIndex = 0;
            button1.Text = "Нажми на меня";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Пес", "Степь", "Озеро", "Море", "Океан" });
            listBox1.Location = new Point(12, 188);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 139);
            listBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 170);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(335, 399);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(75, 23);
            backbtn.TabIndex = 6;
            backbtn.Text = "<- Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // nextbtn
            // 
            nextbtn.Location = new Point(416, 399);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 23);
            nextbtn.TabIndex = 5;
            nextbtn.Text = "Next ->";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 434);
            Controls.Add(backbtn);
            Controls.Add(nextbtn);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "№4 Помазов 185";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Button backbtn;
        private Button nextbtn;
    }
}