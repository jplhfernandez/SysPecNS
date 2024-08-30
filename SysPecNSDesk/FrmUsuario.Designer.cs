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
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(97, 265);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(500, 150);
            dgvUsuarios.TabIndex = 9;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
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
            btnInserir.FlatAppearance.BorderColor = Color.White;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnInserir.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnInserir.FlatStyle = FlatStyle.Popup;
            btnInserir.Image = Properties.Resources.Add;
            btnInserir.Location = new Point(106, 421);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 52);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 35);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 10;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 35);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 101);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 101);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 13;
            label4.Text = "Nível";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 161);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 15;
            label5.Text = "Senha";
            // 
            // txtId
            // 
            txtId.Location = new Point(97, 63);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(48, 23);
            txtId.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(160, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(441, 23);
            txtNome.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(97, 189);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(225, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(97, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(285, 23);
            txtEmail.TabIndex = 1;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(541, 191);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 14;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(398, 129);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(197, 23);
            cmbNivel.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 161);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 16;
            label6.Text = "Confirmar Senha";
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(328, 189);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(186, 23);
            txtConfSenha.TabIndex = 4;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.Edit;
            btnEditar.Location = new Point(241, 421);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 52);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.FlatStyle = FlatStyle.Popup;
            btnDeletar.Image = Properties.Resources.Delete;
            btnDeletar.Location = new Point(376, 421);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 52);
            btnDeletar.TabIndex = 7;
            btnDeletar.Text = "De&letar";
            btnDeletar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(97, 223);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(500, 23);
            txtBusca.TabIndex = 8;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(511, 421);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 52);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmUsuario
            // 
            AcceptButton = btnInserir;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(702, 552);
            Controls.Add(btnCancelar);
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
            StartPosition = FormStartPosition.CenterParent;
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
        private Button btnCancelar;
    }
}