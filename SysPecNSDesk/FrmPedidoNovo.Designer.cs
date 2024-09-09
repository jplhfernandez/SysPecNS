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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            txtIdCliente = new TextBox();
            label4 = new Label();
            btnAbrir = new Button();
            txtUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtIdPedido = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(46, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(674, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identificação";
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
            btnAbrir.Location = new Point(583, 81);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
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
            // groupBox2
            // 
            groupBox2.Location = new Point(46, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(674, 240);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens do pedido";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(748, 52);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(111, 23);
            txtIdPedido.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(748, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Número";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 452);
            Controls.Add(label1);
            Controls.Add(txtIdPedido);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtIdPedido;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox textBox3;
        private TextBox txtIdCliente;
        private Label label4;
        private Button btnAbrir;
    }
}