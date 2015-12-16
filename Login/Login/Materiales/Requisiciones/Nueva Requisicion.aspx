<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/Requisiciones/Requisiciones.master" EnableEventValidation="false"   AutoEventWireup="true" CodeBehind="Nueva Requisicion.aspx.cs" Inherits="Recursos_Materiales.Requisiciones.Nueva_Requisicion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor2" runat="server">
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head id="Head1">
    <title></title>
    <style type="text/css">
        .style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1"">
    <p class="style1">
        LISTA DE PRODUCTOS Y SERVICIOS</p>
    <p class="style1">
        <asp:RadioButton ID="rbtproducto" runat="server" 
            oncheckedchanged="rbtproducto_CheckedChanged" Text="Productos" 
            GroupName="mostrar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rbtservicio" runat="server" 
            oncheckedchanged="rbtservicio_CheckedChanged" Text="Servicios" 
            GroupName="mostrar" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnVer" runat="server" onclick="btnVer_Click" Text="Ver" 
            Width="72px" />
    </p>
    <p class="style1">
        &nbsp;</p>
    <p class="style1">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
            CellPadding="4" 
            onpageindexchanging="GridView1_PageIndexChanging" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" Width="100%">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
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
    <p>
        &nbsp;</p>
    </form>
</body>
</html>

</asp:Content>
