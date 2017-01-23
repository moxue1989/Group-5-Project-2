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
                <asp:Button CssClass="btn btn-primary btn-sm waves-effect waves-light" ID="AccountDetails" runat="server" Text="Change Account Details" OnClick="AccountDetails_Click" Font-Names="roboto" Font-Size="14pt" />
            </div>
        </div>
        <div class="col-xs-12 col-md-6  text-xs-center">
            <div class="divider-new">
                <label class="h2-responsive">Purchases</label>
            </div>
            <div class="jumbotron">
                <p >View Past Bookings Details and Puchases</p> 
                <asp:Button CssClass="btn btn-primary btn-sm waves-effect waves-light" ID="BookingDetails" Font-Size="14pt" runat="server" Text="View Booking Details" OnClick="BookingDetails_Click" Font-Names="roboto"  />
            </div>
        </div>

    <%-- <div class="card">
            <div class="card-block">
                <div class="md-textarea col-sm-8 col-sm-offset-3">
                    <div class="col-sm-4">
                        <h4 class="card-header">Purchases</h4>
                        <p class="card-subtitle">View Details on Past Bookings and Puchases</p> 
                    </div>
                    <div class="col-sm-4">
                        <button class="btn btn-success">View Booking Details</button> 
                    </div>
                </div>
            </div>
        
       </div> <br/>--%>
</asp:Content>
