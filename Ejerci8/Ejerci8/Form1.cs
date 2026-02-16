namespace Ejerci8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int  Label1 = 0;
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
              Label1.Text = (Convert.ToInt32(Label1.Text) + 1).ToString();

        }
    }
}
