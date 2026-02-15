namespace Ejerci1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Este programa te dice que opcion seleccionaste cuando presionas aceptar");
            if (radioButton1.Checked)
            {
                Console.WriteLine("Seleccionaste la opcion 1");
            }
            else if (radioButton2.Checked)
            {
                Console.WriteLine("Seleccionaste la opcion 2");
            }
            else if (radioButton3.Checked)
            {
                Console.WriteLine("Seleccionaste la opcion 3");
            }
             else
            {
                Console.WriteLine("No seleccionaste ninguna opcion");
            }
        }
    }
}
