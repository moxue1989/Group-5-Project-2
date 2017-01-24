<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerLanding.aspx.cs" Inherits="ASP_Workshop.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
        <div class="col-xs-12 col-md-6  text-xs-center">
            <div class="divider-new">
                <label class="h2-responsive">Account Details</label>
            </div>
            <div class="jumbotron">
                <div class="row">
                    <p class="text text-center">Update contact information and address</p> 
                </div>
                
                <div class="row">
                    <div class="col-xs-4 col-xs-offset-2 col-md-4 col-md-offset-3">
                    <asp:Button CssClass="btn btn-primary text-center btn-sm waves-effect waves-light" ID="AccountDetails" runat="server" Text="Change Account Details" OnClick="AccountDetails_Click" Font-Names="roboto" Font-Size="14pt" />
                </div>
                </div>
                
            </div>
        </div>
        <div class="col-xs-12 col-md-6 ">
            <div class="divider-new">
                <label class="h2-responsive">Purchases</label>
            </div>
            <div class="jumbotron">
                <div class="row">
                    <p class="text text-center">View Past Bookings Details and Puchases</p> 
                </div>
                
                <div class="row">
                    <div class="col-xs-4 col-xs-offset-2 col-md-4 col-md-offset-3">
                        <asp:Button CssClass="btn btn-primary text-center btn-sm waves-effect waves-light"  ID="BookingDetails"  runat="server" Text="View Booking Details" OnClick="BookingDetails_Click" Font-Names="roboto"  />
                    </div>
                    
                </div>
            </div>
        </div>
</asp:Content>
