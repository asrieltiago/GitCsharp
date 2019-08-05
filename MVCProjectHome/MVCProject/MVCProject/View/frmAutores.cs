using MVCProject.Model;
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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
            
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void DataGridAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autoresSelect = ((System.Data.DataRowView)
                this.dataGridAutores.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            switch (e.ColumnIndex)
            {                
                case 0:
                    {
                        frmEditAutores editAutores = new frmEditAutores();
                        editAutores.AutoresRow = autoresSelect;
                        editAutores.ShowDialog();

                        this.autoresTableAdapter.Update(editAutores.AutoresRow);

                    }
                    break;
            }

            this.autoresTableAdapter.Fill(sistemaBibliotecaDBDataSet.Autores);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddAutores fAddAutor = new frmAddAutores();
            fAddAutor.ShowDialog();

            if (!string.IsNullOrEmpty(fAddAutor.autoresRow?.Nome))
                this.autoresTableAdapter.Insert
                    (
                    fAddAutor.autoresRow.Nome,
                    fAddAutor.autoresRow.Descricao                 
                    );

            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }
    }
}
