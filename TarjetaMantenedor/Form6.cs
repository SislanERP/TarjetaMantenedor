using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnsaveub_Click(object sender, EventArgs e)
        {
            insusuariobio inser = new insusuariobio();
            string idub = inser.buscaub(Convert.ToString(txtrut.Text));
            if (idub == "")//no existe usuario
            {
                idub = inser.buscatar(Convert.ToString(txttarnum.Text));
                if (idub == "")//tarjeta no asignada
                {
                    txtdv.Text = Convert.ToString("t no asigned");
                    idub = inser.inserta(txtnoms.Text, txtapepat.Text, txtapemat.Text, txtrut.Text, txtdv.Text, txttarnum.Text);
                    MessageBox.Show("Usuario y tarjeta igresados correctamente !!" + idub, "En hora buena !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    txtdv.Text = Convert.ToString("t asignada " + idub);
                    MessageBox.Show("Usuario no existe pero la tarjeta ya esta asignada !!", "Alerta !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else//usuario ya existe
            {
                MessageBox.Show("Usuario ya existe !!","Alerta !!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtdv.Text = Convert.ToString("nopes");
            }

        }
    }
}
