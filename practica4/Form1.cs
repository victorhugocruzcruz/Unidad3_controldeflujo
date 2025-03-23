namespace practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radio, Altura;
            double BaseArea, LateralArea, TotalArea;
            double Volumen;

            Radio = double.Parse(textBox1.Text);
            Altura = double.Parse(textBox2.Text);

            BaseArea = Radio * Radio * Math.PI;
            LateralArea = 2 * Math.PI * Radio * Altura;
            TotalArea = (2 * BaseArea) + LateralArea;
            Volumen = BaseArea * Altura;

            textBox3.Text = BaseArea.ToString("0.##");
            textBox4.Text = LateralArea.ToString("0.##");
            textBox5.Text = TotalArea.ToString("0.##");
            textBox6.Text = Volumen.ToString("0.##");


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
