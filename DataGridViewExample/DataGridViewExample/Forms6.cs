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
    public partial class Forms6 : Form
    {
        public Forms6()
        {
            InitializeComponent();
        }

        private void Forms6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQueryReativar(this.querysInnerJoinDataSet2.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample.QuerysInnerJoinDataSet2.MarcasRow;

            switch (e.ColumnIndex)
            {   //Coluna Alterar
                case 0:
                    {
                        this.marcasTableAdapter.UpdateQueryReativar(marcasSelect.Id);
                    }
                    break;
            }

            this.marcasTableAdapter.CustomQueryReativar(querysInnerJoinDataSet2.Marcas);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 frmCarros = new Form1();
            frmCarros.ShowDialog();
            this.Close();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Form8 frmUsuariosReativ = new Form8();
            frmUsuariosReativ.ShowDialog();
            this.Close();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            Form7 frmVendasReativ = new Form7();
            frmVendasReativ.ShowDialog();
            this.Close();
        }

        private void BtnCarros_Click(object sender, EventArgs e)
        {
            Forms5 frmCarrosReativ = new Forms5();
            frmCarrosReativ.ShowDialog();
            this.Close();

        }
    }
}
