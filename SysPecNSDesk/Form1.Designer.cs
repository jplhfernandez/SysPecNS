namespace SysPecNSDesk
{
    partial class Form1
    {        /// <summary>

        ///  Required designer variable.        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bntConfirma = new Button();
            txtNumero2 = new TextBox();
            lstResultado = new ListBox();
            cmbOperacao = new ComboBox();
            txtNumero1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // bntConfirma
            // 
            bntConfirma.Enabled = false;
            bntConfirma.Location = new Point(478, 326);
            bntConfirma.Name = "bntConfirma";
            bntConfirma.Size = new Size(75, 23);
            bntConfirma.TabIndex = 0;
            bntConfirma.Text = "&Confirma";
            bntConfirma.UseVisualStyleBackColor = true;
            bntConfirma.Click += button1_Click;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(453, 92);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 1;
            txtNumero2.TextChanged += textBox1_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(211, 121);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(342, 199);
            lstResultado.TabIndex = 2;
            lstResultado.SelectedIndexChanged += lstResultado_SelectedIndexChanged;
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiciação", "Logaritmos" });
            cmbOperacao.Location = new Point(211, 92);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(121, 23);
            cmbOperacao.TabIndex = 3;
            cmbOperacao.SelectedIndexChanged += cmbOperacao_SelectedIndexChanged;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(343, 92);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 4;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 74);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "1°Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 74);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "2°Número";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 74);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Operação";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero1);
            Controls.Add(cmbOperacao);
            Controls.Add(lstResultado);
            Controls.Add(txtNumero2);
            Controls.Add(bntConfirma);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bntConfirma;
        private TextBox txtNumero2;
        private ListBox lstResultado;
        private ComboBox cmbOperacao;
        private TextBox txtNumero1;
        private Label label1;
        private Label label2;
        private Label label3;
    }

}
