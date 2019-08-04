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
        public frmAddUsuarios()
        {
            InitializeComponent();
        }

        public Usuario usuariosRow;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
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
