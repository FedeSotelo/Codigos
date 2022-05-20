<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Clase11ASP.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .style1 {
            text-align: center;
            font-weight: normal;
            text-decoration: underline;
            color: white;
            font-size: 40px;
        }
    </style>
</head>
<body style="background-color: #66CCFF" font-size: 20px;>
    <form id="form1" runat="server">
        <div>
            <h1 class="style1"> <em>Bienvenido al Sitio de HTML</em></h1>
            <h3>Ejemplo de uso de cite y bloquote</h3>

            <p>

                Como dijo <cite>Jonnhy Deep</cite>
            </p>
            <blockquote> 
               ¡-No dejes para mañana lo que puedes hacer hoy-!
            </blockquote>

            <ol type="I">
                <li>Argentina</li>
                <li>Chile</li>
            </ol>
            
            <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>

        </div>
    </form>
</body>
</html>
