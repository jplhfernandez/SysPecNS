namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            txtId = new TextBox();
            textBox2 = new TextBox();
            txtProduto = new TextBox();
            btnInserir = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            txtQtdEstoque = new GroupBox();
            textBox4 = new TextBox();
            label5 = new Label();
            txtQtdEstoque.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 0;
            label1.Text = "Estoque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 44);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 96);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade no estoque";
            // 
            // txtId
            // 
            txtId.Location = new Point(32, 62);
            txtId.Name = "txtId";
            txtId.Size = new Size(64, 23);
            txtId.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 114);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(131, 23);
            textBox2.TabIndex = 4;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(102, 62);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(180, 23);
            txtProduto.TabIndex = 5;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(32, 178);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 6;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(207, 178);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 44);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Produto";
            // 
            // txtQtdEstoque
            // 
            txtQtdEstoque.Controls.Add(textBox4);
            txtQtdEstoque.Controls.Add(label5);
            txtQtdEstoque.Controls.Add(label4);
            txtQtdEstoque.Controls.Add(btnCancelar);
            txtQtdEstoque.Controls.Add(txtProduto);
            txtQtdEstoque.Controls.Add(btnInserir);
            txtQtdEstoque.Controls.Add(textBox2);
            txtQtdEstoque.Controls.Add(txtId);
            txtQtdEstoque.Controls.Add(label3);
            txtQtdEstoque.Controls.Add(label2);
            txtQtdEstoque.Location = new Point(35, 60);
            txtQtdEstoque.Name = "txtQtdEstoque";
            txtQtdEstoque.Size = new Size(343, 261);
            txtQtdEstoque.TabIndex = 9;
            txtQtdEstoque.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(182, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 96);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 9;
            label5.Text = "Nova reposição";
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 361);
            Controls.Add(txtQtdEstoque);
            Controls.Add(label1);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            txtQtdEstoque.ResumeLayout(false);
            txtQtdEstoque.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox textBox2;
        private TextBox txtProduto;
        private Button btnInserir;
        private Button btnCancelar;
        private Label label4;
        private GroupBox txtQtdEstoque;
        private TextBox textBox4;
        private Label label5;
    }
}