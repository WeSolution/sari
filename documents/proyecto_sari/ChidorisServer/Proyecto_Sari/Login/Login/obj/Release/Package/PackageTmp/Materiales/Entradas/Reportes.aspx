<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/Entradas/Entradas.master" AutoEventWireup="true" EnableEventValidation="false"   CodeBehind="Reportes.aspx.cs" Inherits="Recursos_Materiales.Entradas.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
<form>
<div class="container">
<h1 class="page-header">Reporte de Entradas</h1>
<div class="form-group">
            <asp:GridView runat="server" CssClass="form-control" ID="GridView1" 
                CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" 
                BorderWidth="1px">
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
        <div class="form-group">
            <div class="col-md-4">
            <br />
                <asp:Button CssClass="btn-success" ID="btnWord" runat="server" 
                    CausesValidation="false" Text="Generar Reporte WORD" 
                    onclick="btnWord_Click" Width="315px"/>
            </div>
            <div class="col-md-4">
            <br />
                <asp:Button CssClass="btn-success" ID="btnPdf" runat="server" 
                    CausesValidation="false" Text="Generar Reporte PDF" 
                    Width="315px" onclick="btnPdf_Click"/>
            </div>
            <div class="col-md-4">
            <br />
                <asp:Button CssClass="btn-success" ID="btnExcel" runat="server" 
                    CausesValidation="false" Text="Generar Reporte EXCEL" 
                    onclick="btnExcel_Click" Width="315px"/>
            </div>
        </div>
</div>
</form>
</asp:Content>
