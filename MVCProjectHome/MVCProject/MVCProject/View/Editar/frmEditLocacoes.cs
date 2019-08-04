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
    public partial class frmEditLocacoes : Form
    {
        public frmEditLocacoes()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow LocacaoRow;

        private void FrmEditLocacoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Livros);

            cbxLivro.SelectedValue = LocacaoRow.Livro;
            cbxUsuario.SelectedValue = LocacaoRow.Usuario;
            dtDevolucao.Value = LocacaoRow.Devolucao;
            numTipo.Value = LocacaoRow.Tipo;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            LocacaoRow.Livro = (int)cbxLivro.SelectedValue;
            LocacaoRow.Usuario = (int)cbxUsuario.SelectedValue;
            LocacaoRow.Devolucao = dtDevolucao.Value;
            LocacaoRow.Tipo = (int)numTipo.Value;

            this.Close();
        }
    }
}
