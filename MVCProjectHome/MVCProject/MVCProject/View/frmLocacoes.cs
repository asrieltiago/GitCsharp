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
    public partial class frmLocacoes : Form
    {
        public frmLocacoes()
        {
            InitializeComponent();
        }

        private void FrmLocacoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.QueryLivrosUsuarios(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddLocacoes fAddLocacoes = new frmAddLocacoes();
            fAddLocacoes.ShowDialog();

            if (fAddLocacoes.locacaoRow?.Livro > 0
                && fAddLocacoes.locacaoRow?.Usuario > 0)
                this.locacaoTableAdapter.Insert(
                fAddLocacoes.locacaoRow.Livro,
                fAddLocacoes.locacaoRow.Usuario,
                fAddLocacoes.locacaoRow.Tipo,
                fAddLocacoes.locacaoRow.Devolucao,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.locacaoTableAdapter.QueryLivrosUsuarios(this.sistemaBibliotecaDBDataSet.Locacao);
        }

        private void DataGridLocacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacoesSelect = ((System.Data.DataRowView)
                this.dataGridLocacoes.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {   //Coluna Deletar
                case 0:
                    {
                        this.locacaoTableAdapter.DeleteQuery(locacoesSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEditLocacoes editLocacoes = new frmEditLocacoes();
                        editLocacoes.LocacaoRow = locacoesSelect;
                        editLocacoes.ShowDialog();

                        this.locacaoTableAdapter.Update(editLocacoes.LocacaoRow);
                    }
                    break;
            }

            this.locacaoTableAdapter.QueryLivrosUsuarios(this.sistemaBibliotecaDBDataSet.Locacao);
        }
    }
}
