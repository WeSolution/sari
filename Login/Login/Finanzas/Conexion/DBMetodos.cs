using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Recursos_Financieros.Conexion
{
    public class DBMetodos
    {
        private Conexion con = new Conexion();
        private string cadena = System.Configuration.ConfigurationManager.ConnectionStrings[1].ToString();
        /*Este método ejecuta el procedimiento almacenado que se crea anteriormente, 
         * para insertar la información que se almacenará */
        public  int EjecutarComandoInsert(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        /*Con este método de tipo SqlCommand se abre la conexión a la BD se crea el procedimiento almacenado 
          se guarda para usarlo más adelante*/
        public  SqlCommand CrearComandoProc(String proc)
        {
            //string CadenaConnexion = con.conectar_bd(cadena).ToString();
            SqlConnection connexion = con.conectar_bd(cadena);
            //SqlConnection connexion = new SqlConnection(CadenaConnexion);
            SqlCommand comando = new SqlCommand(proc, connexion);
            comando.CommandType = CommandType.StoredProcedure;
            return comando;
        } 

        public  SqlCommand CrearComando()
        {
            SqlConnection connexion = con.conectar_bd(cadena);
            //string CadenaConexion = con.conectar_bd(cadena).ToString();
            //SqlConnection connexion = new SqlConnection();
            //connexion.ConnectionString = CadenaConexion;
            SqlCommand comando = new SqlCommand();
            comando = connexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            return comando;
        }

        public  DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { comando.Connection.Close(); }
            return tabla;
        }
    }
}