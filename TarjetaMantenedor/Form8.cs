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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public string idusuario;
        Form7 form7 = null;

        private Form7 FormInstance7
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

        }

        void form7_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        void form7_Disposed(object sender, EventArgs e)
        {
            form7 = null;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            insusuariobio datosaccgrp = new insusuariobio();
            DataTable accgrp = datosaccgrp.traergac();
            cmbgrpacc.ValueMember = "nAccessIdn";
            cmbgrpacc.DisplayMember = "sName";
            cmbgrpacc.DataSource = accgrp;
        }

        private void btnasignaga_Click(object sender, EventArgs e)
        {
            Form7 form7 = this.FormInstance7;
            insusuariobio insertaga = new insusuariobio();
            insertaga.insertagrupoacceso(cmbgrpacc.ValueMember,this.idusuario);
            //form7.grupoacceso = cmbgrpacc.Text;
            //form7.idusuario = this.idusuario;

            form7.Show();
            this.Close();
        }
    }
}
