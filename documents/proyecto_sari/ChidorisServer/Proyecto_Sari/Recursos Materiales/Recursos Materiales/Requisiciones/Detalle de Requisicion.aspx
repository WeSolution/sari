<%@ Page Title="" Language="C#" MasterPageFile="~/Requisiciones/Requisiciones.master" AutoEventWireup="true" CodeBehind="Detalle de Requisicion.aspx.cs" Inherits="Recursos_Materiales.Requisiciones.Detalle_de_Requisicion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor2" runat="server">
<!DOCTYPE>

<html>
<head id="Head1">
    <title></title>
</head>
<body>
    <form id="form1">
    <div>
    
        Detalles de la Requisicion</div>
    <p>
        ID de la Requisicion:
        <asp:Label ID="lbIdrequisicion" runat="server"></asp:Label>
        <br />
        Caracteristicas: 
        <asp:Label ID="lbCaracteristicas" runat="server"></asp:Label>
        <br />
        Tipo:
        <asp:Label ID="lbTipo" runat="server"></asp:Label>
        <br />
        Monto:
        <asp:Label ID="lbMonto" runat="server"></asp:Label>
        <br />
        Fecha:
        <asp:Label ID="lbFecha" runat="server"></asp:Label>
        <br />
        Status:
        <asp:Label ID="lbStatus" runat="server"></asp:Label>
        <br />
        ID del Cliente:&nbsp;<asp:Label ID="lbIdusuario" runat="server"></asp:Label>
    </p>
    <p>
       Lista de Productos:</p>
    <p>
        <asp:GridView ID="GVListaPS" runat="server" CellPadding="4" 
            ForeColor="#333333" GridLines="None" 
            onselectedindexchanged="GVListaPS_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </p>
    <p>
        Lista de Servicios:</p>
    <p>
        <asp:GridView ID="GVListaServicios" runat="server" CellPadding="4" 
            ForeColor="#333333" GridLines="None" 
            onselectedindexchanged="GVListaServicios_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="btnRegresar" runat="server" onclick="btnRegresar_Click" 
            Text="Regresar" Width="145px" />
    </p>
    </form>
    </body>
</html>

</asp:Content>
