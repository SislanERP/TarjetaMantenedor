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
    public partial class Form5 : Form
    {
        Form6 form6 = new Form6();
        Form7 form7 = null;
        public Form5()
        {
            InitializeComponent();
        }

        private Form7 FormInstance
        {
            get
            {
                if (form7 == null)
                {
                    form7 = new Form7();
                    form7.MdiParent = this.MdiParent;

                    form7.Disposed += new EventHandler(form7_Disposed);
                    form7.FormClosed += new FormClosedEventHandler(form7_FormClosed);
                    form7.Load += new EventHandler(form7_Load);

                }

                return form7;
            }
        }

        void form7_Load(object sender, EventArgs e)
        {
            lblsht.Text = "Formulario abierto";
        }

        void form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            lblsht.Text = "Se ha cerrado el Formulario";
        }

        void form7_Disposed(object sender, EventArgs e)
        {
            form7 = null;
        }



        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bioStarDataSet.TB_USUARIO' Puede moverla o quitarla según sea necesario.
           this.tB_USUARIOTableAdapter.Fill(this.bioStarDataSet.TB_USUARIO);
            tblusuariobio tbuser = new tblusuariobio();
            DataTable dt = tbuser.Datos2();
            if (dt != null)
            {
                gridUsuBio.DataSource = dt;
                gridUsuBio.Columns[0].HeaderText = "ID Interno";
                gridUsuBio.Columns[1].HeaderText = "Nombre";
                gridUsuBio.Columns[2].HeaderText = "ID Depto.";
                gridUsuBio.Columns[3].HeaderText = "E-mail";
                gridUsuBio.Columns[4].HeaderText = "Teléfono";
                gridUsuBio.Columns[5].HeaderText = "ID Usuario";
                gridUsuBio.Columns[6].HeaderText = "Contraseña";
                gridUsuBio.Columns[7].HeaderText = "Fecha inicio";
                gridUsuBio.Columns[8].HeaderText = "Fecha término";
                gridUsuBio.Columns[9].HeaderText = "Nivel usuario";
                gridUsuBio.Columns[10].HeaderText = "Autorización";
                gridUsuBio.Columns[11].HeaderText = "Contador limite aut.";
                gridUsuBio.Columns[12].HeaderText = "Tiempo APB";
                gridUsuBio.Columns[13].HeaderText = "Encriptación";
            }
            else
            {
                MessageBox.Show("No Hay Datos !!!!");
            }
        }

        private void btnagregaub_Click(object sender, EventArgs e)
        {
            form6.MdiParent = this.MdiParent;
            form6.Show();
        }

        private void btneditub_Click(object sender, EventArgs e)
        {
            string b = Convert.ToString(gridUsuBio.CurrentCell.ColumnIndex);
            if(b == "0")
            {
                string a = Convert.ToString(gridUsuBio.CurrentCell.Value);
                Form7 form7 = this.FormInstance;
                form7.datz = a;
                //form7.MdiParent = this.MdiParent;
                form7.Show();
            }
            else
            {
                MessageBox.Show("Seleccione el id del registro que desea modificar", "Pregunta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
