namespace Ejerci12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            string entrada = Celsius.Text.Trim();

            if (double.TryParse(entrada, out double tempC))
            {
                double tempF = (tempC * 9 / 5) + 32; 
                Resultado.Text = $"Temperatura en °F: {tempF:F2}"; 
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Celsius.Clear();
                Celsius.Focus();
            }
        }
    }
}
