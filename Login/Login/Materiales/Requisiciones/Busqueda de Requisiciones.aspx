<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/Requisiciones/Requisiciones.master" EnableEventValidation="false"   AutoEventWireup="true" CodeBehind="Busqueda de Requisiciones.aspx.cs" Inherits="Recursos_Materiales.Requisiciones.Busqueda_de_Requisiciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor2" runat="server">
<!DOCTYPE>
<html>
<head id="Head1">
    <title></title>
</head>
<body>
    <form id="form1">
    <h1 class="page-header">Busqueda de Requisicion</h1>
    <h3 class="page-header">Lista de Requisiciones</h3>
    <asp:GridView CssClass="form-control" ID="GVListaRequisicion" runat="server" 
                CellPadding="4"
                onpageindexchanging="GVListaRequisicion_PageIndexChanging" 
            onselectedindexchanged="GVListaRequisicion_SelectedIndexChanged" 
            BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Detalles" 
                    ShowSelectButton="True" />
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
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
</asp:Content>
