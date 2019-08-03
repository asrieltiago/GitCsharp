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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        public novoAluno aluno = new novoAluno();

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            aluno.Nome = tbxNome.Text;
            aluno.Idade = (int)nrIdade.Value;

            this.Close();
        }
    }
}
