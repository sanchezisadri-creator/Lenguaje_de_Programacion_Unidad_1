namespace ejerci4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonSumar_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(cajaNumero1.Text);
            int numero2 = int.Parse(cajaNumero2.Text);

            int suma = numero1 + numero2;

            labelResultado.Text = "El resultado es: " + suma;
            labelResultado.Visible = true;
        }
    }
}
