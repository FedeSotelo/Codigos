<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="Ejer1Wewb.Pagina2" %>

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
            <h1 class="estilo1"><strong>Usando controles de WebForms</strong></h1>


            <br />
            <br />
            hola Mundo!!!<br />
            Fecha Actual: <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
            <br />
            Dia de la semana: <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />

            Hora: <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br /><br />

            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Index.aspx">Volver Pagina Principal</asp:HyperLink>
        </div>
    </form>
</body>
</html>
