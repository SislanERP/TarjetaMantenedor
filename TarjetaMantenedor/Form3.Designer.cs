namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.bioStarDataSet = new WindowsFormsApplication1.BioStarDataSet();
            this.tBUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_USUARIOTableAdapter = new WindowsFormsApplication1.BioStarDataSetTableAdapters.TB_USUARIOTableAdapter();
            this.uSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUSEGUNDONOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUAPELLIDOPATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUAPELLIDOMATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSURUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUDEPARTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUCONTRASENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUROLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUCOMENTARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioStarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSUIDDataGridViewTextBoxColumn,
            this.uSUNOMBREDataGridViewTextBoxColumn,
            this.uSUSEGUNDONOMBREDataGridViewTextBoxColumn,
            this.uSUAPELLIDOPATERNODataGridViewTextBoxColumn,
            this.uSUAPELLIDOMATERNODataGridViewTextBoxColumn,
            this.uSURUTDataGridViewTextBoxColumn,
            this.uSUDVDataGridViewTextBoxColumn,
            this.uSUDEPARTAMENTODataGridViewTextBoxColumn,
            this.uSUUSUARIODataGridViewTextBoxColumn,
            this.uSUCONTRASENADataGridViewTextBoxColumn,
            this.uSUROLDataGridViewTextBoxColumn,
            this.uSUCOMENTARIODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBUSUARIOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(829, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // bioStarDataSet
            // 
            this.bioStarDataSet.DataSetName = "BioStarDataSet";
            this.bioStarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBUSUARIOBindingSource
            // 
            this.tBUSUARIOBindingSource.DataMember = "TB_USUARIO";
            this.tBUSUARIOBindingSource.DataSource = this.bioStarDataSet;
            // 
            // tB_USUARIOTableAdapter
            // 
            this.tB_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // uSUIDDataGridViewTextBoxColumn
            // 
            this.uSUIDDataGridViewTextBoxColumn.DataPropertyName = "USU_ID";
            this.uSUIDDataGridViewTextBoxColumn.HeaderText = "USU_ID";
            this.uSUIDDataGridViewTextBoxColumn.Name = "uSUIDDataGridViewTextBoxColumn";
            this.uSUIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSUNOMBREDataGridViewTextBoxColumn
            // 
            this.uSUNOMBREDataGridViewTextBoxColumn.DataPropertyName = "USU_NOMBRE";
            this.uSUNOMBREDataGridViewTextBoxColumn.HeaderText = "USU_NOMBRE";
            this.uSUNOMBREDataGridViewTextBoxColumn.Name = "uSUNOMBREDataGridViewTextBoxColumn";
            // 
            // uSUSEGUNDONOMBREDataGridViewTextBoxColumn
            // 
            this.uSUSEGUNDONOMBREDataGridViewTextBoxColumn.DataPropertyName = "USU_SEGUNDO_NOMBRE";
            this.uSUSEGUNDONOMBREDataGridViewTextBoxColumn.HeaderText = "USU_SEGUNDO_NOMBRE";
            this.uSUSEGUNDONOMBREDataGridViewTextBoxColumn.Name = "uSUSEGUNDONOMBREDataGridViewTextBoxColumn";
            // 
            // uSUAPELLIDOPATERNODataGridViewTextBoxColumn
            // 
            this.uSUAPELLIDOPATERNODataGridViewTextBoxColumn.DataPropertyName = "USU_APELLIDO_PATERNO";
            this.uSUAPELLIDOPATERNODataGridViewTextBoxColumn.HeaderText = "USU_APELLIDO_PATERNO";
            this.uSUAPELLIDOPATERNODataGridViewTextBoxColumn.Name = "uSUAPELLIDOPATERNODataGridViewTextBoxColumn";
            // 
            // uSUAPELLIDOMATERNODataGridViewTextBoxColumn
            // 
            this.uSUAPELLIDOMATERNODataGridViewTextBoxColumn.DataPropertyName = "USU_APELLIDO_MATERNO";
            this.uSUAPELLIDOMATERNODataGridViewTextBoxColumn.HeaderText = "USU_APELLIDO_MATERNO";
            this.uSUAPELLIDOMATERNODataGridViewTextBoxColumn.Name = "uSUAPELLIDOMATERNODataGridViewTextBoxColumn";
            // 
            // uSURUTDataGridViewTextBoxColumn
            // 
            this.uSURUTDataGridViewTextBoxColumn.DataPropertyName = "USU_RUT";
            this.uSURUTDataGridViewTextBoxColumn.HeaderText = "USU_RUT";
            this.uSURUTDataGridViewTextBoxColumn.Name = "uSURUTDataGridViewTextBoxColumn";
            // 
            // uSUDVDataGridViewTextBoxColumn
            // 
            this.uSUDVDataGridViewTextBoxColumn.DataPropertyName = "USU_DV";
            this.uSUDVDataGridViewTextBoxColumn.HeaderText = "USU_DV";
            this.uSUDVDataGridViewTextBoxColumn.Name = "uSUDVDataGridViewTextBoxColumn";
            // 
            // uSUDEPARTAMENTODataGridViewTextBoxColumn
            // 
            this.uSUDEPARTAMENTODataGridViewTextBoxColumn.DataPropertyName = "USU_DEPARTAMENTO";
            this.uSUDEPARTAMENTODataGridViewTextBoxColumn.HeaderText = "USU_DEPARTAMENTO";
            this.uSUDEPARTAMENTODataGridViewTextBoxColumn.Name = "uSUDEPARTAMENTODataGridViewTextBoxColumn";
            // 
            // uSUUSUARIODataGridViewTextBoxColumn
            // 
            this.uSUUSUARIODataGridViewTextBoxColumn.DataPropertyName = "USU_USUARIO";
            this.uSUUSUARIODataGridViewTextBoxColumn.HeaderText = "USU_USUARIO";
            this.uSUUSUARIODataGridViewTextBoxColumn.Name = "uSUUSUARIODataGridViewTextBoxColumn";
            // 
            // uSUCONTRASENADataGridViewTextBoxColumn
            // 
            this.uSUCONTRASENADataGridViewTextBoxColumn.DataPropertyName = "USU_CONTRASENA";
            this.uSUCONTRASENADataGridViewTextBoxColumn.HeaderText = "USU_CONTRASENA";
            this.uSUCONTRASENADataGridViewTextBoxColumn.Name = "uSUCONTRASENADataGridViewTextBoxColumn";
            // 
            // uSUROLDataGridViewTextBoxColumn
            // 
            this.uSUROLDataGridViewTextBoxColumn.DataPropertyName = "USU_ROL";
            this.uSUROLDataGridViewTextBoxColumn.HeaderText = "USU_ROL";
            this.uSUROLDataGridViewTextBoxColumn.Name = "uSUROLDataGridViewTextBoxColumn";
            // 
            // uSUCOMENTARIODataGridViewTextBoxColumn
            // 
            this.uSUCOMENTARIODataGridViewTextBoxColumn.DataPropertyName = "USU_COMENTARIO";
            this.uSUCOMENTARIODataGridViewTextBoxColumn.HeaderText = "USU_COMENTARIO";
            this.uSUCOMENTARIODataGridViewTextBoxColumn.Name = "uSUCOMENTARIODataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 340);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioStarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BioStarDataSet bioStarDataSet;
        private System.Windows.Forms.BindingSource tBUSUARIOBindingSource;
        private BioStarDataSetTableAdapters.TB_USUARIOTableAdapter tB_USUARIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUSEGUNDONOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUAPELLIDOPATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUAPELLIDOMATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSURUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUDEPARTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUCONTRASENADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUROLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUCOMENTARIODataGridViewTextBoxColumn;
    }
}