<%@ Page Title="" Language="C#" MasterPageFile="~/Finanzas/Principal.Master" AutoEventWireup="true" CodeBehind="ValidarProveedor.aspx.cs" Inherits="Recursos_Financieros.Formularios.ValidarProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
<div class="col-md-12"> 
    <div>
        <div class="jumbotron">
            <div class="container">
            <div class="col-sm-8 well">
                <asp:Label ID="Label1" Text="Seleccione un proveedor" runat="server" />
                <select id="cmbproveedor" runat="server"></select>
                <br />
                <asp:Button Text="Buscar" ID="btnbuscar" runat="server" onclick="btnbuscar_Click" />
            </div>

            <div class="col-sm-8 well">
                <h6 runat="server" id="prove" >Datos del proveedor...</h6>
                <asp:GridView ID="Gdvproveedores" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="id_proveedor" BackColor="White" BorderColor="#999999" 
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="tel_1" HeaderText="Telefono 1" />
                        <asp:BoundField DataField="tel_2" HeaderText="Telefono 2" />
                        <asp:BoundField DataField="ciudad" HeaderText="Ciudad" />
                        <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#5C6665" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>                                       
            </div>
            <div class="col-sm-8 well">
                <h6>Productos que suministra el proveedor seleccionado...</h6>
                <asp:GridView runat="server" ID="gdvproducto"  DataKeyNames="id_producto" AutoGenerateColumns="False" 
                     BackColor="White" BorderColor="#999999" 
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" >
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="modelo" HeaderText="Modelo" />
                        <asp:BoundField DataField="marca" HeaderText="Marca" />
                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                        <asp:BoundField DataField="precio_compra" HeaderText="Precio compra" />
                        <asp:BoundField DataField="localizacion" HeaderText="Localización" />
                        <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#5C6665" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#99CCFF" Font-Bold="True" ForeColor="Black" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>    
            </div>

            <div class="col-sm-8 well">
                <h6>Servicios que brinda el proveedor seleccionado...</h6>
                <asp:GridView runat="server" ID="gdvatiend"  DataKeyNames="id_servicio" AutoGenerateColumns="False" 
                     BackColor="White" BorderColor="#999999" 
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" >
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:BoundField DataField="identificador" HeaderText="Identificador" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />                                               
                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                        <asp:BoundField DataField="precio" HeaderText="Precio" />
                       
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#5C6665" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>    
            </div>
        </div>
    </div>
  </div>
 </div>
</asp:Content>
