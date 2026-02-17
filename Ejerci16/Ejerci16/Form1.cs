using System;
using System.Windows.Forms;

namespace Ejerci16
{
    public partial class Form1 : Form
    {
        
        double Resultado = 0;
        string Operacion = "";
        bool NuevaOperacion = true;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) { AgregarNumero("1"); }
        private void button2_Click(object sender, EventArgs e) { AgregarNumero("2"); }
        private void button3_Click(object sender, EventArgs e) { AgregarNumero("3"); }
        private void button4_Click(object sender, EventArgs e) { AgregarNumero("4"); }
        private void button5_Click(object sender, EventArgs e) { AgregarNumero("5"); }
        private void button6_Click(object sender, EventArgs e) { AgregarNumero("6"); }
        private void button7_Click(object sender, EventArgs e) { AgregarNumero("7"); }
        private void button8_Click(object sender, EventArgs e) { AgregarNumero("8"); }
        private void button9_Click(object sender, EventArgs e) { AgregarNumero("9"); }
        private void button0_Click(object sender, EventArgs e) { AgregarNumero("0"); }

        private void AgregarNumero(string num)
        {
            if (Pantalla.Text == "0" || NuevaOperacion)
            {
                Pantalla.Text = num;
                NuevaOperacion = false;
            }
            else
            {
                Pantalla.Text += num;
            }
        }

        
        private void buttonSumar_Click(object sender, EventArgs e) { OperacionBoton("+"); }
        private void buttonRestar_Click(object sender, EventArgs e) { OperacionBoton("-"); }
        private void buttonMultiplicar_Click(object sender, EventArgs e) { OperacionBoton("*"); }
        private void buttonDividir_Click(object sender, EventArgs e) { OperacionBoton("/"); }

        private void OperacionBoton(string op)
        {
            if (Resultado != 0)
            {
                Calcular();
                Operacion = op;
                NuevaOperacion = true;
            }
            else
            {
                Resultado = double.Parse(Pantalla.Text);
                Operacion = op;
                NuevaOperacion = true;
            }
        }

       
        private void Calcular()
        {
            double numeroActual = double.Parse(Pantalla.Text);

            switch (Operacion)
            {
                case "+":
                    Resultado += numeroActual;
                    break;
                case "-":
                    Resultado -= numeroActual;
                    break;
                case "*":
                    Resultado *= numeroActual;
                    break;
                case "/":
                    if (numeroActual != 0)
                        Resultado /= numeroActual;
                    else
                    {
                        MessageBox.Show("No se puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Resultado = 0;
                    }
                    break;
                default:
                    Resultado = numeroActual;
                    break;
            }

            Pantalla.Text = Resultado.ToString();
        }

        
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "0";
            Resultado = 0;
            Operacion = "";
            NuevaOperacion = true;
        }
    }
}




