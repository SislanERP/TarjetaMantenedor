namespace WindowsFormsApplication1
{
    partial class Form7
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.txttarjeta = new System.Windows.Forms.TextBox();
            this.txtaccgrp = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.brnactualiza = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblrut = new System.Windows.Forms.Label();
            this.lblnumtar = new System.Windows.Forms.Label();
            this.lblaccgrp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnnewgrp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(172, 48);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(265, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtrut
            // 
            this.txtrut.Location = new System.Drawing.Point(172, 74);
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(265, 20);
            this.txtrut.TabIndex = 2;
            // 
            // txttarjeta
            // 
            this.txttarjeta.Location = new System.Drawing.Point(172, 100);
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.Size = new System.Drawing.Size(265, 20);
            this.txttarjeta.TabIndex = 3;
            // 
            // txtaccgrp
            // 
            this.txtaccgrp.Location = new System.Drawing.Point(172, 126);
            this.txtaccgrp.Name = "txtaccgrp";
            this.txtaccgrp.Size = new System.Drawing.Size(265, 20);
            this.txtaccgrp.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(172, 181);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(265, 20);
            this.textBox6.TabIndex = 6;
            // 
            // brnactualiza
            // 
            this.brnactualiza.Location = new System.Drawing.Point(197, 226);
            this.brnactualiza.Name = "brnactualiza";
            this.brnactualiza.Size = new System.Drawing.Size(75, 23);
            this.brnactualiza.TabIndex = 7;
            this.brnactualiza.Text = "Actualizar";
            this.brnactualiza.UseVisualStyleBackColor = true;
            this.brnactualiza.Click += new System.EventHandler(this.brnactualiza_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(23, 51);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 8;
            this.lblnombre.Text = "Nombre";
            // 
            // lblrut
            // 
            this.lblrut.AutoSize = true;
            this.lblrut.Location = new System.Drawing.Point(23, 77);
            this.lblrut.Name = "lblrut";
            this.lblrut.Size = new System.Drawing.Size(30, 13);
            this.lblrut.TabIndex = 9;
            this.lblrut.Text = "RUT";
            // 
            // lblnumtar
            // 
            this.lblnumtar.AutoSize = true;
            this.lblnumtar.Location = new System.Drawing.Point(23, 103);
            this.lblnumtar.Name = "lblnumtar";
            this.lblnumtar.Size = new System.Drawing.Size(76, 13);
            this.lblnumtar.TabIndex = 10;
            this.lblnumtar.Text = "Número tarjeta";
            // 
            // lblaccgrp
            // 
            this.lblaccgrp.AutoSize = true;
            this.lblaccgrp.Location = new System.Drawing.Point(23, 129);
            this.lblaccgrp.Name = "lblaccgrp";
            this.lblaccgrp.Size = new System.Drawing.Size(89, 13);
            this.lblaccgrp.TabIndex = 11;
            this.lblaccgrp.Text = "Grupo de acceso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // btnnewgrp
            // 
            this.btnnewgrp.Location = new System.Drawing.Point(172, 152);
            this.btnnewgrp.Name = "btnnewgrp";
            this.btnnewgrp.Size = new System.Drawing.Size(100, 23);
            this.btnnewgrp.TabIndex = 14;
            this.btnnewgrp.Text = "Buscar grupo";
            this.btnnewgrp.UseVisualStyleBackColor = true;
            this.btnnewgrp.Click += new System.EventHandler(this.btnnewgrp_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.btnnewgrp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblaccgrp);
            this.Controls.Add(this.lblnumtar);
            this.Controls.Add(this.lblrut);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.brnactualiza);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtaccgrp);
            this.Controls.Add(this.txttarjeta);
            this.Controls.Add(this.txtrut);
            this.Controls.Add(this.txtnombre);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.TextBox txttarjeta;
        private System.Windows.Forms.TextBox txtaccgrp;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button brnactualiza;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblrut;
        private System.Windows.Forms.Label lblnumtar;
        private System.Windows.Forms.Label lblaccgrp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnnewgrp;
    }
}