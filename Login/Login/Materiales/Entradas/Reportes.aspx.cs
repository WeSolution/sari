using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Text;
using System.Drawing;


namespace Recursos_Materiales.Entradas
{
    public partial class Reportes : System.Web.UI.Page
    {
        Conexion1 con = new Conexion1();
        private DataTable tab = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            tab = con.Consultas("Select id_entrada as Folio, Convert(char,fecha,103) as Fecha,Convert(nvarchar,hora,108) as Hora,descripcion as Descripción, total as Total," +
                    "nombre as Proveedor from entradas,proveedor where entradas.id_proveedor = proveedor.id_proveedor");
            GridView1.DataSource = tab;
            GridView1.DataBind();
        }

        protected void btnWord_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            try
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
                GridView1.HeaderRow.Cells[5].Style.Add("background-color", "green");


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
                    }
                }
                GridView1.RenderControl(hw);

                string style = @"<style> .textmode { mso-number-format:\@; } </style>";
                Response.Write(style);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
        }

        protected void btnPdf_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.alert('Proximamente');</script>");
        }
    }
}