<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaProd.aspx.cs" Inherits="Login.Materiales.Entradas.ListaProd" %>

<!DOCTYPE>

<html>
<head runat="server">
    <title>Lista de Productos</title>
    <script type="text/javascript">
        function PassDato(id) {
            window.opener.$("[id*='txtProducto']").val(id);
            window.close();
            return false;
        } 
</script>
</head>
    <form runat="server">
<div class="container">
<h1 class="page-header">Productos</h1>
<div class="form-group">
            <asp:GridView runat="server" CssClass="form-control" ID="GridView1" 
                CellPadding="4" 
                HorizontalAlign="Center" BackColor="White" BorderColor="#3366CC" 
                BorderStyle="None" BorderWidth="1px" onrowcommand="GridView1_RowCommand">
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="Seleccionar" 
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
            <asp:Button ID="btn" runat="server" CssClass="btn-success" Text="Enviar" 
                onclick="btnEnviar_Click" Width="112px" />
            <br />
        </div>
</div>
</form>
</html>
