namespace pr1
{
    partial class Form3
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
            button1 = new Button();
            backbtn = new Button();
            nextbtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(379, 197);
            button1.Name = "button1";
            button1.Size = new Size(75, 63);
            button1.TabIndex = 0;
            button1.Text = "Нажми на меня!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(632, 415);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(75, 23);
            backbtn.TabIndex = 4;
            backbtn.Text = "<- Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // nextbtn
            // 
            nextbtn.Location = new Point(713, 415);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 23);
            nextbtn.TabIndex = 3;
            nextbtn.Text = "Next ->";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backbtn);
            Controls.Add(nextbtn);
            Controls.Add(button1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "№3 Помазов 185";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button backbtn;
        private Button nextbtn;
    }
}