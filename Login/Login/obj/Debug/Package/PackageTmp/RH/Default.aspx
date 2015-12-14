<%@ Page Title="" Language="C#" MasterPageFile="~/RH/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Recursos_Humanos.MasterPage.Default" %>
<%@ MasterType  virtualPath="~/RH/MasterPage/Principal.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="MainContent">
    <div>
        <div class="jumbotron">
            <div class="container">
                <h1 class="text-center">Recursos Humanos</h1>
                <p class="MsoNormal">
                    <span>En el área de Recursos Humanos, usted podrá Administrar la&nbsp; información de su capital humano teniendo como principal objetivo optimizar el proceso de alta y manejo de la información de sus trabajadores.</span><o:p></o:p></p>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4" style="display:table-cell; vertical-align:middle; text-align:center">
                <img align="center" class="img-responsive" height="80" src="images/empleado.png" width="80" />
                <br />
                <big><b>
                <p class="text-center">
                    Nuevo Empleado</p>
                </b></big>
                <p class="text-center">
                    Esta opción permite agregar toda la información relacionada al empleado.</p>
            </div>
            <div class="col-md-4">
                <img align="center" class="img-responsive" height="80" src="images/consulta%20(2).png" width="80" />
                <br />
                <big><b>
                <p class="text-center">
                    Buscar Empleado</p>
                </b></big>
                <p class="text-center">
                    Busca un registro específico de la base de datos proporcionando toda la información relacionada a dicho registro.</p>
            </div>
            <div class="col-md-4" style="vertical-align:middle; text-align:center">
                <img align="center" class="img-responsive" height="80" src="images/consulta.png" width="80" />
                <br />
                <big><b>
                <p class="text-center">
                    Consultas</p>
                </b></big>
                <p class="text-center">
                    Genera vistas rápidas de información específica relacionada al empleado.</p>
            </div>
        </div>
    </div>
</asp:Content>

