using DataGridViewExample.Adicionar;
using DataGridViewExample.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet2.Vendas);

        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            Form1 frmCarros = new Form1();
            frmCarros.ShowDialog();
            this.Close();
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            Form3 frmMarcas = new Form3();
            frmMarcas.ShowDialog();
            this.Close();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Form4 frmUsuarios = new Form4();
            frmUsuarios.ShowDialog();
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet2.VendasRow;

            switch (e.ColumnIndex)
            {   //Coluna Deletar
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        FrmEdicaoVendas editVendas = new FrmEdicaoVendas();
                        editVendas.VendasRow = vendasSelect;
                        editVendas.ShowDialog();

                        this.vendasTableAdapter.Update(editVendas.VendasRow);
                    }
                    break;
            }

            this.vendasTableAdapter.CustomQuery(querysInnerJoinDataSet2.Vendas);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarVenda fAddVenda = new frmAdicionarVenda();
            fAddVenda.ShowDialog();

            if (fAddVenda.vendasRow?.Carro > 0
                && fAddVenda.vendasRow?.Valor > 0)
                this.vendasTableAdapter.Insert(
                fAddVenda.vendasRow.Carro,
                fAddVenda.vendasRow.Quantidade,
                fAddVenda.vendasRow.Valor,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet2.Vendas);
        }
    }
}
