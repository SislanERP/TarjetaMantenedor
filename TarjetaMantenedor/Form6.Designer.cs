namespace WindowsFormsApplication1
{
    partial class Form6
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtnoms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtapepat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapemat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdv = new System.Windows.Forms.TextBox();
            this.btnsaveub = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txttarnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(12, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(154, 24);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Agregar usuarios";
            // 
            // txtnoms
            // 
            this.txtnoms.Location = new System.Drawing.Point(16, 71);
            this.txtnoms.Name = "txtnoms";
            this.txtnoms.Size = new System.Drawing.Size(150, 20);
            this.txtnoms.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido Paterno";
            // 
            // txtapepat
            // 
            this.txtapepat.Location = new System.Drawing.Point(16, 110);
            this.txtapepat.Name = "txtapepat";
            this.txtapepat.Size = new System.Drawing.Size(150, 20);
            this.txtapepat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido Materno";
            // 
            // txtapemat
            // 
            this.txtapemat.Location = new System.Drawing.Point(16, 149);
            this.txtapemat.Name = "txtapemat";
            this.txtapemat.Size = new System.Drawing.Size(150, 20);
            this.txtapemat.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "RUT";
            // 
            // txtrut
            // 
            this.txtrut.Location = new System.Drawing.Point(16, 188);
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(150, 20);
            this.txtrut.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dígito Verificador";
            // 
            // txtdv
            // 
            this.txtdv.Location = new System.Drawing.Point(16, 227);
            this.txtdv.Name = "txtdv";
            this.txtdv.Size = new System.Drawing.Size(150, 20);
            this.txtdv.TabIndex = 5;
            // 
            // btnsaveub
            // 
            this.btnsaveub.Location = new System.Drawing.Point(16, 308);
            this.btnsaveub.Name = "btnsaveub";
            this.btnsaveub.Size = new System.Drawing.Size(75, 23);
            this.btnsaveub.TabIndex = 11;
            this.btnsaveub.Text = "Guardar";
            this.btnsaveub.UseVisualStyleBackColor = true;
            this.btnsaveub.Click += new System.EventHandler(this.btnsaveub_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Número de Tarjeta";
            // 
            // txttarnum
            // 
            this.txttarnum.Location = new System.Drawing.Point(16, 266);
            this.txttarnum.Name = "txttarnum";
            this.txttarnum.Size = new System.Drawing.Size(150, 20);
            this.txttarnum.TabIndex = 6;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 343);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttarnum);
            this.Controls.Add(this.btnsaveub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtrut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtapemat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtapepat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnoms);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form6";
            this.Text = "Agrega Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtnoms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtapepat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtapemat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdv;
        private System.Windows.Forms.Button btnsaveub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttarnum;
    }
}