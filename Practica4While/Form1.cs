namespace Practica4While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            while (a <= 20)
            {
                Lista.Items.Add(a);
                a++;
            }
        }
    }
}
