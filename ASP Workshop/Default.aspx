<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Workshop.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <aside class="col-sm-4 content">
        
    </aside>

    <main class="col-sm-6 col-sm-offset-1 card text-center">
        <div class="row" id="blank"></div>
        <div class=" card-block loginCard">
            
        <div class="md-form">
            <i class="fa fa-envelope prefix"></i>
            <asp:TextBox CssClass="text-center form-control" ID="txtUsername" runat="server" MaxLength="20"></asp:TextBox>
            <label>Username</label>
        </div>
        

        <div class="md-form">
            <i class="fa fa-envelope prefix"></i>
            <asp:TextBox CssClass="text-center form-control" ID="txtPassword" runat="server" MaxLength="15"></asp:TextBox>
            <label>Password</label>
        </div>
        
    
        <asp:Label ID="lblLoginError" runat="server"></asp:Label>
   
        <asp:Button CssClass="btn btn-primary btn-round" ID="btnLogin" Width="150px" runat="server" OnClick="btnLogin_Click" Text="Login" />
   </div>
    

    </main>    
   
    

</asp:Content>
