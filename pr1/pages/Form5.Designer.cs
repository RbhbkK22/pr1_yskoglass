namespace pr1
{
    partial class Form5
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
            treeView1 = new TreeView();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.BackColor = SystemColors.ActiveBorder;
            treeView1.Dock = DockStyle.Left;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(121, 761);
            treeView1.TabIndex = 9;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(776, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 761);
            panel1.TabIndex = 10;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 761);
            Controls.Add(panel1);
            Controls.Add(treeView1);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "№5 Помазов 185";
            Load += Form5_Load;
            SizeChanged += Form5_SizeChanged;
            ResumeLayout(false);
        }

        #endregion
        private TreeView treeView1;
        private Panel panel1;
    }
}