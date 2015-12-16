<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/Entradas/Entradas.master" AutoEventWireup="true" CodeBehind="Nueva Entrada.aspx.cs" EnableEventValidation="false"  Inherits="Recursos_Materiales.Entradas.Nueva_Entrada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
<!DOCTYPE>

<html>
<head>
<script type="text/javascript">
    function AbrirVentana() {
        window.open('ListaProd.aspx', 'popup', 'width=1200,height=500'); 
    } 
</script>
</head>
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
                <asp:Button CssClass="btn-primary" ID="btnAgregar" runat="server" 
                    Text="Agregar +" UseSubmitBehavior="False" 
                    Width="541px" onclick="btnAgregar_Click" />
                <br />
                <br />
            </div>
            <div class="col-md-6">
            <b><big><asp:Label ID="Label3" runat="server" Text="Producto" autocomplete="off"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtProducto" runat="server"></asp:TextBox>
                 <asp:Button CssClass="btn-primary" ID="btnBuscar" runat="server" 
                    Text="Buscar Producto" UseSubmitBehavior="False" 
                    Width="260px" onclick="btnBuscar_Click"/>
                <br />
                <br />
                <b><big><asp:Label ID="Label4" runat="server" Text="Proveedor"></asp:Label></big></b>
                <asp:DropDownList CssClass="form-control" ID="cmbProveedores" runat="server">
                </asp:DropDownList>
                <br />
                <b><big><asp:Label ID="Label7" runat="server" Text="Cantidad que entra"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtCantidad" runat="server"></asp:TextBox>
                 
                <br />
                <b><big><asp:Label ID="Label8" runat="server" Text="Ubicación en el Almacén"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtUbicación" runat="server"></asp:TextBox>
                  
                <br />
                <br />
            </div>
        </div>
        <div class="form-group">
            <asp:GridView CssClass="form-control" ID="dgvDatos" runat="server" 
                CellPadding="4" 
                DataKeyNames="Producto" BackColor="White" BorderColor="#3366CC" 
                BorderStyle="None" BorderWidth="1px" onrowcommand="dgvDatos_RowCommand" >
                <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Eliminar" 
                    ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle ForeColor="#003399" BackColor="White" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <br />
            <asp:Button CssClass="btn-success" ID="btnRegistrar" runat="server" 
                    CausesValidation="false" Text="Registrar en Almacén" Width="1153px" 
                onclick="btnRegistrar_Click" />
        </div>
    </div>
</form>
</html>
</asp:Content>
