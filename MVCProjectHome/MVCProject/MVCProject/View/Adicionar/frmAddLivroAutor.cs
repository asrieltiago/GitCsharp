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
    public partial class frmAddLivroAutor : Form
    {
        public frmAddLivroAutor()
        {
            InitializeComponent();
        }

        public LivroAutor livroAutorRow;

        private void FrmAddLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            livroAutorRow = new LivroAutor
            {
                Livro = (int)cbxLivro.SelectedValue,
                Autor = (int)cbxAutor.SelectedValue
            };

            this.Close();
        }
    }
}
