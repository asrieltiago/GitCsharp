namespace DataGridViewExample.Edicao
{
    partial class FrmEdicaoVendas
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.querysInnerJoinDataSet2 = new DataGridViewExample.QuerysInnerJoinDataSet2();
            this.carrosTableAdapter = new DataGridViewExample.QuerysInnerJoinDataSet2TableAdapters.CarrosTableAdapter();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(36, 121);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(478, 94);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modelo ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantidade";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(142, 52);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(370, 22);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Valor R$";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.carrosBindingSource;
            this.comboBox1.DisplayMember = "Modelo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 24);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "Id";
            // 
            // querysInnerJoinDataSet2
            // 
            this.querysInnerJoinDataSet2.DataSetName = "QuerysInnerJoinDataSet2";
            this.querysInnerJoinDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.querysInnerJoinDataSet2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 22);
            this.textBox1.TabIndex = 24;
            // 
            // FrmEdicaoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 238);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Name = "FrmEdicaoVendas";
            this.Text = "FrmEdicaoVendas";
            this.Load += new System.EventHandler(this.FrmEdicaoVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private QuerysInnerJoinDataSet2 querysInnerJoinDataSet2;
        private QuerysInnerJoinDataSet2TableAdapters.CarrosTableAdapter carrosTableAdapter;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private System.Windows.Forms.TextBox textBox1;
    }
}