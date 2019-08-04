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
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        public Genero generosRow;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddGeneros fAddGeneros = new frmAddGeneros();
            fAddGeneros.ShowDialog();

            if (!string.IsNullOrEmpty(fAddGeneros.generosRow?.Tipo))
                this.generosTableAdapter.Insert
                    (
                    fAddGeneros.generosRow.Tipo,
                    fAddGeneros.generosRow.Descricao
                    );

            this.generosTableAdapter.Fill(sistemaBibliotecaDBDataSet.Generos);
        }

        private void DataGridGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var generosSelect = ((System.Data.DataRowView)
                this.dataGridGeneros.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.GenerosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEditGeneros editGeneros = new frmEditGeneros();
                        editGeneros.GenerosRow = generosSelect;
                        editGeneros.ShowDialog();

                        this.generosTableAdapter.Update(editGeneros.GenerosRow);

                    }
                    break;
            }

            this.generosTableAdapter.Fill(sistemaBibliotecaDBDataSet.Generos);
        }
    }
}
