<%@ Page Title="" Language="C#" MasterPageFile="~/RH/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="Candidatos.aspx.cs" Inherits="Login.RH.Candidatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin:0 auto 0 auto; width:745px;">
        <br />
        <asp:Label ID="Label45" runat="server" Text="Seleccinar Candidato:"></asp:Label>
        &nbsp;<asp:DropDownList ID="cbCandidatos" runat="server" Height="23px" Width="530px" AutoPostBack="True" OnSelectedIndexChanged="cbCandidatos_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label46" runat="server" Text="Estatus del Registro: "></asp:Label>
        <asp:DropDownList ID="cbEstatus" runat="server" Height="23px" Width="203px" AutoPostBack="True" OnSelectedIndexChanged="cbEstatus_SelectedIndexChanged">
            <asp:ListItem>Candidato</asp:ListItem>
            <asp:ListItem>Empleado</asp:ListItem>
        </asp:DropDownList>
        <br />
    </div>
                <hr __designer:mapid="712" />

    <br />
    <p>
 <asp:Label ID="Label9" runat="server" Text="CURP:"></asp:Label>
        <asp:TextBox ID="txtCurl" runat="server" Width="250px" CssClass="text-uppercase" Enabled="False"></asp:TextBox>
         <asp:Label ID="Label15" runat="server" Text="RFC:"></asp:Label>
        <asp:TextBox ID="txtRFC" runat="server" Width="250px" CssClass="text-uppercase" Enabled="False"></asp:TextBox>
        
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" Width="250px" CssClass="text-capitalize" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Apellido Paterno:"></asp:Label>
        <asp:TextBox ID="txtApaterno" runat="server" Width="228px" CssClass="text-capitalize" Enabled="False"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Apellido Materno:"></asp:Label>
        <asp:TextBox ID="txtAmaterno" runat="server" Width="208px" CssClass="text-capitalize" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
        <asp:TextBox ID="txtFnac"  runat="server" Height="24px" Width="189px" Enabled="False"></asp:TextBox>

    &nbsp;<asp:Label ID="Label16" runat="server" Text="Estado Civil:" style=" top: 422px; left: 222px; " Height="24px" Width="80px"></asp:Label>
    <asp:TextBox ID="txtEstadoCivil" runat="server" CssClass="text-capitalize" Enabled="False" ></asp:TextBox>

    </p>
    <asp:Label ID="Label13" runat="server" Text="Area:" style=" top: 422px; left: 78px; width: 34px;"></asp:Label>
    <asp:TextBox ID="txtArea" runat="server" style=" top: 418px; left: 118px; width: 94px;" CssClass="text-capitalize" Enabled="False"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador8" runat="server" ControlToValidate="txtArea" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
    <asp:Label ID="Label14" runat="server" Text="Puesto:" style=" top: 422px; left: 222px; width: 40px;"></asp:Label>
    <asp:TextBox ID="txtPuesto" runat="server" style=" top: 418px; left: 270px; width: 121px;" CssClass="text-capitalize" Enabled="False"></asp:TextBox>
    
        &nbsp;&nbsp;<asp:RequiredFieldValidator ID="Validador9" runat="server" ControlToValidate="txtPuesto" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
         &nbsp;&nbsp;
    
        <asp:RadioButtonList ID="rbSexo" runat="server" RepeatDirection="Horizontal" Width="165px" RepeatLayout="Flow" Enabled="False">
            <asp:ListItem Selected="True">Hombre</asp:ListItem>
            <asp:ListItem>Mujer</asp:ListItem>
        </asp:RadioButtonList>
    
    <br/>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Pais:"></asp:Label>
        <asp:TextBox ID="txtPais" runat="server" CssClass="text-capitalize" Enabled="False"></asp:TextBox>
        
    &nbsp;<asp:Label ID="Label6" runat="server" Text="Estado/Provincia:"></asp:Label>
        <asp:TextBox ID="txtestado" runat="server" CssClass="text-capitalize" Enabled="False"></asp:TextBox>
        
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Codigo Postal:"></asp:Label>
        <asp:TextBox ID="txtcp" runat="server" type="number" Width="103px" Enabled="False"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="Colonia:"></asp:Label>
        <asp:TextBox ID="txtColonia" runat="server" CssClass="text-capitalize" Height="23px" Width="348px" Enabled="False"></asp:TextBox>
    </p>
    <p>

        <asp:Label ID="Label10" runat="server" Text="Calle"></asp:Label>
        <asp:TextBox ID="txtcalle" runat="server" CssClass="text-capitalize" Height="23px" Width="258px" Enabled="False"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" Text="No. Exterior:"></asp:Label>
        <asp:TextBox ID="txtnexterior" runat="server" type="number" Width="88px" Enabled="False"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" Text="No. Interior:"></asp:Label>
        <asp:TextBox ID="txtninterior" runat="server" Height="23px" Width="102px" Enabled="False"></asp:TextBox>

        </p>
                <hr __designer:mapid="712" />
        <div align="right">
                <asp:Button ID="btnGuardar" class="btn btn-primary" runat="server" OnClick="btnGuardar_Click" Text="Cambiar Estatus" Enabled="False" ValidationGroup="InformacionPersonal" />
            </div>
    
    <br />
    
</asp:Content>
