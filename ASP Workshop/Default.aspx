<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Workshop.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  

    <main class="card col-sm-6 offset-sm-1">
      <div class="modal-header" id="blank"><h5 class="text-sm-left">Login to your Account</h5></div>
        <!--Header-->
        
        <div class=" card-block loginCard text-center">
   
            <div class="md-form">
                <i class="fa fa-envelope prefix"></i>
                <asp:TextBox CssClass="form-control text-center" ID="txtUsername" runat="server" MaxLength="20" Font-Names="Roboto"></asp:TextBox>
                <label>Username</label>
            </div>
        

            <div class="md-form">
                <i class="fa fa-envelope prefix"></i>
                <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" MaxLength="15" Font-Names="Roboto"></asp:TextBox>
                <label>Password</label>
            </div>
          
            <div class="md-form">
                <asp:Label ID="lblLoginError" runat="server"></asp:Label>
                <div class="text-xs-center">
                    <asp:Button CssClass="btn btn-primary btn-sm" ID="btnLogin"  runat="server" OnClick="btnLogin_Click" Text="Login" />
                </div>
            </div>
               <!--Footer-->
            <div class="modal-footer">
                <div class="options">
                    <p>Not a member? <a href="Customer.aspx">Sign Up</a>     |       
                   Forgot <a href="#">Password?</a></p>
                </div>
            </div> 
            
         
      </div>
    

    </main>    
   
      <aside class="col-sm-4 content">
        
    </aside>

</asp:Content>
