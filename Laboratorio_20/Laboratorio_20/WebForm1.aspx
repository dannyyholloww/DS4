<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="Laboratorio_20.TablaMultiplicar" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabla de Multiplicar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Generador de Tabla de Multiplicar</h2>
                <asp:TextBox ID="txtNumero" runat="server" />
                <asp:Button ID="btnGenerar" runat="server" Text="Generar" OnClick="btnGenerar_Click" />
                <asp:Label ID="Label1" runat="server" />

            <br /><br />
            <asp:Label ID="lblResultado" runat="server" Text="" />
        </div>
    </form>
</body>
</html>
