<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Ejer1Wewb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">        
    </style>
    <link href="Estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="estilo1"><strong>Bienvenido al Sitio de HTML</strong></h1>
            <h3>Ejemplos de uso de cite y Bloquote</h3>

            <p>
                Como dijo <cite>Mahtma Gandhi</cite>
            </p>
            <blockquote>
                Como si fueras a morir mañana y aprende como si fueras a vivir siempre!!!
            </blockquote>

            <ol type="I">
                <li>Argentina</li>
                <li>Brazil</li>
                <li>Chile</li>
            </ol>

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pagina1.aspx">Ir a la Pagina 1</asp:HyperLink>
        
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Pagina2.aspx">Ir a la Pagina 2</asp:HyperLink>
        
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Pagina3.aspx">Ir a la Pagina 3</asp:HyperLink>

            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Pagina4.aspx">Ir a la Pagina 4</asp:HyperLink>
        </div>
    </form>
</body>
</html>
