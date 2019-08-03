﻿using System;
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
    public partial class FrmEdicaoUsuarios : Form
    {
        public FrmEdicaoUsuarios()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerJoinDataSet2.UsuariosRow UsuariosRow;

        private void FrmEdicaoUsuarios_Load(object sender, EventArgs e)
        {
            textBox1.Text = UsuariosRow.Usuario;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosRow.Usuario = textBox1.Text;

            this.Close();
        }
    }
}

