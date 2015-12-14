using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;
using System.Data.SqlClient;


namespace Recursos_Humanos.Capsule152
{
    public class SQLServer
    {
        public string cadConexion = System.Configuration.ConfigurationManager.ConnectionStrings["Login.Properties.Settings.RH2LocalPruebas"].ToString();

        public SqlConnection Conect(ref String m)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadConexion;
            try
            {
                conexion.Open();
                m = ("Connection is open and ready to fire! ( ͡° ͜ʖ ͡°)");
            }
            catch (Exception w)
            {
                conexion = null;
                m = ("( ͠° ͟ʖ ͡°) Error " + w.Message);
            }
            return conexion;
        }


        //public Boolean ModificarBD(String Sentencia, ref String m)
        //{
        //    String men = "";
        //    SqlCommand carrito = new SqlCommand();
        //    carrito.Connection = Conect(ref men);
        //    carrito.CommandText = Sentencia;
        //    Boolean resultado = false;

        //    try
        //    {
        //        carrito.ExecuteNonQuery();
        //        resultado = true;
        //        m = ("Modificacion correcta");
        //    }
        //    catch (Exception w)
        //    {
        //        resultado = false;
        //        m = ("Error " + w.Message);
        //    }
        //    carrito.Connection.Close();
        //    return resultado;
        //}

        //public SqlDataReader ConsultaDR(String Sentencia, ref String m)
        //{
        //    String men = "";
        //    SqlCommand carrito = new SqlCommand();
        //    carrito.Connection = Conect(ref men);
        //    carrito.CommandText = Sentencia;
        //    SqlDataReader contenedor;

        //    try
        //    {
        //        contenedor = carrito.ExecuteReader();
        //        m = ("Consulta Correcta");
        //    }
        //    catch (Exception w)
        //    {
        //        contenedor = null;
        //        m = ("Error " + w.Message);
        //    }

        //    return contenedor;
        //}
        public Boolean Modify(String S, ref String men)
        {
            Boolean wut = true;
            SqlConnection conexion;
            conexion = Conect(ref men);
            if (Conect(ref men) == null)
            {
                wut = false;
            }
            else
            {
                SqlCommand car = new SqlCommand();
                car.Connection = conexion;
                car.CommandText = S;
                try
                {
                    car.ExecuteNonQuery();
                }
                catch (Exception q)
                {
                    men = "Error: " + q.Message;
                }
                wut = true;
            }
            return wut;
        }
        public Boolean MultiModify(List<String> sentencias, ref String men)
        {
            Boolean wut = true;
            SqlConnection conexion;
            conexion = Conect(ref men);
            if (Conect(ref men) == null)
            {
                wut = false;
            }
            else
            {
                foreach (String sentencia in sentencias)
                {
                    SqlCommand car = new SqlCommand();
                    car.Connection = conexion;
                    car.CommandText = sentencia;
                    try
                    {
                        car.ExecuteNonQuery();
                    }
                    catch (Exception q)
                    {
                        men = "Error: " + q.Message;
                    }
                }
                wut = true;
            }
            return wut;
        }
        public DataSet ConsultaDS(String sentencia, ref String men)
        {
            DataSet caja = new DataSet();
            SqlConnection conexion;
            conexion = Conect(ref men);
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
                    men = "Consulta Correcta";
                }
                catch (Exception q)
                {
                    caja = null;
                    men = "Error " + q.Message;
                }
            }
            else
            {
                men = "Oshe, la carretera no sirve. Prueba otra vez!!";
            }
            return caja;
        }
        public SqlDataReader ConsultaDR(String sentencia, ref String men)
        {
            SqlDataReader contenedor = null;
            SqlConnection carretera2;
            carretera2 = Conect(ref men);
            if (carretera2 != null)
            {
                SqlCommand matiz = new SqlCommand();
                matiz.Connection = carretera2;
                matiz.CommandText = sentencia;



                try
                {
                    contenedor = matiz.ExecuteReader();
                    men = "Consulta Correcta";
                }
                catch (Exception q)
                {
                    men = "Error " + q.Message;
                }
                //carretera2.Close();
            }
            else
            {
                men = "Oye no";
            }
            return contenedor;
        }
        public void ConsultaDT(ref DataSet ds, String sentencia, String NombreTabla, ref String men)
        {
            SqlConnection conexion;
            conexion = Conect(ref men);
            if (conexion != null)
            {
                SqlCommand car = new SqlCommand();
                car.Connection = conexion;
                car.CommandText = sentencia;

                SqlDataAdapter contenedor = new SqlDataAdapter();
                contenedor.SelectCommand = car;

                try
                {
                    contenedor.Fill(ds, NombreTabla);
                    men = "Consulta Correcta";
                }
                catch (Exception q)
                {
                    ds = null;
                    men = "Error " + q.Message;
                }
            }
        }
        //public SqlDataAdapter ConsultaDA(String sentencia, DataGridView dgv, ref String mensaje)
        //{
        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = Conect(ref mensaje);
        //    comando.CommandText = sentencia;
        //    SqlDataAdapter trailer = new SqlDataAdapter();
        //    DataSet caja = new DataSet();
        //    trailer.SelectCommand = comando;

        //    try
        //    {
        //        trailer.Fill(caja);
        //        mensaje = "Consulta Correcta";
        //        dgv.DataSource = caja.Tables[0];
        //    }
        //    catch (Exception e)
        //    {
        //        trailer = null;
        //        mensaje = "Error: " + e.Message;
        //    }
        //    return trailer;
        //}
        //int ind = 0;
        //public void LlenarCB(String sentencia, ComboBox cb, ref String men, ref ArrayList arr_id)
        //{
        //    SqlDataReader contenedor;
        //    SqlConnection cn = Conect(ref men);

        //    if (cn != null)
        //    {
        //        contenedor = ConsultaDR(sentencia, ref men);
        //        if (contenedor != null)
        //        {
        //            cb.Items.Clear();
        //            while (contenedor.Read())
        //            {
        //                cb.Items.Add(contenedor[1]);
        //                arr_id.Add((int)contenedor[0]);
        //                ind++;
        //            }
        //        }
        //        cn.Close();
        //    }
        //}
        public void Ids(ref ArrayList ids, String sentencia)
        {
            String men = "";
            //int ind = 0;
            SqlDataReader contenedor;
            SqlConnection cn = Conect(ref men);

            if (cn != null)
            {
                contenedor = ConsultaDR(sentencia, ref men);
                if (contenedor != null)
                {
                    while (contenedor.Read())
                    {
                        ids.Add((int)contenedor[0]);
                        ids.Add((int)contenedor[1]);
                        ids.Add((int)contenedor[2]);

                        //ind++;
                    }
                }
                cn.Close();
            }
        }
        //public void ConsultaCB(String sentencia, ComboBox cb, ref String men)
        //{
        //    SqlDataReader contenedor;
        //    SqlConnection cn = Conect(ref men);

        //    if (cn != null)
        //    {
        //        contenedor = ConsultaDR(sentencia, ref men);
        //        if (contenedor != null)
        //        {
        //            cb.Items.Clear();
        //            while (contenedor.Read())
        //            {
        //                cb.Items.Add(contenedor[0].ToString());
        //            }
        //        }
        //        cn.Close();
        //    }
        //}
        public void ConsultaDRArray(String sentencia, ref String[] datos, ref int[] id, ref String men)
        {
            SqlDataReader contenedor = null;
            SqlConnection carretera2;
            carretera2 = Conect(ref men);
            if (carretera2 != null)
            {
                SqlCommand matiz = new SqlCommand();
                matiz.Connection = carretera2;
                matiz.CommandText = sentencia;



                try
                {
                    contenedor = matiz.ExecuteReader();
                    men = "Consulta Correcta";
                }
                catch (Exception q)
                {
                    men = "Error " + q.Message;
                }
                //carretera2.Close();
                int i = 0;
                while (contenedor.Read())
                {
                    datos[i] = contenedor[1].ToString();
                    id[i] = Convert.ToInt32(contenedor[0].ToString());
                    i++;
                }
            }
            else
            {
                men = "Oye no";
            }
        }

        ////public void StoreProcedure (TextBox tb)
        ////{
        ////    int ultimo = 0;
        ////    String men = "";
        ////    SqlConnection cn = Conect(ref men);

        ////    SqlCommand comando = new SqlCommand();
        ////    //Parametros del Procedimiento Almacenado
        ////    //Tienen que ser iguales que los del P.A.
        ////    SqlParameter nombre = new SqlParameter("@nombre",SqlDbType.VarChar,100);
        ////    SqlParameter presentacion = new SqlParameter("@presentacion",SqlDbType.VarChar,50);
        ////    SqlParameter cantidad = new SqlParameter("@cantidad", SqlDbType.Int);
        ////    SqlParameter descripcion = new SqlParameter("@descripcion", SqlDbType.VarChar, 100);
        ////    SqlParameter preciov = new SqlParameter("@preciov", SqlDbType.Money);
        ////    SqlParameter precioc = new SqlParameter("@precioc", SqlDbType.Money);
        ////    SqlParameter idnuevo = new SqlParameter("@int", SqlDbType.Int);
        ////    idnuevo.Direction = ParameterDirection.Output;

        ////    if(cn != null)
        ////    {
        ////        comando.Connection = cn;
        ////        comando.CommandType = CommandType.StoredProcedure;
        ////        comando.CommandText="Insertar_Productos";
        ////        nombre.Value=tb;

        ////        comando.Parameters.Add(nombre);

        ////        comando.ExecuteNonQuery();
        ////        MessageBox.Show(idnuevo.Value.ToString());

        ////        ultimo = (int)idnuevo.Value;

        ////        cn.Close();
        ////    }

        ////    //Llenar los productos para un kit
        ////    cn = Conect(ref men);
        ////    SqlCommand comando2 = new SqlCommand();
        ////    comando2.Connection = cn;
        ////    comando2.CommandType = CommandType.StoredProcedure;
        ////    comando2.CommandText = "ConsultaProdsparaKit";
        ////    //Hacer el Procedimiento Almacenado
        ////    comando2.Parameters.Add(new SqlParameter("@idkit", SqlDbType.Int));
        ////    comando2.Parameters[0].Value = ultimo;

        ////    SqlDataReader caja;
        ////    caja = comando2.ExecuteReader();
        ////    //combobox1.items.clear()
        ////    //while (caja.read())
        ////    //combobox1.items.add(caja[1].tostring());
        ////}



    }
}