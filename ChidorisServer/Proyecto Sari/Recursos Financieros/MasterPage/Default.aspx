<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Recursos_Financieros.MasterPage.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
<div class="col-md-12"> 
    <div>
        <div class="jumbotron">
            <div class="container">
                <div style="text-align:center"></br>
                    <img src="../Imagenes/ico-finanzas.png"></img>
                    <h1>Recursos Financieros</h1></br>
                    <h3>En el área de Recursos Financieros controla el proceso de compras, mediante requisiciones 
                    que son aprobadas o rechazadas por el responsable de esta área, esta también permite alta 
                    de bienes y servicios asi como de proveedores.</h3>
                </div>
            </div>
        </div>
        <div  class="row">
            <div class="col-md-2" style="display:table-cell; vertical-align:middle; text-align:center">
                <div align="center"><img class="img-responsive" height="80" src="../Imagenes/requi-icon.png" width="80" /></div>
                <br />
                <big><b>
                <p class="text-center">Requisiciones Pendientes</p>
                </b></big>
                <p class="text-center">
                    Guarda todas las requisiciones que se han realizado</p>
            </div>
            <div class="col-md-2">
                <div align="center"><img class="img-responsive" height="80" src="../Imagenes/prod-icon.png" width="80" /></div>
                <br />
                <big><b>
                <p class="text-center">Productos</p>
                </b></big>
                <p class="text-center">
                    Permite registrar un nuevo producto.</p>
            </div>
            <div class="col-md-2" style="vertical-align:middle; text-align:center">
                <div align="center"><img class="img-responsive" height="80" src="../Imagenes/serv_icon.png" width="80" /></div>
                <br />
                <big><b>
                <p class="text-center">Servicios</p>
                </b></big>
                <p class="text-center">Permite registrar nuevos servicios.</p>
            </div>
            <div class="col-md-2" style="vertical-align:middle; text-align:center">
                <div align="center"><img class="img-responsive" height="80" src="../Imagenes/provider-icon.png" width="80" /></div>
                <br />
                <big><b>
                <p class="text-center">Proveedores</p>
                </b></big>
                <p class="text-center">Permite registrar nuevos productores y validar los ya existentes.</p>
            </div>
            <div class="col-md-2" style="vertical-align:middle; text-align:center">
                <div align="center"><img class="img-responsive" height="80" src="../Imagenes/reports-icon.png" width="80" /></div>
                <br />
                <big><b>
                <p class="text-center">Reportes</p>
                </b></big>
                <p class="text-center">Genera el reporte de todas solicitudes realizadas en la empresa por cada mes.</p>
            </div>
      </div>
     </div>
    </div>
</asp:Content>