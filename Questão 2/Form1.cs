namespace Questão_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Real;
            double Dolar;
            double cotacao;
            Dolar = Convert.ToDouble(txtdolar.Text);
            cotacao = Convert.ToDouble(txtdolar.Text);
            Real = Dolar * cotacao;

            Resultadoo.Text= "R$" + Real;
        }
    }
}
