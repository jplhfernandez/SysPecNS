namespace SysPecNSDesk
{
    partial class FrmUsuario
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
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            btnInserir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            chkAtivo = new CheckBox();
            cmbNivel = new ComboBox();
            label6 = new Label();
            txtConfSenha = new TextBox();
            btnEditar = new Button();
            btnDeletar = new Button();
            txtBusca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(153, 272);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(500, 150);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 150;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nível";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 50;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(413, 209);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 38);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 38);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 108);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 108);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "Nível";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 181);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "Senha";
            // 
            // txtId
            // 
            txtId.Location = new Point(149, 66);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(48, 23);
            txtId.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(203, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(450, 23);
            txtNome.TabIndex = 8;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(153, 209);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(108, 23);
            txtSenha.TabIndex = 9;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(285, 23);
            txtEmail.TabIndex = 10;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(599, 138);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 11;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(440, 136);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(139, 23);
            cmbNivel.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 181);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 13;
            label6.Text = "Confirmar Senha";
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(267, 209);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(128, 23);
            txtConfSenha.TabIndex = 14;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(494, 208);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(578, 208);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 16;
            btnDeletar.Text = "De&letar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(153, 243);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(500, 23);
            txtBusca.TabIndex = 17;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBusca);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
            Controls.Add(txtConfSenha);
            Controls.Add(label6);
            Controls.Add(cmbNivel);
            Controls.Add(chkAtivo);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInserir);
            Controls.Add(dgvUsuarios);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
        private Button btnInserir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private CheckBox chkAtivo;
        private ComboBox cmbNivel;
        private Label label6;
        private TextBox txtConfSenha;
        private Button btnEditar;
        private Button btnDeletar;
        private TextBox txtBusca;
    }
}