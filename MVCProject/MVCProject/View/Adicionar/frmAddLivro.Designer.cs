namespace MVCProject.View.Adicionar
{
    partial class frmAddLivro
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numRegistro = new System.Windows.Forms.NumericUpDown();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter();
            this.cbxEditora = new System.Windows.Forms.ComboBox();
            this.editorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editorasTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter();
            this.tbxSinopse = new System.Windows.Forms.TextBox();
            this.tbxObservacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(26, 179);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(359, 76);
            this.btnAdicionar.TabIndex = 31;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Isbn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Gênero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Editora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Sinopse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Observação";
            // 
            // numRegistro
            // 
            this.numRegistro.Location = new System.Drawing.Point(93, 16);
            this.numRegistro.Name = "numRegistro";
            this.numRegistro.Size = new System.Drawing.Size(292, 20);
            this.numRegistro.TabIndex = 39;
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(93, 38);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(292, 20);
            this.tbxTitulo.TabIndex = 40;
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Location = new System.Drawing.Point(93, 60);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(292, 20);
            this.tbxIsbn.TabIndex = 41;
            // 
            // cbxGenero
            // 
            this.cbxGenero.DataSource = this.generosBindingSource;
            this.cbxGenero.DisplayMember = "Tipo";
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(93, 82);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(292, 21);
            this.cbxGenero.TabIndex = 42;
            this.cbxGenero.ValueMember = "Id";
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // cbxEditora
            // 
            this.cbxEditora.DataSource = this.editorasBindingSource;
            this.cbxEditora.DisplayMember = "Nome";
            this.cbxEditora.FormattingEnabled = true;
            this.cbxEditora.Location = new System.Drawing.Point(93, 105);
            this.cbxEditora.Name = "cbxEditora";
            this.cbxEditora.Size = new System.Drawing.Size(292, 21);
            this.cbxEditora.TabIndex = 43;
            this.cbxEditora.ValueMember = "Id";
            // 
            // editorasBindingSource
            // 
            this.editorasBindingSource.DataMember = "Editoras";
            this.editorasBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // editorasTableAdapter
            // 
            this.editorasTableAdapter.ClearBeforeFill = true;
            // 
            // tbxSinopse
            // 
            this.tbxSinopse.Location = new System.Drawing.Point(93, 128);
            this.tbxSinopse.Name = "tbxSinopse";
            this.tbxSinopse.Size = new System.Drawing.Size(292, 20);
            this.tbxSinopse.TabIndex = 44;
            // 
            // tbxObservacao
            // 
            this.tbxObservacao.Location = new System.Drawing.Point(93, 150);
            this.tbxObservacao.Name = "tbxObservacao";
            this.tbxObservacao.Size = new System.Drawing.Size(292, 20);
            this.tbxObservacao.TabIndex = 45;
            // 
            // frmAddLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 272);
            this.Controls.Add(this.tbxObservacao);
            this.Controls.Add(this.tbxSinopse);
            this.Controls.Add(this.cbxEditora);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.tbxIsbn);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.numRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "frmAddLivro";
            this.Text = "frmAddLivro";
            this.Load += new System.EventHandler(this.FrmAddLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numRegistro;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.ComboBox cbxGenero;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter generosTableAdapter;
        private System.Windows.Forms.ComboBox cbxEditora;
        private System.Windows.Forms.BindingSource editorasBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter editorasTableAdapter;
        private System.Windows.Forms.TextBox tbxSinopse;
        private System.Windows.Forms.TextBox tbxObservacao;
    }
}