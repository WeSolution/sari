<%@ Page Title="" Language="C#" MasterPageFile="~/RH2/Principal.Master" AutoEventWireup="true" CodeBehind="Test_Psic_Show.aspx.cs" Inherits="Login.RH2.Capsule152.Test_Psic_Show" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Contenedor" runat="server">
    <div style="text-align: center">
    <asp:Chart ID="ChartTest" runat="server" Palette="Excel" Width="650px">
        <series>
            <asp:Series Name="Series1">
                <Points>
                    <asp:DataPoint YValues="0" />
                    <asp:DataPoint YValues="0" />
                    <asp:DataPoint YValues="0" />
                    <asp:DataPoint YValues="0" />
                    <asp:DataPoint YValues="0" />
                </Points>
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
                <Area3DStyle PointGapDepth="10" WallWidth="0" />
            </asp:ChartArea>
        </chartareas>
        <Titles>
            <asp:Title Font="Apple Kid, 21.75pt, style=Bold" ForeColor="Red" Name="Resultados" ShadowOffset="2" Text="Resultados">
            </asp:Title>
            <asp:Title Docking="Left" Name="Valor" Text="Valor Porcentual">
            </asp:Title>
            <asp:Title Docking="Bottom" Name="Caracteristica" Text="Habilidades y Capacidades">
            </asp:Title>
        </Titles>
    </asp:Chart>
        </div>
    <br />
    <br />
    <div>
        <strong>1 - </strong>Habilidad de Supervision ->&nbsp;
        <asp:Label ID="Valor1" runat="server" Text="[Valor]"></asp:Label>
        %<br />
        <br />
        <strong>2 - </strong>Capacidad de Decisión en las Relaciones Humanas ->&nbsp;
        <asp:Label ID="Valor2" runat="server" Text="[Valor]"></asp:Label>
        %<br />
        <br />
        <strong>3 - </strong>Capacidad de Evaluación de Problemas Interpersonales ->&nbsp;
        <asp:Label ID="Valor3" runat="server" Text="[Valor]"></asp:Label>
        %<br />
        <br />
        <strong>4 - </strong>Habilidad para Establecer Relaciones Interpersonales ->&nbsp;
        <asp:Label ID="Valor4" runat="server" Text="[Valor]"></asp:Label>
        %<br />
        <br />
        <strong>5 - </strong>Sentido Común y Tacto en las Relaciones Interpersonales ->&nbsp;
        <asp:Label ID="Valor5" runat="server" Text="[Valor]"></asp:Label>
        %<br />
        <br />
        <asp:Button ID="BTNFinish" runat="server" Height="55px" OnClick="BTNFinish_Click" Text="Terminar" Width="867px"  class="btn btn-lg btn-primary btn-block"/>

        </div>
</asp:Content>
