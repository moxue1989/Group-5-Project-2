<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerLanding.aspx.cs" Inherits="ASP_Workshop.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
        <div class="col-xs-12 col-md-6  text-xs-center">
            <div class="divider-new">
                <label class="h2-responsive">Account Details</label>
            </div>
            <div class="jumbotron">
                <p >Update contact information and address</p> 
                <div class="row">
                   <asp:Button CssClass="btn btn-primary btn-sm waves-effect waves-light" ID="AccountDetails" runat="server" Text="Change Account Details" OnClick="AccountDetails_Click" Font-Names="roboto" Font-Size="14pt" /> 
                </div>
                
            </div>
        </div>
        <div class="col-xs-12 col-md-6 ">
            <div class="divider-new">
                <label class="h2-responsive">Purchases</label>
            </div>
            <div class="jumbotron text-md-center ">
                <p >View Past Bookings Details and Puchases</p> 
                    <asp:Button CssClass="btn btn-primary btn-sm waves-effect waves-light" ID="BookingDetails" Font-Size="14pt" runat="server" Text="View Booking Details" OnClick="BookingDetails_Click" Font-Names="roboto"  />
           
            </div>
        </div>
</asp:Content>
