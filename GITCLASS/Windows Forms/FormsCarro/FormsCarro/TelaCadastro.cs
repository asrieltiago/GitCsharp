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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        public Carros carro = new Carros();

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            carro.Modelo = tbxModelo.Text;
            carro.Ano = tbxAno.Text;
            carro.Placa = tbxPlaca.Text;

            this.Close();
        }
    }
}
