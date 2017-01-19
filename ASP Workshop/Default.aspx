<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Workshop.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    Username:<br />
<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    <br />
    <br />
Password:<br />
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblLoginError" runat="server"></asp:Label>
    <br />
    <br />
<asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
    <br />

</asp:Content>
