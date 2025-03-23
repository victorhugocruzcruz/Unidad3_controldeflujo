namespace Practica6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Val1, farh1;
            Val1 = double.Parse(Valor1.Text);
            farh1 = Val1 * (9.0 / 5.0) + 32;
            Resultado.Text = farh1.ToString();
            label2.Text = "Equivalencia en Fahrenheint:";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Val1, cent1;
            Val1 = double.Parse(Valor1.Text);
            cent1 = (Val1 - 32) * (5.0 / 9.0);
            Resultado.Text = cent1.ToString();
            label2.Text = "Equivalencia en Centigrados";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Valor1.Clear();
            Resultado.Clear();
        }
    }
}
