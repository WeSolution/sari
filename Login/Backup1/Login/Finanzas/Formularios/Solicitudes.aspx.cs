using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Services;
namespace Recursos_Financieros.Formularios
{
    public partial class Solicitudes : System.Web.UI.Page
    {
        public string Cadena_Conexion = System.Configuration.ConfigurationManager.ConnectionStrings[3].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                listado_servicios();

            }

        }

        private SqlConnection conexion;
        public SqlConnection Abrir_Conexion(string mensaje)
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = mensaje;
            try
            {
                conexion.Open();
            }
            catch (Exception j) { conexion = null; Response.Write(j.Message); }
            return conexion;
        }
        public bool Modificar(string consulta)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = consulta;
            Boolean respuesta = false;
            try
            {
                comando.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception e)
            {
                respuesta = false;
                Response.Write(e.Message);


            }
            conexion.Close();
            return respuesta;
        }
        public SqlDataReader ConsultaDataReader(string consulta)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = consulta;
            SqlDataReader contenedor;
            try
            {
                contenedor = comando.ExecuteReader();

            }
            catch (Exception j) { contenedor = null; Response.Write(j.Message); }
            return contenedor;
        }
        public void listado_servicios()
        {
            string cadena = "";
            SqlDataReader contenedor;
            if (Abrir_Conexion(Cadena_Conexion) != null)
            {
                contenedor = ConsultaDataReader("select id_compra,caracteristicas from sol_compra where sol_compra.estatus = 'PENDIENTE'");
                while (contenedor.Read())
                {
                    cadena += "<tr id='" + contenedor[0].ToString() + "' class='solicitud'><td class='obtener'><h1>" + contenedor[1].ToString() + "</h1></tr>";
                }
            }
            listado.InnerHtml = cadena;
        }
        [System.Web.Services.WebMethod]
        public static string[] Consulata_Servicios(string nombre)
        {
            string[] cadena = new string[10];
            int id = Convert.ToInt32(nombre);
            int i = 7;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[3].ToString();
            conexion.Open();

            if (conexion != null)
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "select * from sol_compra where id_compra=" + id + "";
                SqlDataReader contenedor;
                try
                {
                    contenedor = comando.ExecuteReader();

                    while (contenedor.Read())
                    {
                        cadena[0] = contenedor[0].ToString();
                        cadena[1] = contenedor[1].ToString();
                        cadena[2] = contenedor[2].ToString();
                        cadena[3] = contenedor[3].ToString();
                        cadena[4] = contenedor[4].ToString();
                        cadena[5] = contenedor[5].ToString();


                    }
                    ;



                }
                catch (Exception j) { conexion = null; }

            }
            return cadena;
        }

        [WebMethod]
        public static string Actualizar(string categoria, string id)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[3].ToString();
            conexion.Open();
            string mensaje = "";
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            if (categoria == "aceptar")
            {
                comando.CommandText = "update  sol_compra set estatus='ACEPTADA' where id_compra=" + id;
            }
            else if (categoria == "cancelar")
            {
                comando.CommandText = "update  sol_compra set estatus='CANCELADA' where id_compra=" + id;
            }
            else if (categoria == "rechazar")
            {
                comando.CommandText = "update  sol_compra set estatus='RECHAZADA' where id_compra=" + id;
            }
            try
            {
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la operacion";
            }
            catch (Exception e)
            {
                mensaje = "Error en la Operacion";


            }
            conexion.Close();

            return mensaje;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}