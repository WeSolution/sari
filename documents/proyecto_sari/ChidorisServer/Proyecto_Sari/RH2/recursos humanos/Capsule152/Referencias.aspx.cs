using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Conexiones2015;
using System.Data.SqlClient;
using System.Data;


namespace Recursos_Humanos.Capsule152
{
    public partial class Referencias : System.Web.UI.Page
    {
        SQLServer S = new SQLServer();
        String men = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            S.Seguridad = false;
            S.InitialCatalog = "SARI_RH_Candy";
            S.Server = @"BLUEEQUINOX\SQLEXPRESS";

            //S.Seguridad = true;
            //S.InitialCatalog = "SARI_RH_Candy";
            //S.Server = @"sari.servehttp.com";
            //S.Login = "Server";
            //S.Password = "F46987DE89";
        }

        protected void BTNSigRef(object sender, EventArgs e)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            AgregarLaWea();
            Response.Redirect("../Capsule152/Referencias.aspx?IDCandidato=" + IDCandidato);
        }

        protected void BTNSigpag(object sender, EventArgs e)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            AgregarLaWea();
            Response.Redirect("../Capsule152/PreferenciasLaborales.aspx?IDCandidato=" + IDCandidato);
        }
        private void AgregarLaWea()
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            SqlConnection cn = S.Conect(ref men);

            SqlCommand comando = new SqlCommand();
            SqlParameter Nombre_R = new SqlParameter("@Nombre_R", SqlDbType.VarChar);
            SqlParameter Direccion_R = new SqlParameter("@Direccion_R", SqlDbType.VarChar);
            SqlParameter Ocupacion_R = new SqlParameter("@Ocupacion_R", SqlDbType.VarChar);
            SqlParameter Telefono_R = new SqlParameter("@Telefono_R", SqlDbType.VarChar);
            SqlParameter Candidato = new SqlParameter("@id_Candidato", SqlDbType.Int);

            if (cn != null)
            {
                comando.Connection = cn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarReferencias";

                Nombre_R.Value = TBNom_Ref.Text;
                Direccion_R.Value = TBDirec.Text;
                Ocupacion_R.Value = TBOcupa.Text;
                Telefono_R.Value = TBTel.Text;
                Candidato.Value = IDCandidato;

                comando.Parameters.Add(Nombre_R);
                comando.Parameters.Add(Direccion_R);
                comando.Parameters.Add(Ocupacion_R);
                comando.Parameters.Add(Telefono_R);
                comando.Parameters.Add(Candidato);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception w)
                {
                    MessageBox.Show(this, "A͟l͝gún̛ ̧c̕am͏p̛o dej̕aste e͏n ̨bla͡ņco ҉o̵ ҉al̛g̶o͘ ͏pu͢d̴o ̴ha͟be̢r ͏sa̧l̸i̶do ́m͟a̶l,͟ ̡pru̡e͠ba ̷o̧t͢ra v̨e͝z̶.̢ \n ̷S̢i͜ e̷l pr̸oble̛ma p͟e̢rsi͞st͝e,̵ ́péga̛l͢e͡ ͢a͠l̀ ͡C̕PU.̨ ̀Eso͜ ͢si͡empr͞e fu̵n̕c̷i͏o͜na! ;)");
                    MessageBox.Show(this, "Error: " + w.Message);
                }

                MessageBox.Show(this, men);

                cn.Close();

            }
        }
    }
}