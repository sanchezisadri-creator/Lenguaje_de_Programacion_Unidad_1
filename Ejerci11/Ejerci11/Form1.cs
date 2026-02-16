namespace Ejerci11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarFecha_Click(object sender, EventArgs e)
        {
            EtiquetaFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }
    }
}
