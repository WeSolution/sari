using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Financieros.Clases;

namespace Recursos_Financieros.Formularios
{
    public partial class AltaProveedor1 : System.Web.UI.Page
    {
        estandar obj = new estandar(System.Configuration.ConfigurationManager.ConnectionStrings[1].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            int var = obj.insert_proveedor(txtnombre.Text, txttel_1.Text, txttel_2.Text, txtciudad.Text, txtdireccion.Text);
            if (var == 1)
            {
                Response.Write("<script language=javascript>alert('se inserto el proveedor');</script>");
                txtnombre.Text = "";
                txttel_1.Text = "";
                txttel_2.Text = "";
                txtdireccion.Text = "";
                txtciudad.Text = "";
                txtnombre.Focus();
            }
            else
            {
                Response.Write("<script language=javascript>alert('No se inserto el proveedor');</script>");
            }
        }
    }
}