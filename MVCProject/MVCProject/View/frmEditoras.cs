
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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var editoraSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.EditorasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEditEditoras editEditoras = new frmEditEditoras();
                        editEditoras.EditorasRow = editoraSelect;
                        editEditoras.ShowDialog();

                        this.editorasTableAdapter.Update(editEditoras.EditorasRow);
                    }
                    break;
            }
        }
    }
}
