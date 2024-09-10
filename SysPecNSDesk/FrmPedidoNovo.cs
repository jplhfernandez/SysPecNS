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
    public partial class FrmPedidoNovo : Form
    {
        Produto produto;
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Program.UsuarioLogado,
                Cliente.ObterPorId(int.Parse(txtIdCliente.Text)), 0
                );
            pedido.Inserir();
            txtIdPedido.Text = pedido.Id.ToString();
            grbItens.Enabled = true;
            grbIdentificacao.Enabled = false;
            txtCodBar.Focus();
        }

        private void txtCodBar_Leave(object sender, EventArgs e)
        {
            if (txtCodBar.TextLength > 0)
            {
                produto = Produto.ObterPorId(txtCodBar.Text);
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString();
                txtValorUnit.ReadOnly = true;
                txtQuantidade.Focus();
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            ItemPedido item = new(
                int.Parse(txtIdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
                );

            produto = new();
            txtDescontoItem.Text = "0";
            txtDescricao.Clear();
            txtValorUnit.Text = "0";
            txtQuantidade.Text = "1";
            txtCodBar.Clear();
            txtCodBar.Focus();

            PreencherGridItens();
        }

        private void PreencherGridItens()
        {
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));
            dvgItensPedido.Rows.Clear();
            int linha = 0;
            double total = 0;
            foreach (var item in itens)
            {
                dvgItensPedido.Rows.Add();
                dvgItensPedido.Rows[linha].Cells[0].Value = item.Id;
                dvgItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBar;
                dvgItensPedido.Rows[linha].Cells[1].Value = item.Produto.Descricao;
                dvgItensPedido.Rows[linha].Cells[1].Value = item.ValorUnit;
                dvgItensPedido.Rows[linha].Cells[1].Value = item.Quantidade;
                dvgItensPedido.Rows[linha].Cells[1].Value = item.Desconto;
                dvgItensPedido.Rows[linha].Cells[1].Value = item.ValorUnit * item.Quantidade - item.Desconto;
                linha ++;
                total += item.ValorUnit * item.Quantidade - item.Desconto;
            }
            textBox1.Text = total.ToString();
        }
    }
}
