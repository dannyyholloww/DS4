<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="Parcial_3_app.Articulos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Artículo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Título:</label>
            <asp:TextBox ID="txtTitulo" runat="server" />
        </div>
        <div>
            <label>Palabras Clave:</label>
            <asp:TextBox ID="txtPalabrasClave" runat="server" />
        </div>
        <div>
            <label>Fecha:</label>
            <asp:TextBox ID="txtFecha" runat="server" TextMode="Date" />
        </div>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    </form>
</body>
</html>
