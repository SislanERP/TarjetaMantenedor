﻿using System;
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

        private void Form8_Load(object sender, EventArgs e)
        {
            insusuariobio datosaccgrp = new insusuariobio();
            DataTable accgrp = datosaccgrp.traergac();
            cmbgrpacc.ValueMember = "nAccessIdn";
            cmbgrpacc.DisplayMember = "sName";
            cmbgrpacc.DataSource = accgrp;
        }
    }
}
