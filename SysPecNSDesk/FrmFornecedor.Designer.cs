namespace SysPecNSDesk
{
    partial class FrmFornecedor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnInserir = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            dgvFornecedor = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnRazaoSocial = new DataGridViewTextBoxColumn();
            clnFantasia = new DataGridViewTextBoxColumn();
            clnCnpj = new DataGridViewTextBoxColumn();
            clnContato = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            txtId = new TextBox();
            txtRazaoSocial = new TextBox();
            txtFantasia = new TextBox();
            txtCnpj = new TextBox();
            txtContato = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 73);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Razão Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 68);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Fantasia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 121);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "CNPJ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 121);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Contato";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 178);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(252, 178);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // btnInserir
            // 
            btnInserir.Cursor = Cursors.Hand;
            btnInserir.Image = Properties.Resources.Add;
            btnInserir.Location = new Point(48, 232);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(85, 61);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "&Inserir";
            btnInserir.TextAlign = ContentAlignment.BottomCenter;
            btnInserir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInserir.UseCompatibleTextRendering = true;
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Image = Properties.Resources.Edit;
            btnEditar.Location = new Point(234, 232);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 61);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "&Editar";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseCompatibleTextRendering = true;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Image = Properties.Resources.Search;
            btnConsultar.Location = new Point(420, 232);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(85, 61);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "&Consultar";
            btnConsultar.TextAlign = ContentAlignment.BottomCenter;
            btnConsultar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnConsultar.UseCompatibleTextRendering = true;
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AllowUserToAddRows = false;
            dgvFornecedor.AllowUserToDeleteRows = false;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { clnId, clnRazaoSocial, clnFantasia, clnCnpj, clnContato, clnTelefone, clnEmail });
            dgvFornecedor.Location = new Point(126, 391);
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.ReadOnly = true;
            dgvFornecedor.RowHeadersVisible = false;
            dgvFornecedor.Size = new Size(549, 187);
            dgvFornecedor.TabIndex = 10;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnRazaoSocial
            // 
            clnRazaoSocial.HeaderText = "Razão Social";
            clnRazaoSocial.Name = "clnRazaoSocial";
            clnRazaoSocial.ReadOnly = true;
            clnRazaoSocial.Width = 175;
            // 
            // clnFantasia
            // 
            clnFantasia.HeaderText = "Fantasia";
            clnFantasia.Name = "clnFantasia";
            clnFantasia.ReadOnly = true;
            clnFantasia.Width = 125;
            // 
            // clnCnpj
            // 
            clnCnpj.HeaderText = "CNPJ";
            clnCnpj.Name = "clnCnpj";
            clnCnpj.ReadOnly = true;
            clnCnpj.Width = 75;
            // 
            // clnContato
            // 
            clnContato.HeaderText = "Contato";
            clnContato.Name = "clnContato";
            clnContato.ReadOnly = true;
            clnContato.Width = 75;
            // 
            // clnTelefone
            // 
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            clnTelefone.Width = 75;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 75;
            // 
            // txtId
            // 
            txtId.Location = new Point(22, 42);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(72, 23);
            txtId.TabIndex = 11;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(22, 91);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(326, 23);
            txtRazaoSocial.TabIndex = 12;
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(363, 91);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(176, 23);
            txtFantasia.TabIndex = 13;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(22, 139);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(273, 23);
            txtCnpj.TabIndex = 14;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(313, 139);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(226, 23);
            txtContato.TabIndex = 15;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(22, 196);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(211, 23);
            txtTelefone.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(252, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 23);
            txtEmail.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(258, 11);
            label8.Name = "label8";
            label8.Size = new Size(277, 62);
            label8.TabIndex = 18;
            label8.Text = "Fornecedor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Controls.Add(txtCnpj);
            groupBox1.Controls.Add(txtFantasia);
            groupBox1.Controls.Add(txtRazaoSocial);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(126, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 299);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fornecedor";
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 604);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(dgvFornecedor);
            Name = "FrmFornecedor";
            Text = "FrmFornecedor";
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
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
        private Button btnInserir;
        private Button btnEditar;
        private Button btnConsultar;
        private DataGridView dgvFornecedor;
        private TextBox txtId;
        private TextBox txtRazaoSocial;
        private TextBox txtFantasia;
        private TextBox txtCnpj;
        private TextBox txtContato;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label8;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnRazaoSocial;
        private DataGridViewTextBoxColumn clnFantasia;
        private DataGridViewTextBoxColumn clnCnpj;
        private DataGridViewTextBoxColumn clnContato;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
    }
}