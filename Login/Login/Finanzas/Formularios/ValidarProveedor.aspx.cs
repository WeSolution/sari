using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Recursos_Financieros.Formularios
{
    public partial class ValidarProveedor : System.Web.UI.Page
    {
        public Clases.estandar es = new Clases.estandar(System.Configuration.ConfigurationManager.ConnectionStrings[3].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            // se crea el evento IsPostBack que hace que los elementos se carguen soloamente una vez y ademas tambien se crea
            //o se llena el select o ComboBox.
            if (!IsPostBack)
            {
                DataTable td = es.consulta_proveedor();
                cmbproveedor.DataSource = td;
                cmbproveedor.DataValueField = "id_proveedor";
                cmbproveedor.DataTextField = "nombre";
                DataBind();
            }
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            // se hace el llamado a la funcion consulta_proveedor_todo y se instancia al mismo tiempo a una variable de tipo
            // datatable llamada dt
            DataTable dt = es.consulta_proveedor_todo(Convert.ToInt32(cmbproveedor.Value));
            //se pasan los datos que tiene el datatable a un GridView y se hace el enlace de datos con el DataBind()
            Gdvproveedores.DataSource = dt;
            Gdvproveedores.DataBind();

            // se hace el llamado a la funcion consulta_proveedor_todo y se instancia al mismo tiempo a una variable de tipo
            // datatable llamada dt2
            DataTable dt2 = es.consulta_producto_suministra(Convert.ToInt32(cmbproveedor.Value));
            //se pasan los datos que tiene el datatable a un GridView y se hace el enlace de datos con el DataBind()
            gdvproducto.DataSource = dt2;
            gdvproducto.DataBind();

            // se hace el llamado a la funcion consulta_proveedor_todo y se instancia al mismo tiempo a una variable de tipo
            // datatable llamada dt3
            DataTable dt3 = es.consulta_servicio_brinda(Convert.ToInt32(cmbproveedor.Value));
            //se pasan los datos que tiene el datatable a un GridView y se hace el enlace de datos con el DataBind()
            gdvatiend.DataSource = dt3;
            gdvatiend.DataBind();
        }
    }
}