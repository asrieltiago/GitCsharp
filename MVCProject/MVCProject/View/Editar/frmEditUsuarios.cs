using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editar
{
    public partial class frmEditUsuarios : Form
    {
        public frmEditUsuarios()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow UsuariosRow;

        private void FrmEditUsuarios_Load(object sender, EventArgs e)
        {
            tbxNome.Text = UsuariosRow.Nome;
            tbxLogin.Text = UsuariosRow.Login;
            tbxSenha.Text = UsuariosRow.Senha;
            tbxEmail.Text = UsuariosRow.Email;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosRow.Nome = tbxNome.Text;
            UsuariosRow.Login = tbxLogin.Text;
            UsuariosRow.Senha = tbxSenha.Text;
            UsuariosRow.Email = tbxEmail.Text;

            this.Close();

        }
    }
}
