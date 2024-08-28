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
        public FrmCliente()
        {
            InitializeComponent();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNome.Text,
                txtCPF.Text,
                txtTelefone.Text,
                txtEmail.Text,
                dtpNascimento.Value,
                dtpCadastro.Value = DateTime.Now
                );
            cliente.Inserir();
            if(cliente.Id > 0)
            {
                txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O cliente {cliente.Nome}, foi gravado com sucesso, com o ID {cliente.Id}");
                txtId.Clear();
                txtNome.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Falha ao gravar cliente");
            }
        }
    }
}
