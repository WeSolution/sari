<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" /> 
    <meta name="viewport" content="width=device-width, initial-scale=1.0" /> 
    <title>..::Login::..</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css"  />

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css"  />
    <link href="login.css" rel="stylesheet" type="text/css" />
     <script>
         function habilitar(value) {

             if (value == "Como invitado" || value == false) {
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
                 
                <form id="Form1" action = "http://localhost:6596/validarusuario.aspx"   class="form-signin" runat="server">
                   
                     <asp:TextBox ID="txtusuario" name="txtusuario" class="form-control" type="text" require placeholder="Usuario" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtpass" name = "txtpass" runat="server" type="password" class="form-control" placeholder="Password" ></asp:TextBox> 
                    <asp:DropDownList ID="area" name = "area" class="form-control" 
                         onChange="habilitar(this.value);"  runat="server" required 
                         onselectedindexchanged="area_SelectedIndexChanged" >
                                    </asp:DropDownList>
                 <br /> 
                <asp:Button ID="btningresar" runat="server" class="btn btn-lg btn-primary btn-block" 
                         Text="Iniciar Sesión" type="submit" onclick="btningresar_Click" />
                </form>
            </div> 
        </div>
    </div>
</div>
</body>
</html>
