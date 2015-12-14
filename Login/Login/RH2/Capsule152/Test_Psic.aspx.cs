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
    public partial class Test_Psic : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                AgregarPreguntas();
            }
        }

        private void AgregarRespuestas(int Pregunta)
        {
            var content = Page.Master.FindControl("Contenedor");
            List<RadioButtonList> kjshkdjha = new List<RadioButtonList>();
            foreach (Control c in content.Controls)
            {
                if (c is RadioButtonList)
                    kjshkdjha.Add(c as RadioButtonList);
            }
            SqlDataReader contenedor;
            SqlConnection cn = S.Conect(ref men);
            String sentencia = "SELECT Respuesta from Respuestas_Test where Pregunta ="+ Pregunta +";";

            if (cn != null)
            {
                contenedor = S.ConsultaDR(sentencia, ref men);
                if (contenedor != null)
                {
                    while (contenedor.Read())
                    {
                        kjshkdjha[Pregunta -1].Items.Add(contenedor[0].ToString());
                        //String Hmm = "RBLPregunta" + Pregunta;
                        //RadioButtonList radios = (RadioButtonList)this.FindControl(Hmm);
                        //radios.Items.Add(contenedor[0].ToString());
                    }
                }
                cn.Close();
            }
        }

        private void AgregarPreguntas()
        {
            var content = Page.Master.FindControl("Contenedor");
            List<Label> kjshkdjha = new List<Label>();
            foreach (Control c in content.Controls)
            {
                if (c is Label)
                    kjshkdjha.Add(c as Label);
            }
            SqlDataReader contenedor;
            SqlConnection cn = S.Conect(ref men);
            String sentencia = "SELECT Pregunta from Preguntas_Test;";
            int a = 0;

            if (cn != null)
            {
                contenedor = S.ConsultaDR(sentencia, ref men);
                if (contenedor != null)
                {
                    while (contenedor.Read())
                    {
                        kjshkdjha[a].Text = contenedor[0].ToString();
                        AgregarRespuestas(a+1);
                        a++;
                        //Label nuevo;
                        //String Hmm = "Pregunta" + a;
                        //nuevo = (Label)FindControl("Pregunta1");
                        //nuevo.Text = contenedor[0].ToString();
                        //AgregarRespuestas(a);
                        //a++;

                    }
                }
                cn.Close();
            }
        }

        private int Calificar(int Pregunta)
        {
            int Valor=0;
            SqlDataReader contenedor;
           SqlConnection cn = S.Conect(ref men);
            String sentencia = "SELECT Valor from Preguntas_Test where id_Pregunta = "+ Pregunta + ";";

            if (cn != null)
            {
                contenedor = S.ConsultaDR(sentencia, ref men);
                if (contenedor != null)
                {
                    while (contenedor.Read())
                    {
                        Valor = Convert.ToInt32(contenedor[0].ToString());
                    }
                }
                cn.Close();
            }
            return Valor;
        }

        private void Update(int v1, int v2, int v3, int v4, int v5)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            String Sentencia = "UPDATE Candidatos set Candidatos.Cali_Hab_Sup = " + v1 +
                ", Candidatos.Cali_Cap_Dec = " + v2 +
                ", Candidatos.Cali_Cap_Eva = " + v3 +
                ", Candidatos.Cali_Hab_ERI = " + v4 +
                ", Candidatos.Cali_Sen_Com = " + v5 +
                "where id_Candidato = " + IDCandidato + ";";
            S.Modify(Sentencia, ref men);
        }

        protected void BTNFinish_Click(object sender, EventArgs e)
        {
            int Valor1 = 0;
            int Valor2 = 0;
            int Valor3 = 0;
            int Valor4 = 0;
            int Valor5 = 0;
            int Pregunta = 1;
            #region Calificaciones
            if (RBLPregunta1.SelectedIndex == 2)
            {
                Valor4 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta2.SelectedIndex == 1)
            {
                Valor1 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta3.SelectedIndex == 3)
            {
                Valor1 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta4.SelectedIndex == 1)
            {
                Valor2 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta5.SelectedIndex == 1)
            {
                Valor5 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta6.SelectedIndex == 1)
            {
                Valor2 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta7.SelectedIndex == 1)
            {
                Valor3 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta8.SelectedIndex == 1)
            {
                Valor5 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta9.SelectedIndex == 2)
            {
                Valor3 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta10.SelectedIndex == 2)
            {
                Valor4 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta11.SelectedIndex == 0)
            {
                Valor4 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta12.SelectedIndex == 2)
            {
                Valor3 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta13.SelectedIndex == 3)
            {
                Valor4 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta14.SelectedIndex == 3)
            {
                Valor3 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta15.SelectedIndex == 3)
            {
                Valor5 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta16.SelectedIndex == 3)
            {
                Valor1 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta17.SelectedIndex == 1)
            {
                Valor5 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta18.SelectedIndex == 3)
            {
                Valor1 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta19.SelectedIndex == 2)
            {
                Valor3 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta20.SelectedIndex == 1)
            {
                Valor2 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta21.SelectedIndex == 0)
            {
                Valor3 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta22.SelectedIndex == 0)
            {
                Valor5 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta23.SelectedIndex == 0)
            {
                Valor2 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta24.SelectedIndex == 3)
            {
                Valor1 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta25.SelectedIndex == 1)
            {
                Valor4 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta26.SelectedIndex == 2)
            {
                Valor3 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta27.SelectedIndex == 0)
            {
                Valor3 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta28.SelectedIndex == 2)
            {
                Valor5 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta29.SelectedIndex == 0)
            {
                Valor2 += Calificar(Pregunta);
            }
            Pregunta++;
            if (RBLPregunta30.SelectedIndex == 3)
            {
                Valor1 += Calificar(Pregunta);
            }
            #endregion
            ClientScript.RegisterStartupScript(GetType(), "Loading", "mostrar_procesar()", true);
            String mensaje = "Las calificaciones son las siguientes: /n" +
                "Habilidad de Supervision " + Valor1 + "% /n" +
                "Capacidad de decicion en las relaciones humanas " + Valor2 + "% /n" +
                "Capacidad de evaluacion de problemas interpersonales " + Valor3 + "% /n" +
                "Habilidad para establecer relaciones interpersonales " + Valor4 + "% /n" +
                "Sentido común y tacto en las relaciones interpersonales " + Valor5 + "% /n";
            MessageBox.Show(this, mensaje);
            Update(Valor1, Valor2, Valor3, Valor4, Valor5);
            MessageBox.Show(this, "Gracias por participar! \n Nosotros le llamamos. :D");
            Response.Redirect("/RH2/Default.aspx");
        }
    }
}