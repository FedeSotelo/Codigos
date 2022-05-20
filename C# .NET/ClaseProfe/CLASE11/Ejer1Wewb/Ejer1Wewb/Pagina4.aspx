<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina4.aspx.cs" Inherits="Ejer1Wewb.Pagina4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1 class="estilo1"><strong>Trabajando con Chekbox</strong></h1>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label">Ingrese Nro 1: </asp:Label> <asp:TextBox ID="txtNro1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label">Ingrese Nro 2: </asp:Label> <asp:TextBox ID="txtNro2" runat="server"></asp:TextBox>
             <br />
             <asp:RadioButton ID="rdbSuma" runat="server" Text="Suma" />
             <br />
             <br />
             <asp:RadioButton ID="rdbResta" runat="server" Text="Resta" />
             <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
             <asp:Button ID="Button1" runat="server" Text="Limpiar" Width="71px" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label">Resultado: </asp:Label> <asp:Label ID="LblResultado" runat="server" Text="Label"></asp:Label> 


        </div>
    </form>
</body>
</html>
