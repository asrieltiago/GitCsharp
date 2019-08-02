using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class frmAdicionarVenda : Form
    {
        public frmAdicionarVenda()
        {
            InitializeComponent();
        }
        private void FrmAdicionarVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet2.Carros);

        }

        public Venda vendasRow;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textBox1.Text, out decimal valor);

            vendasRow = new Venda
            {
                Carro = (int)cbxCarro.SelectedValue,
                Quantidade = (int)numericUpDown1.Value,
                Valor = valor
            };

            this.Close();

        }
    }
}
