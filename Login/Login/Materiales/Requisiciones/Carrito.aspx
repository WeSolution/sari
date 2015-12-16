<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/Requisiciones/Requisiciones.master" AutoEventWireup="true" EnableEventValidation="false"   CodeBehind="Carrito.aspx.cs" Inherits="Recursos_Materiales.Requisiciones.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor2" runat="server">
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head id="Head1">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1">
    <div>
    
        <div class="style1">
    
        PRODUCTOS EN EL CARRITO<br />
        <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" 
            BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="100%" 
            onrowdeleting="GridView1_RowDeleting" DataKeyNames="CODIGO">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" HeaderText="Eliminar" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    
    </div>
    <p class="style1">
        Importe de productos:&nbsp;&nbsp;
        $
        <asp:Label ID="lbTotal" runat="server"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp; 
    </p>
    <p class="style1">
        DATOS DE PEDIDO</p>
    <p class="style1">
        id de cliente:
        <asp:TextBox ID="txtCliente" runat="server"></asp:TextBox>
    &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Importe Total:&nbsp; $
        <asp:Label ID="lbTotalG" runat="server"></asp:Label>
    </p>
    <div class="style1">
    <asp:Button ID="btnGuardar" runat="server" onclick="btnGuardar_Click" 
        Text="Guardar Pedido" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnRegresar" runat="server" onclick="btnRegresar_Click" 
        Text="Regresar" />
    &nbsp;
        <br />
    <br />
    </div>
    <p class="style1">
        SERVICIOS EN EL CARRITO</p>
    <p>
        <asp:GridView ID="GridView2" runat="server" BackColor="White" 
            BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            Width="100%" DataKeyNames="ID" 
            onrowdeleting="GridView2_RowDeleting" 
            onselectedindexchanged="GridView2_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </p>
    <p class="style1">
        Importe de Servicios:&nbsp; $
        <asp:Label ID="lbTotalS" runat="server"></asp:Label>
    </p>
    </form>
</body>
</html>
</asp:Content>
