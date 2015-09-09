using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string idubmain;

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == Convert.ToString(""))
            {
                lblmsg.Text = Convert.ToString("Ingrese su nombre de usuario");
                lblmsg.Visible = true;
            }
            else
            {
                lblmsg.Visible = false;
                if (txtpass.Text == Convert.ToString(""))
                {
                    lblmsg.Text = Convert.ToString("Ingrese su Contraseña");
                    lblmsg.Visible = true;
                }
                else
                {
                    try
                    {
                        SqlConnection miConecion = new SqlConnection(@"Data Source=VK-I5\BSSERVER;Initial Catalog=BioStar;Integrated Security=True");
                        //SqlConnection miConecion = new SqlConnection(@"Data Source=XEN-SQL2008ENT;Initial Catalog=BioStar;Trusted_Connection=False;User Id=sisbioint;Password=qweasd");
                        miConecion.Open();
                        SqlCommand consulta = new SqlCommand("Select * from tb_usuario where usu_usuario ='" + Convert.ToString(txtuser.Text) + "' and usu_contrasena ='" + Convert.ToString(txtpass.Text) + "';", miConecion);
                        int validacons = consulta.ExecuteNonQuery();
                        DataSet ds = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter(consulta);
                        da.Fill(ds, "Tblusuario");
                        DataRow DR;
                        miConecion.Close();
                        if (ds.Tables["Tblusuario"].Rows.Count == 0)
                        {
                            lblmsg.Text = Convert.ToString("Su contraseña y/o usuario son invalidos");
                            lblmsg.Visible = true;
                        }
                        else
                        {
                            MDIPrincipal formu2 = new MDIPrincipal();
                            DR = ds.Tables["Tblusuario"].Rows[0];
                            lblmsg.Text = Convert.ToString("Bienvenido " + DR["usu_nombre"] + " !!");
                            idubmain = Convert.ToString(DR["usu_id"]);
                            lblmsg.Visible = true;
                            System.Threading.Thread.Sleep(1000);
                            formu2.Show();
                            this.Hide();
                        }
                    }
                    catch (SqlException ex)
                    {
                        string msg = Convert.ToString(ex.Errors[0]);
                        MessageBox.Show("Error! Su contraseña y/o usuario son invalidos "+msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
