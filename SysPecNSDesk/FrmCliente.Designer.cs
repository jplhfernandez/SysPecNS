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
            txtId = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            chkAtivo = new CheckBox();
            btnInserir = new Button();
            txtCPF = new TextBox();
            label7 = new Label();
            dtpNascimento = new DateTimePicker();
            dtpCadastro = new DateTimePicker();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(87, 85);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(52, 23);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(145, 85);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(347, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 67);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 67);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 168);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 118);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "Telefone";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 233);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 6;
            label5.Text = "Data de nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 233);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 7;
            label6.Text = "Data de cadastro";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(87, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(296, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(324, 136);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(168, 23);
            txtTelefone.TabIndex = 9;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(418, 197);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(417, 313);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(87, 136);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(225, 23);
            txtCPF.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 118);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 13;
            label7.Text = "CPF";
            label7.Click += label7_Click;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(87, 262);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(202, 23);
            dtpNascimento.TabIndex = 14;
            dtpNascimento.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // dtpCadastro
            // 
            dtpCadastro.Format = DateTimePickerFormat.Custom;
            dtpCadastro.Location = new Point(295, 262);
            dtpCadastro.Name = "dtpCadastro";
            dtpCadastro.Size = new Size(197, 23);
            dtpCadastro.TabIndex = 15;
            dtpCadastro.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpCadastro);
            Controls.Add(dtpNascimento);
            Controls.Add(label7);
            Controls.Add(txtCPF);
            Controls.Add(btnInserir);
            Controls.Add(chkAtivo);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "FrmCliente";
            Text = "FrmCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private CheckBox chkAtivo;
        private Button btnInserir;
        private TextBox txtCPF;
        private Label label7;
        private DateTimePicker dtpNascimento;
        private DateTimePicker dtpCadastro;
    }
}