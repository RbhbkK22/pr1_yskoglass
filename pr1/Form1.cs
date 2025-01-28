namespace pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AppStateHandler.AddClosHandler(this);
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppStateHandler.GoToForm(AppStateHandler.CurrentIndex + 1);
        }
    }
}
