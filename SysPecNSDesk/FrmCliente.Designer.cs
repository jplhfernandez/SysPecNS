namespace SysPecNSDesk
{
    partial class FrmCliente
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
            groupBox1 = new GroupBox();
            tabCliente = new TabControl();
            tabPageDadosCliente = new TabPage();
            btnCadastrarEnd = new Button();
            btnInserir = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpDataNasc = new DateTimePicker();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            tabPageEnderecos = new TabPage();
            btnFechar = new Button();
            btnAdicionarEndereco = new Button();
            btnSalvarEndereco = new Button();
            cmbTipoEndereco = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            txtUf = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            label8 = new Label();
            txtCep = new TextBox();
            groupBox1.SuspendLayout();
            tabCliente.SuspendLayout();
            tabPageDadosCliente.SuspendLayout();
            tabPageEnderecos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabCliente);
            groupBox1.Location = new Point(-1, -21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 373);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(tabPageDadosCliente);
            tabCliente.Controls.Add(tabPageEnderecos);
            tabCliente.Location = new Point(11, 30);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(544, 335);
            tabCliente.TabIndex = 0;
            // 
            // tabPageDadosCliente
            // 
            tabPageDadosCliente.Controls.Add(btnCadastrarEnd);
            tabPageDadosCliente.Controls.Add(btnInserir);
            tabPageDadosCliente.Controls.Add(label6);
            tabPageDadosCliente.Controls.Add(label5);
            tabPageDadosCliente.Controls.Add(label4);
            tabPageDadosCliente.Controls.Add(label3);
            tabPageDadosCliente.Controls.Add(label2);
            tabPageDadosCliente.Controls.Add(label1);
            tabPageDadosCliente.Controls.Add(dtpDataNasc);
            tabPageDadosCliente.Controls.Add(txtEmail);
            tabPageDadosCliente.Controls.Add(txtTelefone);
            tabPageDadosCliente.Controls.Add(txtCpf);
            tabPageDadosCliente.Controls.Add(txtNome);
            tabPageDadosCliente.Controls.Add(txtId);
            tabPageDadosCliente.Location = new Point(4, 24);
            tabPageDadosCliente.Name = "tabPageDadosCliente";
            tabPageDadosCliente.Padding = new Padding(3);
            tabPageDadosCliente.Size = new Size(536, 307);
            tabPageDadosCliente.TabIndex = 0;
            tabPageDadosCliente.Text = "Dados do Cliente";
            tabPageDadosCliente.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarEnd
            // 
            btnCadastrarEnd.Enabled = false;
            btnCadastrarEnd.Location = new Point(361, 230);
            btnCadastrarEnd.Name = "btnCadastrarEnd";
            btnCadastrarEnd.Size = new Size(145, 23);
            btnCadastrarEnd.TabIndex = 7;
            btnCadastrarEnd.Text = "Cadastrar endereço";
            btnCadastrarEnd.UseVisualStyleBackColor = true;
            btnCadastrarEnd.Click += btnCadastrarEnd_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(210, 228);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(115, 23);
            btnInserir.TabIndex = 6;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 210);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 31;
            label6.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 151);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 30;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 151);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 29;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 94);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 28;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 94);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 27;
            label2.Text = "Nome Completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 43);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 26;
            label1.Text = "ID";
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(37, 228);
            dtpDataNasc.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(135, 23);
            dtpDataNasc.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(37, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(297, 169);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(340, 112);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(166, 23);
            txtCpf.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(37, 112);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(246, 23);
            txtNome.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(37, 61);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(51, 23);
            txtId.TabIndex = 20;
            // 
            // tabPageEnderecos
            // 
            tabPageEnderecos.Controls.Add(btnFechar);
            tabPageEnderecos.Controls.Add(btnAdicionarEndereco);
            tabPageEnderecos.Controls.Add(btnSalvarEndereco);
            tabPageEnderecos.Controls.Add(cmbTipoEndereco);
            tabPageEnderecos.Controls.Add(label14);
            tabPageEnderecos.Controls.Add(label15);
            tabPageEnderecos.Controls.Add(txtUf);
            tabPageEnderecos.Controls.Add(label12);
            tabPageEnderecos.Controls.Add(label13);
            tabPageEnderecos.Controls.Add(txtCidade);
            tabPageEnderecos.Controls.Add(txtBairro);
            tabPageEnderecos.Controls.Add(label9);
            tabPageEnderecos.Controls.Add(label10);
            tabPageEnderecos.Controls.Add(label11);
            tabPageEnderecos.Controls.Add(txtComplemento);
            tabPageEnderecos.Controls.Add(txtNumero);
            tabPageEnderecos.Controls.Add(txtLogradouro);
            tabPageEnderecos.Controls.Add(label8);
            tabPageEnderecos.Controls.Add(txtCep);
            tabPageEnderecos.Location = new Point(4, 24);
            tabPageEnderecos.Name = "tabPageEnderecos";
            tabPageEnderecos.Padding = new Padding(3);
            tabPageEnderecos.Size = new Size(536, 307);
            tabPageEnderecos.TabIndex = 1;
            tabPageEnderecos.Text = "Endereços";
            tabPageEnderecos.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(428, 260);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 40;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // btnAdicionarEndereco
            // 
            btnAdicionarEndereco.Location = new Point(194, 260);
            btnAdicionarEndereco.Name = "btnAdicionarEndereco";
            btnAdicionarEndereco.Size = new Size(163, 23);
            btnAdicionarEndereco.TabIndex = 39;
            btnAdicionarEndereco.Text = "&Adicionar outro endereço";
            btnAdicionarEndereco.UseVisualStyleBackColor = true;
            btnAdicionarEndereco.Click += btnAdicionarEndereco_Click_1;
            // 
            // btnSalvarEndereco
            // 
            btnSalvarEndereco.Location = new Point(16, 260);
            btnSalvarEndereco.Name = "btnSalvarEndereco";
            btnSalvarEndereco.Size = new Size(102, 23);
            btnSalvarEndereco.TabIndex = 38;
            btnSalvarEndereco.Text = "&Salvar endereço";
            btnSalvarEndereco.UseVisualStyleBackColor = true;
            btnSalvarEndereco.Click += btnSalvarEndereco_Click_1;
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Items.AddRange(new object[] { "RES - Residencial", "COM - Comercial" });
            cmbTipoEndereco.Location = new Point(334, 206);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(121, 23);
            cmbTipoEndereco.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(334, 188);
            label14.Name = "label14";
            label14.Size = new Size(98, 15);
            label14.TabIndex = 36;
            label14.Text = "Tipo de Endereço";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(243, 188);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 34;
            label15.Text = "UF";
            // 
            // txtUf
            // 
            txtUf.Location = new Point(243, 206);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(63, 23);
            txtUf.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 188);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 32;
            label12.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(243, 132);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 31;
            label13.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(16, 206);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(179, 23);
            txtCidade.TabIndex = 30;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(243, 150);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(179, 23);
            txtBairro.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 132);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 28;
            label9.Text = "Complemento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(442, 77);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 27;
            label10.Text = "Nº";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 77);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 26;
            label11.Text = "Logradouro";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(16, 150);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(161, 23);
            txtComplemento.TabIndex = 25;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(440, 95);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(63, 23);
            txtNumero.TabIndex = 24;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(16, 95);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(406, 23);
            txtLogradouro.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 19);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 22;
            label8.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(16, 37);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(127, 23);
            txtCep.TabIndex = 21;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 351);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            Load += FrmCliente_Load;
            groupBox1.ResumeLayout(false);
            tabCliente.ResumeLayout(false);
            tabPageDadosCliente.ResumeLayout(false);
            tabPageDadosCliente.PerformLayout();
            tabPageEnderecos.ResumeLayout(false);
            tabPageEnderecos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TabControl tabCliente;
        private TabPage tabPageDadosCliente;
        private TabPage tabPageEnderecos;
        private Button btnCadastrarEnd;
        private Button btnInserir;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDataNasc;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCpf;
        private TextBox txtNome;
        private TextBox txtId;
        private Label label8;
        private TextBox txtCep;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtLogradouro;
        private Label label12;
        private Label label13;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private Label label14;
        private Label label15;
        private TextBox txtUf;
        private ComboBox cmbTipoEndereco;
        private Button btnSalvarEndereco;
        private Button btnAdicionarEndereco;
        private Button btnFechar;
    }
}