namespace pr1
{
    partial class Form7
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
            backbtn = new Button();
            nextbtn = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backbtn
            // 
            backbtn.Location = new Point(503, 413);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(75, 23);
            backbtn.TabIndex = 10;
            backbtn.Text = "<- Back";
            backbtn.UseVisualStyleBackColor = true;
            // 
            // nextbtn
            // 
            nextbtn.Location = new Point(584, 413);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 23);
            nextbtn.TabIndex = 9;
            nextbtn.Text = "Next ->";
            nextbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(647, 280);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(291, 314);
            button1.Name = "button1";
            button1.Size = new Size(123, 67);
            button1.TabIndex = 12;
            button1.Text = "Поворот рисунка";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 448);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(backbtn);
            Controls.Add(nextbtn);
            Name = "Form7";
            Text = "№7 Помазов 185";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backbtn;
        private Button nextbtn;
        private PictureBox pictureBox1;
        private Button button1;
    }
}