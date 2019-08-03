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
    public partial class FrmEdicaoMarcas : Form
    {
        public FrmEdicaoMarcas()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerJoinDataSet2.MarcasRow MarcasRow;

        private void FrmEdicaoMarcas_Load(object sender, EventArgs e)
        {
            textBox1.Text = MarcasRow.Nome;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MarcasRow.Nome = textBox1.Text;

            this.Close();
        }
    }
}
