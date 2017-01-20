<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerLanding.aspx.cs" Inherits="ASP_Workshop.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblWelcome" runat="server"></asp:Label>
    <br />
    <br />
    <br />
    <asp:GridView ID="gvBookings" runat="server">
    </asp:GridView>
    <asp:DropDownList ID="ddlBookings" runat="server" OnSelectedIndexChanged="ddlBookings_SelectedIndexChanged" AutoPostBack="True">
    </asp:DropDownList>
    <br />
    <br />
    <asp:GridView ID="gvDetails" runat="server">
    </asp:GridView>
    <br />
    <br />
    <br />
</asp:Content>
