namespace MVCProject.View.Editar
{
    partial class frmEditLivro
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
            this.tbxObservacao = new System.Windows.Forms.TextBox();
            this.tbxSinopse = new System.Windows.Forms.TextBox();
            this.cbxEditora = new System.Windows.Forms.ComboBox();
            this.editorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.numRegistro = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.generosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter();
            this.editorasTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxObservacao
            // 
            this.tbxObservacao.Location = new System.Drawing.Point(88, 149);
            this.tbxObservacao.Name = "tbxObservacao";
            this.tbxObservacao.Size = new System.Drawing.Size(292, 20);
            this.tbxObservacao.TabIndex = 60;
            // 
            // tbxSinopse
            // 
            this.tbxSinopse.Location = new System.Drawing.Point(88, 127);
            this.tbxSinopse.Name = "tbxSinopse";
            this.tbxSinopse.Size = new System.Drawing.Size(292, 20);
            this.tbxSinopse.TabIndex = 59;
            // 
            // cbxEditora
            // 
            this.cbxEditora.DataSource = this.editorasBindingSource;
            this.cbxEditora.DisplayMember = "Nome";
            this.cbxEditora.FormattingEnabled = true;
            this.cbxEditora.Location = new System.Drawing.Point(88, 104);
            this.cbxEditora.Name = "cbxEditora";
            this.cbxEditora.Size = new System.Drawing.Size(292, 21);
            this.cbxEditora.TabIndex = 58;
            this.cbxEditora.ValueMember = "Id";
            // 
            // editorasBindingSource
            // 
            this.editorasBindingSource.DataMember = "Editoras";
            this.editorasBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxGenero
            // 
            this.cbxGenero.DataSource = this.generosBindingSource;
            this.cbxGenero.DisplayMember = "Tipo";
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(88, 81);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(292, 21);
            this.cbxGenero.TabIndex = 57;
            this.cbxGenero.ValueMember = "Id";
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Location = new System.Drawing.Point(88, 59);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(292, 20);
            this.tbxIsbn.TabIndex = 56;
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(88, 37);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(292, 20);
            this.tbxTitulo.TabIndex = 55;
            // 
            // numRegistro
            // 
            this.numRegistro.Location = new System.Drawing.Point(88, 15);
            this.numRegistro.Name = "numRegistro";
            this.numRegistro.Size = new System.Drawing.Size(292, 20);
            this.numRegistro.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Observação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Sinopse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Gênero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Isbn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Registro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(21, 178);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(359, 76);
            this.btnSalvar.TabIndex = 46;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // editorasTableAdapter
            // 
            this.editorasTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 271);
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
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmEditLivro";
            this.Text = "frmEditLivro";
            this.Load += new System.EventHandler(this.FrmEditLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxObservacao;
        private System.Windows.Forms.TextBox tbxSinopse;
        private System.Windows.Forms.ComboBox cbxEditora;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.NumericUpDown numRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter generosTableAdapter;
        private System.Windows.Forms.BindingSource editorasBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter editorasTableAdapter;
    }
}