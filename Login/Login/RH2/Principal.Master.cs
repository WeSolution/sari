using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recursos_Humanos2.MasterPage
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            Response.Redirect("/");
        }
    }
}