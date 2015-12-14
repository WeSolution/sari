using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Altaderequisicion;

namespace Recursos_Materiales.Requisiciones
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                // Instanciar DetalleBL
                MetodosCarrito tabla = new MetodosCarrito((DataTable)Session["carrito"], (DataTable)Session["carrito"]);
                MetodosCarrito tabla2 = new MetodosCarrito((DataTable)Session["carrito2"], (DataTable)Session["carrito2"]);

                // Listar productos en carrito
                GridView1.DataSource = tabla.getRegistro;
                GridView1.DataBind();

                // Listar servicios en carrito
                GridView2.DataSource = tabla2.getRegistro;
                GridView2.DataBind();



                // Muestra el importe de productos
                lbTotal.Text = tabla.Totaliza().ToString();



                // Muestra el importe de servicios
                lbTotalS.Text = tabla2.Totaliza().ToString();

                // Suma los importes de productos y servicios y el resultado se imprime en importe total
                decimal valor = decimal.Parse(lbTotal.Text) + decimal.Parse(lbTotalS.Text);
                lbTotalG.Text = valor.ToString();

                //abilita e inabilita boton guardar si el monto es superior a 1000
                if (decimal.Parse(lbTotalG.Text) > 1000)
                {
                    btnGuardar.Enabled = false;
                }
                else
                {
                    btnGuardar.Enabled = true;
                }
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            //valida que el txtCliente tenga un id de usuario
            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + "Ingrese id de usuario" + "');</script>");
            }
            else
            {
                // Instanciar DatosPedido
                DatosPedido pe = new DatosPedido();

                pe.Monto = decimal.Parse(lbTotalG.Text);
                pe.idCliente = int.Parse(txtCliente.Text);
                pe.Fecha = DateTime.Today;

                // Instanciar MetodosCarrito
                MetodosCarrito tabla = new MetodosCarrito((DataTable)Session["carrito"], (DataTable)Session["carrito2"]);


                // Ejecutar y mostrar mensaje

                string message = tabla.grabar(pe);


                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                "<script language=JavaScript>alert('" + (message) + "');</script>");






            }

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Requisiciones/Nueva Requisicion");
        }

        //elimina filas del carrito de productos 
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Intancia la clase MetodosCarrito para poder trabajar con sus metodos
            MetodosCarrito t = new MetodosCarrito((DataTable)Session["carrito"], (DataTable)Session["carrito"]);

            //obtiene el indice de la fila que se va eliminar
            int index = Convert.ToInt32(e.RowIndex);
            DataTable tabla = Session["carrito"] as DataTable;
            //elimina la fila
            tabla.Rows.RemoveAt(index);
            Session["carrito"] = tabla;
            GridView1.DataSource = tabla;
            GridView1.DataBind();
            if (t != null)
            {
                //Sobreescribe los nuevos importes
                lbTotal.Text = t.Totaliza().ToString();
                decimal valor = decimal.Parse(lbTotal.Text) + decimal.Parse(lbTotalS.Text);
                lbTotalG.Text = valor.ToString();
            }

            //abilita e inabilita boton guardar si el monto es superior a 1000
            if (decimal.Parse(lbTotalG.Text) > 1000)
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }




        }
        //elimina filas del carrito de servicios 
        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            //Intancia la clase MetodosCarrito para poder trabajar con sus metodos
            MetodosCarrito t = new MetodosCarrito((DataTable)Session["carrito2"], (DataTable)Session["carrito2"]);

            //obtiene el indice de la fila que se va eliminar
            int index = Convert.ToInt32(e.RowIndex);
            DataTable tabla = Session["carrito2"] as DataTable;
            //elimina la fila
            tabla.Rows.RemoveAt(index);
            Session["carrito2"] = tabla;
            GridView2.DataSource = tabla;
            GridView2.DataBind();
            if (t != null)
            {
                //Sobreescribe los nuevos importes
                lbTotalS.Text = t.Totaliza().ToString();
                decimal valor = decimal.Parse(lbTotal.Text) + decimal.Parse(lbTotalS.Text);
                lbTotalG.Text = valor.ToString();
            }

            //abilita e inabilita boton guardar si el monto es superior a 1000
            if (decimal.Parse(lbTotalG.Text) > 1000)
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }


        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}