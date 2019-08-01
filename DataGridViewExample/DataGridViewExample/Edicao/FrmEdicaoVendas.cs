using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class FrmEdicaoVendas : Form
    {
        public FrmEdicaoVendas()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerJoinDataSet2.VendasRow VendasRow;
        public DataGridViewExample.QuerysInnerJoinDataSet2.CarrosRow CarrosRow;

        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.FillBy(this.querysInnerJoinDataSet2.Carros);

            comboBox1.SelectedValue = VendasRow.Id;            
            numericUpDown1.Value = VendasRow.Quantidade;
            textBox1.Text = VendasRow.Valor.ToString();

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            VendasRow.Carro = (int)comboBox1.SelectedValue;
            VendasRow.Quantidade = (int)numericUpDown1.Value;
            VendasRow.Valor = Convert.ToDecimal(textBox1.Text);

            this.Close();
        }
    }
}
