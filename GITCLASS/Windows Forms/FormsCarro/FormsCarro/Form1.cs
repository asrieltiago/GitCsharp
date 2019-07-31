using FormsCarro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Carros> carro = new List<Carros>();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastro formulario = new TelaCadastro();
            formulario.ShowDialog();
            carro.Add(formulario.carro);

            //NULL para dar Refresh na lista.
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = carro;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var collEdit = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var datCollSelect = collEdit.OwningColumn.DataPropertyName;

                switch (datCollSelect)
                {
                    case "DatInc":
                        {
                            if(DateTime.Parse(collEdit.Value.ToString()) <= DateTime.Now)
                            {
                                this.carrosBindingSource.EndEdit();
                            }
                        }
                }
            }
        }
    }
}
