namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            grbIdentificacao = new GroupBox();
            textBox3 = new TextBox();
            txtIdCliente = new TextBox();
            label4 = new Label();
            btnAbrir = new Button();
            txtUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            grbItens = new GroupBox();
            txtTotal = new TextBox();
            label10 = new Label();
            txtDescontoItem = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dvgItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtDescricao = new TextBox();
            txtCodBar = new TextBox();
            btnAdicionarItem = new Button();
            txtIdPedido = new TextBox();
            label1 = new Label();
            btnFechar = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtSubTotal = new TextBox();
            txtDescontoItens = new TextBox();
            txtDescontoPedido = new TextBox();
            txtTotalPedido = new TextBox();
            label15 = new Label();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(textBox3);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(label4);
            grbIdentificacao.Controls.Add(btnAbrir);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Controls.Add(label3);
            grbIdentificacao.Controls.Add(label2);
            grbIdentificacao.Location = new Point(54, 27);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(674, 121);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(467, 23);
            textBox3.TabIndex = 6;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(27, 81);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(68, 23);
            txtIdCliente.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 63);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Cliente";
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(583, 37);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 67);
            btnAbrir.TabIndex = 3;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(27, 37);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(541, 23);
            txtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 29);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 19);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Usuário";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(label15);
            grbItens.Controls.Add(txtTotal);
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(dvgItensPedido);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(btnAdicionarItem);
            grbItens.Enabled = false;
            grbItens.Location = new Point(54, 154);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(674, 272);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do pedido";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(583, 237);
            txtTotal.Name = "txtTotal";
            txtTotal.RightToLeft = RightToLeft.Yes;
            txtTotal.Size = new Size(75, 23);
            txtTotal.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(529, 240);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 12;
            label10.Text = "Total R$";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(494, 39);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.Size = new Size(93, 23);
            txtDescontoItem.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(494, 21);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 10;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 21);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 9;
            label8.Text = "Quant";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(224, 21);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 8;
            label7.Text = "Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(371, 22);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 7;
            label6.Text = "Valor Unit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 22);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 6;
            label5.Text = "Código de Barras";
            // 
            // dvgItensPedido
            // 
            dvgItensPedido.AllowUserToAddRows = false;
            dvgItensPedido.AllowUserToDeleteRows = false;
            dvgItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dvgItensPedido.Location = new Point(27, 68);
            dvgItensPedido.Name = "dvgItensPedido";
            dvgItensPedido.ReadOnly = true;
            dvgItensPedido.RowHeadersVisible = false;
            dvgItensPedido.Size = new Size(631, 163);
            dvgItensPedido.TabIndex = 5;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 95;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 55;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 65;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 120;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(435, 39);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(53, 23);
            txtQuantidade.TabIndex = 4;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(371, 39);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(58, 23);
            txtValorUnit.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(224, 39);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(141, 23);
            txtDescricao.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(27, 39);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(191, 23);
            txtCodBar.TabIndex = 1;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Location = new Point(593, 39);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(75, 23);
            btnAdicionarItem.TabIndex = 0;
            btnAdicionarItem.Text = "&Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(753, 73);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(111, 23);
            txtIdPedido.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(753, 55);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Número";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(773, 388);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(783, 196);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 5;
            label11.Text = "SubTotal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(770, 242);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 6;
            label12.Text = "Desconto Itens";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(757, 288);
            label13.Name = "label13";
            label13.Size = new Size(114, 15);
            label13.TabIndex = 7;
            label13.Text = "Desconto do Pedido";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(793, 334);
            label14.Name = "label14";
            label14.Size = new Size(32, 15);
            label14.TabIndex = 8;
            label14.Text = "Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(763, 215);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 9;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(764, 261);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(100, 23);
            txtDescontoItens.TabIndex = 10;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(764, 306);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(100, 23);
            txtDescontoPedido.TabIndex = 11;
            // 
            // txtTotalPedido
            // 
            txtTotalPedido.Location = new Point(764, 353);
            txtTotalPedido.Name = "txtTotalPedido";
            txtTotalPedido.ReadOnly = true;
            txtTotalPedido.Size = new Size(100, 23);
            txtTotalPedido.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Blue;
            label15.Location = new Point(548, 21);
            label15.Name = "label15";
            label15.Size = new Size(20, 15);
            label15.TabIndex = 14;
            label15.Text = "R$";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 452);
            Controls.Add(txtTotalPedido);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtSubTotal);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnFechar);
            Controls.Add(label1);
            Controls.Add(txtIdPedido);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private TextBox txtIdPedido;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox textBox3;
        private TextBox txtIdCliente;
        private Label label4;
        private Button btnAbrir;
        private TextBox txtDescricao;
        private TextBox txtCodBar;
        private Button btnAdicionarItem;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private TextBox txtDescontoItem;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dvgItensPedido;
        private TextBox txtTotal;
        private Label label10;
        private Button btnFechar;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtSubTotal;
        private TextBox txtDescontoItens;
        private TextBox txtDescontoPedido;
        private TextBox txtTotalPedido;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
        private Label label15;
    }
}