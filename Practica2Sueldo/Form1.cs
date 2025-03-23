namespace Practica2Sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo, aum, nsueldo;
            sueldo = double.Parse(textBox1.Text);
            if (sueldo < 400000.00)
            {
                aum = sueldo * 0.15;
            }
            else
            {
                aum = sueldo * 0.08;
            }
            nsueldo = sueldo + aum;
            textBox2.Text = nsueldo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
