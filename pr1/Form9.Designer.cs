namespace pr1
{
    partial class Form9
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
            SuspendLayout();
            // 
            // backbtn
            // 
            backbtn.Location = new Point(713, 415);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(75, 23);
            backbtn.TabIndex = 12;
            backbtn.Text = "<- Back";
            backbtn.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backbtn);
            Name = "Form9";
            Text = "№ 9 Помазов 185";
            Load += Form9_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button backbtn;
    }
}