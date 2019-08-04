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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios fUsuarios = new frmUsuarios();
            fUsuarios.ShowDialog();
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores fAutores = new frmAutores();
            fAutores.ShowDialog();
        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros fGeneros = new frmGeneros();
            fGeneros.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros fLivros = new frmLivros();
            fLivros.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacoes fLocacoes = new frmLocacoes();
            fLocacoes.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoras fEditoras = new frmEditoras();
            fEditoras.ShowDialog();
        }

        private void LivroAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivroAutor fLivroAutor = new frmLivroAutor();
            fLivroAutor.ShowDialog();
        }
    }
}
