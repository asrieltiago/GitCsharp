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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQueryReativar(this.querysInnerJoinDataSet2.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           var usuariosSelect = ((System.Data.DataRowView)
           this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
           as DataGridViewExample.QuerysInnerJoinDataSet2.UsuariosRow;

            switch (e.ColumnIndex)
            {   //Coluna Alterar
                case 0:
                    {
                        this.usuariosTableAdapter.UpdateQueryReativar(usuariosSelect.Id);
                    }
                    break;
            }

            this.usuariosTableAdapter.CustomQueryReativar(querysInnerJoinDataSet2.Usuarios);
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 frmCarros = new Form1();
            frmCarros.ShowDialog();
            this.Hide();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            Form7 frmVendasReativ = new Form7();
            frmVendasReativ.ShowDialog();
            this.Hide();
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            Forms6 frmMarcasReativ = new Forms6();
            frmMarcasReativ.ShowDialog();
            this.Hide();
        }

        private void BtnCarros_Click(object sender, EventArgs e)
        {
            Forms5 frmCarrosReativ = new Forms5();
            frmCarrosReativ.ShowDialog();
            this.Hide();
        }
    }
}
