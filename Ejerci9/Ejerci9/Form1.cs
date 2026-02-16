namespace Ejerci9
{
    public partial class Numero : Form
    {
        public Numero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroTexto = textBox1.Text;
            if (int.TryParse(numeroTexto, out int numero))
            {
                if (numero % 2 == 0)
                {
                    MessageBox.Show("El número es par.");
                }
                else
                {
                    MessageBox.Show("El número es impar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");

            }
        }
    }
}

