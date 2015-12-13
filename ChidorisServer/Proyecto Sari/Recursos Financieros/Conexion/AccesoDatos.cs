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
        public int Insert(string nombre, string marca, string modelo, string descripcion, string grupo, float precioCompra,
            string medida, int cantidad, DateTime fecha)
        {
            SqlCommand comando = DBMetodos.CrearComandoProc("InsDatos");
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
            return DBMetodos.EjecutarComandoInsert(comando);
        }

        /*Método que crea el comndo para el procedimiento almacenado para realizar la inserción de los datos,
     indicando de donde tomara la información*/
        public static int Insert_Suministra(int id_proveedor)
        {
            int id_producto = IdProducto();
            SqlCommand comando = DBMetodos.CrearComandoProc("InsSuministra");
            comando.Parameters.AddWithValue("@id_proveedor", id_proveedor);
            comando.Parameters.AddWithValue("@id_producto", id_producto);
            return DBMetodos.EjecutarComandoInsert(comando);
        }

        /*Realiza una consulta a la base de datos para mostrar los datos del proveedor seleccionado.*/
        public static DataTable DatosProveedor(string nombre)
        {
            SqlCommand comando = DBMetodos.CrearComando();
            comando.CommandText = "SELECT * FROM proveedor where nombre ='" + nombre + "'";
            return DBMetodos.EjecutarComandoSelect(comando);
        }

        /*Obtiene el ultimo id insertado en la tabla producto, para asi realizar la inserción en la tabla
         suministra.*/
        public static int IdProducto()
        {
            int id = 0;
           /// string cadenaConexion = Conexion.conectar_bd().ToString();

            //
            SqlConnection conexion = Conexion.conectar_bd();
            //conexion.Open();
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