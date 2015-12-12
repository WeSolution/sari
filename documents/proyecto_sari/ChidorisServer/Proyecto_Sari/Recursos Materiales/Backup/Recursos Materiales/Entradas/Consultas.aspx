<%@ Page Title="" Language="C#" MasterPageFile="~/Entradas/Entradas.master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="Recursos_Materiales.Entradas.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
<form>
    <div class="container">
    <h1 class="page-header">Consulta de Entradas</h1>
    <br />
        <div class"form-group">
            <div class="col-md-6">
                <b><big><asp:Label ID="Label3" runat="server" Text="Del" autocomplete="off"></asp:Label></big></b>
                <asp:Calendar CssClass="form-control" ID="Cal1" runat="server"></asp:Calendar>
            </div>
            <div class="col-md-6">
                <b><big><asp:Label ID="Label1" runat="server" Text="A"></asp:Label></big></b>
                <asp:Calendar CssClass="form-control" ID="Cal2" runat="server"></asp:Calendar>
                <br />
                <br />
                <br />
            </div>
        </div>
        <div class="form-group">
            <asp:GridView CssClass="form-control" ID="GridView1" runat="server" 
                CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <br />
            <br />
            <br />
        </div>
        <div class="form-group">
            <asp:Button CssClass="form-control" ID="btnBuscar" runat="server" Text="Buscar" 
                onclick="btnBuscar_Click" />
        </div>
    </div>
</form>
</asp:Content>
