<%@ Page Title="" Language="C#" MasterPageFile="~/RH/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="SARI.Consulta" %>
<%@ Register assembly="Obout.Ajax.UI" namespace="Obout.Ajax.UI.FileManager" tagprefix="obout" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="obout_Grid_NET" namespace="Obout.Grid" tagprefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div style="margin:0 auto 0 auto; width:85%;">
            <center>
        <asp:Label ID="Label1" runat="server" Text="Consultar:"></asp:Label>
        &nbsp;
        <asp:DropDownList ID="cbMain" runat="server" Height="28px" Width="170px" AutoPostBack="True" OnSelectedIndexChanged="cbMain_SelectedIndexChanged">
            <asp:ListItem>Selecciona una opcion</asp:ListItem>
            <asp:ListItem>Empleado</asp:ListItem>
            <asp:ListItem>Direccion</asp:ListItem>
            <asp:ListItem>Telefono</asp:ListItem>
            <asp:ListItem>Idioma</asp:ListItem>
            <asp:ListItem>Informacion Academica</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:Label ID="lbl1" runat="server" Text="Filtrar por:" Visible="False"></asp:Label>
&nbsp;<asp:DropDownList ID="cbFiltro" runat="server" Height="28px" Width="172px" AutoPostBack="True" OnSelectedIndexChanged="cbFiltro_SelectedIndexChanged" Visible="False">
        </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="cbOption" runat="server" Height="28px" Width="172px" AutoPostBack="True" OnSelectedIndexChanged="cbFiltro_SelectedIndexChanged" Visible="False">
                <asp:ListItem Value="1">Sea igual a:</asp:ListItem>
                <asp:ListItem Value="2">Sea diferente a:</asp:ListItem>
                <asp:ListItem Value="3">Mayor que:</asp:ListItem>
                <asp:ListItem Value="4">Menor que:</asp:ListItem>
                <asp:ListItem Value="5">Menor igual que:</asp:ListItem>
                <asp:ListItem Value="6">Mayor igual que:</asp:ListItem>
                <asp:ListItem Value="7">Inicia con:</asp:ListItem>
                <asp:ListItem Value="8">Termina con:</asp:ListItem>
                <asp:ListItem Value="9">Contiene:</asp:ListItem>
                <asp:ListItem Value="10">No contiene</asp:ListItem>
                <asp:ListItem Value="11">Esta Vacio:</asp:ListItem>
                <asp:ListItem Value="12">No esta Vacio</asp:ListItem>
        </asp:DropDownList>
            &nbsp;
            <asp:TextBox ID="txtparametro" runat="server" Visible="False"></asp:TextBox>
        
         <asp:RequiredFieldValidator ID="Validador2" runat="server" ControlToValidate="txtparametro" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="parametros" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
        
            <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/RH/images/1422279573_filter-32.png" OnClick="btnSearch_Click" Visible="False" ValidationGroup="parametros" />
            &nbsp;<br />
               
                </center>
            </div>
            <hr/>
        
        <p>

            </p>
         <div style="margin:0 auto 0 auto; width:90%;">
        <cc2:Grid ID="gvTabla" runat="server" Height="450px" Width="100%" AllowAddingRecords="False" AllowFiltering="True" AllowKeyNavigation="True" AllowManualPaging="True" AllowMultiRecordSelection="False" AllowPageSizeSelection="False" ShowMultiPageGroupsInfo="False" ShowTotalNumberOfPages="True" EmbedFilterInSortExpression="True" FilterType="ProgrammaticOnly">
            <FilteringSettings InitialState="Visible" MatchingType="AnyFilter" />
            <LocalizationSettings LoadingText="Cargando datos de S.A.R.I..." NoRecordsText="No hay Datos en la consulta a S.A.R.I." Paging_ManualPagingLink="Ir a pagina »" Paging_OfText="de" Paging_PagesText="Pagina:" Paging_RecordsText="Registros:" Paging_TotalNumberOfPages=" (de XXXXX)" />
            <ScrollingSettings ScrollWidth="100%" />
        </cc2:Grid>
        <br />
             </div>
        </div>
            <hr/>
        
        </asp:Content>
