using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Adicionar
{
    public partial class frmAddUsuarios : Form
    {
        Controle controle = new Controle();

        public frmAddUsuarios()
        {
            InitializeComponent();
        }

        public Usuario usuariosRow;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(tbxNome.Text, tbxLogin.Text, tbxSenha.Text, tbxEmail.Text);

            if (controle.tem)// se isso for verdade, a mensagem será de sucesso.
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show(mensagem,"Cadastro", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            usuariosRow = new Usuario
            {
                Nome = tbxNome.Text,
                Login = tbxLogin.Text,
                Senha = tbxSenha.Text,
                Email = tbxEmail.Text
            };

            this.Close();
        }
    }
}
