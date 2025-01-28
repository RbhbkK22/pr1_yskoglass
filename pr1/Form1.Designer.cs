namespace pr1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            c = new Button();
            SuspendLayout();
            // 
            // c
            // 
            c.Location = new Point(713, 415);
            c.Name = "c";
            c.Size = new Size(75, 23);
            c.TabIndex = 0;
            c.Text = "Next ->";
            c.UseVisualStyleBackColor = true;
            c.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(c);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "№1 Помазов 185";
            ResumeLayout(false);
        }

        #endregion

        private Button c;
    }
}
