using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editar
{
    public partial class frmEditEditoras : Form
    {
       public frmEditEditoras()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.EditorasRow EditorasRow;

        private void FrmEditEditoras_Load_1(object sender, EventArgs e)
        {
            tbxNome.Text = EditorasRow.Nome;
            tbxDescricao.Text = EditorasRow.Descricao;
        }
        
        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            EditorasRow.Nome = tbxNome.Text;
            EditorasRow.Descricao = tbxDescricao.Text;

            this.Close();
        }

    }
}
