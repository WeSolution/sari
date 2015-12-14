using Recursos_Humanos.Capsule152;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login.RH2.Capsule152
{
    public partial class Test_Psic_Show : System.Web.UI.Page
    {
        SQLServer S = new SQLServer();
        String men = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            String sentencia = "select Cali_Hab_Sup, Cali_Cap_Dec, Cali_Cap_Eva, Cali_Hab_ERI, Cali_Sen_Com from Candidatos where id_Candidato=" + IDCandidato + ";";

            var content = Page.Master.FindControl("Contenedor");
            List<Label> kjshkdjha = new List<Label>();
            foreach (Control c in content.Controls)
            {
                if (c is Label)
                    kjshkdjha.Add(c as Label);
            }
            SqlDataReader contenedor;
            SqlConnection cn = S.Conect(ref men);

            if (cn != null)
            {
                contenedor = S.ConsultaDR(sentencia, ref men);
                if (contenedor != null)
                {
                    while (contenedor.Read())
                    {
                        for (int a = 0; a < 5; a++)
                        {
                            ChartTest.Series[0].Points[a].YValues[0] = Convert.ToDouble(contenedor[a].ToString());
                            kjshkdjha[a].Text = contenedor[a].ToString();
                        }
                    }
                }
                cn.Close();
            }
        }

        protected void BTNFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Gracias por participar! \n Nosotros le llamamos. :D");
            Response.Redirect("/RH2/Default.aspx");
        }
    }
}