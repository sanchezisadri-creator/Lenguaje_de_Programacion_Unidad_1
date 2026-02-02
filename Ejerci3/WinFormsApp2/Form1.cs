namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exotico_1.Text = "Exotico:" + textBox1.Text;
            exotico_1.Visible = true;
        }
    }
}
