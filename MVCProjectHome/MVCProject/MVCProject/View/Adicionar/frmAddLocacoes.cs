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
    public partial class frmAddLocacoes : Form
    {
        public frmAddLocacoes()
        {
            InitializeComponent();
        }

        private void FrmAddLocacoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Livros);

        }

        public Locacao locacaoRow;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            locacaoRow = new Locacao
            {
                Livro = (int)cbxLivro.SelectedValue,
                Usuario = (int)cbxUsuario.SelectedValue,
                Devolucao = dtDevolucao.Value,
                Tipo = (int)numTipo.Value
            };
            this.Close();
        }
    }
}
