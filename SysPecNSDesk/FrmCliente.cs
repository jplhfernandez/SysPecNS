using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmCliente : Form
    {
        public int ClienteId { get; set; }

        public FrmCliente()
        {
            InitializeComponent();
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            //Cria um novo objeto cliente
            Cliente cliente = new(
                txtNome.Text,
                txtCpf.Text,
                txtTelefone.Text,
                txtEmail.Text,
                dtpDataNasc.Value,
                DateTime.Now
                );

            cliente.Inserir();
            if (cliente.Id > 0)
            {
                //Exibe ID do cliente no formulário, enquanto a caixa de diálogo não for fechada.
                txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O cliente {cliente.Nome}, " + $"foi inserido com sucesso com o ID {cliente.Id}!");

                btnCadastrarEnd.Enabled = true;
                btnAdicionarEndereco.Enabled = false;

                txtNome.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                txtNome.Focus();
                //Recarrega a tabela do formulário para exibir o novo usuário na lista
                FrmCliente_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o cliente no sistema.");
            }

        }



        private void btnCadastrarEnd_Click(object sender, EventArgs e)
        {
            this.tabCliente.SelectedTab = tabPageEnderecos;
            ClienteId = int.Parse(txtId.Text);
        }


        private void btnSalvarEndereco_Click_1(object sender, EventArgs e)
        {
            //Cria um novo objeto cliente
            Endereco endereco = new(
                Cliente.ObterPorId(ClienteId),
                txtCep.Text,
                txtLogradouro.Text,
                txtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                txtUf.Text,
                cmbTipoEndereco.Text

               );

            endereco.Inserir();
            if (endereco.Id > 0)
            {
                //Exibe ID do cliente no formulário, enquanto a caixa de diálogo não for fechada.
                MessageBox.Show($"O endereço foi inserido com sucesso, no cadastro do usuário {endereco.Cliente.Nome}");
                txtCep.Clear();
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtUf.Clear();
                btnAdicionarEndereco.Enabled = true;
                btnSalvarEndereco.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o endereço no sistema.");
            }
        }

        private void btnAdicionarEndereco_Click_1(object sender, EventArgs e)
        {

            btnSalvarEndereco.Enabled = true;
            btnAdicionarEndereco.Enabled = false;
            txtCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUf.Clear();
            txtCep.Focus();

            Endereco endereco = new(
               Cliente.ObterPorId(ClienteId),
               txtCep.Text,
               txtLogradouro.Text,
               txtNumero.Text,
               txtComplemento.Text,
               txtBairro.Text,
               txtCidade.Text,
               txtUf.Text,
               cmbTipoEndereco.Text
              );
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                CarregaGrid(txtBusca.Text);
            }
            else
            {
                CarregaGrid();
            }
        }
        private void CarregaGrid(string? enderecos = "")
        {

            var enderecos = Endereco.ObterLista();
            dgvClienteEndereco.Rows.Clear();
            int cont = 0;
            foreach (var endereco in enderecos)
            {
                dgvClienteEndereco.Rows.Add();
                dgvClienteEndereco.Rows[cont].Cells[0].Value = endereco.Cliente.Nome;
                dgvClienteEndereco.Rows[cont].Cells[1].Value = endereco.Cep;
                dgvClienteEndereco.Rows[cont].Cells[2].Value = endereco.Logradouro;
                dgvClienteEndereco.Rows[cont].Cells[3].Value = endereco.Numero;
                dgvClienteEndereco.Rows[cont].Cells[4].Value = endereco.Complemento;
                dgvClienteEndereco.Rows[cont].Cells[5].Value = endereco.Bairro;
                dgvClienteEndereco.Rows[cont].Cells[6].Value = endereco.Cidade;
                dgvClienteEndereco.Rows[cont].Cells[7].Value = endereco.Uf;
                dgvClienteEndereco.Rows[cont].Cells[8].Value = endereco.Tipo_Endereco;
                cont++;
            }
        }
    }
}
