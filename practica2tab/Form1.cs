using System.Reflection.Metadata;

namespace practica2tab
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

        private void Calcular_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, count = 0, Limite;
            n = int.Parse(textBox1.Text);
            Limite = int.Parse(textBox2.Text);
            do
            {
                Calcular.Items.Add(n + " * " + count + " = " + n * count);
                count++;
            } while (count <= Limite);

        }
    }
}
