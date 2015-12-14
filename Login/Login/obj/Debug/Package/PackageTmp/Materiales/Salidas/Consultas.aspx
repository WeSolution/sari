<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/Salidas/Salidas.master" EnableEventValidation="false"   AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="Recursos_Materiales.Salidas.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <form>
    <div class="container">
    <h1 class="page-header">Consulta de Salidas</h1>
    <br />
        <div class="container">
            <div class="col-xs-6 col-centered">
                <b><big><asp:Label ID="Label3" runat="server" Text="Del" autocomplete="off"></asp:Label>&nbsp; </big></b>
                <asp:Calendar CssClass="form-control" ID="Cal1" runat="server" 
                    BackColor="White" BorderColor="#999999" CellPadding="4" 
                    DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
                    Height="180px" Width="552px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </div>
            <div class="col-xs-6 col-centered">
                <b><big><asp:Label ID="Label1" runat="server" Text="Al"></asp:Label></big></b>
                <asp:Calendar CssClass="form-control" ID="Cal2" runat="server" 
                    BackColor="White" BorderColor="#999999" CellPadding="4" 
                    DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
                    Height="180px" Width="549px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
                <br />
            </div>
        </div>
        <div class="form-group">
            <asp:GridView CssClass="form-control" ID="GridView1" runat="server" 
                CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" 
                BorderWidth="1px" onrowcommand="GridView1_RowCommand">
                <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Detalles" 
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
        <div class="form-group">
            <asp:GridView CssClass="form-control" ID="GridView2" runat="server" 
                CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" 
                BorderWidth="1px">
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
        <div class="form-group">
            <asp:Button CssClass="btn-success" ID="btnBuscar" runat="server" Text="Buscar" 
                onclick="btnBuscar_Click" Width="1143px" />
        </div>
    </div>
</form>
</asp:Content>
