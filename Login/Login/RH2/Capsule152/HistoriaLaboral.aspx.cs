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
    public partial class HistoriaLaboral : System.Web.UI.Page
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

            DDLContacto.Items.Clear();
            DDLContacto.Items.Add("Claro!");
            DDLContacto.Items.Add("Por supuesto que no...");
            DDLContacto.Items.Add("YOLO");
        }

        protected void BNSiguiente3_Click(object sender, EventArgs e)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            AgregarLaWea();
            Response.Redirect("/RH2/Capsule152/Estudios.aspx?IDCandidato=" + IDCandidato);
        }

        protected void BNSiguiente_Click(object sender, EventArgs e)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            AgregarLaWea();
            Response.Redirect("/RH2/Capsule152/HistoriaLaboral.aspx?IDCandidato=" + IDCandidato);
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
            SqlParameter Puesto = new SqlParameter("@Puesto", SqlDbType.VarChar);
            SqlParameter Empresa = new SqlParameter("@Empresa", SqlDbType.VarChar);
            SqlParameter Fecha_I = new SqlParameter("@Fecha_I", SqlDbType.Date);
            SqlParameter Fecha_T = new SqlParameter("@Fecha_T", SqlDbType.Date);
            SqlParameter Area = new SqlParameter("@Area", SqlDbType.VarChar);
            SqlParameter Industria = new SqlParameter("@Industria", SqlDbType.VarChar);
            SqlParameter Sueldo = new SqlParameter("@Sueldo", SqlDbType.Money);
            SqlParameter Motivo_Salida = new SqlParameter("@Motivo_Salida", SqlDbType.VarChar);
            SqlParameter Jefe_In = new SqlParameter("@Jefe_In", SqlDbType.VarChar);
            SqlParameter Puesto_Jefe = new SqlParameter("@Puesto_Jefe", SqlDbType.VarChar);
            SqlParameter Telefono_Jefe = new SqlParameter("@Telefono_Jefe", SqlDbType.VarChar);
            SqlParameter Contacto = new SqlParameter("@Contacto", SqlDbType.Bit);
            SqlParameter Comentarios = new SqlParameter("@Comentarios", SqlDbType.VarChar);
            SqlParameter Candidato = new SqlParameter("@id_Candidato", SqlDbType.Int);

            if (cn != null)
            {
                comando.Connection = cn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarHistoriaLaboral";

                Puesto.Value = TBPuesto.Text;
                Empresa.Value = TBEmpre.Text;
                Fecha_I.Value = FechaNac;
                Fecha_T.Value = FechaNac2;
                Area.Value = TBArea.Text;
                Industria.Value = TBIndus.Text;
                Sueldo.Value = TBSueldo.Text;
                Motivo_Salida.Value = TBMSalida.Text;
                Jefe_In.Value = TBJInter.Text;
                Puesto_Jefe.Value = TBPJefe.Text;
                Telefono_Jefe.Value = TBTJefe.Text;
                if (DDLContacto.SelectedIndex == 2)
                { Contacto.Value = 1; }
                else
                { Contacto.Value = DDLContacto.SelectedIndex; }
                Comentarios.Value = TBComent.Text;
                Candidato.Value = IDCandidato;

                comando.Parameters.Add(Puesto);
                comando.Parameters.Add(Empresa);
                comando.Parameters.Add(Fecha_I);
                comando.Parameters.Add(Fecha_T);
                comando.Parameters.Add(Area);
                comando.Parameters.Add(Industria);
                comando.Parameters.Add(Sueldo);
                comando.Parameters.Add(Motivo_Salida);
                comando.Parameters.Add(Jefe_In);
                comando.Parameters.Add(Puesto_Jefe);
                comando.Parameters.Add(Telefono_Jefe);
                comando.Parameters.Add(Contacto);
                comando.Parameters.Add(Comentarios);
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