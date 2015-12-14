<%@ Page Title="" Language="C#" MasterPageFile="~/RH2/Principal.Master" AutoEventWireup="true" CodeBehind="Direccion.aspx.cs" Inherits="Recursos_Humanos.Capsule152.Direccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title> Registro de Informacion</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
    <div>
    
    <h1> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Registro de Direccion</h1>
    <asp:Label ID="LBCalle" runat="server" Text="Calle"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBCalle" runat="server" class="form-control" Width="371px"></asp:TextBox>
            <p> </p>
            <asp:Label ID="LBNint"  runat="server" Text="Número Interior"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBNoInt" class="form-control" runat="server" Width="371px"></asp:TextBox>
            <p></p>
            <asp:Label ID="LBNExt" runat="server" Text="Número Exterior"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBNoExt" runat="server" class="form-control" Width="371px"></asp:TextBox>
            <p></p>
            <asp:Label ID="LBColonia" runat="server" Text="Colonia"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBColonia" runat="server" class="form-control" Width="371px"></asp:TextBox>
            <p></p>
            <asp:Label ID="LBCP" runat="server" Text="Código Postal"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBCP" runat="server" class="form-control" Width="371px"></asp:TextBox>
            <p></p>
            <asp:Label ID="LBCiudad" runat="server" Text="Ciudad"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBCiudad" runat="server" class="form-control" Width="371px"></asp:TextBox>
            <p></p>
            <asp:Label ID="LBPais" runat="server" Text="País"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DDLPais"   runat="server" class="form-control" Width="219px">
        </asp:DropDownList>
&nbsp;<p></p>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Button ID="BNSiguiente2" runat="server" onclick="Button1_Click" class="btn btn-lg btn-primary btn-block" Text="Siguiente" />


    </div>
</asp:Content>
