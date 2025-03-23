namespace Practica4Ordenar_num
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, C;

            // Parseamos los valores de los TextBox
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = int.Parse(textBox3.Text);

            // Ordenar los n�meros en orden descendente
            if (A >= B && A >= C)
            {
                // A es el mayor
                textBox4.Text = A.ToString();

                if (B >= C)
                {
                    textBox5.Text = B.ToString();
                    textBox6.Text = C.ToString();
                }
                else
                {
                    textBox5.Text = C.ToString();
                    textBox6.Text = B.ToString();
                }
            }
            else if (B >= A && B >= C)
            {
                // B es el mayor
                textBox4.Text = B.ToString();

                if (A >= C)
                {
                    textBox5.Text = A.ToString();
                    textBox6.Text = C.ToString();
                }
                else
                {
                    textBox5.Text = C.ToString();
                    textBox6.Text = A.ToString();
                }
            }
            else
            {
                // C es el mayor
                textBox4.Text = C.ToString();

                if (A >= B)
                {
                    textBox5.Text = A.ToString();
                    textBox6.Text = B.ToString();
                }
                else
                {
                    textBox5.Text = B.ToString();
                    textBox6.Text = A.ToString();
                }
            }

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
