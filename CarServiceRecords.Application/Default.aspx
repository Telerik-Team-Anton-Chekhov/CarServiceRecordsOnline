<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarServiceRecords.Application._Default" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Car Services</h3>

    <hr />

    <asp:ListView 
        ID="ServiceList" 
        runat="server"
        ItemPlaceholderID="ServiceItem"
        ItemType="CarServiceRecords.Models.CarService">

        <ItemTemplate>
            <div class="col-lg-6">
                <div class="panel panel-primary">
                    <div class="panel-body">
                        <div class="col-lg-4">
                            <img class="img-responsive" src="/Uploads/<%#: Item.ImageName %>" />
                        </div>
                        <div class="col-lg-8">
                            <p>Name: <a href="Public/ServiceDetails.aspx?serviceId=<%#: Item.Id %>"<strong><%#: Item.Name%></strong></a></p>
                            <p>Town: <strong><%#: Item.Town.Name%></strong></p>
                            <p>Address: <strong><%#: Item.Address%></strong></p>
                            <p>Phone: <strong><%#: Item.Phone%></strong></p>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>

        <LayoutTemplate>

            <div class="row">
                <asp:PlaceHolder runat="server" ID="ServiceItem"></asp:PlaceHolder>
            </div>

        </LayoutTemplate>
    </asp:ListView>

</asp:Content>
