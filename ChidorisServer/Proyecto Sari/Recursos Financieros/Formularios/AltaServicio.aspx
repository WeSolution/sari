<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="AltaServicio.aspx.cs" Inherits="Recursos_Financieros.Formularios.AltaProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
<div class="col-md-12"> 
    <div>
        <div class="jumbotron">
            <div class="container">
                     <h2>Nuevo Servicio</h2>
            <div id="div1" style="float:left; width:33.3%">
                     <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                     <br />
                    <asp:Label ID="Label1" Text="Identificador" runat="server" /> 
                    <asp:TextBox ID="txtidentificador" runat="server" />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                         ControlToValidate="txtidentificador" ErrorMessage="Escriba solo letras">*</asp:RequiredFieldValidator>
                     <asp:RangeValidator ID="RangeValidator1" runat="server" 
                         ControlToValidate="txtidentificador" ErrorMessage="Solo letras" 
                         MaximumValue="z " MinimumValue="a ">*</asp:RangeValidator>
                    <br />
                    <asp:Label ID="Label2" Text="Nombre" runat="server" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtnombre" runat="server"/>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                         ControlToValidate="txtnombre" ErrorMessage="Escriba solo letras">*</asp:RequiredFieldValidator>
                     <asp:RangeValidator ID="RangeValidator2" runat="server" 
                         ControlToValidate="txtnombre" ErrorMessage="Escriba solo letras" 
                         MaximumValue="z " MinimumValue="a ">*</asp:RangeValidator>
                    <br />
                    <asp:Label ID="Label3" Text="Descripción" runat="server" />
                    &nbsp;<asp:TextBox ID="txtdescripcion" runat="server" />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                         ControlToValidate="txtdescripcion" ErrorMessage="ingrese solo letras">*</asp:RequiredFieldValidator>
                     <asp:RangeValidator ID="RangeValidator3" runat="server" 
                         ControlToValidate="txtdescripcion" ErrorMessage="Escriba solo letras" 
                         MaximumValue="z " MinimumValue="a ">*</asp:RangeValidator>
                    <br />
                    <asp:Label ID="Label4" Text="Precio" runat="server" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtprecio" runat="server" />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                         ControlToValidate="txtprecio" ErrorMessage="Solo numeros">*</asp:RequiredFieldValidator>
                     <asp:RangeValidator ID="RangeValidator4" runat="server" 
                         ControlToValidate="txtprecio" ErrorMessage="Escriba solo numeros" 
                         MaximumValue="999999" MinimumValue="1">*</asp:RangeValidator>
                    <br />
                    <br />
                    <asp:Button ID="btnguardar" Text="Guardar" runat="server"  onclick="btnguardar_Click" />
                    <asp:Button ID="btncancelar" Text="Cancelar" runat="server" 
                         onclick="btncancelar_Click" />
                </div>
                <div id="div2" style="float:left; width:33.3%">
                    <asp:Label ID="Label5" Text="Proveedor" runat="server" />
                    <br />
                    <select runat="server" ID="cmbproveedor" visible="True"></select>
                    <asp:Button Text="Buscar" runat="server" ID="btnbuscarprov" onclick="btnbuscarprov_Click"/>
                    <br />
                    <span>Datos del Proveedor</span><br />
                    <asp:Label ID="Label6" Text="Nombre" runat="server" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox runat="server" ID="txtnombreprove" Enabled="false"/>
                    <br />
                    <asp:Label ID="Label7" Text="Telefono 1" runat="server" />
                    <asp:TextBox runat="server" ID="txttel1" Enabled="false"/>
                    <br />
                    <asp:Label ID="Label8" Text="Telefono 2" runat="server" />
                    <asp:TextBox runat="server" ID="txttel2" Enabled="false" />
                    <br />
                    <asp:Label ID="Label9" Text="Ciudad" runat="server" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox runat="server" ID="txtciudad" Enabled="false"/>
                    <br />
                    <asp:Label ID="Label10" Text="Dirección" runat="server" />
                    &nbsp;
                    <asp:TextBox runat="server" ID="txtdirecion" Enabled="false"/>
                </div>
   </div>
  </div>
 </div>
</div>
</asp:Content>
