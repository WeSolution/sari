using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Importar Librerías
using System.Data;
using System.Data.SqlClient;


namespace Altaderequisicion
{
    // Esta clase tiene como objetivo trabajar con todos los métodos del carrito
    public class MetodosCarrito
    {
        // Definir un DataTable que trabajara con todos los registros del carrito
        private DataTable registro;
        private DataTable registro2;


        public MetodosCarrito()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        // Crear un constructor que reciba el contenido del carrito
        public MetodosCarrito(DataTable carrito, DataTable carrito2)
        {
            this.registro = carrito;
            this.registro2 = carrito2;

        }

       


        // Retornar o enviar
        public DataTable getRegistro
        {
            get
            {
                return registro;
            }
        }
        public DataTable getRegistro2
        {
            get
            {
                return registro2;
            }
        }


        // Método que agregar un producto al carrito y retorna la confirmación del proceso
        public String agregar(int cod, string id, string nom, string marc, string mod, string desc, string gru, string loca, decimal preco, string unidad,
            int canti, int sto, DateTime fech, int cant)
        {
            string msg = "";

            DataRow fila;
            // Buscar el registro por su código: clave
            fila = registro.Rows.Find(cod);

            // Si lo encuentra
            if (fila != null)
            {
                msg = "Ya exite en el carrito";
            }
            else
            {
                fila = registro.NewRow(); // Nueva fila

                // Agregamos
                fila[0] = cod;
                fila[1] = id;
                fila[2] = nom;
                fila[3] = marc;
                fila[4] = mod;
                fila[5] = desc;
                fila[6] = gru;
                fila[7] = loca;
                fila[8] = preco;
                fila[9] = unidad;
                fila[10] = canti;
                fila[11] = sto;
                fila[12] = fech;
                fila[13] = cant;

                // Agregamos fila a registro
                registro.Rows.Add(fila);
                msg = "Agregado al carrito";
            }
            return msg;
        }


        // Método que agregar un servicio al carrito y retorna la confirmación del proceso
        public String agregar2(int cod, string ids, string nom, string desc, decimal prec, int cant)
        {
            string msg = "";

            // Buscar el registro por su código: clave
            DataRow filas = registro2.Rows.Find(cod);

            // Si lo encuentra
            if (filas != null)
            {
                msg = "Ya exite en el carrito";
            }
            else
            {
                filas = registro2.NewRow(); // Nueva fila

                // Agregamos
                filas[0] = cod;
                filas[1] = ids;
                filas[2] = nom;
                filas[3] = desc;
                filas[4] = prec; 
                filas[5] = cant;

                // Agregamos fila a registro
                registro2.Rows.Add(filas);
                msg = "Agregado al carrito";
            }
            return msg;
        }

        // Método que retorna el importe de pedidos
        public decimal Totaliza()
        {//(DBNull.Value ? 0 : registro.Rows.Count)
            
            decimal t = 0;
            if (registro.Rows.Count > 0)

                t = Convert.ToDecimal(registro.Compute("Sum(total)", ""));
            
                return t;
            
           
        }

        private bool isDBNull(int p)
        {
            throw new NotImplementedException();
        }
        // Método que obtiene el ultimo id de la tabla sol_compra
        public int obtenerId()
        {
           
            // Instanciar la conexión
            ConexionBL cn = new ConexionBL();

            // Comando que selecciona el id maximo de la tabla  sol_compra
            SqlCommand cmd = new SqlCommand("select ISNULL(MAX(id_compra), 0) from sol_compra", cn.getCn);
            cn.getCn.Open(); // Abrir la conexión
            int i = (int)cmd.ExecuteScalar() + 1; // Ejecuto y retorno count
            cn.getCn.Close(); // Cierro la conexión

            // Retorno el siguiente número de pedido
            return (i);
        }

        // Método que registra el pedido y su detalle
        public string grabar(DatosPedido dp)
        {
            string msg = "";

            // Obtiene el autogenerado 
            int np = obtenerId();
            // Instanciar la conexión
            ConexionBL cn = new ConexionBL();
            // Abri conexión
            cn.getCn.Open();
            // Definir que es una transacción
            SqlTransaction tr = cn.getCn.BeginTransaction(IsolationLevel.Serializable);
            // Comando que ejecuta el insert en la sol_compra
            SqlCommand cmd = new SqlCommand("insert into sol_compra(monto, fecha, id_usuario) values(@m,@f,@idc)", cn.getCn, tr);
            // Lista de parámetros
            
            cmd.Parameters.Add("@m", SqlDbType.Decimal).Value = dp.Monto;
            cmd.Parameters.Add("@f", SqlDbType.DateTime).Value = dp.Fecha;
            cmd.Parameters.Add("@idc", SqlDbType.Int).Value = dp.idCliente;

            cmd.ExecuteNonQuery(); // ejecuto
            

            try
            {
 
                // Grabar el detalle
                foreach (DataRow filas in registro2.Rows)
                {
                    // Comando que ejecuta el insert en la tabla detalle_producto
                    cmd = new SqlCommand("insert into detalle_servicio(id_compra, id_servicio, precio_venta) values(@n,@idservicio,@precio)", cn.getCn, tr);
                    // Lista de parámetros
                    cmd.Parameters.Add("@n", SqlDbType.Int).Value = np;
                    cmd.Parameters.Add("@idservicio", SqlDbType.Int).Value = filas[0];
                    cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = filas[4];


                    cmd.ExecuteNonQuery(); // ejecuto

                }
                // Grabar el detalle
                foreach (DataRow fila in registro.Rows)
                {
                    // Comando que ejecuta el insert en la tabla detalle_producto
                    cmd = new SqlCommand("insert into detalle_producto(id_compra, id_producto, cantidad, precio_venta) values(@n,@idproducto,@cant,@precio)", cn.getCn, tr);
                    // Lista de parámetros
                    cmd.Parameters.Add("@n", SqlDbType.Int).Value = np;
                    cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = fila[0];
                    cmd.Parameters.Add("@cant", SqlDbType.Int).Value = fila[13];
                    cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = fila[8];

                    cmd.ExecuteNonQuery(); // ejecuto
            }

                tr.Commit(); // Actualizar bd
                msg = "Pedido Agregado";
            }
           
            finally
            {
                cn.getCn.Close(); // Cerramos la conexión
            }
            return msg;
        }

    }
}