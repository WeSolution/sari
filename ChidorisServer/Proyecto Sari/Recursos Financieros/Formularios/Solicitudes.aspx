<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="Recursos_Financieros.Formularios.Solicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<%--<head id="Head1" runat="server">--%>
    <title></title>
<%--</head>--%>
<script type="text/javascript" src="../JQuery/jquery-1.11.2.js"></script>
<script type="text/javascript">
    function aceptar(codigo) {
        var actionData = "{'categoria': 'aceptar','id':" + codigo + "}";
        $.ajax({
            type: "POST",                                              // tipo de request que estamos generando
            url: 'solicitudes.aspx/Actualizar',               // URL al que vamos a hacer el pedido
            data: actionData,                                                // data es un arreglo JSON que contiene los parámetros que // van a ser recibidos por la función del servidor
            contentType: "application/json; charset=utf-8",            // tipo de contenido
            dataType: "json",                                          // formato de transmición de datos
            async: true,
            success: function (data) {
                alert(data.d);
            }
        });
    }
    function cancelar(codigo) {
        var actionData = "{'categoria': 'cancelar ','id':" + codigo + "}";

        $.ajax({
            type: "POST",                                              // tipo de request que estamos generando
            url: 'solicitudes.aspx/Actualizar',               // URL al que vamos a hacer el pedido
            data: actionData,                                                // data es un arreglo JSON que contiene los parámetros que // van a ser recibidos por la función del servidor
            contentType: "application/json; charset=utf-8",            // tipo de contenido
            dataType: "json",                                          // formato de transmición de datos
            async: true,
            success: function (data) {
                alert(data.d);
            }
        });
    }
    function rechazar(codigo) {
        var actionData = "{'categoria': 'rechazar','id':" + codigo + "}";

        $.ajax({
            type: "POST",                                              // tipo de request que estamos generando
            url: 'solicitudes.aspx/Actualizar',               // URL al que vamos a hacer el pedido
            data: actionData,                                                // data es un arreglo JSON que contiene los parámetros que // van a ser recibidos por la función del servidor
            contentType: "application/json; charset=utf-8",            // tipo de contenido
            dataType: "json",                                          // formato de transmición de datos
            async: true,
            success: function (data) {
                alert(data.d);
            }
        });
    }

    function obtener_contenido() {
        $('.solicitud').on('click', function (e) {

            var id_usu1 = this.id;
            enviar = "" + id_usu1 + "";
            var actionData = "{'nombre': '" + enviar + "'}";
            e.preventDefault();
            $.ajax({
                type: "POST",                                              // tipo de request que estamos generando
                url: 'solicitudes.aspx/Consulata_Servicios',               // URL al que vamos a hacer el pedido
                data: actionData,                                                // data es un arreglo JSON que contiene los parámetros que // van a ser recibidos por la función del servidor
                contentType: "application/json; charset=utf-8",            // tipo de contenido
                dataType: "json",                                          // formato de transmición de datos
                async: true,
                beforeSend: function () {
                    $('.contenedor').html('');
                    $('.contenedor').html('<img src="animacion.gif" style="padding-left:30%; width:200px; height:200px;"/>');
                },
                success: function (data) 
                    $contenido_html = "";
                    $contenido_html = "<h3>Caracteristicas:<p>" + data.d[1] + "</p></h3>" +
                                       "<h3>Tipo:<p  style='padding:5px padding-left:5px;'>" + data.d[2] + "</p><h3>" +
                                       "<h3>Monto:<p  style='padding:5px padding-left:5px;'> $" + data.d[3] + "</p></h3>" +
                                       "<h3>Fecha:<p  style='padding:5px padding-left:5px;'>" + data.d[4] + "</p></h3>" +
                                       "<h3>Estatus:<p  style='padding:5px padding-left:5px;'>" + data.d[5] + "</p></h3><b/>" +
                                       "<div style='padding-left:100px;'><table border='2px' >" +
                                            "<tr><td style='padding:10px;'><h4>Productos</h4></td>" +
                                            "<td style='padding:10px;'><h4>Servicios</h4></td></tr>" +
                                            "<tr><td>Coca</td><td>Mantenimiento</td></tr>" +
                                       "</table></div><br/>" +
                                       "<div><input id='prueba' onclick='aceptar(" + data.d[0] + ");' style='padding:15px; position: relative; left: 5%;' type='submit' value='Aceptar'>" +
                                       "<input  onclick='rechazar(" + data.d[0] + ");'style='padding:15px; position: relative; left: 15%;' type='submit' value='Rechazar'>" +
                                       "<input onclick='cancelar(" + data.d[0] + ");' style='padding:15px; position: relative; left: 25%;' type='submit' value='Cancelar'></div> <br/>";

                    $('.contenedor').html($contenido_html);
                    var height = $('.contenedor')[0].scrollHeight;
                    $('.contenedor').scrollTop(height);
                }
            });
        });
    }
    window.addEventListener('load', obtener_contenido, false);
</script>
<body>
    <form id="form1">
    <div style="padding-left:5%; padding-bottom:-50px;"  >
        <table style="box-shadow:0px 10px 10px rgba(0,0,0,0.5);" border="2px" cellpadding="0" cellspacing="0">
            <tr>
                <td style="padding:10px;">
                    <h1>
                        Lista de Solicitudes
                    </h1>
                </td>
                <td style="padding:10px; width:60%;">
                    <h1>
                        Contenido 
                    </h1>
                </td>
            </tr>
            <tr>
                <td>                   
                </td>
                <td  rowspan="7" style="position:absolute; border:2px; height:412px; width:435px;">
                    <div class="contenedor" style="overflow:scroll; height:412px; width:435px;">
                    </div>
                </td>
            </tr>
            <div id="listado" runat="server">
            </div>
        </table>
    </div>
    </form>
</body>
</html>
</asp:Content>
