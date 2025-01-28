namespace pr1
{
    partial class Form6
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
            pictureBox1 = new PictureBox();
            backbtn = new Button();
            nextbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 351);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(632, 415);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(75, 23);
            backbtn.TabIndex = 8;
            backbtn.Text = "<- Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // nextbtn
            // 
            nextbtn.Location = new Point(713, 415);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 23);
            nextbtn.TabIndex = 7;
            nextbtn.Text = "Next ->";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backbtn);
            Controls.Add(nextbtn);
            Controls.Add(pictureBox1);
            Name = "Form6";
            Text = "№6 Помазов 185";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backbtn;
        private Button nextbtn;
    }
}