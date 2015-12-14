<%@ Page Title="" Language="C#" MasterPageFile="~/RH2/Principal.Master" AutoEventWireup="true"  Inherits="Recursos_Humanos.MasterPage.Default2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server"><div class="jumbotron">
    <h1>Bienvenido Nuevo Candidato</h1>
    <p>
                <img align="center" class="img-responsive" src="../RH/images/recursos_humanos.png" style="margin: auto 50px auto 30%; right: auto; top: auto;" /></p>
                <p class="MsoNormal">
                    <span>EL primero paso para el registro en el sistema es la evaluacion de los nuevos Candidatos, El sistema realizara una serie de preguntas, estas seran evaluadas y verificadas por el Personal del Area de Recursos Humanos</span></p>
            <p>&nbsp;<asp:Button ID="BtnCandidato" runat="server" class="btn btn-lg btn-primary btn-block" Text="Estoy Listo" onclick="BtnCandidato_Click1"/>

    </p></Div>
<p>&nbsp;</p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
    </p>

</asp:Content>
