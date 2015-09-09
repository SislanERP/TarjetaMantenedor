namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.gridUsuBio = new System.Windows.Forms.DataGridView();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnagregaub = new System.Windows.Forms.Button();
            this.btneditub = new System.Windows.Forms.Button();
            this.btndesactub = new System.Windows.Forms.Button();
            this.bioStarDataSet = new WindowsFormsApplication1.BioStarDataSet();
            this.tBUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_USUARIOTableAdapter = new WindowsFormsApplication1.BioStarDataSetTableAdapters.TB_USUARIOTableAdapter();
            this.tBUSUARIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnactub = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuBio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioStarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUSUARIOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUsuBio
            // 
            this.gridUsuBio.AllowUserToAddRows = false;
            this.gridUsuBio.AllowUserToDeleteRows = false;
            this.gridUsuBio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUsuBio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuBio.Location = new System.Drawing.Point(12, 87);
            this.gridUsuBio.Name = "gridUsuBio";
            this.gridUsuBio.ReadOnly = true;
            this.gridUsuBio.Size = new System.Drawing.Size(834, 244);
            this.gridUsuBio.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(9, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(303, 24);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Administración de Usuarios BioStar";
            // 
            // btnagregaub
            // 
            this.btnagregaub.Location = new System.Drawing.Point(13, 56);
            this.btnagregaub.Name = "btnagregaub";
            this.btnagregaub.Size = new System.Drawing.Size(75, 23);
            this.btnagregaub.TabIndex = 2;
            this.btnagregaub.Text = "Agregar";
            this.btnagregaub.UseVisualStyleBackColor = true;
            this.btnagregaub.Click += new System.EventHandler(this.btnagregaub_Click);
            // 
            // btneditub
            // 
            this.btneditub.Location = new System.Drawing.Point(94, 56);
            this.btneditub.Name = "btneditub";
            this.btneditub.Size = new System.Drawing.Size(75, 23);
            this.btneditub.TabIndex = 3;
            this.btneditub.Text = "Editar";
            this.btneditub.UseVisualStyleBackColor = true;
            this.btneditub.Click += new System.EventHandler(this.btneditub_Click);
            // 
            // btndesactub
            // 
            this.btndesactub.Location = new System.Drawing.Point(256, 56);
            this.btndesactub.Name = "btndesactub";
            this.btndesactub.Size = new System.Drawing.Size(75, 23);
            this.btndesactub.TabIndex = 4;
            this.btndesactub.Text = "Desactivar";
            this.btndesactub.UseVisualStyleBackColor = true;
            this.btndesactub.Click += new System.EventHandler(this.btndesactub_Click);
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
            // tBUSUARIOBindingSource1
            // 
            this.tBUSUARIOBindingSource1.DataMember = "TB_USUARIO";
            this.tBUSUARIOBindingSource1.DataSource = this.bioStarDataSet;
            // 
            // btnactub
            // 
            this.btnactub.Location = new System.Drawing.Point(175, 56);
            this.btnactub.Name = "btnactub";
            this.btnactub.Size = new System.Drawing.Size(75, 23);
            this.btnactub.TabIndex = 5;
            this.btnactub.Text = "Activar";
            this.btnactub.UseVisualStyleBackColor = true;
            this.btnactub.Click += new System.EventHandler(this.btnactub_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(337, 56);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(103, 23);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "Actualizar tabla";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 343);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnactub);
            this.Controls.Add(this.btndesactub);
            this.Controls.Add(this.btneditub);
            this.Controls.Add(this.btnagregaub);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.gridUsuBio);
            this.Name = "Form5";
            this.Text = "Administración Usuarios BioStar";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuBio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioStarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUSUARIOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUsuBio;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnagregaub;
        private System.Windows.Forms.Button btneditub;
        private System.Windows.Forms.Button btndesactub;
        private BioStarDataSet bioStarDataSet;
        private System.Windows.Forms.BindingSource tBUSUARIOBindingSource;
        private BioStarDataSetTableAdapters.TB_USUARIOTableAdapter tB_USUARIOTableAdapter;
        private System.Windows.Forms.BindingSource tBUSUARIOBindingSource1;
        private System.Windows.Forms.Button btnactub;
        private System.Windows.Forms.Button btnrefresh;
    }
}