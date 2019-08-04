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
    public partial class frmAddAutores : Form
    {
        public frmAddAutores()
        {
            InitializeComponent();
        }

        public Autor autoresRow;


        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            autoresRow = new Autor
            {
                Nome = tbxNome.Text,
                Descricao = tbxDescricao.Text
            };

            this.Close();
        }
    }
}
