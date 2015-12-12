<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Recursos_Humanos.Capsule152.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Registro de Informacion</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
    <div>

    <h1> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     &nbsp;&nbsp;&nbsp; Registro de información </h1>
         <p> &nbsp;</p>
            <asp:Label ID="LBNombre" runat="server" Text="Nombre"></asp:Label>
            &nbsp;&nbsp;&nbsp;*&nbsp;&nbsp;&nbsp;&nbsp;
           <!-- <asp:TextBox ID="TBNombre" runat="server" Width="371px"></asp:TextBox>-->
            <asp:TextBox ID="TBNombre1" runat="server" Width="325px" class="form-control"></asp:TextBox>
            <p></p>
            <asp:Label ID= "LBAPaterno" runat ="server" Text="Apellido Paterno"></asp:Label>
             &nbsp;&nbsp;&nbsp;*&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBApaterno" runat="server" Width="301px" class="form-control"></asp:TextBox>
            <p></p>
            <asp:Label ID= "LBAMaterno" runat ="server" Text="Apellido Materno"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;*&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBAmaterno" runat="server" Width="271px" class="form-control"></asp:TextBox>
            <p></p>
            <asp:Label ID= "LBSexo" runat ="server" Text="Sexo"></asp:Label>
             &nbsp;&nbsp;&nbsp;*&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DDLSexo" runat="server" Width="183px" class="form-control">
        </asp:DropDownList>
&nbsp;<p></p>
            <asp:Label ID= "LBFNAC" runat ="server" Text="Fecha de Nacimiento"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*&nbsp;&nbsp;
         <asp:Label ID="LabelDía" runat="server" Text="Día"></asp:Label>
         <asp:DropDownList ID="DDLDia" runat="server">
             <asp:ListItem>1</asp:ListItem>
             <asp:ListItem>2</asp:ListItem>
             <asp:ListItem>3</asp:ListItem>
             <asp:ListItem>4</asp:ListItem>
             <asp:ListItem>5</asp:ListItem>
             <asp:ListItem>6</asp:ListItem>
             <asp:ListItem>7</asp:ListItem>
             <asp:ListItem>8</asp:ListItem>
             <asp:ListItem>9</asp:ListItem>
             <asp:ListItem>10</asp:ListItem>
             <asp:ListItem>11</asp:ListItem>
             <asp:ListItem>12</asp:ListItem>
             <asp:ListItem>13</asp:ListItem>
             <asp:ListItem>14</asp:ListItem>
             <asp:ListItem>15</asp:ListItem>
             <asp:ListItem>16</asp:ListItem>
             <asp:ListItem>17</asp:ListItem>
             <asp:ListItem>18</asp:ListItem>
             <asp:ListItem>19</asp:ListItem>
             <asp:ListItem>20</asp:ListItem>
             <asp:ListItem>21</asp:ListItem>
             <asp:ListItem>22</asp:ListItem>
             <asp:ListItem>23</asp:ListItem>
             <asp:ListItem>24</asp:ListItem>
             <asp:ListItem>25</asp:ListItem>
             <asp:ListItem>26</asp:ListItem>
             <asp:ListItem>27</asp:ListItem>
             <asp:ListItem>28</asp:ListItem>
             <asp:ListItem>29</asp:ListItem>
             <asp:ListItem>30</asp:ListItem>
             <asp:ListItem>31</asp:ListItem>
         </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
         <asp:Label ID="LabelMes" runat="server" Text="Mes"></asp:Label>
         <asp:DropDownList ID="DDLMes" runat="server">
             <asp:ListItem>Enero</asp:ListItem>
             <asp:ListItem>Febrero</asp:ListItem>
             <asp:ListItem>Marzo</asp:ListItem>
             <asp:ListItem>Abril</asp:ListItem>
             <asp:ListItem>Mayo</asp:ListItem>
             <asp:ListItem>Junio</asp:ListItem>
             <asp:ListItem>Julio</asp:ListItem>
             <asp:ListItem>Agosto</asp:ListItem>
             <asp:ListItem>Septiembre</asp:ListItem>
             <asp:ListItem>Octubre</asp:ListItem>
             <asp:ListItem>Noviembre</asp:ListItem>
             <asp:ListItem>Diciembre</asp:ListItem>
         </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
         <asp:Label ID="LabelAno" runat="server" Text="Año"></asp:Label>
         <asp:DropDownList ID="DDLAno" runat="server">
             <asp:ListItem>1990</asp:ListItem>
             <asp:ListItem>1991</asp:ListItem>
             <asp:ListItem>1992</asp:ListItem>
             <asp:ListItem>1993</asp:ListItem>
             <asp:ListItem>1994</asp:ListItem>
             <asp:ListItem>1995</asp:ListItem>
             <asp:ListItem>1996</asp:ListItem>
             <asp:ListItem>1997</asp:ListItem>
             <asp:ListItem>1998</asp:ListItem>
             <asp:ListItem>1999</asp:ListItem>
             <asp:ListItem>2000</asp:ListItem>
             <asp:ListItem>2001</asp:ListItem>
             <asp:ListItem>2002</asp:ListItem>
             <asp:ListItem>2003</asp:ListItem>
             <asp:ListItem>2004</asp:ListItem>
             <asp:ListItem>2005</asp:ListItem>
             <asp:ListItem>2006</asp:ListItem>
             <asp:ListItem>2007</asp:ListItem>
             <asp:ListItem>2008</asp:ListItem>
             <asp:ListItem>2009</asp:ListItem>
             <asp:ListItem>2010</asp:ListItem>
             <asp:ListItem>2011</asp:ListItem>
             <asp:ListItem>2012</asp:ListItem>
             <asp:ListItem>2013</asp:ListItem>
             <asp:ListItem>2014</asp:ListItem>
             <asp:ListItem>2015</asp:ListItem>
         </asp:DropDownList>
         <br />
         <p></p>
         <br />
         &nbsp;<!--<asp:Calendar ID="CalendarFecha_Nac" runat="server"></asp:Calendar>
&nbsp;<p></p>-->&nbsp;
            <asp:Label ID= "LBNacio" runat ="server" Text="Nacionalidad"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*&nbsp;&nbsp;
            <asp:TextBox ID="TBNacio" runat="server" Width="253px" class="form-control"></asp:TextBox>
            <p></p>
            <asp:Label ID= "LBEmail" runat ="server" Text="Correo Electronico"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;*&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBEmail" runat="server" Width="383px" class="form-control"></asp:TextBox>
            <p></p>
            <asp:Label ID= "LBECivil" runat ="server" Text="Estado Civil"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;*&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DDLEstadoCivil" runat="server" Width="242px" class="form-control">
        </asp:DropDownList>
&nbsp;<p></p>
            <asp:Label ID= "LBRFC" runat ="server" Text="RFC"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBRFC" runat="server" Width="242px" MaxLength="13" class="form-control"></asp:TextBox>
            <p></p>
            <asp:Label ID= "LBNIMSS" runat ="server" Text="No IMSS"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBIMSS" runat="server" Width="348px" MaxLength="25" class="form-control"></asp:TextBox>
            <p></p>
            <asp:Label ID= "LBCurp" runat ="server" Text="CURP"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;*&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBCurp" runat="server" Width="362px" MaxLength="18" class="form-control"></asp:TextBox>
            <p></p>
            <asp:Label ID= "LBTEL1" runat ="server" Text="Telefono 1"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;*&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBTel1" runat="server" Width="295px" class="form-control"></asp:TextBox>
            <p></p>
            <asp:Label ID= "LBTEL2" runat ="server" Text="Telefono 2"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TBTel2" runat="server" Width="292px" class="form-control"></asp:TextBox>
            <p></p>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<p>&nbsp;</p>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Button ID="ButtonSiguiente" runat="server" onclick="Button1_Click" Text="Siguiente" class="btn btn-lg btn-primary btn-block" />

    </div>
</asp:Content>
