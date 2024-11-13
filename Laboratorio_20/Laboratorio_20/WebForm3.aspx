<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm3.aspx.cs" Inherits="Laboratorio_20.FuncionalidadesLab14" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Funcionalidades del Laboratorio 14</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calculadora Básica</h2>
                 <asp:TextBox ID="txtNumero1" runat="server" />
                <asp:TextBox ID="txtNumero2" runat="server" />
                <asp:DropDownList ID="ddlOperacion" runat="server">
                    <asp:ListItem Value="+">+</asp:ListItem>
                    <asp:ListItem Value="-">-</asp:ListItem>
                    <asp:ListItem Value="*">*</asp:ListItem>
                    <asp:ListItem Value="/">/</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
                <asp:Label ID="Label1" runat="server" />

            <br /><br />
            <asp:Label ID="lblResultado" runat="server" Text="Resultado: " />
        </div>
    </form>
</body>
</html>
