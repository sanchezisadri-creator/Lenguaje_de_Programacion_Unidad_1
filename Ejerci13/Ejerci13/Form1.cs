namespace Ejerci13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10; 
            }
            else
            {
                MessageBox.Show("La barra de progreso finalizo.");
            }
        }
    }
}
