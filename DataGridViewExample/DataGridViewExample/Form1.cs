﻿using DataGridViewExample.Adicionar;
using DataGridViewExample.Edicao;
using DataGridViewExample.Meme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet2.Carros);
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            Form3 frmMarcas = new Form3();
            frmMarcas.ShowDialog();
            this.Close();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Form4 frmUsuarios = new Form4();
            frmUsuarios.ShowDialog();
            this.Close();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            Form2 frmVendas = new Form2();
            frmVendas.ShowDialog();
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet2.CarrosRow;

            switch (e.ColumnIndex)
            {   //Coluna Deletar
                case 0:
                    {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                    }
                    break;
                case 1:
                    {
                        FrmEdicaoCarros editCarros = new FrmEdicaoCarros();
                        editCarros.CarrosRow = carSelect;
                        editCarros.ShowDialog();

                        //Forma 1 de atualizar (Atualiza todas as querys, mesmo que se altere apenas um campo)
                        this.carrosTableAdapter.Update(editCarros.CarrosRow);

                        //Forma 2 de atualizar os dados ( Forma correta, fazendo uma Query)

                        /*this.carrosTableAdapter.UpdateQuery(
                            editCarros.CarrosRow.Modelo,
                            editCarros.CarrosRow.Ano.ToString(),
                            editCarros.CarrosRow.Marca,
                            editCarros.CarrosRow.UsuInc,
                            DateTime.Now,
                            editCarros.CarrosRow.Id);*/
                    }
                    break;
            }

            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet2.Carros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Forms5 frmCarrosReativ = new Forms5();
            frmCarrosReativ.ShowDialog();
            this.Close();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            //Abre o formulario de atualizacao
            frmAdicionar fAddCarro = new frmAdicionar();
            fAddCarro.ShowDialog();

            if(!string.IsNullOrEmpty(fAddCarro.carrosRow?.Modelo))
            //Insert na tabela do banco de dados
            this.carrosTableAdapter.Insert(
                fAddCarro.carrosRow.Modelo,
                fAddCarro.carrosRow.Ano,
                fAddCarro.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            //Atualiza a tabela
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet2.Carros);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormEpico epico = new FormEpico();
            epico.Show();
        }
    }
}
