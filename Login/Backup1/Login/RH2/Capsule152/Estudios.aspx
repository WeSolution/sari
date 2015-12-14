<%@ Page Title="" Language="C#" MasterPageFile="~/RH2/Principal.Master" AutoEventWireup="true" CodeBehind="Estudios.aspx.cs" Inherits="Recursos_Humanos.Capsule152.Estudios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
    <h1> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     &nbsp;&nbsp;&nbsp;&nbsp;Registro de Estudios </h1>
         <div>
             <table style="width:100%;">
                 <tr>
                     <td class="style1">

            <asp:Label ID="LBPais" runat="server" Text="Pais"></asp:Label>
                     </td>
                     <td>
            <asp:TextBox ID="TBPais" runat="server" class="form-control" Width="371px"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
            <asp:Label ID="LBNivel_est" runat="server" Text="Nivel de Estudios"></asp:Label>
                     </td>
                     <td>
            <asp:TextBox ID="TBNivel_Est" runat="server" class="form-control" Width="371px"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
            <asp:Label ID="LBInst" runat="server" Text="Institución"></asp:Label>
                     </td>
                     <td>
            <asp:TextBox ID="TBInsti" runat="server" class="form-control" Width="371px"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
           <asp:Label ID="LBArea" runat="server" Text="Area"></asp:Label>
                     </td>
                     <td>
             <asp:TextBox ID="TBArea" class="form-control" runat="server" Width="371px"></asp:TextBox>
                     </td>
                 </tr>

                   <tr>
                     <td class="style1">
           <asp:Label ID="LBTitulo" runat="server" Text="Titulo"></asp:Label>
                     </td>
                     <td>
             <asp:TextBox ID="TBTitulo" runat="server" class="form-control" widht="371pdx" Width="371px"></asp:TextBox>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
           <asp:Label ID="LBFe_Ini" runat="server" Text="Fecha Inicio"></asp:Label>
                     </td>
                     <td>
         <asp:Label ID="LabelDía" runat="server" Text="Día"></asp:Label>
         <asp:DropDownList ID="DDLDia" runat="server">
             <asp:ListItem>1</asp:ListItem>
             <asp:ListItem>2</asp:ListItem>
             <asp:ListItem>3</asp:ListItem>
             <asp:ListItem>4</asp:ListItem>
             <asp:ListItem>5</asp:ListItem>
             <asp:ListItem>6</asp:ListItem>
             <asp:ListItem>7</asp:ListItem>
             <asp:ListItem>8</asp:ListItem>
             <asp:ListItem>9</asp:ListItem>
             <asp:ListItem>10</asp:ListItem>
             <asp:ListItem>11</asp:ListItem>
             <asp:ListItem>12</asp:ListItem>
             <asp:ListItem>13</asp:ListItem>
             <asp:ListItem>14</asp:ListItem>
             <asp:ListItem>15</asp:ListItem>
             <asp:ListItem>16</asp:ListItem>
             <asp:ListItem>17</asp:ListItem>
             <asp:ListItem>18</asp:ListItem>
             <asp:ListItem>19</asp:ListItem>
             <asp:ListItem>20</asp:ListItem>
             <asp:ListItem>21</asp:ListItem>
             <asp:ListItem>22</asp:ListItem>
             <asp:ListItem>23</asp:ListItem>
             <asp:ListItem>24</asp:ListItem>
             <asp:ListItem>25</asp:ListItem>
             <asp:ListItem>26</asp:ListItem>
             <asp:ListItem>27</asp:ListItem>
             <asp:ListItem>28</asp:ListItem>
             <asp:ListItem>29</asp:ListItem>
             <asp:ListItem>30</asp:ListItem>
             <asp:ListItem>31</asp:ListItem>
         </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
         <asp:Label ID="LabelMes" runat="server" Text="Mes"></asp:Label>
         <asp:DropDownList ID="DDLMes" runat="server" >
             <asp:ListItem>Enero</asp:ListItem>
             <asp:ListItem>Febrero</asp:ListItem>
             <asp:ListItem>Marzo</asp:ListItem>
             <asp:ListItem>Abril</asp:ListItem>
             <asp:ListItem>Mayo</asp:ListItem>
             <asp:ListItem>Junio</asp:ListItem>
             <asp:ListItem>Julio</asp:ListItem>
             <asp:ListItem>Agosto</asp:ListItem>
             <asp:ListItem>Septiembre</asp:ListItem>
             <asp:ListItem>Octubre</asp:ListItem>
             <asp:ListItem>Noviembre</asp:ListItem>
             <asp:ListItem>Diciembre</asp:ListItem>
         </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
         <asp:Label ID="LabelAno" runat="server" Text="Año"></asp:Label>
         <asp:DropDownList ID="DDLAno" runat="server">
             <asp:ListItem>1990</asp:ListItem>
             <asp:ListItem>1991</asp:ListItem>
             <asp:ListItem>1992</asp:ListItem>
             <asp:ListItem>1993</asp:ListItem>
             <asp:ListItem>1994</asp:ListItem>
             <asp:ListItem>1995</asp:ListItem>
             <asp:ListItem>1996</asp:ListItem>
             <asp:ListItem>1997</asp:ListItem>
             <asp:ListItem>1998</asp:ListItem>
             <asp:ListItem>1999</asp:ListItem>
             <asp:ListItem>2000</asp:ListItem>
             <asp:ListItem>2001</asp:ListItem>
             <asp:ListItem>2002</asp:ListItem>
             <asp:ListItem>2003</asp:ListItem>
             <asp:ListItem>2004</asp:ListItem>
             <asp:ListItem>2005</asp:ListItem>
             <asp:ListItem>2006</asp:ListItem>
             <asp:ListItem>2007</asp:ListItem>
             <asp:ListItem>2008</asp:ListItem>
             <asp:ListItem>2009</asp:ListItem>
             <asp:ListItem>2010</asp:ListItem>
             <asp:ListItem>2011</asp:ListItem>
             <asp:ListItem>2012</asp:ListItem>
             <asp:ListItem>2013</asp:ListItem>
             <asp:ListItem>2014</asp:ListItem>
             <asp:ListItem>2015</asp:ListItem>
         </asp:DropDownList>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
           <asp:Label ID="LBFe_Fin" runat="server" Text="Fecha Final"></asp:Label>
                     </td>
                     <td>
         <asp:Label ID="LabelDía0" runat="server" Text="Día"></asp:Label>
         <asp:DropDownList ID="DDLDia0" runat="server">
             <asp:ListItem>1</asp:ListItem>
             <asp:ListItem>2</asp:ListItem>
             <asp:ListItem>3</asp:ListItem>
             <asp:ListItem>4</asp:ListItem>
             <asp:ListItem>5</asp:ListItem>
             <asp:ListItem>6</asp:ListItem>
             <asp:ListItem>7</asp:ListItem>
             <asp:ListItem>8</asp:ListItem>
             <asp:ListItem>9</asp:ListItem>
             <asp:ListItem>10</asp:ListItem>
             <asp:ListItem>11</asp:ListItem>
             <asp:ListItem>12</asp:ListItem>
             <asp:ListItem>13</asp:ListItem>
             <asp:ListItem>14</asp:ListItem>
             <asp:ListItem>15</asp:ListItem>
             <asp:ListItem>16</asp:ListItem>
             <asp:ListItem>17</asp:ListItem>
             <asp:ListItem>18</asp:ListItem>
             <asp:ListItem>19</asp:ListItem>
             <asp:ListItem>20</asp:ListItem>
             <asp:ListItem>21</asp:ListItem>
             <asp:ListItem>22</asp:ListItem>
             <asp:ListItem>23</asp:ListItem>
             <asp:ListItem>24</asp:ListItem>
             <asp:ListItem>25</asp:ListItem>
             <asp:ListItem>26</asp:ListItem>
             <asp:ListItem>27</asp:ListItem>
             <asp:ListItem>28</asp:ListItem>
             <asp:ListItem>29</asp:ListItem>
             <asp:ListItem>30</asp:ListItem>
             <asp:ListItem>31</asp:ListItem>
         </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
         <asp:Label ID="LabelMes0" runat="server" Text="Mes"></asp:Label>
         <asp:DropDownList ID="DDLMes0" runat="server">
             <asp:ListItem>Enero</asp:ListItem>
             <asp:ListItem>Febrero</asp:ListItem>
             <asp:ListItem>Marzo</asp:ListItem>
             <asp:ListItem>Abril</asp:ListItem>
             <asp:ListItem>Mayo</asp:ListItem>
             <asp:ListItem>Junio</asp:ListItem>
             <asp:ListItem>Julio</asp:ListItem>
             <asp:ListItem>Agosto</asp:ListItem>
             <asp:ListItem>Septiembre</asp:ListItem>
             <asp:ListItem>Octubre</asp:ListItem>
             <asp:ListItem>Noviembre</asp:ListItem>
             <asp:ListItem>Diciembre</asp:ListItem>
         </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
         <asp:Label ID="LabelAno0" runat="server" Text="Año"></asp:Label>
         <asp:DropDownList ID="DDLAno0" runat="server">
             <asp:ListItem>1990</asp:ListItem>
             <asp:ListItem>1991</asp:ListItem>
             <asp:ListItem>1992</asp:ListItem>
             <asp:ListItem>1993</asp:ListItem>
             <asp:ListItem>1994</asp:ListItem>
             <asp:ListItem>1995</asp:ListItem>
             <asp:ListItem>1996</asp:ListItem>
             <asp:ListItem>1997</asp:ListItem>
             <asp:ListItem>1998</asp:ListItem>
             <asp:ListItem>1999</asp:ListItem>
             <asp:ListItem>2000</asp:ListItem>
             <asp:ListItem>2001</asp:ListItem>
             <asp:ListItem>2002</asp:ListItem>
             <asp:ListItem>2003</asp:ListItem>
             <asp:ListItem>2004</asp:ListItem>
             <asp:ListItem>2005</asp:ListItem>
             <asp:ListItem>2006</asp:ListItem>
             <asp:ListItem>2007</asp:ListItem>
             <asp:ListItem>2008</asp:ListItem>
             <asp:ListItem>2009</asp:ListItem>
             <asp:ListItem>2010</asp:ListItem>
             <asp:ListItem>2011</asp:ListItem>
             <asp:ListItem>2012</asp:ListItem>
             <asp:ListItem>2013</asp:ListItem>
             <asp:ListItem>2014</asp:ListItem>
             <asp:ListItem>2015</asp:ListItem>
         </asp:DropDownList>
                     </td>
                 </tr>

                 <tr>
                     <td class="style1">
           <asp:Label ID="LBPromedio" runat="server" Text="Promedio"></asp:Label>
                     </td>
                     <td>
             <asp:TextBox ID="TBPromedio" runat="server" class="form-control" Width="371px"></asp:TextBox>
                     </td>
                 </tr>

             </table>
    </div>

                    <p>&nbsp;<asp:Button ID="BNSiguiente" runat="server" 
                            Text="Siguiente Estudio" onclick="BNSiguiente_Click" class="btn btn-lg btn-primary btn-block" />
&nbsp; </p>
            <asp:Button ID="BNSiguiente3" runat="server" Text="Siguiente" 
                            onclick="BNSiguiente3_Click" class="btn btn-lg btn-primary btn-block" />
</asp:Content>
