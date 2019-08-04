namespace MVCProject.View
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
            this.dataGridLivroAutor = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivroAutor)).BeginInit();
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
            // dataGridLivroAutor
            // 
            this.dataGridLivroAutor.AllowUserToAddRows = false;
            this.dataGridLivroAutor.AllowUserToDeleteRows = false;
            this.dataGridLivroAutor.AutoGenerateColumns = false;
            this.dataGridLivroAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLivroAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditCommand,
            this.livroDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn});
            this.dataGridLivroAutor.DataSource = this.livroAutorBindingSource;
            this.dataGridLivroAutor.Location = new System.Drawing.Point(0, 51);
            this.dataGridLivroAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridLivroAutor.Name = "dataGridLivroAutor";
            this.dataGridLivroAutor.ReadOnly = true;
            this.dataGridLivroAutor.RowHeadersWidth = 51;
            this.dataGridLivroAutor.RowTemplate.Height = 24;
            this.dataGridLivroAutor.Size = new System.Drawing.Size(600, 314);
            this.dataGridLivroAutor.TabIndex = 2;
            this.dataGridLivroAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(1, 0);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(598, 48);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // frmLivroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridLivroAutor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLivroAutor";
            this.Text = "frmLivroAutor";
            this.Load += new System.EventHandler(this.FrmLivroAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivroAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livroAutorBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivroAutorTableAdapter livroAutorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditCommand;
        private System.Windows.Forms.DataGridView dataGridLivroAutor;
        private System.Windows.Forms.Button btnAdicionar;
    }
}