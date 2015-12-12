<%@ Page Title="" Language="C#" MasterPageFile="~/Entradas/Entradas.master" AutoEventWireup="true" CodeBehind="Nueva Entrada.aspx.cs" Inherits="Recursos_Materiales.Entradas.Nueva_Entrada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
<form>
    <div class="container">
    <h1 class="page-header">Entrada al Almacén</h1>
        <div class="form-group">
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
                <b><big><asp:Label ID="Label6" runat="server" Text="Total"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtTotal" ReadOnly="True" runat="server"></asp:TextBox>
                <br />
                <asp:Button CssClass="form-control" ID="btnAgregar" runat="server" 
                    Text="Agregar +" onclick="btnAgregar_Click" UseSubmitBehavior="False" />
                <br />
            </div>
            <div class="col-md-6">
            <b><big><asp:Label ID="Label3" runat="server" Text="Producto" autocomplete="off"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtProducto" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                    ControlToValidate="txtProducto"
                    ErrorMessage="Proporcione un Id o Identificador de producto."
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
                <br />
                <b><big><asp:Label ID="Label4" runat="server" Text="Proveedor"></asp:Label></big></b>
                <asp:DropDownList CssClass="form-control" ID="cmbProveedores" runat="server">
                </asp:DropDownList>
                <br />
                <b><big><asp:Label ID="Label7" runat="server" Text="Cantidad que entra"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtCantidad" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                    ControlToValidate="txtCantidad"
                    ErrorMessage="Proporcione la cantidad de entrada"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
                <br />
                <b><big><asp:Label ID="Label8" runat="server" Text="Ubicación en el Almacén"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtUbicación" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server"
                    ControlToValidate="txtUbicación"
                    ErrorMessage="Proporcione la ubicación en el almacén"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
                <br />
                <br />
            </div>
        </div>
        <div class="form-group">
            <asp:GridView CssClass="form-control" ID="dgvDatos" runat="server" 
                CellPadding="4" ForeColor="#333333" GridLines="None" 
                DataKeyNames="Producto" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Eliminar" 
                    ShowSelectButton="True" />
                </Columns>
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
            <br />
        </div>
        <br />
        <div class="form-group">
            <div class="container">
                <br />
                <asp:Button CssClass="form-control" ID="btnRegistrar" runat="server" CausesValidation="false" Text="Registrar en Almacén" onclick="btnRegistrar_Click" />
                <br />
            </div>
        </div>
    </div>
</form>
</asp:Content>
