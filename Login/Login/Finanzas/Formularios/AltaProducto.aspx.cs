using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Recursos_Financieros.Conexion;

namespace Recursos_Financieros.AltaProducto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Conexion.Conexion con = new Conexion.Conexion();
        private string cadena = System.Configuration.ConfigurationManager.ConnectionStrings[3].ToString();//ma cai que me estoy durmiendo
        protected void Page_Load(object sender, EventArgs e)
        {
            string mensaje = "";
            lblfecha.Text = DateTime.Now.ToString();
                       //string cadenaConexion = Conexion.Conexion.conectar_bd(cadena).ToString();
            //SqlConnection conexion = new SqlConnection(cadenaConexion);
            
            //yo ya me harte 
            SqlConnection conexion = con.conectar_bd(cadena);
            DataTable ds = new DataTable();
            string query = "SELECT id_proveedor, nombre FROM proveedor";
            try
            {
                conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(ds);
                conexion.Close();
                foreach (DataRow row in ds.Rows)
                {
                    if (Proveedor.Items.FindByValue(row[0].ToString()) == null)
                        Proveedor.Items.Add(new ListItem(row[1].ToString(), row[0].ToString()));
                }
            }
            catch (Exception ex)
            {
                mensaje = "<script> window.alert('No ha seleccionado un proveedor')</script>";
            }
            Response.Write(mensaje);
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (!Page.IsValid)
                    return;
                AccesoLogica producto = new AccesoLogica(cadena);
                if (txtNombre.Text.Length == 0 || txtMarca.Text.Length == 0 || txtModelo.Text.Length == 0 ||
                    txtDescripcion.Text.Length == 0 || Grupo.SelectedIndex == 0 || txtPrecioCompra.Text.Length == 0 ||
                    Medida.SelectedIndex == 0 || txtCantidad.Text.Length == 0 || Proveedor.SelectedIndex == 0)
                {
                    mensaje = "<script> window.alert('Todos los campos son obligatorios.')</script>";
                }
                else
                {
                    string nombre = txtNombre.Text;
                    string marca = txtMarca.Text;
                    string modelo = txtModelo.Text;
                    string descripcion = txtDescripcion.Text;
                    string grupo = Grupo.SelectedItem.Text;
                    float precioCompra = float.Parse(txtPrecioCompra.Text);
                    string medida = Medida.SelectedItem.Text;
                    int cantidad = int.Parse(txtCantidad.Text);
                    int resultado = producto.Insert(nombre, marca, modelo, descripcion, grupo, precioCompra, medida,
                        cantidad, DateTime.Now);
                    if (resultado > 0)
                        mensaje = "<script> window.alert('Nuevo Registro Agregado Satisfactoriamente.')</script>";
                    else
                        mensaje = "<script> window.alert('El producto: " + txtNombre.Text + " ya existe, agrege otro')</script>";
                    
                    producto.InsertSuministra(Convert.ToInt32(Proveedor.SelectedValue));
                    
                    Response.Write(mensaje);

                    txtNombre.Text = txtMarca.Text = txtModelo.Text = txtDescripcion.Text = txtPrecioCompra.Text = "";
                    txtCantidad.Text = ""; txtNombreProveedor.Text = txtTelefono1.Text = "";
                    txtTelefono2.Text = txtCiudad.Text = txtDireccion.Text = "";
                    Medida.SelectedIndex = Grupo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                mensaje = "<script> window.alert('Verifique que los campos esten llenados correctamente.'"+ex+")</script>";
                Response.Write(mensaje);
                txtNombre.Text = txtMarca.Text = txtModelo.Text = txtDescripcion.Text = txtPrecioCompra.Text = "";
                txtCantidad.Text = txtNombreProveedor.Text = txtTelefono1.Text = "";
                txtTelefono2.Text = txtCiudad.Text = txtDireccion.Text = "";
                Medida.SelectedIndex = Grupo.SelectedIndex = Proveedor.SelectedIndex = 0;
            }
        }

        protected void Proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mensaje = "";
            if (Proveedor.SelectedItem.Text == "Seleccione Proveedor")
            {
                mensaje = "<script> window.alert('Es necesario seleccionar un proveedor')</script>";
                Response.Write(mensaje);
            }
            else
            {
                Response.Write(mensaje);
               
                SqlConnection conexion = con.conectar_bd(cadena);
                DataTable ds = new DataTable();
                string query = "SELECT * FROM proveedor where nombre ='" + Proveedor.SelectedItem.Text + "'";
                try
                {
                    conexion.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    adapter.Fill(ds);
                    conexion.Close();
                    foreach (DataRow row in ds.Rows)
                    {
                        txtNombreProveedor.Text = row[1].ToString();
                        txtTelefono1.Text = row[2].ToString();
                        txtTelefono2.Text = row[3].ToString();
                        txtCiudad.Text = row[4].ToString();
                        txtDireccion.Text = row[5].ToString();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}