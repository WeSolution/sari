<%@ Page Title="" Language="C#" MasterPageFile="~/Requisiciones/Requisiciones.master" AutoEventWireup="true" CodeBehind="Busqueda de Requisiciones.aspx.cs" Inherits="Recursos_Materiales.Requisiciones.Busqueda_de_Requisiciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor2" runat="server">
<!DOCTYPE>
<html>
<head id="Head1">
    <title></title>
</head>
<body>
    <form id="form1">
    <div class="page-header">Busqueda de Requisicion</div>
    <p>
        Lista de Requisiciones</p>
    <p>
    <asp:GridView CssClass="form-control" ID="GVListaRequisicion" runat="server" 
                CellPadding="4" ForeColor="#333333" GridLines="None"
                onpageindexchanging="GVListaRequisicion_PageIndexChanging" 
            onselectedindexchanged="GVListaRequisicion_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Ver" 
                    ShowSelectButton="True" />
                </Columns>
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
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
</asp:Content>
