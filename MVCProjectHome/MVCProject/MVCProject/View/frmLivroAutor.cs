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
    public partial class frmLivroAutor : Form
    {
        public frmLivroAutor()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivrosRow;

        private void FrmLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);
            this.autoresTableAdapter1.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddLivroAutor fAddLivroAutor = new frmAddLivroAutor();
            fAddLivroAutor.ShowDialog();
            /*if (fAddLivroAutor.livroAutorRow?.Autor > 0
                && fAddLivroAutor.livroAutorRow?.Livro > 0)*/
                this.livroAutorTableAdapter.Insert(
                    fAddLivroAutor.livroAutorRow.Autor,
                    fAddLivroAutor.livroAutorRow.Livro);

            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroAutorSelect = ((System.Data.DataRowView)
                this.dataGridLivroAutor.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.LivroAutorRow;

            switch (e.ColumnIndex)
            {   //Coluna Deletar
                case 0:
                    {
                        frmEditLivroAutor editLivroAutor = new frmEditLivroAutor();
                        editLivroAutor.LivroAutorRow = livroAutorSelect;
                        editLivroAutor.ShowDialog();

                        this.livroAutorTableAdapter.Update(editLivroAutor.LivroAutorRow);
                    }
                    break;
            }


        }

    }
}