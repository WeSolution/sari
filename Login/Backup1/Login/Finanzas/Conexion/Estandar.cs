using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Recursos_Financieros.Clases
{
    public class estandar
    {
        private string cadena;
        public estandar(string s) { cadena = s; }// y si le pasas la cadena directo aqui
        //private estandar es; 
        private Conexion.Conexion con = new Conexion.Conexion();
        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo, el tipo de dato, y el identificador de la funcion.
        //es una funcion que te permite crear el procedimiento almacenado para la inserccion de datos 
        public  SqlCommand procedimiento() 
        {
           // string cadenaconexion = Conexion.Conexion.conectar_bd().ToString();
            SqlConnection _conexion =con.conectar_bd(cadena);
            //SqlConnection _conexion = new SqlConnection();
           // _conexion.ConnectionString = cadenaconexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            _comando = new SqlCommand("insertar_servicio", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }
        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo, el tipo de dato, y el identificador de la funcion.
        //es una funcion que te permite crear el procedimiento almacenado para la inserccion de datos 
        public  SqlCommand procedimiento_proveedor()
        {
           // string cadenaconexion = Conexion.Conexion.conectar_bd().ToString();
            SqlConnection _conexion = con.conectar_bd(cadena);
           // SqlConnection _conexion = new SqlConnection();
           // _conexion.ConnectionString = cadenaconexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            _comando = new SqlCommand("insertar_proveedor", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }
        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo,el tipo de dato que te devuelve un datatable, y el identificador de la funcion.
        //es una funcion que te permite crear el procedimiento almacenado para la inserccion de datos 
        public  SqlCommand procedimiento_atiende()
        {
           // string cadenaconexion = Conexion.Conexion.conectar_bd().ToString();
            SqlConnection _conexion = new SqlConnection(cadena);
           // _conexion.ConnectionString = cadenaconexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            _comando = new SqlCommand("insertar_atiende", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }
        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo,el tipo de dato que te devuelve un datatable, y el identificador de la funcion.
        //es una funcion que te permite hacer una consulta que te devuelve los datos del proveedor

        public  DataTable consulta_datos_prove(int id_proveedor)
        {
           // string cadenaconexion = Conexion.Conexion.conectar_bd().ToString();
            //SqlConnection _conexion = new SqlConnection();
            //_conexion.ConnectionString = cadenaconexion;
            SqlConnection _conexion = con.conectar_bd(cadena);
            _conexion.Open();
            DataTable dt = new DataTable();
            string consulta = "select nombre,tel_1,tel_2,ciudad,direccion from proveedor where id_proveedor=" + id_proveedor + ";";
            SqlCommand cmd = new SqlCommand(consulta, _conexion);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dt);

            return dt;

        }
        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo,el tipo de dato que te devuelve un entero, y el identificador de la funcion.
        //es una funcion que te permite hacer una consulta que devuelve el id_servicio maximo que te sirve para hacer una inserccion mas adelante se utiliza en 
        //en la funcion insertar_atiende. 
        public  int consulta_id_servicio()
        {
            //string cadenaconexion = Conexion.Conexion.conectar_bd().ToString();
            //SqlConnection _conexion = new SqlConnection();
           // _conexion.ConnectionString = cadenaconexion;
            SqlConnection _conexion = con.conectar_bd(cadena);
            _conexion.Open();
            string consulta = "select Max(id_servicio) from servicios;";
            SqlCommand cmd = new SqlCommand(consulta, _conexion);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;

        }
        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo,el tipo de dato que te devuelve un Datatable, y el identificador de la funcion.
        //es una funcion que te permite hacer una consulta que devuelve un datatable que se utlizara para llenar un select o combobox
        public  DataTable consulta_proveedor()
        {
            //string cadenaconexion = Conexion.Conexion.conectar_bd().ToString();
            //SqlConnection _conexion = new SqlConnection();
            SqlConnection _conexion = this.con.conectar_bd(cadena); 
            //_conexion.ConnectionString = cadenaconexion;
            _conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select id_proveedor, nombre from proveedor;";
            string con = cmd.CommandText;
            SqlDataAdapter ada = new SqlDataAdapter(con, _conexion);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;
        }
        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo,el tipo de dato que te devuelve un Datatable, y el identificador de la funcion.
        //es una funcion que te permite hacer una consulta que devuelve datatable, se utilizara para llenar un GridView con
        //los datos de un proveedor en especifico
        public  DataTable consulta_proveedor_todo(int id_proveedor)
        {
            //string cadenaconexion = Conexion.Conexion.conectar_bd().ToString();
            //SqlConnection _conexion = new SqlConnection();
            SqlConnection _conexion = this.con.conectar_bd(cadena);
           // _conexion.ConnectionString = cadenaconexion;
            _conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from proveedor where id_proveedor=" + id_proveedor + ";";
            string con = cmd.CommandText;
            SqlDataAdapter ada = new SqlDataAdapter(con, _conexion);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;

        }
        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo,el tipo de dato que te devuelve un Datatable, y el identificador de la funcion.
        //es una funcion que te permite hacer una consulta que devuelve un datatable con los datos de los producto que 
        //suministra un proveedor.
        public  DataTable consulta_producto_suministra(int id_proveedor)
        {
            //string cadenaconexion = Conexion.Conexion.conectar_bd().ToString();
            //SqlConnection _conexion = new SqlConnection();
            //_conexion.ConnectionString = cadenaconexion;
            SqlConnection _conexion = this.con.conectar_bd(cadena);
            _conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select producto.id_producto, producto.nombre, producto.modelo, producto.marca, producto.descripcion, producto.precio_compra,producto.localizacion,producto.fecha from producto, suministra, proveedor where suministra.id_proveedor = proveedor.id_proveedor and suministra.id_producto = producto.id_producto and proveedor.id_proveedor = " + id_proveedor + "";
            string con = cmd.CommandText;
            SqlDataAdapter ada = new SqlDataAdapter(con, _conexion);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;
        }

        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo,el tipo de dato que te devuelve un Datatable, y el identificador de la funcion.
        //es una funcion que te permite hacer una consulta que devuelve un datatable con los datos del servicio que 
        //brinda un proveedor.
        public  DataTable consulta_servicio_brinda(int id_proveedor)
        {
            //string cadenaconexion = Conexion.Conexion.conectar_bd().ToString();
            //SqlConnection _conexion = new SqlConnection();
            //_conexion.ConnectionString = cadenaconexion;
            SqlConnection _conexion = this.con.conectar_bd(cadena);
            _conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select servicios.id_servicio, servicios.identificador, servicios.nombre, servicios.descripcion, servicios.precio from atiende,proveedor,servicios where atiende.id_proveedor = proveedor.id_proveedor and atiende.id_servicio = servicios.id_servicio and proveedor.id_proveedor = " + id_proveedor + " ;";
            string con = cmd.CommandText;
            SqlDataAdapter ada = new SqlDataAdapter(con, _conexion);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;
        }
        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo,el tipo de dato que te devuelve un entero, el identificador de la funcion y los parametros
        //que se necesitan , esta funcion retorna un valor que se ejecuta en otra funcion que ejecuta el transac sql 
        public  int insert_servicio(string identi, string nombre, string descripcion, double precio)
        {
            estandar es = new estandar(cadena);
            SqlCommand _comando = es.procedimiento();
            _comando.Parameters.AddWithValue("@identificador", identi);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@descripcion", descripcion);
            _comando.Parameters.AddWithValue("@precio", precio);
            return EjecutarComandoInsert(_comando);
        }

        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo,el tipo de dato que te devuelve un entero, el identificador de la funcion,
        //y los parametros que recibe la funcion esta funcion retorna un valor que se ejecuta en otra funcion que ejecuta el transac sql
        public  int insert_atiende(int id_proveedor)
        {
            int id_servicio = consulta_id_servicio();
            estandar es = new estandar(cadena);
            SqlCommand _comando = es.procedimiento_atiende();
            _comando.Parameters.AddWithValue("@id_proveedor", id_proveedor);
            _comando.Parameters.AddWithValue("@id_servicio", id_servicio);

            return EjecutarComandoInsert(_comando);
        }

        //se crea una funcion con la palabra reservada public,  que hace que la funcion no sea necesario 
        //crear un objeto para referenciarlo,el tipo de dato que te devuelve un entero, el identificador de la funcion,
        // y los parametros que recibe la funcion, esta funcion es la que se encarga que se ejecute el transac de sql 

        public  int EjecutarComandoInsert(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        
        //se crea una funcion con la palabra reservada public, 
        //el tipo de dato que te devuelve un entero, el identificador de la funcion y los parametros
        //que se necesitan , esta funcion retorna un valor que se ejecuta en otra funcion que ejecuta el transac sql 
        public int insert_proveedor(string nombre, string tel_1, string tel_2, string ciudad, string direccion)
        {
            int i = 0;
            estandar es = new estandar(cadena);
            SqlCommand _comando = es.procedimiento_proveedor();
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tel_1", tel_1);
            _comando.Parameters.AddWithValue("@tel_2", tel_2);
            _comando.Parameters.AddWithValue("@ciudad", ciudad);
            _comando.Parameters.AddWithValue("@direccion", direccion);
            try
            {
                _comando.Connection.Open();
                i =  _comando.ExecuteNonQuery();
            }
            catch(Exception ex) 
            {

            }
            finally
            {
                _comando.Connection.Dispose();
                _comando.Connection.Close();
            }
            return i;
        }
    }
}