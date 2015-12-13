using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;
using System.Data;
using System.Data.SqlClient;

namespace Recursos_Materiales.Salidas
{
    public partial class Nueva_Salida : System.Web.UI.Page
    {
        private Conexion1 con = new Conexion1();
        private DataTable temporal = new DataTable();

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
            if (!Page.IsPostBack)
            {
                this.Form.Attributes.Add("autocomplete", "off");
                temporal = new DataTable();
                CrearTabla();
                cmbQuien.DataSource = con.Consultas("Select nombre + ' ' + apellido_p + ' ' + apellido_m as Nombre from empleado");
                cmbQuien.DataValueField = "Nombre";
                cmbQuien.DataTextField = "Nombre";
                cmbQuien.DataBind();
                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtHora.Text = DateTime.Now.ToString("hh:mm:ss");
            }
        }

        private void CrearTabla()
        {
            temporal.Columns.Add("ID");
            temporal.Columns.Add("Producto");
            temporal.Columns.Add("Cantidad");
            temporal.Columns.Add("Empleado");
            objdtTabla = temporal;
        }

        private void AgregarFila(string id, string prod, string cantidad, string empleado)
        {
            DataTable dt = objdtTabla;
            DataRow drFila = dt.NewRow();
            drFila["ID"] = id;
            drFila["Producto"] = prod;
            drFila["Cantidad"] = cantidad;
            drFila["Empleado"] = empleado;
            dt.Rows.Add(drFila);
            objdtTabla = dt;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string id, prod, cantidad, empleado;
                id = txtProducto.Text;
                prod = con.Consultas("Select nombre from producto where id_producto=" + id + ";").Rows[0][0].ToString();
                cantidad = txtCantidad.Text;
                empleado = cmbQuien.Text;
                AgregarFila(id, prod, cantidad, empleado);
                GridView1.DataSource = objdtTabla;
                GridView1.DataBind();
                txtCantidad.Text = "";
                txtProducto.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            objdtTabla.Rows[index].Delete();
            GridView1.DataSource = objdtTabla;
            GridView1.DataBind();
        }

        protected void btnSalida_Click(object sender, EventArgs e)
        {
            try
            {
                string ide = con.Consultas("Select id_empleado from empleado where nombre + ' ' + apellido_p + ' ' + apellido_m = '" + cmbQuien.Text + "'").Rows[0][0].ToString();
                // Comando que ejecuta el insert en la tabla detalle_producto
                SqlCommand cmd = new SqlCommand("insert into salida values(@fecha,@hora,@desc,@ide)", con.conectar());
                // Lista de parámetros
                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = txtFecha.Text;
                cmd.Parameters.Add("@hora", SqlDbType.Time).Value = txtHora.Text;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = txtDesc.Text;
                cmd.Parameters.Add("@ide", SqlDbType.Money).Value = ide;
                cmd.ExecuteNonQuery(); // ejecuto

                string idsalida = con.Consultas("Select Max(id_salida) from salida").Rows[0][0].ToString();
                int idsal;
                idsal = Convert.ToInt32(idsalida);
                for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
                {
                    string stock = con.Consultas("Select stock from producto where id_producto = " + objdtTabla.Rows[i][0].ToString()).Rows[0][0].ToString();
                    if (Convert.ToInt32(stock) < Convert.ToInt32(objdtTabla.Rows[i][2].ToString()))
                    {
                        Response.Write("<script>window.alert('No hay suficientes piezas para el producto con ID: " + objdtTabla.Rows[i][0].ToString() + "');</script>");
                    }
                    else
                    {
                        con.DML("UPDATE producto set stock = stock - " + txtCantidad.Text + " where id_producto = " + objdtTabla.Rows[i][0].ToString());
                        // Comando que ejecuta el insert en la tabla detalle_producto
                        SqlCommand cmd2 = new SqlCommand("insert into detalle_salida values(@ide,@idprod,@cantidad)", con.conectar());
                        // Lista de parámetros
                        cmd2.Parameters.Add("@ide", SqlDbType.Int).Value = idsal;
                        cmd2.Parameters.Add("@idprod", SqlDbType.Int).Value = Convert.ToInt32(objdtTabla.Rows[i][0].ToString());
                        cmd2.Parameters.Add("@cantidad", SqlDbType.Int).Value = Convert.ToInt32(objdtTabla.Rows[i][2].ToString());
                        cmd2.ExecuteNonQuery(); // ejecuto
                    }
                }
                string script = @"alert('Salida registrada satisfactoriamente');
                        window.location.href='../Salidas/Nueva Salida.aspx'";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Mensaje", script, true);
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
        }
    }
}