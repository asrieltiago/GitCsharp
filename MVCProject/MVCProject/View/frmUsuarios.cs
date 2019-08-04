using MVCProject.View.Adicionar;
using MVCProject.View.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddUsuarios fAddUsuarios = new frmAddUsuarios();
            fAddUsuarios.ShowDialog();

            if (!string.IsNullOrEmpty(fAddUsuarios.usuariosRow?.Nome))
                this.usuariosTableAdapter.Insert(
                    fAddUsuarios.usuariosRow.Nome,
                    fAddUsuarios.usuariosRow.Login,
                    fAddUsuarios.usuariosRow.Senha,
                    fAddUsuarios.usuariosRow.Email,
                    true,
                    1,
                    1,
                    DateTime.Now,
                    DateTime.Now
                    );
            this.usuariosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void DataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuariosSelect = ((System.Data.DataRowView)
                this.dataGridUsuarios.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {   //Coluna Deletar
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuariosSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEditUsuarios editUsuarios = new frmEditUsuarios();
                        editUsuarios.UsuariosRow = usuariosSelect;
                        editUsuarios.ShowDialog();

                        this.usuariosTableAdapter.Update(editUsuarios.UsuariosRow);
                    }
                    break;
            }

            this.usuariosTableAdapter.FillBy(sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
