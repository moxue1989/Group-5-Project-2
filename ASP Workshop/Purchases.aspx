<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Purchases.aspx.cs" Inherits="ASP_Workshop.WebForm2" %>

<%--Front End Layout and Design by Kasi Emmanuel--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <div id="Container" class="container" runat="server">
        <div class="row">
            <%--Start page header--%>
            <div class="col-sm-8 col-sm-offset-2 divider-new">
                <label class="h2-responsive">Purchase Details</label>
            </div>
            <%--End page header--%>
        </div>

        <%--Display booking total of all bookings--%>
      <div class="col-xs-5  col-xs-offset-6  col-md-4 col-md-offset-7">
        <asp:Label ID="Label2" runat="server" Text="Customer Total:" Font-Bold="True" Font-Names="roboto" Font-Size="Larger"></asp:Label>
        <asp:Label CssClass="" ID="lblTotalCost" runat="server" Font-Bold="True" Font-Names="roboto" Font-Size="Larger"></asp:Label>
     </div>

    </div>
     
</asp:Content>
