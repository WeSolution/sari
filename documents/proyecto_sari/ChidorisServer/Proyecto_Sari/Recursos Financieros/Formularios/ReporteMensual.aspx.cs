using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using System.Diagnostics;
using Recursos_Financieros.Clases;

namespace Recursos_Financieros.Formularios
{
    public partial class ReporteMensual : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public int mes;
        public int año;

        protected void Btn_gen_rep_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Conexion.ConsultarBD bd = new Conexion.ConsultarBD();
                string error = "";
                string mes_nombre = DList_mes.SelectedItem.ToString();
                try
                {
                    string contenido = DocumentoPDF.contenido_doc(mes, mes_nombre, año);
                    Document pdfDoc = DocumentoPDF.Generar_doc(contenido, error);
                    if (error.Length > 0)
                    {
                        Response.Write(error);
                    }
                    else
                    {
                        Response.ContentType = "application/pdf";
                        Response.AddHeader("content-disposition", "attachment; filename=Reporte" + mes_nombre + año + ".pdf");
                        System.Web.HttpContext.Current.Response.Write(pdfDoc);
                        Response.Flush();
                        Response.End();
                    }

                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Conexion.ConsultarBD bd = new Conexion.ConsultarBD();
                //string error = "";
                string mes_nombre = DList_mes.SelectedItem.ToString();
                try
                {
                    string contenido = DocumentoPDF.vista_prev(mes, mes_nombre, año);
                    vista_prev.Text = contenido;

                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }

        }

        private bool Validar()
        {
            DateTime fecha = DateTime.Now;
            int año_sis = fecha.Year;
            if (textAnio.Text.ToString().Length == 4)
            {
                año = Int32.Parse(textAnio.Text.ToString());
                if (año > año_sis)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error año incorrecto')", true);
                    return false;
                }
                else
                {
                    mes = Int32.Parse(DList_mes.SelectedValue);
                    if (mes == 0)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe seleccionar un mes')", true);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('El año debe ser de 4 digitos')", true);
                return false;
            }
        }
    }
}