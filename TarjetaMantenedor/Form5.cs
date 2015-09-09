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
        Form6 form6 = null;
        Form7 form7 = null;
        public Form5()
        {
            InitializeComponent();
        }

        public string idagrega="1", idedita="2", iddesactiva="4", idactiva="5",idusmain;

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

        private Form6 FormInstance6
        {
            get
            {
                if (form6 == null)
                {
                    form6 = new Form6();
                    form6.MdiParent = this.MdiParent;
                    form6.Disposed += new EventHandler(form7_Disposed);
                    form6.FormClosed += new FormClosedEventHandler(form7_FormClosed);
                    form6.Load += new EventHandler(form7_Load);
                }

                return form6;
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
            form7 = null;
            form6 = null;
        }

        public void cargagrid()
        {
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


        private void Form5_Load(object sender, EventArgs e)
        {
            this.cargagrid();
        }

        private void btnagregaub_Click(object sender, EventArgs e)
        {
            validaform validaact = new validaform();
            string paramfrm = validaact.buscaform(this.idagrega, this.idusmain);
            if (paramfrm == "")
            {
                MessageBox.Show("Usted no tiene autorización para realizar esta acción, por favor comuniquese con el administrador del sistema.", "Advertencia !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form6 form6 = this.FormInstance6;
                form6.iduspaso = this.idusmain;
                form6.Show();
                this.Close();
            }
        }

        private void btneditub_Click(object sender, EventArgs e)
        {
            validaform validaact = new validaform();
            string paramfrm = validaact.buscaform(this.idedita, this.idusmain);
            if (paramfrm == "")
            {
                MessageBox.Show("Usted no tiene autorización para realizar esta acción, por favor comuniquese con el administrador del sistema.", "Advertencia !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string columnaid = Convert.ToString(gridUsuBio.CurrentCell.ColumnIndex);
                if (columnaid == "0")
                {
                    string idusuariobio = Convert.ToString(gridUsuBio.CurrentCell.Value);
                    Form7 form7 = this.FormInstance;
                    form7.idusuario = idusuariobio;
                    //form7.MdiParent = this.MdiParent;
                    form7.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione el id del registro que desea modificar", "Pregunta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btndesactub_Click(object sender, EventArgs e)
        {
            validaform validaact = new validaform();
            string paramfrm = validaact.buscaform(this.iddesactiva, this.idusmain);
            if (paramfrm == "")
            {
                MessageBox.Show("Usted no tiene autorización para realizar esta acción, por favor comuniquese con el administrador del sistema.", "Advertencia !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string columnaidb = Convert.ToString(gridUsuBio.CurrentCell.ColumnIndex);
                if (columnaidb == "0")
                {
                    string idusuariobiob = Convert.ToString(gridUsuBio.CurrentCell.Value);
                    insusuariobio desact = new insusuariobio();
                    string revisa = desact.desactivaub(idusuariobiob);
                    MessageBox.Show("Usuario desactivado exitosamente", "Pregunta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Seleccione el id del registro que desea modificar", "Pregunta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnactub_Click(object sender, EventArgs e)
        {
            validaform validaact = new validaform();
            string paramfrm = validaact.buscaform(this.idactiva, this.idusmain);
            if (paramfrm == "")
            {
                MessageBox.Show("Usted no tiene autorización para realizar esta acción, por favor comuniquese con el administrador del sistema.", "Advertencia !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string columnaidc = Convert.ToString(gridUsuBio.CurrentCell.ColumnIndex);
                if (columnaidc == "0")
                {
                    string idusuariobioc = Convert.ToString(gridUsuBio.CurrentCell.Value);
                    insusuariobio desact = new insusuariobio();
                    string revisab = desact.activaub(idusuariobioc);
                    MessageBox.Show("Usuario activado exitosamente", "Pregunta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Seleccione el id del registro que desea modificar", "Pregunta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
