using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Recursos_Financieros.Conexion
{
    public class AccesoDatos
        
    {
        private Conexion con = new Conexion();
        private string cadena = "";
        public AccesoDatos(string s) { cadena = s; }
        DBMetodos meto = new DBMetodos();
        public int Insert(string nombre, string marca, string modelo, string descripcion, string grupo, float precioCompra,
            string medida, int cantidad, DateTime fecha)
        {
            SqlCommand comando = meto.CrearComandoProc("InsDatos");
            comando.Parameters.AddWithValue("@identificador", "");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@grupo", grupo);
            comando.Parameters.AddWithValue("@localizacion", "");
            comando.Parameters.AddWithValue("@precio_compra", precioCompra);
            comando.Parameters.AddWithValue("@unidad_medida", medida);
            comando.Parameters.AddWithValue("@cantidad_medida", cantidad);
            comando.Parameters.AddWithValue("@stock", "");
            comando.Parameters.AddWithValue("@fecha", fecha);
            return meto.EjecutarComandoInsert(comando);
        }

        /*Método que crea el comndo para el procedimiento almacenado para realizar la inserción de los datos,
     indicando de donde tomara la información*/
        public  int Insert_Suministra(int id_proveedor)
        {
            int id_producto = IdProducto();
            SqlCommand comando = meto.CrearComandoProc("InsSuministra");
            comando.Parameters.AddWithValue("@id_proveedor", id_proveedor);
            comando.Parameters.AddWithValue("@id_producto", id_producto);
            return meto.EjecutarComandoInsert(comando);
        }

        /*Realiza una consulta a la base de datos para mostrar los datos del proveedor seleccionado.*/
        public  DataTable DatosProveedor(string nombre)
        {
            SqlCommand comando = meto.CrearComando();
            comando.CommandText = "SELECT * FROM proveedor where nombre ='" + nombre + "'";
            return meto.EjecutarComandoSelect(comando);
        }

        /*Obtiene el ultimo id insertado en la tabla producto, para asi realizar la inserción en la tabla
         suministra.*/
        public  int IdProducto()
        {
            int id = 0;
           /// string cadenaConexion = con.conectar_bd(cadena).ToString();

            //no manches creo no terminare! y t tengo que ir a trabajar yo igual w pro que crees que te dije que 
            // mejor lo dejaramos asi jajajja por que ya sabia que era un pedo 
            //ellas seugun ya lo habian arreglado su codigo y segun ellas lo habian mejorado 
            // creo qu elo unico que hicieron fue hacer mas statics
            //jajajajaja este como le hacemos? puros ctrl +z? solo arregla este a ver que pasa este conexion quiero ver que pasa
            SqlConnection conexion = con.conectar_bd(cadena);
            //con.Open();
            //SqlConnection conexion = new SqlConnection(cadenaConexion);
            DataTable ds = new DataTable();
            string query = "select MAX(id_producto) from producto";
            try
            {
                conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(ds);
                foreach (DataRow row in ds.Rows)
                {
                    id = int.Parse(row[0].ToString());
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
            }
            return id;
        }
    }
}