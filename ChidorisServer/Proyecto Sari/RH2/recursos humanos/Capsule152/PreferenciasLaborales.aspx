<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="PreferenciasLaborales.aspx.cs" Inherits="Recursos_Humanos.Capsule152.PreferenciasLaborales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
    <h1> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Preferencias Laborales </h1>
         <div> 
             <table style="width:100%;">
                 <tr>
                     <td class="style1">

         <asp:Label ID="LBTurno" runat="server" Text="Turno"></asp:Label>
                     </td>
                     <td>
         <asp:TextBox ID="TBTurno" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
         <asp:Label ID="LBArea" runat="server" Text="Area"></asp:Label>
                     </td>
                     <td>
         <asp:TextBox ID="TBArea" runat="server" width="371px" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
         <asp:Label ID="LBPuesto" runat="server" Text="Puesto"></asp:Label>
                     </td>
                     <td>
         <asp:TextBox ID="TBPuesto" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
         <asp:Label ID="LBSueldo" runat="server" Text="Sueldo"></asp:Label>
                     </td>
                     <td>
         <asp:TextBox ID="TBSueldo" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
         <asp:Label ID="LBObjetivo" runat="server" Text="Objetivo"></asp:Label>
                     </td>
                     <td>
         <asp:TextBox ID="TBObjet" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
                         Tiene Actividades a las que tenga que dedicarle tiempo extra?</td>
                     <td>
                         <asp:RadioButton ID="RadioButtonYes" runat="server" OnCheckedChanged="RadioButtonYes_CheckedChanged" Text="Si" class="form-control" />
&nbsp;<asp:RadioButton ID="RadioButtonNo" runat="server" OnCheckedChanged="RadioButtonNo_CheckedChanged" Text="No" class="form-control" />
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
                         <asp:Label ID="LabelHow" runat="server" Text="Cuales son? Cuanto tiempo le dedica? Que días? En que horario?" Visible="False"></asp:Label>
                     </td>
                     <td>
         <asp:TextBox ID="TBHow" runat="server" Width="371px" TextMode="MultiLine" Visible="False" class="form-control"></asp:TextBox>
                     </td>
                 </tr>

             </table>
    </div>

            <asp:Button ID="BNSiguiente_Pag" runat="server" Text="Siguiente" onclick="BNSig_Pag_Click" class="btn btn-lg btn-primary btn-block" />

</asp:Content>
