namespace Atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius;
            double fahrenheit;
       
            celsius = Convert.ToDouble(txtCelsius.Text);

            fahrenheit = (celsius * 9 / 5) + 32;
           resultado.Text = fahrenheit.ToString();

            Console.WriteLine( resultado.Text  );
            

        }
    }
}

