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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQueryReativar(this.querysInnerJoinDataSet2.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample.QuerysInnerJoinDataSet2.VendasRow;

            switch (e.ColumnIndex)
            {   //Coluna Alterar
                case 0:
                    {
                        this.vendasTableAdapter.UpdateQueryReativar(vendasSelect.Id);
                    }
                    break;
            }

            this.vendasTableAdapter.CustomQueryReativar(querysInnerJoinDataSet2.Vendas);
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

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            Forms6 frmMarcasReativ = new Forms6();
            frmMarcasReativ.ShowDialog();
            this.Close();
        }

        private void BtnCarros_Click(object sender, EventArgs e)
        {
            Forms5 frmCarrosReativ = new Forms5();
            frmCarrosReativ.ShowDialog();
            this.Close();
        }

        private void VendasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
