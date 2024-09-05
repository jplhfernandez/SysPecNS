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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[cont].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[cont].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[cont].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[cont].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[cont].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[cont].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[cont].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[cont].Cells[8].Value = produto.DataCad;
                cont++;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto produto = new(txtCodigoDeBarras.Text, txtDescricao.Text, double.Parse(txtValorUnitario.Text),
                txtUnidadeDeVenda.Text, Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)npEstoMinimo.Value, double.Parse(txtDesconto.Text)
                );
            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto gravado com sucesso com o ID {produto.Id}");
                FrmProduto_Load(sender, e);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                LimpaControles();
                btnConsultar.Text = "&Obter por ID";
                txtId.Focus();
                txtId.ReadOnly = false;
            }
            else if (txtId.Text.Length > 0 /*&& btnConsultar.Text == "&Obter por ID"*/)
            {
                Produto produto = Produto.ObterPorId(int.Parse(txtId.Text));
                txtCodigoDeBarras.Text = produto.CodBar;
                txtValorUnitario.Text = Convert.ToString(produto.ValorUnit);// uma forma de converter
                txtDescricao.Text = produto.Descricao;
                txtDesconto.Text = produto.ClasseDesconto.ToString();// outra forma
                txtUnidadeDeVenda.Text = produto.UnidadeVenda;
                cmbCategoria.SelectedIndex = cmbCategoria.FindString(produto.Categoria.Nome);
                btnEditar.Enabled = true;
                btnConsultar.Text = "&Limpar";
                
                if (btnConsultar.PerformClick)
                {
                    LimpaControles();
                    txtCodigoDeBarras.Focus();
                    txtId.ReadOnly = true;
                    btnConsultar.Text = "&Consultar";
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                int.Parse(txtId.Text),
                txtCodigoDeBarras.Text,
                txtDescricao.Text,
                double.Parse(txtValorUnitario.Text),
                txtUnidadeDeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)npEstoMinimo.Value,
                double.Parse(txtDesconto.Text),
                null,
                null
                );
            produto.Atualizar();//grava alterações no banco
            MessageBox.Show($"Produto {produto.Descricao} atualizado com sucesso");
            btnEditar.Enabled = false;
            txtId.ReadOnly = true;
            btnConsultar.Text = "&Consultar";
            LimpaControles();
            FrmProduto_Load(sender, e);
        }

        private void LimpaControles()
        {
            txtCodigoDeBarras.Clear();
            txtDescricao.Clear();
            txtUnidadeDeVenda.Clear();
            txtValorUnitario.Clear();
            txtDesconto.Clear();
            npEstoMinimo.Value = 0;
            cmbCategoria.SelectedIndex = 0;
        }
    }
}
