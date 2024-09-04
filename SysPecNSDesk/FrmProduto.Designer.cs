namespace SysPecNSDesk
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            txtCodigoDeBarras = new TextBox();
            txtValorUnitario = new TextBox();
            txtUnidadeDeVenda = new TextBox();
            txtDescricao = new TextBox();
            cmbCategoria = new ComboBox();
            label9 = new Label();
            txtDesconto = new TextBox();
            btnInserir = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            npEstoMinimo = new NumericUpDown();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodigoDeBarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnitario = new DataGridViewTextBoxColumn();
            clnUnidadeDeVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDataDeCadastro = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)npEstoMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 110);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 166);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Código de barras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 78);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 142);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor Unitário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 142);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(161, 142);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 5;
            label6.Text = "Unidade de Venda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(151, 297);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 6;
            label7.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(442, 78);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 7;
            label8.Text = "Estoque Mínimo";
            // 
            // txtId
            // 
            txtId.Location = new Point(151, 131);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(58, 23);
            txtId.TabIndex = 8;
            // 
            // txtCodigoDeBarras
            // 
            txtCodigoDeBarras.Location = new Point(152, 193);
            txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            txtCodigoDeBarras.Size = new Size(110, 23);
            txtCodigoDeBarras.TabIndex = 9;
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(42, 171);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(100, 23);
            txtValorUnitario.TabIndex = 10;
            // 
            // txtUnidadeDeVenda
            // 
            txtUnidadeDeVenda.Location = new Point(161, 171);
            txtUnidadeDeVenda.Name = "txtUnidadeDeVenda";
            txtUnidadeDeVenda.PlaceholderText = "Ex: Caixa";
            txtUnidadeDeVenda.Size = new Size(100, 23);
            txtUnidadeDeVenda.TabIndex = 11;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(172, 105);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(255, 23);
            txtDescricao.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(387, 259);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(259, 23);
            cmbCategoria.TabIndex = 13;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(271, 18);
            label9.Name = "label9";
            label9.Size = new Size(232, 56);
            label9.TabIndex = 14;
            label9.Text = "PRODUTOS";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(152, 324);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(162, 23);
            txtDesconto.TabIndex = 15;
            // 
            // btnInserir
            // 
            btnInserir.Cursor = Cursors.Hand;
            btnInserir.FlatStyle = FlatStyle.Popup;
            btnInserir.Location = new Point(237, 236);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 16;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Location = new Point(349, 235);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.Location = new Point(461, 236);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // npEstoMinimo
            // 
            npEstoMinimo.Location = new Point(442, 106);
            npEstoMinimo.Name = "npEstoMinimo";
            npEstoMinimo.Size = new Size(94, 23);
            npEstoMinimo.TabIndex = 19;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodigoDeBarras, clnDescricao, clnValorUnitario, clnUnidadeDeVenda, clnCategoria, clnEstoqueMinimo, clnDesconto, clnDataDeCadastro });
            dgvProdutos.Location = new Point(110, 378);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(555, 182);
            dgvProdutos.TabIndex = 20;
            // 
            // clnId
            // 
            clnId.FillWeight = 50F;
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnCodigoDeBarras
            // 
            clnCodigoDeBarras.HeaderText = "Código de Barras";
            clnCodigoDeBarras.Name = "clnCodigoDeBarras";
            clnCodigoDeBarras.ReadOnly = true;
            clnCodigoDeBarras.Width = 150;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnValorUnitario
            // 
            clnValorUnitario.HeaderText = "Valor Unitário";
            clnValorUnitario.Name = "clnValorUnitario";
            clnValorUnitario.ReadOnly = true;
            clnValorUnitario.Width = 75;
            // 
            // clnUnidadeDeVenda
            // 
            clnUnidadeDeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeDeVenda.Name = "clnUnidadeDeVenda";
            clnUnidadeDeVenda.ReadOnly = true;
            clnUnidadeDeVenda.Width = 75;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.HeaderText = "Estoque Mínimo";
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            clnEstoqueMinimo.Width = 75;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 75;
            // 
            // clnDataDeCadastro
            // 
            clnDataDeCadastro.HeaderText = "Data de Cadastro";
            clnDataDeCadastro.Name = "clnDataDeCadastro";
            clnDataDeCadastro.ReadOnly = true;
            clnDataDeCadastro.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(npEstoMinimo);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtValorUnitario);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUnidadeDeVenda);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(110, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 284);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 603);
            Controls.Add(dgvProdutos);
            Controls.Add(txtDesconto);
            Controls.Add(label9);
            Controls.Add(cmbCategoria);
            Controls.Add(txtCodigoDeBarras);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmProduto";
            Text = "Produtos";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)npEstoMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtId;
        private TextBox txtCodigoDeBarras;
        private TextBox txtValorUnitario;
        private TextBox txtUnidadeDeVenda;
        private TextBox txtDescricao;
        private ComboBox cmbCategoria;
        private Label label9;
        private TextBox txtDesconto;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnConsultar;
        private NumericUpDown npEstoMinimo;
        private DataGridView dgvProdutos;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodigoDeBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnitario;
        private DataGridViewTextBoxColumn clnUnidadeDeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDataDeCadastro;
    }
}