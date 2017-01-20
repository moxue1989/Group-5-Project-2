<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Workshop.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  

    <main class="card col-sm-6 col-sm-offset-1 col-md-6 col-md-offset-1">
      <div class="header" id="blank"><p class="text-xs-left">Login to your Account</p></div>
        <!--Header-->
        
            <div class="card-block loginCard text-xs-center text-md-center">
                
                <div class="md-form">
                    <i class="fa fa-envelope prefix"></i>
                    <asp:TextBox CssClass="form-control text-center" ID="txtUsername" Width="350" runat="server" MaxLength="20" Font-Names="Roboto"></asp:TextBox>
                    <label data-error="wrong" data-success="right">Username</label>
                </div>

                <div class="md-form password">
                    <i class="fa fa-envelope prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtPassword" Width="350" runat="server" MaxLength="15" Font-Names="Roboto"></asp:TextBox>
                    <label data-error="wrong" data-success="right">Password</label>
                    
                </div>
               <div class="alert alert-dismissible alert-danger">
                  <button type="button" class="close" data-dismiss="alert">&times;</button>
                   <asp:Label CssClass="control-label" for="txtUsername txtPassword" ID="lblLoginError" runat="server"></asp:Label>
                  <strong>Oh snap!</strong> <a href="#" class="alert-link">Change a few things up</a> and try submitting again.
               </div>
                    
           
                <div class="md-form ">
                     
                    <div class="col-sm-12">        
                        <asp:Button CssClass="btn btn-primary btn-sm" ID="btnLogin"  runat="server" OnClick="btnLogin_Click" Text="Login" />
                    </div>
                 </div>
                   <!--Footer-->
                <div class="col-sm-12 modal-footer">
                    <div class="options">
                        <p>Not a member? <a href="Customer.aspx">Sign Up</a>     |       
                        Forgot <a href="#">Password?</a></p>
                    </div>
                </div> 
            </div>
      
    </main>    
   
      <aside class="col-sm-4 col-lg-4 content">
        
    </aside>

</asp:Content>
