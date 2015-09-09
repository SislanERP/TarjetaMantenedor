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

        Form5 formulariousuario = null;
        public string iduspaso;

        private Form5 FormInstance5
        {
            get
            {
                if (formulariousuario == null)
                {
                    formulariousuario = new Form5();
                    formulariousuario.MdiParent = this.MdiParent;

                    formulariousuario.Disposed += new EventHandler(form7_Disposed);
                    formulariousuario.FormClosed += new FormClosedEventHandler(form7_FormClosed);
                    formulariousuario.Load += new EventHandler(form7_Load);
                }

                return formulariousuario;
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
            formulariousuario = null;
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
                    //idub = inser.inserta(txtnoms.Text, txtapepat.Text, txtapemat.Text, txtrut.Text, txtdv.Text, txttarnum.Text);
                    MessageBox.Show("Usuario y tarjeta igresados correctamente !!", "En hora buena !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form5 formulariousuario = this.FormInstance5;
                    formulariousuario.idusmain = this.iduspaso;
                    formulariousuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no existe pero la tarjeta ya esta asignada !!", "Alerta !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else//usuario ya existe
            {
                MessageBox.Show("Usuario ya existe !!","Alerta !!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
    }
}
