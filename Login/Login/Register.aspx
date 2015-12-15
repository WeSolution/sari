<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Login.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>..::Register::..</title>
    <link rel="stylesheet" href="/CSS/bootstrap.min.css"  />

    <!-- Optional theme -->
    <link rel="stylesheet" href="/CSS/bootstrap-theme.min.css"  />
    <link href="login.css" rel="stylesheet" type="text/css" />

</head>
<body>
   <div class="container">
    <div class="row">
        <div class="col-sm-6 col-md-4 col-md-offset-4">
            <h1 class="text-center login-title">Registrarse</h1>
            <div class="account-wall">
                 
                <form id="Form1"   class="form-signin" runat="server">
                 
                 <asp:Label ID="Empleado" runat="server" Text="Empleado:"></asp:Label>
                <asp:DropDownList ID="EmpleadoCombo" class="form-control" runat="server" required autofocus> </asp:DropDownList>
                <br />
                <asp:TextBox ID="txtusuario" runat="server" type="text"  class="form-control" 
                    placeholder="usuario" required autofocus  ></asp:TextBox>
                <asp:TextBox ID="txtpass" runat="server" type="password" class="form-control" placeholder="Password" required></asp:TextBox> 
                 
                <asp:Label ID="Label1" runat="server" Text="Privelegio:"></asp:Label>
                <asp:DropDownList ID="Privilegio" class="form-control" runat="server" required autofocus> </asp:DropDownList>

                
                <asp:Button ID="Button1" runat="server"  
                    class="btn btn-lg btn-primary btn-block" Text="Registrarse" onclick="Button1_Click" 
                    />
                </form>
            </div>
             
        </div>
    </div>
</div>
</body>
</html>
