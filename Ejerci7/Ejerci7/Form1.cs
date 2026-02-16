using System;
using System.Windows.Forms;

namespace Ejerci7
{
    public partial class listaElementos : Form
    {
        public listaElementos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Debe escribir algo primero");
            }
        }
    }
}




