using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            area.Items.Add("Recursos Humanos");
            area.Items.Add("Finanzas");
            area.Items.Add("Recursos Materiales");
            area.Items.Add("Como invitado");
        }

        protected void btningresar_Click(object sender, EventArgs e)
        {

        }

        protected void area_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}