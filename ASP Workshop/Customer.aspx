<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="ASP_Workshop.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-sm-10 col-sm-offset-1 ">
        <div id="messageAlert" class="alert alert-dismissible alert-danger" runat="server" visible="False">
            <button type="button" class="close" data-dismiss="alert">×</button>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="FNReqV" runat="server" Display="Dynamic" ErrorMessage="First Name is required!" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
            <%--<asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="LNReqV" runat="server" Display="Dynamic" ErrorMessage="Last Name is required!" ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
            <asp:RangeValidator CssClass="alert alert-dismissible alert-danger" ID="LNRangeV" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name must be between 0 and 15 characters!" MaximumValue="15" MinimumValue="0"></asp:RangeValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="HPReqV" runat="server" Display="Dynamic" ErrorMessage="Home Phone is required!" ControlToValidate="txtHomePhone"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator CssClass="alert alert-dismissible alert-danger" ID="HPFormatV" runat="server" ControlToValidate="txtHomePhone" Display="Dynamic" ErrorMessage="Home Phone has wrong format. (EX: 999-999-9999)" ValidationExpression="([2-9]\d{2})-?([2-9]\d{2})-?(\d{4})"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="EmailReqV" runat="server" Display="Dynamic" ErrorMessage="Email is required!" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator CssClass="alert alert-dismissible alert-danger" ID="EmailFormatV" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email has wrong format. (EX: example@email.com)" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <asp:RegularExpressionValidator CssClass="alert alert-dismissible alert-danger" ID="BPFormatV" runat="server" ControlToValidate="txtBusPhone" Display="Dynamic" ErrorMessage="Business Phone has wrong format. (EX: 999-999-9999)" ValidationExpression="([2-9]\d{2})-?([2-9]\d{2})-?(\d{4})"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="AddReqV" runat="server" Display="Dynamic" ErrorMessage="Address is Required!" ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
            <asp:RangeValidator CssClass="alert alert-dismissible alert-danger" ID="AddRangeV" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address must be between 0 and 75 characters!" MaximumValue="75" MinimumValue="0"></asp:RangeValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="CityReqV" runat="server" Display="Dynamic" ErrorMessage="City is Required!" ControlToValidate="txtCity"></asp:RequiredFieldValidator>
            <asp:RangeValidator CssClass="alert alert-dismissible alert-danger" ID="CityFormatV" runat="server" ControlToValidate="txtCity" ErrorMessage="City must be between 0 and 15 characters!" MaximumValue="15" MinimumValue="0"></asp:RangeValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="ProvReqV" runat="server" Display="Dynamic" ErrorMessage="Province is Required!" ControlToValidate="txtProv"></asp:RequiredFieldValidator>
            <asp:RangeValidator CssClass="alert alert-dismissible alert-danger" ID="ProvFormatV" runat="server" ControlToValidate="txtProv" ErrorMessage="Province must be 2 characters!" MaximumValue="2" MinimumValue="2"></asp:RangeValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="PostalReqV" runat="server" Display="Dynamic" ErrorMessage="Postal Code is Required!" ControlToValidate="txtPostal"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="PostalFormatV" runat="server" ControlToValidate="txtPostal" Display="Dynamic" ErrorMessage="Postal Code has wrong format. (EX: Z9Z 9Z9)" ValidationExpression="^[A-Z]\d[A-Z] \d[A-Z]\d$"></asp:RegularExpressionValidator>
            <asp:RangeValidator CssClass="alert alert-dismissible alert-danger" ID="CountryRangeV" runat="server" ControlToValidate="txtCountry" ErrorMessage="Country must be between 0 and 50 characters!" MaximumValue="50" MinimumValue="0"></asp:RangeValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="UNReqV" runat="server" Display="Dynamic" ErrorMessage="User Name is required!" ControlToValidate="txtUserName" Enabled="False"></asp:RequiredFieldValidator>
            <asp:RangeValidator CssClass="alert alert-dismissible alert-danger" ID="UNRangeV" runat="server" ControlToValidate="txtUserName" ErrorMessage="Username must be between 0 and 50 characters!" MaximumValue="50" MinimumValue="0" Enabled="False"></asp:RangeValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="PWReqV" runat="server" Display="Dynamic" ErrorMessage="Password is required!" ControlToValidate="txtPassword" Enabled="False"></asp:RequiredFieldValidator>
            <asp:RangeValidator CssClass="alert alert-dismissible alert-danger" ID="PWRangeV" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password must be between 0 and 20 characters!" MaximumValue="20" MinimumValue="0" Enabled="False"></asp:RangeValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-dismissible alert-danger" ID="CPWReqV" runat="server" Display="Dynamic" ErrorMessage="Confirm Password is required!" ControlToValidate="txtConfirmPassword" Enabled="False"></asp:RequiredFieldValidator>
            <asp:RangeValidator CssClass="alert alert-dismissible alert-danger" ID="CPWRangeV" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Confirm Password must be between 0 and 20 characters!" MaximumValue="20" MinimumValue="0" Enabled="False"></asp:RangeValidator>
            <asp:CompareValidator CssClass="alert alert-dismissible alert-danger" ID="CPWCompareV" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" Enabled="False" ErrorMessage="Passwords must be the same!"></asp:CompareValidator>--%>
        </div>
        <div class="row">
            <!--Header-->
            <div class="header text-xs-center">
                <asp:Label ID="newCust" CssClass="h2-responsive" runat="server" Text="Customer Registration:"></asp:Label>
                <asp:Label ID="AccountDetails" CssClass="h2-responsive" runat="server" Text="Change Account Details:"></asp:Label>
                <hr class="mt-2 mb-2" />
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
                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" />
                    <label for="form4">Email:</label>

                </div>

                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtBusPhone" runat="server" />
                    <label for="form4">Business Phone:</label>

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
                    <label for="form4">Postal Code:</label>

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
            <div class="col-sm-6">
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtUserName" runat="server" />
                    <label for="form4">UserName:</label>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" />
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

                <asp:Button CssClass="btn btn-primary" Font-Size="12" ID="btnUpdate" Width="100px" runat="server" OnClick="btnUpdate_Click" Text="Update Info" CausesValidation="False" />

            </div>
            <div class="col-sm-4 ">
                <asp:Button CssClass="btn btn-primary" ID="btnRegister" Width="100px" runat="server" Text="Register" OnClick="btnRegister_Click" CausesValidation="False" />
            </div>
        </div>
    </div>
</asp:Content>
