<%@ Page Title="" Language="C#" MasterPageFile="~/Materiales/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Recursos_Materiales.MasterPage.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenedor" runat="server">
<div class="jumbotron">
    <div class="container">
        <h1 class="text-center">Recursos Materiales</h1>
        <p class="text-center">En el área de Recursos Materiales dentro del S.A.R.I, usted podrá controlar las entradas y salidas de un producto solicitado por otro departamento,
        asi como también, tener el control del Almacén</p>
    </div>
  </div>

  <div class="row">
      <div class="col-md-4">
          <img class="img-responsive" src="/Materiales/Imagenes/in.png" height="80" width="80" align="center" />
        <br />
        <big><b><p class="text-center" >Entradas</p></b></big>
        <p class="text-center">Nuevos ingresos de materia prima o materia </p>
        <p class="text-center">terminada como producto dentro del almacén.</p>
      </div>
      <div class="col-md-4">
          <img class="img-responsive" src="/Materiales/Imagenes/out.png" height="80" width="80" align="center"  />
        <br />
        <big><b><p class="text-center">Salidas</p></b></big>
        <p class="text-center">Nuevos egresos de materia prima o materia </p>
        <p class="text-center">terminada como producto dentro del almacén.</p>
        </div>
      <div class="col-md-4">
          <img class="img-responsive" src="/Materiales/Imagenes/new.png" height="80" width="80" align="center"  />
        <br />
        <big><b><p class="text-center">Requisiciones</p></b></big>
        <p class="text-center">Nueva requisición de productos</p>
        <p class="text-center">al departamento de Recursos Financieros.</p> 
      </div>
  </div>

</asp:Content>
