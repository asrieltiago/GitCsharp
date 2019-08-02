﻿namespace MVCProject.View
{
    partial class frmLivroAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.livroAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroAutorTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivroAutorTableAdapter();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroAutorBindingSource
            // 
            this.livroAutorBindingSource.DataMember = "LivroAutor";
            this.livroAutorBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // livroAutorTableAdapter
            // 
            this.livroAutorTableAdapter.ClearBeforeFill = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Width = 125;
            // 
            // livroDataGridViewTextBoxColumn
            // 
            this.livroDataGridViewTextBoxColumn.DataPropertyName = "Livro";
            this.livroDataGridViewTextBoxColumn.HeaderText = "Livro";
            this.livroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.livroDataGridViewTextBoxColumn.Name = "livroDataGridViewTextBoxColumn";
            this.livroDataGridViewTextBoxColumn.ReadOnly = true;
            this.livroDataGridViewTextBoxColumn.Width = 125;
            // 
            // EditCommand
            // 
            this.EditCommand.HeaderText = "Editar";
            this.EditCommand.MinimumWidth = 6;
            this.EditCommand.Name = "EditCommand";
            this.EditCommand.ReadOnly = true;
            this.EditCommand.Text = "Editar";
            this.EditCommand.UseColumnTextForButtonValue = true;
            this.EditCommand.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditCommand,
            this.livroDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.livroAutorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 387);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(1, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(797, 59);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // frmLivroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmLivroAutor";
            this.Text = "frmLivroAutor";
            this.Load += new System.EventHandler(this.FrmLivroAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livroAutorBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivroAutorTableAdapter livroAutorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditCommand;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdicionar;
    }
}