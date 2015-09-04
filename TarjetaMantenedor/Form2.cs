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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formprb = new Form3();
            formprb.Show();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WindowsFormsApplication1.tbluser tbuser = new WindowsFormsApplication1.tbluser();
            DataTable dt = tbuser.Datos2();
            if (dt != null)
            {
                gridUsuarios.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Hay Datos !!!!");
            }
        }

        private void gridUsuarios_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }
        
      
        
    }
}
