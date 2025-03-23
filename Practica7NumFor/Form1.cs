namespace Practica7NumFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for ( int i = 0; i <= 5; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
