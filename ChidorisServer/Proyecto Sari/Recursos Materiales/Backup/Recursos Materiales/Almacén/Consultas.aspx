<%@ Page Title="" Language="C#" MasterPageFile="~/Almacén/Catalogo.master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="Recursos_Materiales.Catálogo.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor2" runat="server">
    <form>
<div class="container">
<h1 class="page-header">Almacén</h1>
<div class="form-group">
            <asp:GridView runat="server" CssClass="form-control" ID="GridView1" 
                CellPadding="4" ForeColor="#333333" GridLines="None" 
                HorizontalAlign="Center">
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
        </div>
</div>
</form>
</asp:Content>
