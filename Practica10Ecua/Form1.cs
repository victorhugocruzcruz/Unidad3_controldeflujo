namespace Practica10Ecua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int X = 0; X <= 10; X++)
            {
                listBox1.Items.Add(X);
                double fx = X / (1.0 + X * X);
                listBox2.Items.Add(fx);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int X1 = 1;
            while (X1 <= 10)
            {
                listBox1.Items.Add(X1);
                double fx = X1 / (1.0 + X1 * X1!);
                listBox2.Items.Add(fx);
                X1++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int X2 = 1;
            do
            {
                listBox1.Items.Add(X2);
                double fx = X2 / (1.0 + X2 * X2);
                listBox2.Items.Add(fx);
                X2++;
            } while (X2 <= 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
