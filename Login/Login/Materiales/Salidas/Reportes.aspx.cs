using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;
using System.IO;

namespace Recursos_Materiales.Salidas
{
    public partial class Reportes : System.Web.UI.Page
    {
        Conexion1 con = new Conexion1();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = con.Consultas("Select id_salida as Folio, Convert(char,fecha,103) as Fecha,Convert(nvarchar,hora,108) as Hora, descripcion as Descripción, nombre + ' ' + apellido_p + ' ' + apellido_m as Empleado  from salida, empleado" +
                    " where salida.id_empleado = empleado.id_empleado");
            GridView1.DataBind();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void btnWord_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition",
            "attachment;filename=Reporte de Entradas - " + DateTime.Now.ToString("dd/MM/yyyy") + " - " + DateTime.Now.ToString("hh:mm:ss") + ".doc");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-word ";
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            GridView1.AllowPaging = false;
            GridView1.DataBind();
            GridView1.RenderControl(hw);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;

            Response.AddHeader("content-disposition",
            "attachment;filename=Reporte de Entradas - " + DateTime.Now.ToString("dd/MM/yyyy") + " - " + DateTime.Now.ToString("hh:mm:ss") + ".xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            GridView1.AllowPaging = false;
            GridView1.DataBind();


            GridView1.HeaderRow.Style.Add("background-color", "#FFFFFF");


            GridView1.HeaderRow.Cells[0].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[1].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[2].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[3].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[4].Style.Add("background-color", "green");


            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridViewRow row = GridView1.Rows[i];


                row.BackColor = System.Drawing.Color.White;


                row.Attributes.Add("class", "textmode");


                if (i % 2 != 0)
                {
                    row.Cells[0].Style.Add("background-color", "#C2D69B");
                    row.Cells[1].Style.Add("background-color", "#C2D69B");
                    row.Cells[2].Style.Add("background-color", "#C2D69B");
                    row.Cells[3].Style.Add("background-color", "#C2D69B");
                    row.Cells[4].Style.Add("background-color", "#C2D69B");
                }
            }
            GridView1.RenderControl(hw);

            string style = @"<style> .textmode { mso-number-format:\@; } </style>";
            Response.Write(style);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }

        protected void btnPdf_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.alert('Proximamente');</script>");
        }
    }
}