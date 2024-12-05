<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Parcial_3_app.Default" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lista de Artículos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Artículos Científicos</h2>
            <asp:GridView ID="gvArticulos" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="Titulo" HeaderText="Título" />
        <asp:BoundField DataField="PalabrasClave" HeaderText="Palabras Clave" />
        <asp:BoundField DataField="FechaPublicacion" HeaderText="Fecha de Publicación" />
    </Columns>
</asp:GridView>


            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Artículo" OnClick="btnNuevo_Click" />
        </div>
    </form>
</body>
</html>
