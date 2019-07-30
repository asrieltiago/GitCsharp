using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAlunos.Classes;

namespace WinFormAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<novoAluno> alunos = new List<novoAluno>();

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro formulario = new TelaCadastro();
            formulario.ShowDialog();
            alunos.Add(formulario.aluno);

            //NULL para dar Refresh na lista.
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alunos;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtListar_Click(object sender, EventArgs e)
        {
           
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
