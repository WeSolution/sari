<%@ Page Title="" Language="C#" MasterPageFile="~/RH/MasterPage/Principal.Master" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="SARI.WebForm2" %>

<%@ Register assembly="obout_ImageZoom_NET" namespace="OboutInc.ImageZoom" tagprefix="obout" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<%@ Register assembly="obout_Calendar2_Net" namespace="OboutInc.Calendar2" tagprefix="obout" %>
<%@ Register assembly="Obout.Ajax.UI" namespace="Obout.Ajax.UI.SmartImage" tagprefix="obout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        #TextArea1 {
            height: 13px;
            width: 146px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin:0 auto 0 auto; width:480px;">
        <asp:Label ID="Label45" runat="server" Text="Buscar Por: "></asp:Label>
    <asp:DropDownList ID="cbBuscar" runat="server" Height="24px" Width="140px" OnSelectedIndexChanged="cbBuscar_SelectedIndexChanged">
        <asp:ListItem>Id</asp:ListItem>
        <asp:ListItem Value="CURP"></asp:ListItem>
        <asp:ListItem>RFC</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="txtParametro" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador1" runat="server" ControlToValidate="txtParametro" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="grupoBuscar" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
    <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/RH/images/1422194782_old-edit-find.png" OnClick="btnBuscar_Click" style="height: 32px" ValidationGroup="grupoBuscar"  />
    <br /></div>
            <hr/>
        
    <p>
        <div style="margin:0 auto 0 auto; width:995px;">
 <asp:Label ID="Label9" runat="server" Text="CURP:"></asp:Label>
        <asp:TextBox ID="txtCurl" runat="server" Width="250px" CssClass="text-uppercase"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador2" runat="server" ControlToValidate="txtCurl" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
         <asp:Label ID="Label15" runat="server" Text="RFC:"></asp:Label>
        <asp:TextBox ID="txtRFC" runat="server" Width="250px" CssClass="text-uppercase"></asp:TextBox>
        
         <asp:RequiredFieldValidator ID="Validador3" runat="server" ControlToValidate="txtRFC" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                 
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" Width="250px" CssClass="text-capitalize" Height="23px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador4" runat="server" ControlToValidate="txtNombre" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Image ID="foto" runat="server" Height="163px" Width="159px" ImageUrl="~/RH/images/perfil.png" style="position: absolute; top: 53px; left: 775px;"/>
        <asp:Label ID="Label2" runat="server" Text="Apellido Paterno:"></asp:Label>
        <asp:TextBox ID="txtApaterno" runat="server" Width="228px" CssClass="text-capitalize" Height="22px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador5" runat="server" ControlToValidate="txtApaterno" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <asp:Label ID="Label3" runat="server" Text="Apellido Materno:"></asp:Label>
        <asp:TextBox ID="txtAmaterno" runat="server" Width="209px" CssClass="text-capitalize"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador6" runat="server" ControlToValidate="txtAmaterno" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
        <asp:TextBox ID="txtFnac"  runat="server" Height="25px" Width="189px"></asp:TextBox>

        <cc1:CalendarExtender ID="txtFnac_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtFnac" Format="dd/MM/yyyy">
        </cc1:CalendarExtender>

    &nbsp;<asp:RequiredFieldValidator ID="Validador7" runat="server" ControlToValidate="txtFnac" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
         <asp:Label ID="Label16" runat="server" Text="Estado Civil:" style=" top: 422px; left: 222px; " Height="17px"></asp:Label>
    <asp:TextBox ID="txtEstadoCivil" runat="server" CssClass="text-capitalize" ></asp:TextBox>

         <asp:RequiredFieldValidator ID="Validador8" runat="server" ControlToValidate="txtEstadoCivil" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>

    </p>
    <asp:Label ID="Label13" runat="server" Text="Area:" style=" top: 422px; left: 78px; width: 34px;"></asp:Label>
    <asp:TextBox ID="txtArea" runat="server" style=" top: 418px; left: 118px; width: 94px;" CssClass="text-capitalize"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador9" runat="server" ControlToValidate="txtArea" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
    <asp:Label ID="Label14" runat="server" Text="Puesto:" style=" top: 422px; left: 222px; width: 40px;"></asp:Label>
    <asp:TextBox ID="txtPuesto" runat="server" style=" top: 418px; left: 270px; width: 121px;" CssClass="text-capitalize"></asp:TextBox>
    
        &nbsp;&nbsp;<asp:RequiredFieldValidator ID="Validador10" runat="server" ControlToValidate="txtPuesto" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:RegularExpressionValidator ID="validaFoto" runat="server" ErrorMessage="Solo Imagenes (JPG,GIF,PNG,JPEG)" ForeColor="Red" style="position:absolute; top: 213px; left: 740px; width: 245px;" ControlToValidate="file" ValidationExpression=".*((\.jpg)|(\.bmp)|(\.gif)|(\.png)|(\.jpeg)|(\.JPG)|(\.GIF)|(\.PNG)|(\.BMP)|(\.JPEG))"></asp:RegularExpressionValidator>
    
        <asp:RadioButtonList ID="rbSexo" runat="server" RepeatDirection="Horizontal" Width="180px" RepeatLayout="Flow">
            <asp:ListItem Selected="True">Hombre</asp:ListItem>
            <asp:ListItem>Mujer</asp:ListItem>
        </asp:RadioButtonList>
    
    <input id="btnExaminar" runat="server" type="button" value="Examinar" style="position:absolute; top: 243px; left: 740px;" class="btn btn-primary"/>
    
    <br/>
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-primary" style="position: absolute; top: 243px; left: 875px; bottom: 1781px; height: 35px;" OnClick="btnCancelar_Click" />
    <p>
        
    <p>
        <asp:Label ID="Label5" runat="server" Text="Pais:"></asp:Label>
        <asp:TextBox ID="txtPais" runat="server" CssClass="text-capitalize"></asp:TextBox>
        
    &nbsp;<asp:RequiredFieldValidator ID="Validador11" runat="server" ControlToValidate="txtPais" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
         <asp:Label ID="Label6" runat="server" Text="Estado/Provincia:"></asp:Label>
        <asp:TextBox ID="txtestado" runat="server" CssClass="text-capitalize"></asp:TextBox>
        
         <asp:RequiredFieldValidator ID="Validador12" runat="server" ControlToValidate="txtestado" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
        
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Codigo Postal:"></asp:Label>
        <asp:TextBox ID="txtcp" runat="server" type="number"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador13" runat="server" ControlToValidate="txtcp" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <asp:Label ID="Label8" runat="server" Text="Colonia:"></asp:Label>
        <asp:TextBox ID="txtColonia" runat="server" CssClass="text-capitalize"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador14" runat="server" ControlToValidate="txtColonia" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </p>
    <p>

        <asp:Label ID="Label10" runat="server" Text="Calle"></asp:Label>
        <asp:TextBox ID="txtcalle" runat="server" CssClass="text-capitalize"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador16" runat="server" ControlToValidate="txtcalle" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <asp:Label ID="Label11" runat="server" Text="No. Exterior:"></asp:Label>
        <asp:TextBox ID="txtnexterior" runat="server" type="number"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Validador15" runat="server" ControlToValidate="txtnexterior" ErrorMessage="(✽)" ForeColor="Red" ToolTip="Requerido" ValidationGroup="InformacionPersonal" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <asp:Label ID="Label12" runat="server" Text="No. Interior:"></asp:Label>
        <asp:TextBox ID="txtninterior" runat="server"></asp:TextBox>
</Div>
        </p>
    <p>
        <asp:Button ID="btnsavefoto" runat="server" OnClick="btnsavefoto_Click" Text="guardaFoto" style="display:none;"/>
        <asp:FileUpload id="file" runat="server" onChange="" class="hidden" style="display:none;"/>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        </p>
    <script runat="server">

    protected void menuTabs_MenuItemClick(object sender, MenuEventArgs e)
    {
        multiTabs.ActiveViewIndex = Int32.Parse(menuTabs.SelectedValue);
        ControlsEnable(btnGuardar.Visible);
    }
</script>
    <div style="margin:0 auto 0 auto; width:600px;">
    <asp:Menu
        id="menuTabs"
        CssClass="menuTabs"
        StaticMenuItemStyle-CssClass="tab"
        StaticSelectedStyle-CssClass="selectedTab"
        Orientation="Horizontal"
        OnMenuItemClick="menuTabs_MenuItemClick"
        Runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
        <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="#FFFBD6" />
        <DynamicSelectedStyle BackColor="#FFCC66" />
        <Items>
        <asp:MenuItem
            Text="Telefonos"
            Value="0" 
            Selected="true" ImageUrl="~/RH/images/1439283793_address-book-alt.png" />
        <asp:MenuItem
            Text="Idioma" 
            Value="1" ImageUrl="~/RH/images/1439283880_english_ime.png"/>
        <asp:MenuItem
            Text="Habilidades"
            Value="2" ImageUrl="~/RH/images/1439283815_computer.png" />
            <asp:MenuItem ImageUrl="~/RH/images/product_documentation.png" Text="Informacion Academica" Value="3"></asp:MenuItem>
            <asp:MenuItem ImageUrl="~/RH/images/map.png" Text="Jornada Laboral" Value="4"></asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#990000" ForeColor="White" />
<StaticMenuItemStyle CssClass="tab" HorizontalPadding="5px" VerticalPadding="2px"></StaticMenuItemStyle>
<StaticSelectedStyle CssClass="selectedTab" BackColor="#FFCC66"></StaticSelectedStyle>
    </asp:Menu></div>
    <div class="tabBody">
    <asp:MultiView
        id="multiTabs"
        ActiveViewIndex="0"
        Runat="server">
        <asp:View ID="view1" runat="server">
        
            <hr />
        <div style="margin:0 auto 0 auto; width:600px;">
            <asp:Label ID="Label44" runat="server" Text="Telefono: "></asp:Label>
        
            <asp:DropDownList ID="cbTelefono" runat="server" Height="26px" Width="197px" AutoPostBack="True" OnSelectedIndexChanged="cbTelefono_SelectedIndexChanged">
                <asp:ListItem Value="0">Nuevo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label39" runat="server" Text="Tipo"></asp:Label>
            <asp:TextBox ID="txtTelTipo" runat="server" CssClass="text-capitalize"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="Validador17" runat="server" ControlToValidate="txtTelTipo" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoTelefono"></asp:RequiredFieldValidator>
            <asp:Label ID="Label17" runat="server" Text="Numero Telefonico: "></asp:Label>
            <asp:TextBox ID="txtTelNumero" runat="server" type="tel"></asp:TextBox>
            <asp:RequiredFieldValidator ID="Validador18" runat="server" ControlToValidate="txtTelNumero" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoTelefono"></asp:RequiredFieldValidator>
            </div>
            <br /><div align="center">
            <asp:ImageButton ID="btnAddTelefono" runat="server" ImageUrl="~/RH/images/correcto.png" OnClick="btnAddTelefono_Click" ValidationGroup="grupoTelefono" />
            <asp:ImageButton ID="btnDelTelefono" runat="server" ImageUrl="~/RH/images/error.png" OnClick="btnDelTelefono_Click" />
                </div>
            <hr />
        
        </asp:View>
        <asp:View ID="view2" runat="server">
            <hr /><div style="margin:0 auto 0 auto; width:600px;">
            <asp:Label ID="Label43" runat="server" Text="Idioma: "></asp:Label>
        <asp:DropDownList ID="cbIdioma" runat="server" Height="26px" Width="197px" AutoPostBack="True" OnSelectedIndexChanged="cbIdioma_SelectedIndexChanged">
                <asp:ListItem Value="0">Nuevo</asp:ListItem>
            </asp:DropDownList>
                <br />
                <p>
                    <asp:Label ID="Label36" runat="server" Text="Nombre del Idioma: "></asp:Label>
                    <asp:TextBox ID="txtIdiomaNombre" runat="server" CssClass="text-capitalize"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="Validador19" runat="server" ControlToValidate="txtIdiomaNombre" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoIdioma"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label37" runat="server" Text="Nivel: "></asp:Label>
                    <asp:TextBox ID="txtIdiomaNivel" runat="server" CssClass="text-capitalize"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Validador20" runat="server" ControlToValidate="txtIdiomaNivel" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoIdioma"></asp:RequiredFieldValidator>
                </p>
            <p>
                <asp:Label ID="Label38" runat="server" Text="Descripción: "></asp:Label>
                <asp:TextBox ID="txtIdiomaDes" runat="server" TextMode="multiline" Height="67px" Width="498px"></asp:TextBox>
            </div></p><div align="center">
        <asp:ImageButton ID="btnaddIdioma" runat="server" ImageUrl="~/RH/images/correcto.png" OnClick="btnaddIdioma_Click" ValidationGroup="grupoIdioma" />
            <asp:ImageButton ID="btndelidioma" runat="server" ImageUrl="~/RH/images/error.png" OnClick="btndelidioma_Click" />
        </div>
            <hr />
        
        </asp:View>
        <asp:View ID="view3" runat="server">
            <hr /><div style="margin:0 auto 0 auto; width:600px;">
            <asp:Label ID="Label42" runat="server" Text="Habilidades: "></asp:Label>
        <asp:DropDownList ID="cbHabilidad" runat="server" Height="26px" Width="197px" AutoPostBack="True" OnSelectedIndexChanged="cbHabilidad_SelectedIndexChanged">
                <asp:ListItem Value="0">Nuevo</asp:ListItem>
            </asp:DropDownList>
                <br />
            <p>
                <asp:Label ID="Label29" runat="server" Text="Tipo de Habilidad: "></asp:Label>
                <asp:TextBox ID="txthabilidadTipo" runat="server" CssClass="text-capitalize"></asp:TextBox>
                <asp:RequiredFieldValidator ID="Validador21" runat="server" ControlToValidate="txthabilidadTipo" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoHabilidad"></asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="Label30" runat="server" Text="Descripción: "></asp:Label>
                <asp:TextBox ID="txtHabilidadDesc" TextMode="multiline" runat="server" Height="72px" Width="493px"></asp:TextBox>
            </div></p><div align="center">
        <asp:ImageButton ID="btnAddHabilidad" runat="server" ImageUrl="~/RH/images/correcto.png" OnClick="btnAddHabilidad_Click" ValidationGroup="grupoHabilidad" />
            <asp:ImageButton ID="btnDelHabilidad" runat="server" ImageUrl="~/RH/images/error.png" OnClick="btnDelHabilidad_Click" />
            <hr /></div>
        </asp:View>
        <asp:View ID="view4" runat="server">
            <hr /><div style="margin:0 auto 0 auto; width:645px;">
            <asp:Label ID="Label41" runat="server" Text="Grado Academico: "></asp:Label>
        <asp:DropDownList ID="cbAcademica" runat="server" Height="26px" Width="197px" AutoPostBack="True" OnSelectedIndexChanged="cbAcademica_SelectedIndexChanged">
                <asp:ListItem Value="0">Nuevo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label23" runat="server" Text="Fecha de Inicio:"></asp:Label>
            <asp:TextBox ID="txtAcaInicio" runat="server" ></asp:TextBox>
                <cc1:CalendarExtender ID="txtAcaInicio_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtAcaInicio" Format="dd/MM/yyyy">
                </cc1:CalendarExtender>
            &nbsp;<asp:RequiredFieldValidator ID="Validador22" runat="server" ControlToValidate="txtAcaInicio" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoAcademico"></asp:RequiredFieldValidator>
                <asp:Label ID="Label24" runat="server" Text="Fecha de Fin:"></asp:Label>
            <asp:TextBox ID="txtAcaFin" runat="server" ></asp:TextBox>
            <cc1:CalendarExtender ID="txtAcaFin_CalendarExtender" runat="server" PopupPosition="Right" TargetControlID="txtAcaFin" Format="dd/MM/yyyy" TodaysDateFormat="dd MM, yyyy">
            </cc1:CalendarExtender>
                <asp:RequiredFieldValidator ID="Validador23" runat="server" ControlToValidate="txtAcaFin" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoAcademico"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label26" runat="server" Text="Nombre de la institucion"></asp:Label>
            <asp:TextBox ID="txtAcaInstitucion" runat="server" CssClass="text-capitalize"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="Validador24" runat="server" ControlToValidate="txtAcaInstitucion" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoAcademico"></asp:RequiredFieldValidator>
                <asp:Label ID="Label25" runat="server" Text="Titulo Obtenido: "></asp:Label>
            <asp:TextBox ID="txtAcaTitulo" runat="server" CssClass="text-capitalize"></asp:TextBox>
           
                <asp:RequiredFieldValidator ID="Validador25" runat="server" ControlToValidate="txtAcaTitulo" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoAcademico"></asp:RequiredFieldValidator>
           
            <br /></div>
           
            <br /><div align="center">
        <asp:ImageButton ID="btnAddAcademica" runat="server" ImageUrl="~/RH/images/correcto.png" OnClick="btnAddAcademica_Click" ValidationGroup="grupoAcademico" />
            <asp:ImageButton ID="btnDelAcademica" runat="server" ImageUrl="~/RH/images/error.png" OnClick="btnDelAcademica_Click" />
            </div>
            <hr />
        
        </asp:View>
        <asp:View ID="view5" runat="server">
        
            <hr />
        <div style="margin:0 auto 0 auto; width:695px;">
            <asp:Label ID="Label40" runat="server" Text="Jornada: "></asp:Label>
            <asp:DropDownList ID="cbJornada" runat="server" Height="26px" Width="197px" AutoPostBack="True" OnSelectedIndexChanged="cbJornada_SelectedIndexChanged">
                <asp:ListItem Value="0">Nuevo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label18" runat="server" Text="Tipo Jornada:"></asp:Label>
            <asp:TextBox ID="txtJornadaTipo" runat="server" CssClass="text-capitalize"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="Validador26" runat="server" ControlToValidate="txtJornadaTipo" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoJornada"></asp:RequiredFieldValidator>
            <asp:Label ID="Label19" runat="server" Text="Dias x Semana: "></asp:Label>
            <asp:TextBox ID="txtJornadaDias" runat="server" type="number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="Validador27" runat="server" ControlToValidate="txtJornadaDias" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoJornada"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label20" runat="server" Text="Turno: "></asp:Label>
            <asp:DropDownList ID="cbJornadaTurno" runat="server">
                <asp:ListItem Selected="True">Matutino</asp:ListItem>
                <asp:ListItem Value="Vespertino"></asp:ListItem>
                <asp:ListItem>Nocturno</asp:ListItem>
                <asp:ListItem>Diurno</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<asp:Label ID="Label21" runat="server" Text="Hora de Entrada: "></asp:Label>
            <asp:TextBox ID="txtJornadaHrEntrada" runat="server" Height="25px" Width="115px" type="time"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="Validador28" runat="server" ControlToValidate="txtJornadaHrEntrada" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoJornada"></asp:RequiredFieldValidator>
            <asp:Label ID="Label22" runat="server" Text="Hora de Salida :"></asp:Label>
            <asp:TextBox ID="txtJornadaHrSAlida" runat="server" Height="24px" Width="99px" type="time"></asp:TextBox>
            <asp:RequiredFieldValidator ID="Validador29" runat="server" ControlToValidate="txtJornadaHrSAlida" Display="Dynamic" ErrorMessage="(✽)" ForeColor="Red" SetFocusOnError="True" ToolTip="Requerido" ValidationGroup="grupoJornada"></asp:RequiredFieldValidator>
            <br />
            <br /></div>
           <div align="center">
        <asp:ImageButton ID="btnaddJornada" runat="server" ImageUrl="~/RH/images/correcto.png" OnClick="btnaddJornada_Click" ValidationGroup="grupoJornada" />
            <asp:ImageButton ID="btnCancelJornada" runat="server" ImageUrl="~/RH/images/error.png" OnClick="btnCancelJornada_Click" />
        </div>
            <hr />
        </asp:View>
    </asp:MultiView>  
        <div align="right">
                &nbsp;<asp:Label ID="lblerror" runat="server" ForeColor="Red"></asp:Label>
    &nbsp;<asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click"  class="btn btn-primary"  Text="Editar" Enabled="False" EnableTheming="False"/>
                <asp:Button ID="btnGuardar" class="btn btn-primary" runat="server" OnClick="btnGuardar_Click" Text="Guardar" Enabled="False" Visible="False" ValidationGroup="InformacionPersonal" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancelar" Visible="False" class="btn btn-primary" EnableTheming="False"/>
            <script type = "text/javascript">
                function Confirmar() {
                    var confirm_value = document.createElement("INPUT");
                    confirm_value.type = "hidden";
                    confirm_value.name = "confirm_value";
                    if (confirm("¿Esta completamente seguro que desea eliminar?")) {
                        confirm_value.value = "Si";
                    } else {
                        confirm_value.value = "No";
                    }
                    document.forms[0].appendChild(confirm_value);
                }
    </script>    
            <asp:Button ID="btnEliminar" class="btn btn-primary" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" OnClientClick = "Confirmar()" Enabled="False" EnableTheming="True"  />

                <asp:Button ID="btnCancelEdit"  class="btn btn-primary" runat="server" Enabled="False" OnClick="btnCancelEdit_Click" Text="Cancelar"/>

            </div>
          
    </div>
</asp:Content>
