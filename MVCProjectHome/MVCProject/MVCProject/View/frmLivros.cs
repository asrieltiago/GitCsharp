using MVCProject.View.Adicionar;
using MVCProject.View.Editar;
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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.FillEditorasGeneros(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void DataGridLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)
                this.DataGridLivros.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.livrosTableAdapter.DeleteQuery(livroSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEditLivro editLivro = new frmEditLivro();
                        editLivro.LivrosRow = livroSelect;
                        editLivro.ShowDialog();

                        
                        this.livrosTableAdapter.Update(editLivro.LivrosRow);

                    }
                    break;
                case 2:
                    {
                        frmLivroAutor fLivroAutor = new frmLivroAutor();
                        fLivroAutor.LivrosRow = livroSelect;
                        fLivroAutor.ShowDialog();
                    }
                    break; 
            }

            this.livrosTableAdapter.FillEditorasGeneros(sistemaBibliotecaDBDataSet.Livros);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddLivro fAddLivro = new frmAddLivro();
            fAddLivro.ShowDialog();

            if (!string.IsNullOrEmpty(fAddLivro.livrosRow?.Titulo) && (fAddLivro.livrosRow?.Registro > 0))
                this.livrosTableAdapter.Insert
                    (
                    fAddLivro.livrosRow.Registro,
                    fAddLivro.livrosRow.Titulo,
                    fAddLivro.livrosRow.Isbn,
                    fAddLivro.livrosRow.Genero,
                    fAddLivro.livrosRow.Editora,
                    fAddLivro.livrosRow.Sinopse,
                    fAddLivro.livrosRow.Observacao,
                    true,
                    1,
                    1,
                    DateTime.Now,
                    DateTime.Now
                    );

            this.livrosTableAdapter.FillEditorasGeneros(this.sistemaBibliotecaDBDataSet.Livros);

        }

 
    }
}
