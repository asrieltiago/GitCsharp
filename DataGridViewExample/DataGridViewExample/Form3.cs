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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet2.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet2.MarcasRow;

            switch (e.ColumnIndex)
            {   //Coluna Deletar
                case 0:
                    {
                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        FrmEdicaoMarcas editMarcas = new FrmEdicaoMarcas();
                        editMarcas.MarcasRow = marcasSelect;
                        editMarcas.ShowDialog();

                        this.marcasTableAdapter.Update(editMarcas.MarcasRow);
                    }
                    break;
            }

            this.marcasTableAdapter.CustomQuery(querysInnerJoinDataSet2.Marcas);
        }

        private void BtnCarros_Click(object sender, EventArgs e)
        {
            Form1 frmCarros = new Form1();
            frmCarros.ShowDialog();
            this.Close();
        }

        private void BtnUsuarios2_Click(object sender, EventArgs e)
        {
            Form4 frmUsuarios = new Form4();
            frmUsuarios.ShowDialog();
            this.Close();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            Form2 frmVendas = new Form2();
            frmVendas.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarMarca fAddMarca = new frmAdicionarMarca();
            fAddMarca.ShowDialog();
            if (!string.IsNullOrEmpty(fAddMarca.marcasRow?.Nome))
                this.marcasTableAdapter.Insert
                (
                fAddMarca.marcasRow.Nome,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );

            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet2.Marcas);
        }
    }
}
