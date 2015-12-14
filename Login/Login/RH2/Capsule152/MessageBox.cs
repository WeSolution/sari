using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace Recursos_Humanos.Capsule152
{
    public class MessageBox
    {
        public static void Show(Page Page, String Message)
        {
            //Page.ClientScript.RegisterStartupScript(
            // Page.GetType(),
            //"MessageBox",
            //"<script language='javascript'>alert('" + Message + "');</script>"
            // );
            Page.Response.Write("<script>alert('" + Message + "');</script>");
        }
    }
}
