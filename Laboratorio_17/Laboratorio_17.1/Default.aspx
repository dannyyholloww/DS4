<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_17._1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 
  <div class="row">


      <div>
      <asp:GridView id="MyGridView" DataSourceID="MyDataSource1"
           AllowSorting="True" AllowPaging="True"
           DataKeyNames="ProductID"
           AutoGenerateEditButton="True"
     Runat="Server" />

    <asp:SqlDataSource ID="MyDataSource1" Runat="Server"
        ConnectionString="data source=DESKTOP-V42SQS6\SQLEXPRESS;initial catalog=northwind;persist security info=True;Integrated Security=SSPI;"
        ProviderName="System.Data.SqlClient"
        SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products"
        UpdateCommand="Update Products Set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice Where [ProductID]=@ProductID">
    </asp:SqlDataSource>
</div>


        </div>
            

</asp:Content>
