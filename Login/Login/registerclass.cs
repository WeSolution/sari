using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Data;
namespace Login
{
    public class registerclass
    {
         DataSet almacen2 = new DataSet();
            DataSet almacen = new DataSet();
            public string cadena { get; set; }
            string m = "";
            public registerclass()
            {
            }
            public registerclass(string cad)
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

            //CREAMOS NUESTRO MÉTODO PARA CREAR PROCEDIMIENTOS
            public SqlCommand procedimientoalmacenado(string procedimientos)
            {

                SqlCommand cadena_Sql = new SqlCommand(procedimientos, Conectar(ref m));
                cadena_Sql.CommandType = CommandType.StoredProcedure;
                cadena_Sql.CommandText = procedimientos;
                return cadena_Sql;
            }
            public void InsertarUsuario(SqlConnection con, String usuario, string pass,int id_empleado, string privilegio, ref String m)
            {
                SqlCommand comando = procedimientoalmacenado("insertarusuario");
                comando.Connection = con;

                SqlParameter user = new SqlParameter("@usuario", SqlDbType.VarChar, 50);
                user.Value = usuario;
                comando.Parameters.Add(user);

                SqlParameter password = new SqlParameter("@pass", SqlDbType.VarChar, 50);
                password.Value = pass;
                comando.Parameters.Add(password);

                SqlParameter privelgios = new SqlParameter("@privilegio", SqlDbType.VarChar, 50);
                privelgios.Value = privilegio;
                comando.Parameters.Add(privelgios);

                SqlParameter empleados = new SqlParameter("@id_empleado", SqlDbType.Int);
                empleados.Value = id_empleado;
                comando.Parameters.Add(empleados);
 
                try
                {
                    comando.ExecuteNonQuery();
                    m = "COnsulta correcta";
                }
                catch (Exception error)
                {
                    m = error.Message;
                } 
            }

            public void InsertarArea(SqlConnection con, String nombre_area, string descripcion, string telefono,int id_empleado,  ref String m)
            {
                SqlCommand comando = procedimientoalmacenado("insertararea");
                comando.Connection = con;

                SqlParameter n_area = new SqlParameter("@area", SqlDbType.VarChar, 50);
                n_area.Value = nombre_area;
                comando.Parameters.Add(n_area);

                SqlParameter description = new SqlParameter("@descripcion", SqlDbType.VarChar, 50);
                description.Value = descripcion;
                comando.Parameters.Add(description);

                SqlParameter telefon = new SqlParameter("@telefono", SqlDbType.VarChar, 50);
                telefon.Value = telefon;
                comando.Parameters.Add(telefon);

                SqlParameter empleados = new SqlParameter("@id_empleado", SqlDbType.Int);
                empleados.Value = id_empleado;
                comando.Parameters.Add(empleados);


                /*SqlParameter ultimoidinsertado = new SqlParameter("@ultimoid", SqlDbType.Int);
                ultimoidinsertado.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ultimoidinsertado);
                */
                try
                {
                    comando.ExecuteNonQuery();
                    m = "COnsulta correcta";
                }
                catch (Exception error)
                {
                    m = error.Message;
                } 
            }

            public int insertarEmpleados(SqlConnection con, string Nombre, string Ape_P, string Ape_M,string direccion, string telefono, string correo, string sexo, ref string men)
            {
                SqlCommand comando = procedimientoalmacenado("insertarempleados");
                //comando.Connection = complemento.abrirconection(ref men);
                comando.Connection = con;

                SqlParameter Name = new SqlParameter("@nombre", SqlDbType.VarChar, 50);
                Name.Value = Nombre;
                comando.Parameters.Add(Name);

                SqlParameter Apellido_P = new SqlParameter("@apellido_p", SqlDbType.VarChar, 50);
                Apellido_P.Value = Ape_P;
                comando.Parameters.Add(Apellido_P);

                SqlParameter Apellido_M = new SqlParameter("@apellido_m", SqlDbType.VarChar, 50);
                Apellido_M.Value = Ape_M;
                comando.Parameters.Add(Apellido_M);

                SqlParameter direction = new SqlParameter("@direccion", SqlDbType.VarChar, 50);
                direction.Value = direccion;
                comando.Parameters.Add(direction);

                SqlParameter telefon = new SqlParameter("@telefono", SqlDbType.VarChar, 50);
                telefon.Value = telefono;
                comando.Parameters.Add(telefon);

                SqlParameter mail = new SqlParameter("@correo", SqlDbType.VarChar, 50);
                mail.Value = correo;
                comando.Parameters.Add(mail);

                SqlParameter sex = new SqlParameter("@sexo", SqlDbType.VarChar, 50);
                sex.Value = sexo;
                comando.Parameters.Add(sex);
                /*SqlParameter id_user = new SqlParameter("@id_usuario", SqlDbType.Int);
                id_user.Value = id_usuario;
                comando.Parameters.Add(id_user);
                
                SqlParameter id_areas = new SqlParameter("@id_area", SqlDbType.Int);
                id_areas.Value = id_area;
                comando.Parameters.Add(id_areas);
                */
                SqlParameter ultimoidinsertado = new SqlParameter("@ultimoid", SqlDbType.Int);
                ultimoidinsertado.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ultimoidinsertado);
                try
                {
                    comando.ExecuteNonQuery();
                    m = "Correcto";
                }
                catch (Exception error)
                {
                    m = error.Message;
                }
                return (int)ultimoidinsertado.Value;
            }
            
    }
    public class User 
    {
        public string user { set; get; }
        private string password { set; get; }
        public string permiso { get; set; }
        public bool Valido { get; set; }
        public User(string u, string p, string pe) 
        {
            user = u; password = p; permiso = pe;
        }
        public bool esValido(string u,string p) 
        {
            return Valido = (String.Compare(u, user, false) == 0) && (String.Compare(p, password, false) == 0);
        }
    }
}