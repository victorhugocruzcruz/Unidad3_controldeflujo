namespace Practica3Par_div3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);
            if (num % 2 == 0)
            {
                MessageBox.Show(" El número es par ");
            }
            else
            {
                if (num % 3 == 0) MessageBox.Show(" El número es impar y es divisible por 3");
                else MessageBox.Show(" El número es impar y no es divisible por 3");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
