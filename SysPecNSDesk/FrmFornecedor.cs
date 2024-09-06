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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
                txtRazaoSocial.Text,
                txtFantasia.Text,
                txtCnpj.Text,
                txtTelefone.Text,
                txtContato.Text,
                txtEmail.Text
                );
            fornecedor.Inserir();
            if (fornecedor.Id > 0)
            {
                txtId.Text = fornecedor.Id.ToString();
                MessageBox.Show($"o usuário {fornecedor.Fantasia}, foi gravado com sucesso, com o ID {fornecedor.Id}");
                txtRazaoSocial.Clear();
                txtFantasia.Clear();
                txtCnpj.Clear();
                txtTelefone.Clear();
                txtContato.Clear();
                txtEmail.Clear();
                txtRazaoSocial.Focus();
            }
            else
            {
                MessageBox.Show("Falha ao gravar usuário.");
            }
        }
    }
}
