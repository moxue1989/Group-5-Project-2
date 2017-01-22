<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="ASP_Workshop.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-sm-10 col-sm-offset-1 ">
        <div id="messageAlert" class="alert alert-dismissible alert-danger" runat="server" Visible="False">
       
            <button type="button" class="close" data-dismiss="alert">×</button>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
        <div class="row">
                 <!--Header-->
        <div class="header text-xs-center"  >
            <asp:Label ID="newCust" CssClass="h2-responsive" runat="server" Text="Customer Registration:"></asp:Label>
           <asp:Label ID="AccountDetails" CssClass="h2-responsive" runat="server" Text="Change Account Details:"></asp:Label>
           <hr class="mt-2 mb-2"/>
        </div>
            <div class="col-sm-6">
                
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtFirstName" runat="server" />
                    <label for="form4">First Name:</label>
                </div>
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtLastName" runat="server" />
                    <label for="form4">Last Name:</label>
                </div>
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtHomePhone" runat="server" />
                    <label for="form4">Home Phone:</label>
                </div>

                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtBusPhone" runat="server" />
                    <label for="form4">Business Phone:</label>
                </div>
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" />
                    <label for="form4">Email:</label>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtAddress" runat="server" />
                    <label for="form4">Address:</label>
                </div>
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtCity" runat="server" />
                    <label for="form4">City:</label>
                </div>
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtProv" runat="server" />
                    <label for="form4">Province:</label>
                </div>
                
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtPostal" runat="server" />
                    <label for="form4">Postal:</label>
                </div>
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtCountry" runat="server" />
                    <label for="form4">Country:</label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-8">
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:DropDownList CssClass="form-control" ID="ddlAgents" runat="server"></asp:DropDownList>
                    <%--<h6 id="lblAgent" runat="server">Agent:</h6>--%>
                </div>
            </div>
            <div class="col-sm-4">
                
            </div>
        </div>
    <div id="LoginInfo" runat="server"></div>
        <div class="row" id="newCustomerPassword" runat="server">
           <%-- <div class="col-sm-6">
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtUserName" runat="server" />
                    <label for="form4">UserName:</label>
                </div>
                
            </div>--%>
            <div class="col-sm-6">
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox  CssClass="form-control" ID="txtPassword" runat="server" />
                    <label for="form4">Password:</label>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtConfirmPassword" runat="server" />
                    <label for="form4">Confirm Password:</label>
                </div>
            </div>
        </div>
        <div class="container ">
            <div class="col-sm-4">
                
                <asp:Button CssClass="btn btn-primary" Font-Size="12" ID="btnUpdate" Width="100px" runat="server" OnClick="btnUpdate_Click" Text="Update Info" />
                
            </div>
            <div class="col-sm-4 ">
                <asp:Button CssClass="btn btn-primary" ID="btnRegister" Width="100px"  runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
        </div>
    </div>
</asp:Content>
