using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;
using System.Data;
using System.Data.SqlClient;

namespace Recursos_Materiales.Entradas
{
    public partial class Nueva_Entrada : System.Web.UI.Page
    {
        DataTable temporal;
        Conexion1 con = new Conexion1();
        protected DataTable objdtTabla
        {
            get
            {
                if (ViewState["objdtTabla"] != null)
                {
                    return (DataTable)ViewState["objdtTabla"];
                }
                else
                {
                    return temporal;
                }
            }
            set
            {
                ViewState["objdtTabla"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Form.Attributes.Add("autocomplete", "off");
                temporal = new DataTable();
                CrearTabla();
                cmbProveedores.DataSource = con.Consultas("Select * from proveedor");
                cmbProveedores.DataValueField = "Nombre";
                cmbProveedores.DataTextField = "Nombre";
                cmbProveedores.DataBind();
                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtHora.Text = DateTime.Now.ToString("hh:mm");
                txtTotal.Text = "0.0";
            }

        }

        private void CrearTabla()
        {
            temporal.Columns.Add("ID");
            temporal.Columns.Add("Producto");
            temporal.Columns.Add("Proveedor");
            temporal.Columns.Add("Cantidad");
            temporal.Columns.Add("Precio");
            temporal.Columns.Add("Ubicación");
            objdtTabla = temporal;
        }

        private void AgregarFila(string id, string nombre, string proveedor,string cantidad,string precio,string ubicacion)
        {
            DataTable dt = objdtTabla;
            DataRow drFila = dt.NewRow();
            drFila["ID"] = id;
            drFila["Producto"] = nombre;
            drFila["Proveedor"] = proveedor;
            drFila["Cantidad"] = cantidad;
            drFila["Precio"] = precio;
            drFila["Ubicación"] = ubicacion;
            dt.Rows.Add(drFila);
            objdtTabla = dt;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string id, nombre, proveedor, cantidad, precio, ubicacion;
                double total;
                id = txtProducto.Text;
                nombre = con.Consultas("Select nombre from producto where id_producto=" + id + ";").Rows[0][0].ToString();
                precio = con.Consultas("Select precio_compra from producto where id_producto=" + id + ";").Rows[0][0].ToString();
                proveedor = cmbProveedores.Text;
                cantidad = txtCantidad.Text;
                total = Convert.ToDouble(precio) * Convert.ToInt32(cantidad);
                ubicacion = txtUbicación.Text;
                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + total).ToString();
                AgregarFila(id, nombre, proveedor, cantidad, precio, ubicacion);
                dgvDatos.DataSource = objdtTabla;
                dgvDatos.DataBind();
                txtCantidad.Text = "";
                txtProducto.Text = "";
                txtUbicación.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
        }

        protected void dgvDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            objdtTabla.Rows[index].Delete();
            dgvDatos.DataSource = objdtTabla;
            dgvDatos.DataBind();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Comando que ejecuta el insert en la tabla detalle_producto
                SqlCommand cmd = new SqlCommand("insert into entradas values(@fecha,@hora,@desc,@total,@prov)", con.conectar());
                // Lista de parámetros
                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = txtFecha.Text;
                cmd.Parameters.Add("@hora", SqlDbType.Time).Value = txtHora.Text;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = txtDesc.Text;
                cmd.Parameters.Add("@total", SqlDbType.Money).Value = txtTotal.Text;
                cmd.Parameters.Add("@prov", SqlDbType.Int).Value = con.Consultas("Select id_proveedor from proveedor where nombre='" + cmbProveedores.Text + "'").Rows[0][0].ToString();
                cmd.ExecuteNonQuery(); // ejecuto

                string identrada = con.Consultas("Select Max(id_entrada) from entradas").Rows[0][0].ToString();
                int iden;
                iden = Convert.ToInt32(identrada);

                for (int i = 0; i <= dgvDatos.Rows.Count - 1; i++)
                {
                    con.DML("UPDATE producto set stock = stock + " + objdtTabla.Rows[i][3].ToString() + " where id_producto = " + objdtTabla.Rows[i][0].ToString());
                    con.DML("UPDATE producto set localizacion = " + objdtTabla.Rows[i][5].ToString() + " where id_producto = " + objdtTabla.Rows[i][0].ToString());
                    // Comando que ejecuta el insert en la tabla detalle_producto
                    SqlCommand cmd2 = new SqlCommand("insert into detalle_entradas values(@ide,@idprod,@cantidad)", con.conectar());
                    // Lista de parámetros
                    cmd2.Parameters.Add("@ide", SqlDbType.Int).Value = iden;
                    cmd2.Parameters.Add("@idprod", SqlDbType.Int).Value = Convert.ToInt32(objdtTabla.Rows[i][0].ToString());
                    cmd2.Parameters.Add("@cantidad", SqlDbType.Int).Value = Convert.ToInt32(objdtTabla.Rows[i][3].ToString());
                    cmd2.ExecuteNonQuery(); // ejecuto
                }
                string script = @"alert('Entrada registrada satisfactoriamente');
                        window.location.href='../Entradas/Nueva Entrada.aspx'";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Mensaje", script, true);
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
        }
    }
}
