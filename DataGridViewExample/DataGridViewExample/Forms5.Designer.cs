namespace DataGridViewExample
{
    partial class Forms5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.querysInnerJoinDataSet2 = new DataGridViewExample.QuerysInnerJoinDataSet2();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataTable1TableAdapter = new DataGridViewExample.QuerysInnerJoinDataSet2TableAdapters.DataTable1TableAdapter();
            this.ReactivateCollumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestaurarCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.carrosTableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet2TableAdapters.CarrosTableAdapter();
            this.marcasTableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet2TableAdapters.MarcasTableAdapter();
            this.usuariosTableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet2TableAdapters.UsuariosTableAdapter();
            this.vendasTableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet2TableAdapters.VendasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReactivateCollumn,
            this.idDataGridViewTextBoxColumn,
            this.RestaurarCommand});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.querysInnerJoinDataSet2;
            // 
            // querysInnerJoinDataSet2
            // 
            this.querysInnerJoinDataSet2.DataSetName = "QuerysInnerJoinDataSet2";
            this.querysInnerJoinDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(12, 8);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(163, 35);
            this.btnMarcas.TabIndex = 1;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.BtnMarcas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(350, 8);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(163, 35);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(181, 8);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(163, 35);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.BtnVendas_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(519, 8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(166, 35);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // ReactivateCollumn
            // 
            this.ReactivateCollumn.DataPropertyName = "ReactivateCommand";
            this.ReactivateCollumn.HeaderText = "Reativar";
            this.ReactivateCollumn.MinimumWidth = 6;
            this.ReactivateCollumn.Name = "ReactivateCollumn";
            this.ReactivateCollumn.ReadOnly = true;
            this.ReactivateCollumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // RestaurarCommand
            // 
            this.RestaurarCommand.DataPropertyName = " Tabela";
            this.RestaurarCommand.HeaderText = "Tabela";
            this.RestaurarCommand.MinimumWidth = 6;
            this.RestaurarCommand.Name = "RestaurarCommand";
            this.RestaurarCommand.ReadOnly = true;
            this.RestaurarCommand.Width = 125;
            // 
            // carrosTableAdapter1
            // 
            this.carrosTableAdapter1.ClearBeforeFill = true;
            // 
            // marcasTableAdapter1
            // 
            this.marcasTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // vendasTableAdapter1
            // 
            this.vendasTableAdapter1.ClearBeforeFill = true;
            // 
            // Forms5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Forms5";
            this.Text = "Forms5";
            this.Load += new System.EventHandler(this.Forms5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnVoltar;
        private QuerysInnerJoinDataSet2 querysInnerJoinDataSet2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private QuerysInnerJoinDataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn ReactivateCollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn RestaurarCommand;
        private QuerysInnerJoinDataSet2TableAdapters.CarrosTableAdapter carrosTableAdapter1;
        private QuerysInnerJoinDataSet2TableAdapters.MarcasTableAdapter marcasTableAdapter1;
        private QuerysInnerJoinDataSet2TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private QuerysInnerJoinDataSet2TableAdapters.VendasTableAdapter vendasTableAdapter1;
    }
}