namespace WindowsFormsApplication1
{
    partial class Form8
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
            this.cmbgrpacc = new System.Windows.Forms.ComboBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblgrpac = new System.Windows.Forms.Label();
            this.btnasignaga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbgrpacc
            // 
            this.cmbgrpacc.FormattingEnabled = true;
            this.cmbgrpacc.Location = new System.Drawing.Point(129, 75);
            this.cmbgrpacc.Name = "cmbgrpacc";
            this.cmbgrpacc.Size = new System.Drawing.Size(121, 21);
            this.cmbgrpacc.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(22, 28);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(200, 13);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Seleccione el grupo de acceso a asignar";
            // 
            // lblgrpac
            // 
            this.lblgrpac.AutoSize = true;
            this.lblgrpac.Location = new System.Drawing.Point(22, 78);
            this.lblgrpac.Name = "lblgrpac";
            this.lblgrpac.Size = new System.Drawing.Size(94, 13);
            this.lblgrpac.TabIndex = 2;
            this.lblgrpac.Text = "Grupos de acceso";
            // 
            // btnasignaga
            // 
            this.btnasignaga.Location = new System.Drawing.Point(175, 129);
            this.btnasignaga.Name = "btnasignaga";
            this.btnasignaga.Size = new System.Drawing.Size(75, 23);
            this.btnasignaga.TabIndex = 3;
            this.btnasignaga.Text = "Asignar";
            this.btnasignaga.UseVisualStyleBackColor = true;
            this.btnasignaga.Click += new System.EventHandler(this.btnasignaga_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.btnasignaga);
            this.Controls.Add(this.lblgrpac);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.cmbgrpacc);
            this.Name = "Form8";
            this.Text = "Asignación grupos de acceso";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbgrpacc;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblgrpac;
        private System.Windows.Forms.Button btnasignaga;
    }
}