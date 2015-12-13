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
    public partial class Estudios : System.Web.UI.Page
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

        protected void BNSiguiente_Click(object sender, EventArgs e)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            AgregarLaWea();
            Response.Redirect("../Capsule152/Estudios.aspx?IDCandidato=" + IDCandidato);
        }

        protected void BNSiguiente3_Click(object sender, EventArgs e)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            AgregarLaWea();
            Response.Redirect("../Capsule152/Referencias.aspx?IDCandidato=" + IDCandidato);
        }

        private void AgregarLaWea()
        {
            String date1 = DDLDia.SelectedValue.ToString() + "/" + DDLMes.SelectedValue.ToString() + "/" + DDLAno.SelectedValue.ToString();
            DateTime FechaNac = Convert.ToDateTime(date1);
            String date2 = DDLDia0.SelectedValue.ToString() + "/" + DDLMes0.SelectedValue.ToString() + "/" + DDLAno0.SelectedValue.ToString();
            DateTime FechaNac2 = Convert.ToDateTime(date2);
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            SqlConnection cn = S.Conect(ref men);

            SqlCommand comando = new SqlCommand();
            SqlParameter Pais = new SqlParameter("@Pais", SqlDbType.VarChar);
            SqlParameter Nivel_Estudios = new SqlParameter("@Nivel_Estudios", SqlDbType.VarChar);
            SqlParameter Institucion = new SqlParameter("@Institucion", SqlDbType.VarChar);
            SqlParameter Area = new SqlParameter("@Area", SqlDbType.VarChar);
            SqlParameter Titulo = new SqlParameter("@Titulo", SqlDbType.VarChar);
            SqlParameter Fecha_I = new SqlParameter("@Fecha_I", SqlDbType.Date);
            SqlParameter Fecha_T = new SqlParameter("@Fecha_T", SqlDbType.Date);
            SqlParameter Promedio = new SqlParameter("@Promedio", SqlDbType.Float);
            SqlParameter Candidato = new SqlParameter("@id_Candidato", SqlDbType.Int);

            if (cn != null)
            {
                comando.Connection = cn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarEstudios";

                Pais.Value = TBPais.Text;
                Nivel_Estudios.Value = TBNivel_Est.Text;
                Institucion.Value = TBInsti.Text;
                Area.Value = TBArea.Text;
                Titulo.Value = TBTitulo.Text;
                Fecha_I.Value = FechaNac;
                Fecha_T.Value = FechaNac2;
                Promedio.Value = TBPromedio.Text;
                Candidato.Value = IDCandidato;

                comando.Parameters.Add(Pais);
                comando.Parameters.Add(Nivel_Estudios);
                comando.Parameters.Add(Institucion);
                comando.Parameters.Add(Area);
                comando.Parameters.Add(Titulo);
                comando.Parameters.Add(Fecha_I);
                comando.Parameters.Add(Fecha_T);
                comando.Parameters.Add(Promedio);
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