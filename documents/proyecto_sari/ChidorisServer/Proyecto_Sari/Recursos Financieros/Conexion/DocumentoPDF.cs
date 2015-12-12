using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using Recursos_Financieros.Conexion;

namespace Recursos_Financieros.Clases
{
    public class DocumentoPDF
    {
        //Crea el archivo con extencion .PDF con las especificaciones necesarias
        public static Document Generar_doc(string contenido, string error)
        {
            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
            try
            {
                PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);
                pdfDoc.Open();
                string strContent = contenido;
                var parsedHtmlElements = HTMLWorker.ParseToList(new StringReader(strContent), null);
                foreach (var htmlElement in parsedHtmlElements)
                    pdfDoc.Add(htmlElement as IElement);
                pdfDoc.Close();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
            }
            return pdfDoc;
        }

        //Genera el contenido del documento en una cadena con codigo HTML
        public static string contenido_doc(int mes, string mes_nom, int año)
        {

            string Contenido = "<h3 ALIGN=center>Requisiciones del mes " + mes_nom + " " + año.ToString() + " </h3><br>";
            Contenido += "<TABLE BORDER='1' style='font-size:10px'>";
            Contenido += "<tr>";
            Contenido += "<th align='center' >No. Requi</th>";
            Contenido += "<th align='center'>Caracteristicas</th>";
            Contenido += "<th align='center'>Tipo</th>";
            Contenido += "<th align='center'>Fecha</th>";
            Contenido += "<th align='center'>Estado</th>";
            Contenido += "<th align='center'>Area</th>";
            Contenido += "<th align='center'>Cant Prod</th>";
            Contenido += "<th align='center'>Cant Serv</th>";
            Contenido += "<th align='center'>Total</th>";
            Contenido += "</tr>";
            ConsultarBD bd = new ConsultarBD();
            DataTable datos = bd.MostrarInfRequisision(mes, año);
            string row = "";
            string total = "0";
            foreach (DataRow rows in datos.Rows)
            {
                int id_req = Int32.Parse(rows[0].ToString());
                total = bd.Monto_total(mes, año);
                string cant_pro = bd.Cantidad_productos(id_req);
                string cat_serv = bd.Cantidad_serv(id_req);
                row += "<tr>";
                row += "<td>" + rows[0].ToString() + "</td>";
                row += "<td>" + rows[1].ToString() + "</td>";
                row += "<td>" + rows[2].ToString() + "</td>";
                row += "<td>" + rows[3].ToString() + "</td>";
                row += "<td>" + rows[4].ToString() + "</td>";
                row += "<td>" + rows[5].ToString() + "</td>";
                row += "<td>" + cant_pro + "</td>";
                row += "<td>" + cat_serv + "</td>";
                row += "<td>" + rows[6].ToString() + "</td>";
                row += "</tr>";

            }

            if (row.Length > 0)
            {
                row += "<tr>";
                row += "<th colspan='8' align='right'>TOTAL: </th>";
                row += "<td>" + total + "</td>";
                row += "</tr>";
                Contenido += row;
                Contenido += "</TABLE>";
            }
            else
            {
                Contenido += "</TABLE>";
                Contenido += "<table>";
                Contenido += "<tr><td>Sin registros encontrados</td></tr>";
                Contenido += "</table>";
            }
            return Contenido;
        }

        public static string vista_prev(int mes, string mes_nom, int año)
        {

            string Contenido = "<h4 ALIGN=center>Requisiciones del mes " + mes_nom + " " + año.ToString() + " </h4><br>";
            Contenido += "<TABLE BORDER='1' style='font-size:18px'>";
            Contenido += "<tr>";
            Contenido += "<th align='center' ><span>No. Requi</span></th>";
            Contenido += "<th align='center'><span>Caracteristicas</span></th>";
            Contenido += "<th align='center'><span>Tipo</span></th>";
            Contenido += "<th align='center'><span>Fecha</span></th>";
            Contenido += "<th align='center'><span>Estado</span></th>";
            Contenido += "<th align='center'><span>Area</span></th>";
            Contenido += "<th align='center'><span>Cant Prod</span></th>";
            Contenido += "<th align='center'><span>Cant Serv</span></th>";
            Contenido += "<th align='center'><span>Total</span></th>";
            Contenido += "</tr>";
            ConsultarBD bd = new ConsultarBD();
            DataTable datos = bd.MostrarInfRequisision(mes, año);
            string row = "";
            string total = "0";
            foreach (DataRow rows in datos.Rows)
            {
                int id_req = Int32.Parse(rows[0].ToString());
                total = bd.Monto_total(mes, año);
                string cant_pro = bd.Cantidad_productos(id_req);
                string cat_serv = bd.Cantidad_serv(id_req);
                row += "<tr>";
                row += "<td>" + rows[0].ToString() + "</td>";
                row += "<td>" + rows[1].ToString() + "</td>";
                row += "<td>" + rows[2].ToString() + "</td>";
                row += "<td>" + rows[3].ToString() + "</td>";
                row += "<td>" + rows[4].ToString() + "</td>";
                row += "<td>" + rows[5].ToString() + "</td>";
                row += "<td>" + cant_pro + "</td>";
                row += "<td>" + cat_serv + "</td>";
                row += "<td>" + rows[6].ToString() + "</td>";
                row += "</tr>";

            }

            if (row.Length > 0)
            {
                row += "<tr>";
                row += "<th colspan='8' align='right'>TOTAL: </th>";
                row += "<td>" + total + "</td>";
                row += "</tr>";
                Contenido += row;
                Contenido += "</TABLE>";
            }
            else
            {
                Contenido += "</TABLE>";
                Contenido += "<table>";
                Contenido += "<tr><td>Sin registros encontrados</td></tr>";
                Contenido += "</table>";
            }
            return Contenido;
        }
    }
}