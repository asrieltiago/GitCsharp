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
    public partial class frmAddLivro : Form
    {
        public frmAddLivro()
        {
            InitializeComponent();
        }

        private void FrmAddLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        public Livro livrosRow;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            livrosRow = new Livro
            {
                Registro = (int)numRegistro.Value,
                Titulo = tbxTitulo.Text,
                Isbn = tbxIsbn.Text,
                Genero = (int)cbxGenero.SelectedValue,
                Editora = (int)cbxEditora.SelectedValue,
                Sinopse = tbxSinopse.Text,
                Observacao = tbxObservacao.Text
            };

            this.Close();
        }
    }
}
