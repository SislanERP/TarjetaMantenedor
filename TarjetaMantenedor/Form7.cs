using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* en la rama desarrollo */

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public string datz;
        public Form7()
        {
            InitializeComponent();
        }

        Form8 form8 = null;

        private Form8 FormInstance8
        {
            get
            {
                if (form8 == null)
                {
                    form8 = new Form8();
                    form8.MdiParent = this.MdiParent;

                    form8.Disposed += new EventHandler(form7_Disposed);
                    form8.FormClosed += new FormClosedEventHandler(form7_FormClosed);
                    form8.Load += new EventHandler(form7_Load);
                }

                return form8;
            }
        }

        void form7_Load(object sender, EventArgs e)
        {

        }

        void form7_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        void form7_Disposed(object sender, EventArgs e)
        {
            form8 = null;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            insusuariobio datosub = new insusuariobio();
            DataTable nombre = datosub.traerub(datz);
            string tarjeta = datosub.buscatarpeerid(datz);
            DataTable puerta = datosub.traepuerta(datz);
            try
            {
                txtnombre.Text = Convert.ToString(nombre.Rows[0][1]);
                txtrut.Text = Convert.ToString(nombre.Rows[0][5]);
                txttarjeta.Text = tarjeta;
                txtaccgrp.Text = Convert.ToString(puerta.Rows[0][1]);
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Usuario no tiene grupo de acceso asignado !!", "Alerta !!", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void brnactualiza_Click(object sender, EventArgs e)
        {

        }

        private void btnnewgrp_Click(object sender, EventArgs e)
        {
            Form8 form8 = this.FormInstance8;
            form8.Show();
        }

    }

    public class datox
    {
        public string nande;
        public string SetTextLblfrm1
        {
            set
            {
              nande = value;
            }

            get
            {
                return nande;
            }
        }

    }
}
