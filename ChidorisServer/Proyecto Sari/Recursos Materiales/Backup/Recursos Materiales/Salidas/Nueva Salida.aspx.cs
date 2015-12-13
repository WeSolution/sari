using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;
using System.Data;

namespace Recursos_Materiales.Salidas
{
    public partial class Nueva_Salida : System.Web.UI.Page
    {
        public DataTable tab;
        public DataRow row;
        public static DataTable savefiles = new DataTable();
        public DataTable prod = new DataTable();
        Conexion1 con = new Conexion1();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtHora.Text = DateTime.Now.ToString("hh:mm:ss");
            CargarCombo();
            if (!Page.IsPostBack)
            {
                prod.Columns.Add("Producto");
                prod.Columns.Add("Solicitante");
                prod.Columns.Add("Cantidad de productos");
                Session.Add("Tabla", prod);
            }
        }

        public void CargarCombo()
        {
            try
            {
                tab = new DataTable();
                tab = con.Consultas("SELECT nombre + ' ' + apellido_p + ' ' + apellido_m as Nombre FROM empleado");
                cmbQuien.DataTextField = tab.Columns[0].ToString();
                cmbQuien.DataValueField = tab.Columns[0].ToString();
                cmbQuien.DataSource = tab;
                cmbQuien.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                prod = (System.Data.DataTable)(Session["Tabla"]);
                row = prod.NewRow();
                row[0] = txtProducto.Text;
                row[1] = cmbQuien.Text;
                row[2] = txtCantidad.Text;
               

                prod.Rows.Add(row);
                GridView1.DataSource = prod;
                GridView1.DataBind();
                Session.Add("Tabla", prod);

            }

            catch (Exception ex)
            {
                Response.Write("<script>window.alert('Error: " + ex.Message + "');</script>");
            }
        }
        int cont = 0;
        protected void btnSalida_Click(object sender, EventArgs e)
        {
            string us = con.Consultas("SELECT id_empleado FROM empleado where Nombre + ' ' + Apellido_p + ' ' + Apellido_m ='" + cmbQuien.Text + "';").Rows[0][0].ToString();
            if (con.DML("INSERT INTO salida(hora,fecha,descripcion) VALUES('" + txtHora.Text + "','" + txtFecha.Text + "','" + txtDesc.Text + "');") == true)
            {
                try
                {
                    for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
                    {
                        string sal = con.Consultas("SELECT MAX(id_salida) FROM salida").Rows[0][0].ToString();
                        if (con.DML("INSERT INTO detalle_salida VALUES(" + txtProducto.Text + "," + sal + "," + txtCantidad.Text + ");") == true)
                        {
                            con.DML("UPDATE producto SET stock = stock - " + Convert.ToInt32(GridView1.Rows[i].Cells[2].Text) + " WHERE id_producto = " + GridView1.Rows[i].Cells[0].Text + " or identificador ='" + GridView1.Rows[i].Cells[0].Text + "';");
                            if (cont == GridView1.Rows.Count)
                            {
                                Response.Write("<script>window.alert('Salida registrada correctamente');</script>");
                            }
                            txtCantidad.Text = "";
                            txtDesc.Text = "";
                            txtProducto.Text = "";
                            cont++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>window.alert(' Error: " + ex.Message + "');</script>");
                }
                txtDesc.Text = "";
                GridView1.Visible = false;
            }

        }
    }
}