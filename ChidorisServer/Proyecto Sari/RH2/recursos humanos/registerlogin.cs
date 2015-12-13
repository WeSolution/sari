using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Recursos_Humanos
{
    public class registerlogin
    {

        DataSet almacen2 = new DataSet();
        DataSet almacen = new DataSet();
        public string cadena { get; set; }
        string m = "";
        public registerlogin()
        {
        }
        public registerlogin(string cad)
        {
            cadena = cad;
        }
        //Metodo para conectarme
        public SqlConnection Conectar(ref string men)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadena;
            try
            {
                conexion.Open();
                men = "Conexión Abierta";
            }
            catch (Exception w)
            {
                conexion = null;
                men = "ERROR" + w.Message;
            }

            return conexion;
        }
        //Metodo para mostrar las consultas
        public DataSet ConsultaDs(SqlConnection con, String sentencia)
        {
            DataSet caja = new DataSet();
            SqlConnection conexion;
            conexion = Conectar(ref m);
            if (conexion != null)
            {
                SqlCommand car = new SqlCommand();
                car.Connection = conexion;
                car.CommandText = sentencia;

                SqlDataAdapter contenedor = new SqlDataAdapter();
                contenedor.SelectCommand = car;

                try
                {

                    contenedor.Fill(caja);
                    m = ("Consulta Correcta");
                }
                catch (Exception q)
                {
                    caja = null;
                    m = ("Error " + q.Message);
                }
            }
            else
            {
                m = ("Oshe, la carretera no sirve. Prueba otra vez!!");
            }
            return caja;
        }
        public DataSet consultas(string sentencia, SqlConnection con)
        {
            SqlConnection c_a;
            cadena = cadena;
            c_a = Conectar(ref m);
            almacen = ConsultaDs(c_a, sentencia);
            c_a.Close();
            return almacen;
        }

    }
}