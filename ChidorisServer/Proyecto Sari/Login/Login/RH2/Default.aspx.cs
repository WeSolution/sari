using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recursos_Humanos.MasterPage
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCandidato_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/RH2/Capsule152/Registro.aspx");
        }
    }
}