<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="Mas_Info.aspx.cs" Inherits="Recursos_Humanos.Capsule152.Mas_Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
    <h1> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Mas Información </h1>
         <div>
             <table style="width:100%;">
                 <tr>
                     <td class="style1">

        <asp:Label ID="LBIdiomas" runat="server" Text="Idiomas"></asp:Label>
                     </td>
                     <td>
        <asp:TextBox ID="TBIdiomas" runat="server" class="form-control" Width="371px"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
        <asp:Label ID="LBHerra_Offi" runat="server" Text="Herramientas de Oficina"></asp:Label>
                     </td>
                     <td>
        <asp:TextBox ID="TBHerra_Offi" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
        <asp:Label ID="LBHerra_Info" runat="server" Text="Herramientas de Información"></asp:Label>
                     </td>
                     <td>
        <asp:TextBox ID="TBHerra_Info" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
        <asp:Label ID="LBCursos" runat="server" Text="Cursos"></asp:Label>
                     </td>
                     <td>
        <asp:TextBox ID="TBCursos" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
        <asp:Label ID="LBCono_Tec" runat="server" Text="Conocimientos de Tecnología"></asp:Label>
                     </td>
                     <td>
        <asp:TextBox ID="TBCono_Tec" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
        <asp:Label ID="LBCono_Fin" runat="server" Text="Conocimientos Financieros"></asp:Label>
                     </td>
                     <td>
        <asp:TextBox ID="TBCono_Fina" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

             </table>
    </div>

       
        <asp:Button ID="BTSiguiente_Pag" runat="server" Text="Siguiente" OnClick="Siguiente_Pag_Clik" class="btn btn-lg btn-primary btn-block" />

</asp:Content>
