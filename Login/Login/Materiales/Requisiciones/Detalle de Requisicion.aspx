<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/Requisiciones/Requisiciones.master" EnableEventValidation="false"   AutoEventWireup="true" CodeBehind="Detalle de Requisicion.aspx.cs" Inherits="Recursos_Materiales.Requisiciones.Detalle_de_Requisicion" %>
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
            onselectedindexchanged="GVListaPS_SelectedIndexChanged" BackColor="White" 
            BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
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
    <p>
        Lista de Servicios:</p>
    <p>
        <asp:GridView ID="GVListaServicios" runat="server" CellPadding="4" 
            onselectedindexchanged="GVListaServicios_SelectedIndexChanged" 
            BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
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
    <p>
        <asp:Button ID="btnRegresar" runat="server" onclick="btnRegresar_Click" 
            Text="Regresar" Width="145px" />
    </p>
    </form>
    </body>
</html>

</asp:Content>
