<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/Almacén/Catalogo.master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="Recursos_Materiales.Catálogo.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor2" runat="server">
    <form>
<div class="container">
<h1 class="page-header">Almacén</h1>
<div class="form-group">
            <asp:GridView runat="server" CssClass="form-control" ID="GridView1" 
                CellPadding="4" 
                HorizontalAlign="Center" BackColor="White" BorderColor="#3366CC" 
                BorderStyle="None" BorderWidth="1px">
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
            <br />
        </div>
</div>
</form>
</asp:Content>
