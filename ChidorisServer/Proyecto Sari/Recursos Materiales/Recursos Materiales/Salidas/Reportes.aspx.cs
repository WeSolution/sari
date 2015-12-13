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
            GridView1.DataSource = con.Consultas("select s.id_salida as Folio,s.fecha as Fecha,s.hora as Hora,p.nombre as Producto,ds.no_articulos as Cantidad,e.nombre + ' ' + e.apellido_p + ' ' + e.apellido_m as Solicitante, s.descripcion as Descripción " +
                    " from salida as s, detalle_salida as ds, producto as p, empleado as e " +
                    " where s.id_salida = ds.id_salida and p.id_producto = ds.id_producto");
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
            "attachment;filename=Reporte de Entradas.doc");
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
            "attachment;filename=Reporte de Entradas.xls");
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
            GridView1.HeaderRow.Cells[5].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[6].Style.Add("background-color", "green");


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
                    row.Cells[5].Style.Add("background-color", "#C2D69B");
                    row.Cells[6].Style.Add("background-color", "#C2D69B");
                }
            }
            GridView1.RenderControl(hw);

            string style = @"<style> .textmode { mso-number-format:\@; } </style>";
            Response.Write(style);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
    }
}