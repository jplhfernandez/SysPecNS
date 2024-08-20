using SysPecNSLib;

namespace SysPecNSDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //   MessageBox.Show("Olá TI96");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero2.Text.Length > 0)
            {
                bntConfirma.Enabled = true;
            }
            else
            {
                bntConfirma.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operacao = cmbOperacao.Text;
            int posicaoOperacao = cmbOperacao.SelectedIndex;
            double numero2 = 0;
            double resultado = 0;
            double numero1 = 0;

            if (txtNumero1.Text != string.Empty)
            {
                numero1 = Convert.ToDouble(txtNumero1.Text);
            }

            if (posicaoOperacao < 5)
            {
                if (txtNumero2.Text != string.Empty)
                {
                    numero2 = Convert.ToDouble(txtNumero2.Text);
                }
            }

            switch (posicaoOperacao)
            {
                case 0:
                    resultado = numero1 * numero2;
                    break;
                case 1:
                    resultado = numero1 / numero2;
                    break;
                case 2:
                    resultado = numero1 + numero2;
                    break;
                case 3:
                    resultado = numero1 - numero2;
                    break;
                case 4:
                    resultado = Math.Pow(numero1, numero2);
                    break;
                case 5:
                    resultado = Math.Sqrt(numero1);
                    break;
                case 6:
                    resultado = Math.Log(numero1);
                    break;
            }


            lstResultado.Items.Add($"{operacao} - {posicaoOperacao} = {resultado}");

            //Existem 3 tipos de conversão no C#
            // CAST
            // PARSE
            // CONVERT
            //int numero = int.Parse(txtNumero1.Text);
            //for (int i = 0; i < 10; i++)
            //{
            //    lstResultado.Items.Add($"{numero} x {i + 1}= {numero * (i + 1)}");
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Length > 0)
            {
                bntConfirma.Enabled = true;
            }
        }

        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperacao.SelectedIndex > 4)
            {
                txtNumero2.Enabled = false;
            }
            else
            {
                txtNumero2.Enabled = true;
            }
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
            bntConfirma.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(textBox1.Text, textBox2.Text);
            nivel.Inserir();
            MessageBox.Show("Nível gravado com sucesso!");
            button1.Enabled = false;
        }
    }
}

