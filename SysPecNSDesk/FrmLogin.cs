using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);//pega o que foi digitado
                if (usuario.Id > 0)//verifica se existe o usuario
                {
                    if (usuario.Ativo)//verifica se o usuario existente esta com a conta ativo
                    {
                        Program.UsuarioLogado = usuario;
                        this.Close();//fecha e entra no sistema
                    }
                    else
                    {
                        MessageBox.Show("Seu usuário está inativo. \n Se achar que isso é um erro, procure a gerência.");
                        Application.Exit();//fecha todo o sistema 
                    }
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos ou inexistentes. \n Se achar que isso é um erro, procure a gerência.");
                    txtEmail.Clear();
                    txtSenha.Clear();
                    txtEmail.Focus();
                }
            }
            else
            {
                MessageBox.Show("Você deve preencher todos os campos.");
                txtEmail.Clear();
                txtSenha.Clear();
                txtEmail.Focus();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
