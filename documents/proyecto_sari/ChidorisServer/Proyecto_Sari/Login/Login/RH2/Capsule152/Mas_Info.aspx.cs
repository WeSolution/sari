using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Recursos_Humanos.Capsule152
{
    public partial class Mas_Info : System.Web.UI.Page
    {
        SQLServer S = new SQLServer();
        String men = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //S.Seguridad = false;
            //S.InitialCatalog = "SARI_RH_Candy";
            //S.Server = @"BLUEEQUINOX\SQLEXPRESS";

            //S.Seguridad = true;
            //S.InitialCatalog = "SARI_RH_Candy";
            //S.Server = @"sari.servehttp.com";
            //S.Login = "Server";
            //S.Password = "F46987DE89";
        }

        protected void Siguiente_Pag_Clik(object sender, EventArgs e)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            AgregarLaWea();
            MessageBox.Show(this, "Gracias por registrarte. Es hora de la prueba psicológica. :) G̴̛̭̫̥̠̮̟̫̓̊͗͐ͩ͒͐́̔̓͒̒̔ͩ̕Ỏ͂ͦ̍ͯ̾ͩ͆̐́͋͠҉͙͓̻̜̫͓͙̰̻O̒ͣ͗̃ͥͤ͑̿̍ͥ͏̧҉̩̟̱͚̖͖͙́Ḑ̷͖̣͙̼͓͙͙̮͒͒͋͂́͆͢͞ͅ ̢̳̘̫̱͔͔̲̟̩̆̀̐̅̑̃͑̍ͥ̑͞ͅLͪ͑ͣ͋ͫ̎̄ͦ͗ͭ͛̏̃̃͏̵͏̶̛̟͎̜͔͔̦̗̤̖̜̹͓̗U̸͉̗̫̗̲̖̮̩̞̜̮̩͈̝ͩ͒̏̅ͥͬ̋̆͛̂̽ͤ̓̂ͨ̽̽̏̔̕͜͟͡ͅC̗̫̱̞͕̗͍̍̉̈́ͦ̋̀̅ͤ̀̿̚̕͟K͆ͧ́̈̌͊͋͐̂̃҉̷̧͖̬̹̤̜̳̩̯̭͓͕̣̲͍̠̻̝ͅ");
            Response.Redirect("/RH2/Capsule152/Test_Psic.aspx?IDCandidato=" + IDCandidato);
        }
        private void AgregarLaWea()
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            SqlConnection cn = S.Conect(ref men);

            SqlCommand comando = new SqlCommand();
            SqlParameter Idiomas = new SqlParameter("@Idiomas", SqlDbType.VarChar);
            SqlParameter Herra_Ofi = new SqlParameter("@Herra_Ofi", SqlDbType.VarChar);
            SqlParameter Herra_Info = new SqlParameter("@Herra_Info", SqlDbType.VarChar);
            SqlParameter Cursos = new SqlParameter("@Cursos", SqlDbType.VarChar);
            SqlParameter Cono_Tec = new SqlParameter("@Cono_Tec", SqlDbType.VarChar);
            SqlParameter Cono_Fina = new SqlParameter("@Cono_Fina", SqlDbType.VarChar);
            SqlParameter Candidato = new SqlParameter("@IDCandidato", SqlDbType.Int);

            if (cn != null)
            {
                comando.Connection = cn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarMoreInfo";

                Idiomas.Value = TBIdiomas.Text;
                Herra_Ofi.Value = TBHerra_Offi.Text;
                Herra_Info.Value = TBHerra_Info.Text;
                Cursos.Value = TBCursos.Text;
                Cono_Tec.Value = TBCono_Tec.Text;
                Cono_Fina.Value = TBCono_Fina.Text;
                Candidato.Value = IDCandidato;

                comando.Parameters.Add(Idiomas);
                comando.Parameters.Add(Herra_Ofi);
                comando.Parameters.Add(Herra_Info);
                comando.Parameters.Add(Cursos);
                comando.Parameters.Add(Cono_Tec);
                comando.Parameters.Add(Cono_Fina);
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