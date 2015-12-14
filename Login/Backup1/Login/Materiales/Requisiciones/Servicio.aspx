<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/Requisiciones/Requisiciones.master" EnableEventValidation="false"  AutoEventWireup="true" CodeBehind="Servicio.aspx.cs" Inherits="Recursos_Materiales.Requisiciones.Servicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor2" runat="server">
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1">
    <title></title>
</head>
<body>
    <form id="form1">
    <div>
    
        DATOS DE SERVICIO SELECCIONADO</div>
    <p>
        Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbid" runat="server"></asp:Label>
    </p>
    <p>
        Identificador:&nbsp;&nbsp;
        <asp:Label ID="lbidentificador" runat="server"></asp:Label>
    </p>
    <p>
        Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbnombre" runat="server"></asp:Label>
    </p>
    <p>
        Descripcion:&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbdescripcion" runat="server"></asp:Label>
    </p>
    <p>
        Precio:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $
        <asp:Label ID="lbprecio" runat="server"></asp:Label>
    </p>
    <p>
        Cantidad a Comprar:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAgregar" runat="server" onclick="btnAgregar_Click" 
            Text="Agregar al Carrito" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnComprar" runat="server" onclick="btnComprar_Click" 
            Text="Revisar Carrito" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRegresar" runat="server" onclick="btnRegresar_Click" 
            Text="Regresar" />
    </p>
    </form>
</body>
</html>
</asp:Content>
