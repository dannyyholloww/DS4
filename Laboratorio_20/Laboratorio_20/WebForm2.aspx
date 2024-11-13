<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm2.aspx.cs" Inherits="Laboratorio_20.MatrizDiagonal" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matriz Diagonal Inversa</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Generador de Matriz Diagonal Inversa</h2>
                <asp:TextBox ID="txtTamaño" runat="server" />
                <asp:Button ID="btnGenerar" runat="server" Text="Generar" OnClick="btnGenerar_Click" />
                <asp:Literal ID="Literal1" runat="server" />

            <br /><br />
            <asp:Literal ID="lblMatriz" runat="server" />
        </div>
    </form>
</body>
</html>
