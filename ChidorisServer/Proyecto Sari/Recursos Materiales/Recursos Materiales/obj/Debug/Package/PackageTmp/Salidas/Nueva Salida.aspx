<%@ Page Title="" Language="C#" MasterPageFile="~/Salidas/Salidas.master" AutoEventWireup="true" CodeBehind="Nueva Salida.aspx.cs" Inherits="Recursos_Materiales.Salidas.Nueva_Salida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <form>
    <div class="container">
    <h1 class="page-header">Salida de Almacén</h1>
            <div class="col-md-6">
                <b><big><asp:Label ID="Label1" runat="server" Text="Fecha"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtFecha" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <b><big><asp:Label ID="Label2" runat="server" Text="Hora"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtHora" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <b><big><asp:Label ID="Label5" runat="server" Text="Descripción"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtDesc" runat="server"></asp:TextBox>
                <br />
                <asp:Button CssClass="form-control" ID="btnAgregar" runat="server" Text="Agregar +"
                    UseSubmitBehavior="False" 
                    onclick="btnAgregar_Click" />
            </div>
            <div class="col-md-6">
                <b><big><asp:Label ID="Label3" runat="server" Text=" Quien solicita"></asp:Label></big></b>
                <asp:DropDownList CssClass="form-control" ID="cmbQuien" runat="server">
                </asp:DropDownList>
                <br />
            <b><big><asp:Label ID="Label4" runat="server" Text="Producto"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtProducto" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                    ControlToValidate="txtProducto"
                    ErrorMessage="Proporcione un Id o Identificador de producto."
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
                <br />
                <b><big><asp:Label ID="Label7" runat="server" Text="Cantidad que sale"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtCantidad" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                    ControlToValidate="txtCantidad"
                    ErrorMessage="Proporcione la cantidad que sale"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
                <br />
             </div>
            
        </div>
        <br />
        <div class="container">
            <asp:GridView CssClass="form-control" ID="GridView1" runat="server" 
                CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <br />
        </div>
        <div class="container">
        
            <asp:Button ID="btnSalida" runat="server" CssClass="form-control" 
                Text="Registrar Salida" onclick="btnSalida_Click" />
            <br />
            <br />
            
        </div>
</form>
</asp:Content>
