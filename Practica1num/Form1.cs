namespace Practica1num
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            do
            {
                Numeros.Items.Add(x);
                x++;
            }
            while (x <= 10);
        }
    }
}
