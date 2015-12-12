<%@ Page Title="" Language="C#" MasterPageFile="~/RH2/Principal.Master" AutoEventWireup="true" CodeBehind="Referencias.aspx.cs" Inherits="Recursos_Humanos.Capsule152.Referencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
     <h1> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     &nbsp;&nbsp;Registro de Referencias </h1>
         <div> 
             <table style="width:100%;">
                 <tr>
                     <td class="style1">

         <asp:Label ID="LBNom_Ref" runat="server" Text="Nombre de Referencia" ></asp:Label>
                     </td>
                     <td>
         <asp:TextBox ID="TBNom_Ref" runat="server" width="371px" class="form-control"></asp:TextBox>
                     </td>
                     <td>
                         &nbsp;</td>
                 </tr>
                 <tr>
                     <td class="style1">
         <asp:Label ID="LBDirec" runat="server" Text="Direccion Referencia"></asp:Label>
                     </td>
                     <td>
         <asp:TextBox ID="TBDirec" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                     <td>
                         &nbsp;</td>
                 </tr>
                 <tr>
                     <td class="style1">
         <asp:Label ID="LBOcupa" runat="server" Text="Ocupación referencia"></asp:Label>
                     </td>
                     <td>
         <asp:TextBox ID="TBOcupa" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                     <td>
                         &nbsp;</td>
                 </tr>

                  <tr>
                     <td class="style1">
         <asp:Label ID="LBTel" runat="server" Text="Telefono Referencia"></asp:Label>
                     </td>
                     <td>
         <asp:TextBox ID="TBTel" runat="server" Width="371px" class="form-control"></asp:TextBox>
                     </td>
                     <td>
                         &nbsp;</td>
                 </tr>

             </table>
    </div>

            <asp:Button ID="BTNSig_Ref" runat="server" Text="Siguiente Referencia" onclick="BTNSigRef" class="btn btn-lg btn-primary btn-block" />
            &nbsp;&nbsp; 
            <asp:Button ID="BTNSig_Pag" runat="server" Text="Siguiente" OnClick="BTNSigpag"  class="btn btn-lg btn-primary btn-block"/>

</asp:Content>
