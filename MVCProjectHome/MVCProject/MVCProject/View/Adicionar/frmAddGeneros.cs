using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Adicionar
{
    public partial class frmAddGeneros : Form
    {
        public frmAddGeneros()
        {
            InitializeComponent();
        }

        public Genero generosRow;

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            generosRow = new Genero
            {
                Tipo = tbxTipo.Text,
                Descricao = tbxDescricao.Text
            };

            this.Close();
        }
    }
}
