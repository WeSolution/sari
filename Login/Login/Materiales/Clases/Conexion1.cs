using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recursos_Materiales.Clases
{
    public class Conexion1
    {
        private string cadcon = System.Configuration.ConfigurationManager.ConnectionStrings[5].ToString();
        //private string cadcon = @"Data Source = sari.servehttp.com; Initial Catalog = SARI; user= Server; pwd=F46987DE89;";

        public SqlConnection conectar()
        {
            SqlConnection con = new SqlConnection(cadcon);
            try
            {
                con.Open();
                return con;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool DML(string query)
        {
            bool respuesta;
            SqlCommand comando = new SqlCommand(query,conectar());
            try
            {
                if (comando.ExecuteNonQuery() >= 1)
                {
                    respuesta = true;
                }
                else
                {
                    respuesta = false;
                }
            }
            catch(Exception)
            {
                
                respuesta = false;
            }

            return respuesta;
        }

        public DataTable Consultas(string query)
        {
            SqlDataAdapter a = new SqlDataAdapter();
            DataTable tab = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(query, conectar());
                a.SelectCommand = comando;
                a.Fill(tab);
                return tab;
            }
            catch (Exception )
            {
                
                return null;
            }
        }
    }
}