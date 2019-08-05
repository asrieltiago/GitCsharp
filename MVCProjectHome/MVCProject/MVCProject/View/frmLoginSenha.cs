using MVCProject.Model;
using MVCProject.View.Adicionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmLoginSenha : Form
    {
        public frmLoginSenha()
        {
            InitializeComponent();
        }
        

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCadastreSe_Click(object sender, EventArgs e)
        {
            frmAddUsuarios fAddUsuarios = new frmAddUsuarios();
            fAddUsuarios.ShowDialog();            
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            //Acessando o metodo Acessar, enviando as informações de login e senha
            controle.acessar(tbxLogin.Text, tbxSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal fPrincipal = new frmPrincipal();
                fPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login não encontrado, verifique o login e senha", "ERRO!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
