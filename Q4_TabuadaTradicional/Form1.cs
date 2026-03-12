namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(txtNumero);

            lstTabuada.Items.Clear();
            for (int i = 1; i <= 10; i ++)
            {
                lstTabuada.Items.Add(numero + "x" + i + "=" + (numero * 1));
            }
        }
    }
}


