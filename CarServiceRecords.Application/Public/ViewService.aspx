<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewService.aspx.cs" Inherits="CarServiceRecords.Application.Public.ViewService" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>View My Service</h3>
    <a href="EditService.aspx" class="btn btn-primary" role="button">Edit Service</a>

    <hr />

    <asp:ListView 
        ID="ServiceList" 
        runat="server"
        ItemPlaceholderID="ServiceItem"
        ItemType="CarServiceRecords.Models.CarService">

        <ItemTemplate>
            <div class="col-lg-6">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <%#: Item.Name %>
                    </div>
                    <div class="panel-body">
                        <p>Town: <strong><%#: Item.Town.Name%></strong></p>
                        <p>Address: <strong><%#: Item.Address%></strong></p>
                        <p>Phone: <strong><%#: Item.Phone%></strong></p>
                    </div>
                </div>
            </div>
        </ItemTemplate>

        <LayoutTemplate>

            <div class="row">
                <asp:PlaceHolder runat="server" ID="ServiceItem"></asp:PlaceHolder>
                <div class="col-md-6">
                    <a href="AddJob.aspx" class="btn btn-primary" role="button">Add Repair Job</a>
                </div>
            </div>

        </LayoutTemplate>
    </asp:ListView>
</asp:Content>
