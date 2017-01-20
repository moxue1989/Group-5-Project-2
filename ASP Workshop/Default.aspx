<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Workshop.WebForm1" %>

<%--All front end codign done by Kasi Emmanuel--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  

    <main class="card col-xs-12 col-sm-6 col-md-6">
        <!--Start Header-->
      <div class="header" id="blank"><p class="text-xs-left">Login to your Account</p></div>
        <!--End Header-->

            <!--Login Form Body-->
            <div class="card-block loginCard text-sm-center text-lg-center">
                
                <div class="md-form">
                    <i class="fa fa-envelope prefix"></i>
                    <asp:TextBox CssClass="form-control has-error" ID="txtUsername" runat="server" MaxLength="20" Font-Names="Roboto"></asp:TextBox>
                    <label data-error="wrong" data-success="right">Username</label>
                </div>

                <div class="md-form password">
                    <i class="fa fa-envelope prefix"></i>
                    <asp:TextBox CssClass="form-control has-error" ID="txtPassword" TextMode="Password"  runat="server" MaxLength="15" Font-Names="Roboto"></asp:TextBox>
                    <label data-error="wrong" data-success="right">Password</label>
                    
                </div>

                <div class="md-form text-center">
                        <asp:Button CssClass="btn btn-primary btn-sm" ID="btnLogin"  runat="server" OnClick="btnLogin_Click" Text="Login" />
                </div>

                <div class="md-form has-error text-center" id="error ">
                    <asp:Label CssClass="control-label " Font-Names="Roboto" for="txtUsername txtPassword" Height="30px" ID="lblLoginError" runat="server"></asp:Label>
                </div>     
            <!--Login Form Body-->
                   <!--Start Footer-->
                <div class="col-sm-12 modal-footer">
                    <div class="options">
                        <p>Not a member? <a href="Customer.aspx">Sign Up</a>     |       
                        Forgot <a href="#">Password?</a></p>
                    </div>
                </div> 
                  <!--End Footer-->
            </div>
      
    </main>    

   <!--Login Form Image-->
      <aside class="col-xs-12 col-sm-6 col-md-5  content">
      </aside>
    <!--End Login Form Image-->
</asp:Content>
