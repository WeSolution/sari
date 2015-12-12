using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Recursos_Financieros.Formularios
{
    public partial class AltaProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //se crea una objeto de la instancia datable que crea un tabla con la cual podemos interactuar.
                DataTable dt = new DataTable();
                // se asigna el valor devuelto por el metodo consulta_servicio el cual regresa un datatable
                DataTable dtproveedor = Clases.estandar.consulta_proveedor();
                // se pasan los datos para que se llene el combobox o select para servicios.
                cmbproveedor.DataSource = dtproveedor;
                cmbproveedor.DataValueField = "id_proveedor";
                cmbproveedor.DataTextField = "nombre";
                DataBind();

            }
        }

        protected void btnbuscarprov_Click(object sender, EventArgs e)
        {
            //se crea una objeto de la instancia datable que crea un tabla con la cual podemos interactuar.
            DataTable dt = new DataTable();
            // se asigna el valor devuelto por el metodo consulta_servicio el cual regresa un datatable
            dt = Clases.estandar.consulta_datos_prove(Convert.ToInt32(cmbproveedor.Value));

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtnombreprove.Text = Convert.ToString(row["nombre"]);
                txttel1.Text = Convert.ToString(row["tel_1"]);
                txttel2.Text = Convert.ToString(row["tel_2"]);
                txtciudad.Text = Convert.ToString(row["ciudad"]);
                txtdirecion.Text = Convert.ToString(row["direccion"]);

            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            //se llama a la funcion insert_servicio que esta en la carpeta clases -> y en la clase estandar y se pasan los parametros que necesitan
            Clases.estandar.insert_servicio(txtidentificador.Text, txtnombre.Text, txtdescripcion.Text, Convert.ToDouble(txtprecio.Text));
            //se limpian los campos
            txtnombre.Text = "";
            txtidentificador.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtnombre.Focus();
            //se llama a la funcion insert_atiende que esta en la carpeta clases -> y en la clase estandar y se pasan los parametros que necesitan
            Clases.estandar.insert_atiende(Convert.ToInt32(cmbproveedor.Value));
        }

        protected void btncancelar_Click(object sender, EventArgs e)
        {

        }
    }
}