namespace pr1
{
    partial class Form8
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
            button1 = new Button();
            SuspendLayout();
            // 
            // backbtn
            // 
            backbtn.Location = new Point(723, 556);
            backbtn.Margin = new Padding(3, 4, 3, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(86, 31);
            backbtn.TabIndex = 12;
            backbtn.Text = "<- Back";
            backbtn.UseVisualStyleBackColor = true;
            // 
            // nextbtn
            // 
            nextbtn.Location = new Point(816, 556);
            nextbtn.Margin = new Padding(3, 4, 3, 4);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(86, 31);
            nextbtn.TabIndex = 11;
            nextbtn.Text = "Next ->";
            nextbtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(396, 219);
            button1.Name = "button1";
            button1.Size = new Size(102, 70);
            button1.TabIndex = 13;
            button1.Text = "будем рисовать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(backbtn);
            Controls.Add(nextbtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "№8 Помазов 185";
            Load += Form8_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button backbtn;
        private Button nextbtn;
        private Button button1;
    }
}