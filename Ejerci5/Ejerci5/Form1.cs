namespace Ejerci5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo_colores.Items.Add("Rojo");
            combo_colores.Items.Add("Verde");
            combo_colores.Items.Add("Azul");
        }

        private void combo_colores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_colores.SelectedItem != null)
            {
                string color = combo_colores.SelectedItem.ToString();

                if (color == "Rojo")
                    this.BackColor = Color.Red;
                else if (color == "Verde")
                    this.BackColor = Color.Green;
                else if (color == "Azul")
                    this.BackColor = Color.Blue;
            }
        }
    }
}



