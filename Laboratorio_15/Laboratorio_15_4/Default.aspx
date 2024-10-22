<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppSum.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sumar dos números</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Suma de dos números</h2>
            <asp:Label ID="Label1" runat="server" Text="Ingrese el primer número: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br /><br />
            
            <asp:Label ID="Label2" runat="server" Text="Ingrese el segundo número: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br /><br />
            
            <asp:Button ID="Button1" runat="server" Text="Sumar" OnClick="Button1_Click" />
            <br /><br />
            
            <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
