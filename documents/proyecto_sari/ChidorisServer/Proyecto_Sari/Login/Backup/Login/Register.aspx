<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Login.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>..::Register::..</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css"  />

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css"  />
    <link href="login.css" rel="stylesheet" type="text/css" />

</head>
<body>
   <div class="container">
    <div class="row">
        <div class="col-sm-6 col-md-4 col-md-offset-4">
            <h1 class="text-center login-title">Registrarse</h1>
            <div class="account-wall">
                 
                <form id="Form1"   class="form-signin" runat="server">
                <asp:TextBox ID="Nombre_empleado" runat="server" class="form-control" required autofocus placeholder="Nombre del empleado"></asp:TextBox>
                <asp:TextBox ID="Apellido_p" runat="server" class="form-control" required autofocus placeholder="Apellido paterno"></asp:TextBox>
                <asp:TextBox ID="Apellido_m" runat="server" class="form-control" required autofocus placeholder="Apellido materno"></asp:TextBox> 
                
                
                <asp:TextBox ID="txtusuario" runat="server" type="text"  class="form-control" 
                    placeholder="usuario" required autofocus  ></asp:TextBox>
                <asp:TextBox ID="txtpass" runat="server" type="password" class="form-control" placeholder="Password" required></asp:TextBox> 

                <asp:TextBox ID="Direccion" runat="server" class="form-control" required autofocus placeholder="Dirección"></asp:TextBox>
                <asp:TextBox ID="Telefono" runat="server" class="form-control" required autofocus placeholder="Telefono "></asp:TextBox> 
                <asp:TextBox ID="Correo" runat="server" class="form-control" required autofocus placeholder="Correo"></asp:TextBox> 
                
                <asp:Label ID="Label3" runat="server" Text="Sexo:"></asp:Label>
                <asp:DropDownList ID="Sexo" class="form-control" runat="server" required autofocus> </asp:DropDownList>

                <asp:Label ID="Label1" runat="server" Text="Privelegio:"></asp:Label>
                <asp:DropDownList ID="Privilegio" class="form-control" runat="server" required autofocus> </asp:DropDownList>

                <asp:Label ID="Label2" runat="server" Text="Nombre del area"></asp:Label>
                <asp:DropDownList ID="area" runat="server" class="form-control" required autofocus placeholder="Nombre del area"> </asp:DropDownList>
                <br />
                <asp:TextBox ID="descripcion" runat="server" class="form-control" required autofocus placeholder="Descripción del area" ></asp:TextBox>
                 <br />
                <asp:TextBox ID="telearea" runat="server" class="form-control" required autofocus placeholder="Telefono del area" ></asp:TextBox>
                <br />
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
