<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="AltaProveedor.aspx.cs" Inherits="Recursos_Financieros.Formularios.AltaProveedor1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
<br />
<div class="col-md-12"> 
    <div>
        <div class="jumbotron">
        <div class="container">
            <p>Alta Proveedor</p>
                <asp:Label ID="Label1" Text="Nombre" runat="server" />
                <asp:TextBox runat="server" ID="txtnombre"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtnombre" ErrorMessage="Es necesario llenar el campo">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ControlToValidate="txtnombre" ErrorMessage="Escribe solo letras" 
                    MaximumValue="z" MinimumValue="a">*</asp:RangeValidator>
                <br />
                <asp:Label ID="Label2" Text="Telefono 1 " runat="server" />
                <asp:TextBox runat="server" ID="txttel_1"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txttel_1" ErrorMessage="Es necesario llenar el campo">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator2" runat="server" 
                    ControlToValidate="txttel_1" ErrorMessage="Escribe solo letras" 
                    MaximumValue="z" MinimumValue="a">*</asp:RangeValidator>
                <br />
                <asp:Label ID="Label3" Text="Telefono 2 " runat="server" />
                <asp:TextBox runat="server" ID="txttel_2"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txttel_2" ErrorMessage="Es necesario llenar el campo">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator3" runat="server" 
                    ControlToValidate="txttel_2" ErrorMessage="Escribe solo letras" 
                    MaximumValue="z" MinimumValue="a">*</asp:RangeValidator>
                <br />
                <asp:Label ID="Label4" Text="Ciudad" runat="server" />
                <asp:TextBox runat="server" ID="txtciudad"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtciudad" ErrorMessage="Es necesario llenar el campo">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator4" runat="server" 
                    ControlToValidate="txtciudad" ErrorMessage="Escribe solo letras" 
                    MaximumValue="z" MinimumValue="a">*</asp:RangeValidator>
                <br />
                <asp:Label ID="Label5" Text="Dirección" runat="server" />
                <asp:TextBox runat="server" ID="txtdireccion"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtdireccion" ErrorMessage="Es necesario llenar el campo">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator5" runat="server" 
                    ControlToValidate="txtdireccion" ErrorMessage="Escribe solo letras" 
                    MaximumValue="z" MinimumValue="a">*</asp:RangeValidator>
                <br />
                <br />
                <asp:Button ID="Button1" Text="Guardar" runat="server" onclick="Unnamed5_Click" />
            </div>
        </div>
        </div>
        </div>
</asp:Content>
