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
    public partial class frmEditLivroAutor : Form
    {
        public frmEditLivroAutor()
        {
            InitializeComponent();
        }

        private void FrmEditLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

            cbxAutor.SelectedValue = LivroAutorRow.Autor;
            cbxLivro.SelectedValue = LivroAutorRow.Livro;
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivroAutorRow LivroAutorRow;
        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivrosRow;
        public MVCProject.SistemaBibliotecaDBDataSet.AutoresRow AutoresRow;

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            LivroAutorRow.Autor = (int)cbxAutor.SelectedValue;
            LivroAutorRow.Livro = (int)cbxLivro.SelectedValue;

            this.Close();
        }
    }
}
