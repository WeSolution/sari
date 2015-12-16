<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/Salidas/Salidas.master" AutoEventWireup="true" EnableEventValidation="false"   CodeBehind="Nueva Salida.aspx.cs" Inherits="Recursos_Materiales.Salidas.Nueva_Salida" %>
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
                <asp:Button CssClass="btn-primary" ID="btnAgregar" runat="server" Text="Agregar +"
                    UseSubmitBehavior="False" 
                    onclick="btnAgregar_Click" Width="541px" />
            </div>
            <div class="col-md-6">
                <b><big><asp:Label ID="Label3" runat="server" Text=" Quien solicita"></asp:Label></big></b>
                <asp:DropDownList CssClass="form-control" ID="cmbQuien" runat="server">
                </asp:DropDownList>
                <br />
            <b><big><asp:Label ID="Label4" runat="server" Text="Producto"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtProducto" runat="server"></asp:TextBox>
                <asp:Button CssClass="btn-primary" ID="btnBuscar" runat="server" 
                    Text="Buscar Producto" UseSubmitBehavior="False" 
                    Width="260px" onclick="btnBuscar_Click"/>
                <br />
                <b><big><asp:Label ID="Label7" runat="server" Text="Cantidad que sale"></asp:Label></big></b>
                <asp:TextBox CssClass="form-control" ID="txtCantidad" runat="server"></asp:TextBox>
                <br />
             </div>
            
        </div>
        <br />
        <div class="container">
            <asp:GridView CssClass="form-control" ID="GridView1" runat="server" 
                CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" 
                BorderWidth="1px" onrowcommand="GridView1_RowCommand">
                <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Eliminar" 
                    ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <br />
        </div>
        <div class="container">
        
            <asp:Button ID="btnSalida" runat="server" CssClass="btn-success" 
                Text="Registrar Salida" Width="1153px" onclick="btnSalida_Click" />
            <br />
            <br />
            
        </div>
</form>
</html>
</asp:Content>
