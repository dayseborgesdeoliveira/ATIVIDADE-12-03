namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcule_Click(object sender, EventArgs e)
        {
            double distancia;
            double preco;

            distancia = Convert.ToDouble(txtkm.Text);

            if (distancia > 200)
            {
                preco = distancia * 0,50;
            }

            else
            {
                preco = distancia * 0,45;
            }

            txtvalor.Text = "R$ " + preco;

        
        }
    }
}
