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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet2.Usuarios);

        }

        private void BtnCarros_Click(object sender, EventArgs e)
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

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            Form2 frmVendas = new Form2();
            frmVendas.ShowDialog();
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet2.UsuariosRow;                       

            switch (e.ColumnIndex)
            {   //Coluna Deletar
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuarioSelect.Id);
                    }
                    break;
                case 1:
                    {
                        FrmEdicaoUsuarios editUsuarios = new FrmEdicaoUsuarios();
                        editUsuarios.UsuariosRow = usuarioSelect;
                        editUsuarios.ShowDialog();

                        this.usuariosTableAdapter.Update(editUsuarios.UsuariosRow);
                    }
                    break;

            }
            this.usuariosTableAdapter.CustomQuery(querysInnerJoinDataSet2.Usuarios);
        }


    }
}
