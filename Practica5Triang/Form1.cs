using System.Diagnostics.Eventing.Reader;

namespace Practica5Triang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;
            lado1 = double.Parse(textBox1.Text);
            lado2 = double.Parse(textBox2.Text);
            lado3 = double.Parse(textBox3.Text);

            if ((lado1 == lado2) && (lado2 == lado3))
                textBox4.Text = " Equilatero ";
            else
                if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
                textBox4.Text = " Isosceles ";
            else textBox4.Text = " Escaleno";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
