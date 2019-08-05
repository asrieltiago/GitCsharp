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
    public partial class frmEditLivro : Form
    {
        public frmEditLivro()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivrosRow;

        private void FrmEditLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

            numRegistro.Value = LivrosRow.Registro;
            tbxTitulo.Text = LivrosRow.Titulo;
            tbxIsbn.Text = LivrosRow.Isbn;
            cbxGenero.SelectedValue = LivrosRow.Genero;
            cbxEditora.SelectedValue = LivrosRow.Editora;
            tbxSinopse.Text = LivrosRow.Sinopse;
            tbxObservacao.Text = LivrosRow.Observacao;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            LivrosRow.Registro = (int)numRegistro.Value;
            LivrosRow.Titulo = tbxTitulo.Text;
            LivrosRow.Isbn = tbxIsbn.Text;
            LivrosRow.Genero = (int)cbxGenero.SelectedValue;
            LivrosRow.Editora = (int)cbxEditora.SelectedValue;
            LivrosRow.Sinopse = tbxSinopse.Text;
            LivrosRow.Observacao = tbxObservacao.Text;

            this.Close();
        }
    }
}
