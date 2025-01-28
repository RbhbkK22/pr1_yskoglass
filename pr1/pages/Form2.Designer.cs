namespace pr1
{
    partial class Form2
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
            nextbtn = new Button();
            backbtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(325, 173);
            button1.Name = "button1";
            button1.Size = new Size(85, 85);
            button1.TabIndex = 0;
            button1.Text = "Нажми на меня!";
            button1.UseVisualStyleBackColor = true;
            // 
            // nextbtn
            // 
            nextbtn.Location = new Point(713, 415);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 23);
            nextbtn.TabIndex = 1;
            nextbtn.Text = "Next ->";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(632, 415);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(75, 23);
            backbtn.TabIndex = 2;
            backbtn.Text = "<- Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backbtn);
            Controls.Add(nextbtn);
            Controls.Add(button1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "№2 Помазов 185";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button nextbtn;
        private Button backbtn;
    }
}