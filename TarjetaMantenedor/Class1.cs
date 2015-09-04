using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class conexionbd
    {
        //SqlConnection conexion = new SqlConnection(@"Data Source=192.168.2.246,1433;Initial Catalog=BioStar;Trusted_Connection=False;User Id=sa;Password=sql526337");
        SqlConnection conexion = new SqlConnection(@"Data Source=XEN-SQL2008ENT;Initial Catalog=BioStar;Trusted_Connection=False;User Id=sisbioint;Password=qweasd;");
        public SqlConnection _SqlConnetion
        {
            get
            {
                return conexion;
            }
            set
            {
                conexion = value;
            }
        }
    }

    class consuser
    {
        WindowsFormsApplication1.conexionbd con1 = new WindowsFormsApplication1.conexionbd();

        public DataTable Datos(string usuario, string pass)
        {
            String consulta = "Select * from tb_usuario where usu_usuario ='" + usuario + "' and usu_contrasena ='" + pass + "';";
            DataSet ds = new DataSet();
            SqlDataAdapter sqd = new SqlDataAdapter(consulta, con1._SqlConnetion);
            sqd.Fill(ds,"matriz1");
            return ds.Tables["matriz1"];
        }
    }

    class tbluser
    {
        WindowsFormsApplication1.conexionbd con1 = new WindowsFormsApplication1.conexionbd();

        public DataTable Datos2()
        {
            String consulta2 = "Select * from tb_usuario";
            DataSet ds2 = new DataSet();
            SqlDataAdapter sqd2 = new SqlDataAdapter(consulta2, con1._SqlConnetion);
            sqd2.Fill(ds2, "matriz2");
            return ds2.Tables["matriz2"];
        }
    }

    class tblusuariobio
    {
        WindowsFormsApplication1.conexionbd con1 = new WindowsFormsApplication1.conexionbd();

        public DataTable Datos2()
        {
            String consulta = "Select [nUserIdn],[sUserName],[nDepartmentIdn],[sTelNumber],[sEmail],[sUserID],[sPassword],[nStartDate],[nEndDate],[nAdminLevel],[nAuthMode],[nAuthLimitCount],[nTimedAPB],[nEncryption] from TB_USER";
            DataSet ds = new DataSet();
            SqlDataAdapter sqd = new SqlDataAdapter(consulta, con1._SqlConnetion);
            sqd.Fill(ds, "matriz2");
            return ds.Tables["matriz2"];
        }
    }

    class insusuariobio
    {
        WindowsFormsApplication1.conexionbd con1 = new WindowsFormsApplication1.conexionbd();

        string salida;
        public string buscaub(string rut)
        {
            String consulta = "select nUserIdn from TB_USER where sUserID = '"+rut+"';";
            SqlCommand sqd = new SqlCommand(consulta, con1._SqlConnetion);
            try
            {
                con1._SqlConnetion.Open();
                salida = Convert.ToString(sqd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                salida=Convert.ToString(ex.Message);
            }
            con1._SqlConnetion.Close();
            return salida;
        }

        public string buscatar(string tarjeta)
        {
            String consulta = "select nUserIdn from TB_USER_CARD where sCardNo = '" + tarjeta + "' and nStatus = 1;";
            SqlCommand sqd = new SqlCommand(consulta, con1._SqlConnetion);
            try
            {
                con1._SqlConnetion.Open();
                salida = Convert.ToString(sqd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                salida=Convert.ToString(ex.Message);
            }
            con1._SqlConnetion.Close();
            return salida;
        }

        public string buscatarpeerid(string idub)
        {
            String consulta = "select sCardNo from TB_USER_CARD where nUserIdn = '" + idub + "' and nStatus = 1;";
            SqlCommand sqd = new SqlCommand(consulta, con1._SqlConnetion);
            try
            {
                con1._SqlConnetion.Open();
                salida = Convert.ToString(sqd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                salida = Convert.ToString(ex.Message);
            }
            con1._SqlConnetion.Close();
            return salida;
        }

        public string buscaubid(string idubt)
        {
            String consulta = "select sUserName from TB_USER where nUserIdn = '" + idubt + "';";
            SqlCommand sqd = new SqlCommand(consulta, con1._SqlConnetion);
            try
            {
                con1._SqlConnetion.Open();
                salida = Convert.ToString(sqd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                salida = Convert.ToString(ex.Message);
            }
            con1._SqlConnetion.Close();
            return salida;
        }

        public string inserta(string nombres, string apepat, string apemat, string rut, string dv,string numtar)
        {
            string sard = " bien";
            try
            {
                String consulta = "Insert into BioStar.dbo.TB_USER(sUserID,sUserName,nDepartmentIdn,nStartDate,nEndDate,nAdminLevel,nEncryption,sTelNumber,sEmail,bPassword2,nAuthMode,nAuthLimitCount,nTimedAPB,sPassword) values('" + rut + "','" + apepat + " " + apemat + " " + nombres + "',0,946684800,1924988400,241,0,0,' ',0x0000000000000000000000000000000000000000000000000000000000000000,0,0,0,' ');";
                SqlCommand sqd = new SqlCommand(consulta, con1._SqlConnetion);
                con1._SqlConnetion.Open();
                sqd.ExecuteNonQuery();
                con1._SqlConnetion.Close();
                insusuariobio proc = new insusuariobio();
                string dat1 = proc.buscaub(rut);
                String consultab = "insert into TB_USER_EX(nUserIdn,sSurName,sFirstName,sMiddleName,nImageSize,sImageFilePath,nDuration,nCountPerDay,nUsePrivateImage,sGreetingMsg,nEncryption) values(" + dat1 + ",'','','',0,'',0,0,0,'',0);";
                String consultac = "insert into TB_USER_CARD(nUserIdn,nType,sCardNo,sCustomNo,nSecurityLevel,nDateTime,nExpiryDateTime,nBypass,nStatus,nLatest,nEncryption)	values(" + dat1 + ",1," + numtar + ",0,0,DATEDIFF(second,{d '1970-01-01'},getdate()),0,1,1,1,0);";
                SqlCommand sqd2 = new SqlCommand(consultab, con1._SqlConnetion);
                SqlCommand sqd3 = new SqlCommand(consultac, con1._SqlConnetion);
                con1._SqlConnetion.Open();
                sqd2.ExecuteNonQuery();
                sqd3.ExecuteNonQuery();
                con1._SqlConnetion.Close();
            }
            catch (Exception ex)
            {
                sard = ex.Message;
            }
            return "ok" + sard;
        }

        public DataTable traerub(string id)
        {
            String consulta = "Select * from TB_USER where nUserIdn = '" + id + "';";
            DataSet ds = new DataSet();
            SqlDataAdapter sqd = new SqlDataAdapter(consulta, con1._SqlConnetion);
            sqd.Fill(ds, "matriz3");
            return ds.Tables["matriz3"];
        }

        public DataTable traepuerta(string id)
        {
            String consulta = "select a.nAgentIdn,b.sName as acgrp,d.sName as puerta,e.sName as tmzone from TB_ACCESSGROUP_USER a left join TB_ACCESSGROUP b on a.nAccessIdn = b.nAccessIdn left join TB_ACCESSGROUP_DOOR c on a.nAccessIdn = c.nAccessIdn left join TB_DOOR d on c.nAgentIdn = d.nDoorIdn left join TB_TIMEZONE e on c.nTimezone = e.nTimezone where a.nAgentIdn = '" + id + "';";
            DataSet ds = new DataSet();
            SqlDataAdapter sqd = new SqlDataAdapter(consulta, con1._SqlConnetion);
            sqd.Fill(ds, "matriz3");
            return ds.Tables["matriz3"];
        }
    }
}