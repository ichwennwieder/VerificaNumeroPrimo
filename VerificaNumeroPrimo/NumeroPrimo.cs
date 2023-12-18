namespace VerificaNumeroPrimo
{
    public partial class TxtNumero : Form
    {
        public TxtNumero()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(txtPrimo.Text))
                int.TryParse(txtPrimo.Text, out i);

            bool boEhPrimo = VerificaSeEhPrimo(i);

            if (boEhPrimo)
                MessageBox.Show("O n�mero � primo!");
            else
                MessageBox.Show("O n�mero n�o � primo!");
        }

        private bool VerificaSeEhPrimo(int numero)
        {
            if (numero < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int x = 0;
            int iSomaTotal = 0;
            if (!string.IsNullOrEmpty(txtSoma.Text))
                int.TryParse(txtSoma.Text, out x);

            for (int i = 2; i <= x; i++)
            {
                if (VerificaSeEhPrimo(i))
                {
                    iSomaTotal += i;
                }
            }

            MessageBox.Show("A soma de todos os n�meros primos de 2 at� " + x + " �: " + iSomaTotal + "!");
        }
    }
}
