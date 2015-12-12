<%@ Page Title="" Language="C#" MasterPageFile="~/Finanzas/Principal.Master" AutoEventWireup="true" CodeBehind="AltaProducto.aspx.cs" Inherits="Recursos_Financieros.AltaProducto.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
<div class="col-md-12"> 
    <div>
        <div class="jumbotron">
            <div class="container">
            <h2>Nuevo Producto</h2>
        <div id="div1" style="float:left; width:35%">
                <asp:Label ID="Label2" runat="server" Text="Fecha"></asp:Label>
                <asp:Label ID="lblfecha" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
&nbsp;<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Marca"></asp:Label>
&nbsp;<asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Modelo"></asp:Label>
&nbsp;<asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Descripción"></asp:Label>
&nbsp;<asp:TextBox ID="txtDescripcion" runat="server" Width="248px"></asp:TextBox>
            <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Grupo"></asp:Label>
&nbsp;<asp:DropDownList ID="Grupo" runat="server">
                    <asp:ListItem>Seleccione grupo</asp:ListItem>
                    <asp:ListItem>Mobiliario</asp:ListItem>
                    <asp:ListItem>Papeleria</asp:ListItem>
                    <asp:ListItem>Bebidas</asp:ListItem>
                    <asp:ListItem>Comida</asp:ListItem>
                    <asp:ListItem>Electronicos</asp:ListItem>
                    <asp:ListItem>Maquinaria</asp:ListItem>
                </asp:DropDownList>
            <br />
                <br />
                <asp:Label ID="Label8" runat="server" Text="Precio"></asp:Label>
&nbsp;<asp:TextBox ID="txtPrecioCompra" runat="server"></asp:TextBox>
            <br />
                <br />
                <asp:Label ID="Label9" runat="server" Text="Cantidad"></asp:Label>
&nbsp;<asp:TextBox ID="txtCantidad" runat="server" Width="70px"></asp:TextBox>
            &nbsp;<asp:DropDownList ID="Medida" runat="server">
                    <asp:ListItem>Seleccione medida</asp:ListItem>
                    <asp:ListItem>Pieza(s)</asp:ListItem>
                    <asp:ListItem>Kilogramo(s)</asp:ListItem>
                    <asp:ListItem>Litro(s)</asp:ListItem>
                    <asp:ListItem>Metro(s)</asp:ListItem>
                    <asp:ListItem>Ciento(s)</asp:ListItem>
                    <asp:ListItem>Caja(s)</asp:ListItem>
                    <asp:ListItem>Paquete(s)</asp:ListItem>
                </asp:DropDownList>
            <br />
                <br />
            <%--<p>
                &nbsp;</p>--%>
        </div>
        <div id="div2" style="float:left; width:35%">
            <asp:Label ID="Label11" runat="server" Text="Proveedor"></asp:Label>
            <br />
            <asp:DropDownList ID="Proveedor" runat="server" 
                onselectedindexchanged="Proveedor_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Value="Seleccione proveedor"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="Datos Proveedor"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txtNombreProveedor" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label14" runat="server" Text="Teléfono 1"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtTelefono1" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label15" runat="server" Text="Teléfono 2"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtTelefono2" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label16" runat="server" Text="Ciudad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCiudad" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label17" runat="server" Text="Dirección"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDireccion" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <br />
                <asp:Button ID="Agregar" runat="server" onclick="Agregar_Click" 
                    Text="Agregar" />
        </div>
        <div id="div3" style="float:left; width:30%"></div>
   </div>
  </div>
 </div>
</div>
</asp:Content>
