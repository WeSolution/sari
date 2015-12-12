using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Recursos_Financieros.Conexion
{
    public class ConsultarBD
    {
        private string cadena = "";
        public ConsultarBD(string s) { cadena = s; }
        private Conexion con = new Conexion();
        //Permite obtener la informacion de todas las requisiciones hechas en el mes y año solicitado
        public DataTable MostrarInfRequisision(int mes, int año)
        {
            SqlConnection conexion = con.conectar_bd(cadena);
            conexion.Open();
            string consulta = "SELECT id_compra AS 'Num_Requi', sol_compra.caracteristicas AS" +
                              " 'Caracteristicas',tipo AS 'Tipo', Convert(Varchar(10),fecha,103) AS 'Fecha', estatus AS 'Estado', area.area AS 'Area', monto AS 'Total'" +
                              " FROM sol_compra INNER JOIN usuario ON sol_compra.id_usuario=usuario.id_usuario " +
                              "INNER JOIN empleado ON usuario.id_empleado=empleado.id_empleado " +
                              "INNER JOIN area ON empleado.id_empleado=area.id_empleado WHERE DATEPART (MONTH, fecha)=" + mes +
                              "AND DATEPART (YEAR, fecha)=" + año;
            SqlDataAdapter mostrar = new SqlDataAdapter(consulta, conexion);
            DataTable datos = new DataTable();
            mostrar.Fill(datos);
            conexion.Close();
            return datos;
        }

        //Obtiene la cantidad total de productos que contiene una requisicion
        public String Cantidad_productos(int id_compra)
        {
            SqlConnection conexion = con.conectar_bd(cadena);
            conexion.Open();
            string consulta = "SELECT COUNT (*) as 'Total_Prod' FROM sol_compra INNER JOIN detalle_producto ON sol_compra.id_compra = detalle_producto.id_compra INNER JOIN producto ON producto.id_producto= detalle_producto.id_producto";
            //string consulta = "SELECT * FROM sol_compra WHERE DATEPART (MONTH, fecha)=" + mes +"AND DATEPART (YEAR, fecha)=" + año  ;
            SqlDataAdapter mostrar = new SqlDataAdapter(consulta, conexion);
            DataTable datos = new DataTable();
            mostrar.Fill(datos);
            conexion.Close();
            string cant = "";
            foreach (DataRow row in datos.Rows)
            {
                cant = row[0].ToString();

            }
            return cant;
        }

        //Obtiene la cantidad total de servicios que contiene una requisicion
        public String Cantidad_serv(int id_compra)
        {
            SqlConnection conexion = con.conectar_bd(cadena);
            conexion.Open();
            string consulta = "SELECT COUNT (*) as 'Total_serv' FROM sol_compra INNER JOIN detalle_servicio ON sol_compra.id_compra = detalle_servicio.id_compra INNER JOIN servicios ON servicios.id_servicio= detalle_servicio.id_servicio";
            //string consulta = "SELECT * FROM sol_compra WHERE DATEPART (MONTH, fecha)=" + mes +"AND DATEPART (YEAR, fecha)=" + año  ;
            SqlDataAdapter mostrar = new SqlDataAdapter(consulta, conexion);
            DataTable datos = new DataTable();
            mostrar.Fill(datos);
            conexion.Close();
            string cant = "";
            foreach (DataRow row in datos.Rows)
            {
                cant = row[0].ToString();

            }
            return cant;
        }

        //Obtiene el monto total de todas las requisiciones generadas el mes y año indicado
        public String Monto_total(int mes, int año)
        {
            SqlConnection conexion = con.conectar_bd(cadena);
            conexion.Open();
            string consulta = "SELECT SUM(monto) FROM sol_compra WHERE DATEPART (MONTH, fecha)=" + mes + "AND DATEPART (YEAR, fecha)=" + año;
            //string consulta = "SELECT * FROM sol_compra WHERE DATEPART (MONTH, fecha)=" + mes +"AND DATEPART (YEAR, fecha)=" + año  ;
            SqlDataAdapter mostrar = new SqlDataAdapter(consulta, conexion);
            DataTable datos = new DataTable();
            mostrar.Fill(datos);
            conexion.Close();
            string monto = "";
            foreach (DataRow row in datos.Rows)
            {
                monto = row[0].ToString();

            }
            return monto;
        }
    }
}