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
            fAddUsuarios.Show();
        }
    }
}
