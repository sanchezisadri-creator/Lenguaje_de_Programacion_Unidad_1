namespace Ejerci14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Has seleccionado la pestaña 1");
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                MessageBox.Show("Has seleccionado la pestaña 2");
            }
        }
    }
}
