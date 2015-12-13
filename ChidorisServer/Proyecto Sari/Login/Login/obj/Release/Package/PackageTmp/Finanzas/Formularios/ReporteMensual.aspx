<%@ Page Title="" Language="C#" MasterPageFile="~/Finanzas/Principal.Master" AutoEventWireup="true" CodeBehind="ReporteMensual.aspx.cs" Inherits="Recursos_Financieros.Formularios.ReporteMensual" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
<div class="col-md-12"> 
    <div>
        <div class="jumbotron">
            <div class="container">
Mes:
    <asp:DropDownList ID="DList_mes" runat="server" Height="19px" Width="117px">
        <asp:ListItem Value="1">Enero</asp:ListItem>
        <asp:ListItem Value="2">Febrero</asp:ListItem>
        <asp:ListItem Value="3">Marzo</asp:ListItem>
        <asp:ListItem Value="4">Abril</asp:ListItem>
        <asp:ListItem Value="5">Mayo</asp:ListItem>
        <asp:ListItem Value="6">Junio</asp:ListItem>
        <asp:ListItem Value="7">Julio</asp:ListItem>
        <asp:ListItem Value="8">Agosto</asp:ListItem>
        <asp:ListItem Value="9">Septiembre</asp:ListItem>
        <asp:ListItem Value="10">Octubre</asp:ListItem>
        <asp:ListItem Value="11">Noviembre</asp:ListItem>
        <asp:ListItem Value="12">Diciembre</asp:ListItem>
        <asp:ListItem Selected="True" Value="0">Selecionar</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    Año&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="textAnio" runat="server" 
        MaxLength="4"  Width="128px" TextMode="Number"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
        ID="btn_generar_r" runat="server" onclick="Button1_Click" 
        Text="Generar Reporte" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="vista_prev" runat="server" Text="Vista previa"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Button ID="Btn_descargar"  runat="server" onclick="Btn_gen_rep_Click" 
        Text="Descargar" />
    <br />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
