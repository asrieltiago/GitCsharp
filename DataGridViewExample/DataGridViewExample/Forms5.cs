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
    public partial class Forms5 : Form
    {
        public Forms5()
        {
            InitializeComponent();
        }

        private void Forms5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQueryReativar(this.querysInnerJoinDataSet2.Carros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridViewExample.QuerysInnerJoinDataSet2.CarrosRow;

            switch (e.ColumnIndex)
            {   //Coluna Alterar
                case 0:
                    {
                        this.carrosTableAdapter.UpdateQueryReativar(carSelect.Id);
                    }
                    break;
            }

            this.carrosTableAdapter.CustomQueryReativar(querysInnerJoinDataSet2.Carros);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 frmCarros = new Form1();
            frmCarros.ShowDialog();
            this.Close();
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            Forms6 frmMarcasReativ = new Forms6();
            frmMarcasReativ.ShowDialog();
            this.Close();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            Form7 frmVendasReativ = new Form7();
            frmVendasReativ.ShowDialog();
            this.Close();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Form8 frmUsuariosReativ = new Form8();
            frmUsuariosReativ.ShowDialog();
            this.Close();
        }
    }
}
