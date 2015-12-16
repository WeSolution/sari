<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" /> 
    <meta name="viewport" content="width=device-width, initial-scale=1.0" /> 
    <title>..::Login::..</title>
    <link rel="stylesheet" href="/CSS/bootstrap.min.css"  />
    <link rel="stylesheet" href="/CSS/bootstrap-theme.min.css"  />
    <link href="login.css" rel="stylesheet" type="text/css" />
     <script>
         function habilitar(value) {

             if (value == "RH2" || value == false) {
                 // deshabilitamos
                 document.getElementById("txtpass").readOnly = true;
                 // document.getElementById("area").readOnly = true;

                 // document.getElementById("txtpass").value = "N/A";
                 // document.getElementById("area").value = "N/A"; 
             } else {
                 document.getElementById("txtpass").readOnly = false;

             }
         }
	</script>
</head>
<body>
   <div class="container">
    <div class="row">
        <div class="col-sm-6 col-md-4 col-md-offset-4">
            <h1 class="text-center login-title">Iniciar Sesión</h1>
            <div class="account-wall">
                 
                <form id="Form1" class="form-signin" runat="server" method="post">
                   <div style="margin:0 auto 0 auto; width:200px; height: 276px;">
                     <asp:Image ID="Image1" runat="server" Height="91%" ImageUrl="~/RH/images/login.png" Width="92%" />
                   </div>
                     <asp:TextBox ID="txtusuario" name="txtusuario" class="form-control" type="text" require placeholder="Usuario" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtpass" name = "txtpass" runat="server" type="password" class="form-control" placeholder="Password" ></asp:TextBox> 
                    <asp:DropDownList ID="area" name = "area" class="form-control" 
                         onChange="habilitar(this.value);"  runat="server"   >
                        <asp:ListItem Value="RH">Recursos Humanos</asp:ListItem>
                        <asp:ListItem Value="Finanzas">Finanzas</asp:ListItem>
                        <asp:ListItem Value="Recursos Materiales">Recursos Materiales</asp:ListItem>
                                    </asp:DropDownList>
                 <br /> 
                <asp:Button ID="btningresar" runat="server" class="btn btn-lg btn-primary btn-block" 
                         Text="Iniciar Sesión"  onclick="btningresar_Click" />
                     <br /> 
                    <asp:LinkButton ID="LBTNRH2" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Large" Font-Underline="True" OnClick="LBTNRH2_Click">Eres un Nuevo Postulante? REGISTRATE!</asp:LinkButton>
                    <br />
                    <br />
                    <asp:Label ID="lblerror" runat="server" ForeColor="Red"></asp:Label>
                </form>
            </div> 
        </div>
    </div>
</div>
</body>
</html>
