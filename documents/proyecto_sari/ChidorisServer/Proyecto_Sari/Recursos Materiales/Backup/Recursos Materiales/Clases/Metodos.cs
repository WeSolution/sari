using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Recursos_Materiales.Clases;

namespace Recursos_Materiales.Clases
{
    public class Metodos
    {
        // Instanciamos la Conexion
        Conexion2 con = new Conexion2();

        // Definir una vista que filtre las requisiciones
        //private DataView dv;

        //public Metodos()
        //{
            //dv = Obtener_Requisiciones().DefaultView;
        //}

        // Metodo para Obtener Lista de Requisiciones
        public DataTable Obtener_Requisiciones(string area)
        {
            SqlDataAdapter da = new SqlDataAdapter("select sol_compra.id_compra as ID, sol_compra.caracteristicas as Caracteristicas, sol_compra.tipo as Tipo, sol_compra.monto as Monto, sol_compra.fecha as Fecha, sol_compra.estatus as Estatus, sol_compra.id_usuario as Usuario "
                                                    +"from sol_compra, area "
                                                    +"where area.area='" + area + "' ", con.getCn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        // Metodo para Obtener Lista de Productos
        public DataTable Obtener_Productos(int id_compra)
        {
            SqlDataAdapter da = new SqlDataAdapter("select detalle_producto.id_producto, producto.nombre, detalle_producto.cantidad, detalle_producto.precio_venta "
                                                    +"from producto, detalle_producto "
                                                    +"where id_compra=" + id_compra + " and detalle_producto.id_producto=producto.id_producto", con.getCn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        // Metodo para Obtener Lista de Servicios
        public DataTable Obtener_Servicios(int id_compra)
        {
            SqlDataAdapter da = new SqlDataAdapter("select detalle_servicio.id_servicio, servicios.nombre, servicios.descripcion, detalle_servicio.precio_venta "
                                                    + "from servicios, detalle_servicio "
                                                    + "where id_compra=" + id_compra + " and detalle_servicio.id_servicio=servicios.id_servicio", con.getCn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        // Metodo para Obtener el Nombre y Apellifos de un Empleado
        public String Obtener_NombreCliente(int id_cliente)
        {
            SqlDataAdapter da = new SqlDataAdapter("select empleado.nombre, empleado.apellido_p, empleado.apellido_m "
                                                    +"from empleado, usuario "
                                                    +"where usuario.id_usuario="+id_cliente+" ", con.getCn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            string nom = tb.Rows[0]["nombre"].ToString();       //guardo informacion en variables
            string app = tb.Rows[0]["apellido_p"].ToString();   //guardo informacion en variables
            string apm = tb.Rows[0]["apellido_m"].ToString();   //guardo informacion en variables
            string nombre = nom + " " + app + " " + apm; 
            return nombre;
        }
        // Metodo para Obtener el Area que pertenece un Empleado
        public String Obtener_AreaCliente(int id_cliente)
        {
            SqlDataAdapter da = new SqlDataAdapter("select empleado.nombre, empleado.apellido_p, empleado.apellido_m "
                                                    + "from area, empleado, usuario "
                                                    + "where usuario.id_usuario=" + id_cliente + " ", con.getCn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            string area = tb.Rows[0]["area"].ToString();       //guardo informacion en variables
            return area;
        }
    }
}