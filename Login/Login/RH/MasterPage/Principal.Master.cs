using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Login;

namespace Recursos_Humanos.MasterPage
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        User u = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                u = (User)Application["user"];
                Menu y = NavigationMenu;
                y.Items[4].ChildItems[0].Text = "Usuario: " + u.user;
                verificaUsuario();
            }
            catch (Exception x) { Response.Redirect("/"); }
        }
        private void verificaUsuario()
        {
            if (!u.Valido)
                Response.Redirect("/");
        }

        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            Menu m = (Menu)sender;
            if (m.SelectedValue == "Salir")
            {
                Application["user"] = null;
                Response.Redirect("/");
            }
        }
    }
}