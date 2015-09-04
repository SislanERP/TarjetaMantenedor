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
