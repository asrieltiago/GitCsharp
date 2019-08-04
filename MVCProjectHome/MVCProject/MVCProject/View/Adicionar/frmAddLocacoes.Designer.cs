namespace MVCProject.View.Adicionar
{
    partial class frmAddLocacoes
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
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.cbxLivro = new System.Windows.Forms.ComboBox();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLocar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDevolucao = new System.Windows.Forms.DateTimePicker();
            this.livrosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter();
            this.usuariosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter();
            this.numTipo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.DataSource = this.usuariosBindingSource;
            this.cbxUsuario.DisplayMember = "Nome";
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(71, 30);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(293, 21);
            this.cbxUsuario.TabIndex = 58;
            this.cbxUsuario.ValueMember = "Id";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxLivro
            // 
            this.cbxLivro.DataSource = this.livrosBindingSource;
            this.cbxLivro.DisplayMember = "Titulo";
            this.cbxLivro.FormattingEnabled = true;
            this.cbxLivro.Location = new System.Drawing.Point(71, 7);
            this.cbxLivro.Name = "cbxLivro";
            this.cbxLivro.Size = new System.Drawing.Size(293, 21);
            this.cbxLivro.TabIndex = 57;
            this.cbxLivro.ValueMember = "Id";
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Livro";
            // 
            // btnLocar
            // 
            this.btnLocar.Location = new System.Drawing.Point(11, 107);
            this.btnLocar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocar.Name = "btnLocar";
            this.btnLocar.Size = new System.Drawing.Size(353, 76);
            this.btnLocar.TabIndex = 46;
            this.btnLocar.Text = "Locar";
            this.btnLocar.UseVisualStyleBackColor = true;
            this.btnLocar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Devolucao";
            // 
            // dtDevolucao
            // 
            this.dtDevolucao.Location = new System.Drawing.Point(71, 57);
            this.dtDevolucao.Name = "dtDevolucao";
            this.dtDevolucao.Size = new System.Drawing.Size(293, 20);
            this.dtDevolucao.TabIndex = 62;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // numTipo
            // 
            this.numTipo.Location = new System.Drawing.Point(71, 82);
            this.numTipo.Name = "numTipo";
            this.numTipo.Size = new System.Drawing.Size(293, 20);
            this.numTipo.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Tipo";
            // 
            // frmAddLocacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 192);
            this.Controls.Add(this.numTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDevolucao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.cbxLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLocar);
            this.Name = "frmAddLocacoes";
            this.Text = "Nova Locacao";
            this.Load += new System.EventHandler(this.FrmAddLocacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.ComboBox cbxLivro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLocar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDevolucao;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.NumericUpDown numTipo;
        private System.Windows.Forms.Label label1;
    }
}