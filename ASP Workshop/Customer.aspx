<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="ASP_Workshop.WebForm3" %>

<%--Dhwani Desai inserted the validations | 
    Kasi Emmanuel coded all the Front End--%> 

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <div class="col-sm-10 col-sm-offset-1 ">
        <%--Display confirmation message to Customer--%>
        <div id="messageAlert" class="alert alert-dismissible alert-danger" runat="server" visible="False">
            <button type="button" class="close" data-dismiss="alert">×</button>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>

        <%--Display all the input fields errors--%> 
        <div class="row">
            <asp:RequiredFieldValidator CssClass="control-label" ID="FNReqV" runat="server" Display="Dynamic" ErrorMessage="First Name is required!" ControlToValidate="txtFirstName" EnableClientScript="False"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator CssClass="control-label" ID="LNReqV" runat="server" Display="Dynamic" ErrorMessage="Last Name is required!" ControlToValidate="txtLastName" EnableClientScript="False"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator CssClass="control-label" ID="HPReqV" runat="server" Display="Dynamic" ErrorMessage="Home Phone is required!" ControlToValidate="txtHomePhone" EnableClientScript="False"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator CssClass="control-label" ID="HPFormatV" runat="server" ControlToValidate="txtHomePhone" Display="Dynamic" ErrorMessage="Home Phone has wrong format. (EX: 1112229999)" ValidationExpression="([2-9]\d{2})-?([2-9]\d{2})-?(\d{4})" EnableClientScript="False"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator CssClass="control-label" ID="EmailReqV" runat="server" Display="Dynamic" ErrorMessage="Email is required!" ControlToValidate="txtEmail" EnableClientScript="False"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator CssClass="control-label" ID="EmailFormatV" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email has wrong format. (EX: example@email.com)" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" EnableClientScript="False"></asp:RegularExpressionValidator>

            <asp:RegularExpressionValidator CssClass="control-label" ID="BPFormatV" runat="server" ControlToValidate="txtBusPhone" Display="Dynamic" ErrorMessage="Business Phone has wrong format. (EX: 1112229999)" ValidationExpression="([2-9]\d{2})-?([2-9]\d{2})-?(\d{4})" EnableClientScript="False"></asp:RegularExpressionValidator>

            <asp:RequiredFieldValidator CssClass="control-label" ID="AddReqV" runat="server" Display="Dynamic" ErrorMessage="Address is Required!" ControlToValidate="txtAddress" EnableClientScript="False"></asp:RequiredFieldValidator>

            <asp:RequiredFieldValidator CssClass="control-label" ID="CityReqV" runat="server" Display="Dynamic" ErrorMessage="City is Required!" ControlToValidate="txtCity" EnableClientScript="False"></asp:RequiredFieldValidator>

            <asp:RequiredFieldValidator CssClass="control-label" ID="ProvReqV" runat="server" Display="Dynamic" ErrorMessage="Province is Required!" ControlToValidate="txtProv" EnableClientScript="False"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator CssClass="control-label" ID="ProvFormatV" runat="server" ControlToValidate="txtProv" Display="Dynamic" ErrorMessage="Province has wrong format. (EX: XX)" ValidationExpression="^[A-Z][A-Z]$" EnableClientScript="False"></asp:RegularExpressionValidator>

            <asp:RequiredFieldValidator CssClass="control-label" ID="PostalReqV" runat="server" Display="Dynamic" ErrorMessage="Postal Code is Required!" ControlToValidate="txtPostal" EnableClientScript="False"></asp:RequiredFieldValidator>

            <asp:RegularExpressionValidator ID="PostalFormatV" runat="server" ControlToValidate="txtPostal" Display="Dynamic" ErrorMessage="Postal Code has wrong format. (EX: Z9Z 9Z9)" ValidationExpression="^[A-Z]\d[A-Z] \d[A-Z]\d$" EnableClientScript="False"></asp:RegularExpressionValidator>

            <asp:RequiredFieldValidator CssClass="control-label" ID="UNReqV" runat="server" Display="Dynamic" ErrorMessage="User Name is required!" ControlToValidate="txtUserName" Enabled="False" EnableClientScript="False"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator CssClass="control-label" ID="PWReqV" runat="server" Display="Dynamic" ErrorMessage="Password is required!" ControlToValidate="txtPassword" Enabled="False" EnableClientScript="False"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator CssClass="control-label" ID="CPWReqV" runat="server" Display="Dynamic" ErrorMessage="Confirm Password is required!" ControlToValidate="txtConfirmPassword" Enabled="False" EnableClientScript="False"></asp:RequiredFieldValidator>
            <asp:CompareValidator CssClass="control-label" ID="CPWCompareV" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" Enabled="False" ErrorMessage="Passwords must be the same!" EnableClientScript="False"></asp:CompareValidator>
        </div>
        

        <div class="row">
            <!--Start Form Header-->
            <div class="header text-xs-center">
                <asp:Label ID="newCust" CssClass="h2-responsive" runat="server" Text="Customer Registration:"></asp:Label>
                <asp:Label ID="AccountDetails" CssClass="h2-responsive" runat="server" Text="Change Account Details:"></asp:Label>
                <hr class="mt-2 mb-2" />
            </div>
            <!--End Form Header-->

            <!--Start Main Form Body-->
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
                    <label for="form4">Home Phone(4031112222):</label>

                </div>

                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" />
                    <label for="form4">Email(eg. abc@live.com):</label>

                </div>

                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtBusPhone" runat="server" />
                    <label for="form4">Business Phone(4031112223):</label>
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
                    <label for="form4">Province(XX):</label>

                </div>
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtPostal" runat="server" />
                    <label for="form4">Postal Code(XXX XXX):</label>

                </div>
                <div class="md-form">
                    <i class="fa fa-lock prefix"></i>
                    <asp:TextBox CssClass="form-control" ID="txtCountry" runat="server" />
                    <label for="form4">Country:</label>
                </div>
            </div>

            <div class="col-sm-5 col-sm-offset-1" id="agent">

                <h4 id="lblAgent" class="text-left" runat="server">Agent:</h4>
                <i class="fa fa-lock prefix"></i>

                <asp:DropDownList CssClass="col-sm-12 dropdown dropdown-menu-right" ID="ddlAgents" runat="server"></asp:DropDownList>

            </div>
            <!--End Main Form Body-->
        </div>

        <!--Start User Authentication Section-->
        <div id="LoginInfo" runat="server">
            <div class="row" id="newCustomerPassword" runat="server">
                <div class="col-sm-6">
                    <div class="md-form">
                        <i class="fa fa-lock prefix"></i>
                        <asp:TextBox CssClass="form-control" ID="txtUserName" runat="server" />
                        <label for="form4">UserName:</label>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    <div class="md-form">
                        <i class="fa fa-lock prefix"></i>
                        <asp:TextBox CssClass="form-control" ID="txtPassword" TextMode="Password" runat="server" />
                        <label for="form4">Password:</label>
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="md-form">
                        <i class="fa fa-lock prefix"></i>
                        <asp:TextBox CssClass="form-control" ID="txtConfirmPassword" TextMode="Password" runat="server" />
                        <label for="form4">Confirm Password:</label>
                    </div>
                </div>
            </div>
        </div>
        <!--End User Authentication Section-->

    </div>
    <div class="container ">
        <!--Start Button Section-->
        <div class="col-sm-4 col-sm-offset-5">
            <asp:Button CssClass="btn btn-primary" ID="btnUpdate" Width="100"  runat="server" OnClick="btnUpdate_Click" Text="Update Info" />
            <asp:Button CssClass="btn btn-primary" ID="btnRegister" Width="100" runat="server" Text="Register" OnClick="btnRegister_Click" />
        </div>
        <!--End Button Section-->
    </div>

</asp:Content>
