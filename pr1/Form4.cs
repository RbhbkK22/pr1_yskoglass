using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            AppStateHandler.AddClosHandler(this);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex - 1);

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show(this, $"Вы ничего не выбрали", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, $"Вы выбрли {listBox1.SelectedItem}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
