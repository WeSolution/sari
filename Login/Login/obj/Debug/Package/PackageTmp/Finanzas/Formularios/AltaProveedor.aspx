﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Finanzas/Principal.Master" AutoEventWireup="true" CodeBehind="AltaProveedor.aspx.cs" Inherits="Recursos_Financieros.Formularios.AltaProveedor1" %>
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
              
                <br />
                <asp:Label ID="Label2" Text="Telefono 1 " runat="server" />
                <asp:TextBox runat="server" ID="txttel_1"/>

                <br />
                <asp:Label ID="Label3" Text="Telefono 2 " runat="server" />
                <asp:TextBox runat="server" ID="txttel_2"/>

                <br />
                <asp:Label ID="Label4" Text="Ciudad" runat="server" />
                <asp:TextBox runat="server" ID="txtciudad"/>
              
                <br />
                <asp:Label ID="Label5" Text="Dirección" runat="server" />
                <asp:TextBox runat="server" ID="txtdireccion"/>
               
                <br />
                <br />
                <asp:Button ID="Button1" Text="Guardar" runat="server" onclick="Unnamed5_Click" />
            </div>
        </div>
        </div>
        </div>
</asp:Content>
