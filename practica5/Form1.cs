namespace practirca5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Valor1 = float.Parse(textBox1.Text);
            float Valor2 = float.Parse(textBox2.Text);

            float Valor3 = Valor1 * Valor2 / 2;

            textBox3.Text = Valor3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
