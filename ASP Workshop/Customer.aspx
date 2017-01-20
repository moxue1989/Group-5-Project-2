<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="ASP_Workshop.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container form-group-lg">
        <div id="messageAlert" class="alert alert-dismissible alert-danger" runat="server" Visible="False">
            <button type="button" class="close" data-dismiss="alert">×</button>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <h6>First Name:</h6>
                <asp:TextBox CssClass="form-control" ID="txtFirstName" runat="server" ></asp:TextBox>
                <h6>Last Name:</h6>
                <asp:TextBox CssClass="form-control" ID="txtLastName" runat="server" ></asp:TextBox>
                <h6>Home Phone:</h6>
                <asp:TextBox CssClass="form-control" ID="txtHomePhone" runat="server" ></asp:TextBox>
                <h6>Business Phone:</h6>
                <asp:TextBox CssClass="form-control" ID="txtBusPhone" runat="server" ></asp:TextBox>
                <h6>Email:</h6>
                <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" ></asp:TextBox>
            </div>
            <div class="col-sm-6">
                <h6>Address:</h6>
                <asp:TextBox CssClass="form-control" ID="txtAddress" runat="server" ></asp:TextBox>
                <h6>City:</h6>
                <asp:TextBox CssClass="form-control" ID="txtCity" runat="server" ></asp:TextBox>
                <h6>Province:</h6>
                <asp:TextBox CssClass="form-control" ID="txtProv" runat="server" ></asp:TextBox>
                <h6>Postal:</h6>
                <asp:TextBox CssClass="form-control" ID="txtPostal" runat="server" ></asp:TextBox>
                <h6>Country:</h6>
                <asp:TextBox CssClass="form-control" ID="txtCountry" runat="server" ></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-8">
                <h6 id="lblAgent" runat="server">Agent:</h6>
                <asp:DropDownList CssClass="form-control" ID="ddlAgents" runat="server"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                
            </div>
        </div>
    <div id="LoginInfo" class="page-header" runat="server">Login Information:</div>
        <div class="row" id="newCustomerPassword" runat="server">
            <div class="col-sm-6">
                <h6>UserName:</h6>
                <asp:TextBox CssClass="form-control" ID="txtUserName" runat="server" />
            </div>
            <div class="col-sm-6">
                <h6>Password:</h6>
                <asp:TextBox type="password" class="form-control" ID="txtPassword" runat="server" ></asp:TextBox>
                <h6>Confirm Password:</h6>
                <asp:TextBox type="password" class="form-control" ID="txtConfirmPassword" runat="server" ></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update Info" />
                
            </div>
            <div class="col-sm-8">
                
            </div>
            <div class="col-sm-4">
                <asp:Button CssClass="btn btn-primary btn-lg" ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
        </div>
    </div>
</asp:Content>
