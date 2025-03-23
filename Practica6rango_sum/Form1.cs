namespace Practica6rango_sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RangoI, RangoS, Suma = 0;

            RangoI = int.Parse(textBox1.Text);
            RangoS = int.Parse(textBox2.Text);
            for (int i = RangoI; i <= RangoS; i++)
            {
                listBox1.Items.Add(i);
                Suma = Suma + i;
            }
            textBox3.Text = Suma.ToString();
        }
    }
}
