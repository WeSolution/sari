using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Recursos_Financieros.Conexion
{
    public class AccesoLogica
    {
        public string cadena = "";
        public AccesoLogica(string s) { cadena = s; }
        /*Método que permite el aceso al método de inserción, para poder utilizarlo en la clase Alta producto.aspx.cs
         y poder realizar el nuevo registro a la BD*/
        public int Insert(string nombre, string marca, string modelo, string descripcion, string grupo, float precioCompra,
            string medida, int cantidad, DateTime fecha)
        {
            AccesoDatos acceso = new AccesoDatos(cadena);
            return acceso.Insert(nombre, marca, modelo, descripcion, grupo, precioCompra, medida, cantidad, fecha);
        }

        /*Método que permite el aceso al método de inserción, para poder utilizarlo en la clase 
         * AltaProducto.aspx.cs y poder realizar el nuevo registro a la BD*/
        public  int InsertSuministra(int id_proveedor)
        {
            AccesoDatos acceso = new AccesoDatos(cadena);
            return acceso.Insert_Suministra(id_proveedor);
        }

        /*Métodoque permite el acceso a la información obtenida con la consulta de la clase AccesoDatos*/
        public  DataTable DatosProveedor(string nombre)
        {
            AccesoDatos acceso = new AccesoDatos(cadena);
            return acceso.DatosProveedor(nombre);
        }
    }
}