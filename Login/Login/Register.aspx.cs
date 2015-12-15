using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Data;
namespace Login
{
    public partial class Register : System.Web.UI.Page
    {
        string usuario = "";
        string men = "";
        SqlConnection con;
        DataSet almacen = new DataSet();
        int id_empleado, user;
       registerclass obj1 = new registerclass();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            obj1.cadena = System.Configuration.ConfigurationManager.ConnectionStrings[2].ToString();
            con = obj1.Conectar(ref men);
            Privilegio.Items.Add("Superadministrador");
            Privilegio.Items.Add("administrador");
            Privilegio.Items.Add("usuario");

            String cons = "Select idempleado,nombre,apaterno,amaterno from Empleado inner join persona on persona.idpersona = Empleado.fkpersona";
            almacen = obj1.consultas(cons, con);
            if (almacen.Tables[0].Rows.Count > 0)
            {
                EmpleadoCombo.DataSource = almacen.Tables[0];
                //Indicale directamente el nombre de la columna
                EmpleadoCombo.DataTextField = "nombre";
                EmpleadoCombo.DataValueField = "idempleado";
                EmpleadoCombo.SelectedIndex = 0;
                this.EmpleadoCombo.DataBind();
                this.EmpleadoCombo.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
            }
          /*  foreach (DataRow fill in almacen.Tables[0].Rows)
            {
                //usuario = fill["usuario"].ToString();
                this.EmpleadoCombo.DataSource = almacen;
                this.EmpleadoCombo.DataValueField = "idempleado";
                this.EmpleadoCombo.DataTextField = "Empleado";
                this.EmpleadoCombo.DataBind();
                this.EmpleadoCombo.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
                CBID_Personero.DataSource = Data.Tables(0);
                //Indicale directamente el nombre de la columna
                CBID_Personero.DataTextField = "Nombre_de_columna_mostrar";
                CBID_Personero.DataValueField = "Nombre_de_columna_valor";
                CBID_Personero.SelectedIndex = 0;
            } */
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = obj1.Conectar(ref men);
            String cons = "Select usuario from usuario where usuario = '" + txtusuario.Text + "'"; 
            almacen = obj1.consultas(cons, con);
            foreach (DataRow fill in almacen.Tables[0].Rows)
            {
                usuario = fill["usuario"].ToString();

            }
            if (usuario == txtusuario.Text)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "MiScript", "alert('Usuario ya está en uso')", true);
            }
            else
            {
 
                obj1.InsertarUsuario(con, txtusuario.Text, txtpass.Text,Convert.ToInt32(EmpleadoCombo.Text), Privilegio.Text, ref men);
                   EmpleadoCombo.SelectedIndex = -1;
                txtusuario.Text = "";
                txtpass.Text = "";
                Page.ClientScript.RegisterStartupScript(GetType(), "MiScript", "alert('Registrado')", true);
                 
            }

        }

         
    
    }
}