<%@ Page Title="" Language="C#" MasterPageFile="~/RH2/Principal.Master" AutoEventWireup="true" CodeBehind="Test_Psic.aspx.cs" Inherits="Recursos_Humanos.Capsule152.Test_Psic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" lang="javascript">
        function mostrar_procesar()
        {
            document.getElementById("procesando_div").style.display ="";
            setTimeout("document.images['procesando_gif'].src='loading_spinner.gif'", 200);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
        <h1> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Test Psicológico </h1>
     <p> Bienvenido al Test Psicológico. En este Test usaremos el famoso TEST DE MOSS para comprobar sus habilidades y capacidades.</p>
     <p> &nbsp;</p>
     <p> <b>Instrucciones:</b>&nbsp;Para cada uno de los problemas siguientes, se sugieren cuatro respuestas. Seleccione la respuesta que corresponda a la solucion que usted considere más acertada. <em><b>No marque más de una.</b></em></p>
     <p><em> No haga ningun cambio en este TEST. Nos daríamos cuenta y usted sería descalificado de manera automática.</em></p>
     <div>
         <asp:Label ID="Pregunta1" runat="server" Text="[Aquí va la pregunta 1]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta1" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta2" runat="server" Text="[Aquí va la pregunta 2]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta2" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta3" runat="server" Text="[Aquí va la pregunta 3]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta3" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta4" runat="server" Text="[Aquí va la pregunta 4]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta4" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta5" runat="server" Text="[Aquí va la pregunta 5]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta5" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta6" runat="server" Text="[Aquí va la pregunta 6]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta6" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta7" runat="server" Text="[Aquí va la pregunta 7]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta7" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta8" runat="server" Text="[Aquí va la pregunta 8]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta8" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta9" runat="server" Text="[Aquí va la pregunta 9]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta9" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta10" runat="server" Text="[Aquí va la pregunta 10]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta10" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta11" runat="server" Text="[Aquí va la pregunta 11]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta11" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta12" runat="server" Text="[Aquí va la pregunta 12]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta12" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta13" runat="server" Text="[Aquí va la pregunta 13]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta13" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta14" runat="server" Text="[Aquí va la pregunta 14]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta14" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta15" runat="server" Text="[Aquí va la pregunta 15]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta15" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta16" runat="server" Text="[Aquí va la pregunta 16]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta16" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta17" runat="server" Text="[Aquí va la pregunta 17]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta17" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta18" runat="server" Text="[Aquí va la pregunta 18]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta18" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta19" runat="server" Text="[Aquí va la pregunta 19]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta19" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta20" runat="server" Text="[Aquí va la pregunta 20]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta20" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta21" runat="server" Text="[Aquí va la pregunta 21]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta21" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta22" runat="server" Text="[Aquí va la pregunta 22]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta22" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta23" runat="server" Text="[Aquí va la pregunta 23]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta23" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta24" runat="server" Text="[Aquí va la pregunta 24]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta24" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta25" runat="server" Text="[Aquí va la pregunta 25]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta25" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta26" runat="server" Text="[Aquí va la pregunta 26]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta26" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta27" runat="server" Text="[Aquí va la pregunta 27]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta27" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta28" runat="server" Text="[Aquí va la pregunta 28]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta28" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta29" runat="server" Text="[Aquí va la pregunta 29]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta29" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
         <div>
         <asp:Label ID="Pregunta30" runat="server" Text="[Aquí va la pregunta 30]"></asp:Label>
         <asp:RadioButtonList ID="RBLPregunta30" runat="server">
         </asp:RadioButtonList>
    </div>
    <br />
        <br />
        <div>
            <span id="procesando_div" style="display: none; position:absolute; text-align:center">
                <img src="../loading_spinner.gif" id="procesando_gif" style="text-align:center" />
            </span>
            
            <asp:Button ID="BTNFinish" runat="server" Height="55px" OnClick="BTNFinish_Click" Text="Terminar y Ver Resultados" Width="867px"  class="btn btn-lg btn-primary btn-block"/>

    </div>
</asp:Content>
