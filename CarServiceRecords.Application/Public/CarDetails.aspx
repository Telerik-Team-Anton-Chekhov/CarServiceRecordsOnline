<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarDetails.aspx.cs" Inherits="CarServiceRecords.Application.Public.CarDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Car Details</h3>
    <hr />

    <asp:ListView 
        ID="CarList" 
        runat="server"
        ItemPlaceholderID="CarItem"
        ItemType="CarServiceRecords.Models.Car">

        <ItemTemplate>
            <div class="col-lg-6">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <%#: Item.Model.Make.Name %> - <%#: Item.Model.Name %>
                    </div>
                    <div class="panel-body">
                        <p>VIN: <strong><%#: Item.VinNumber%></strong></p>
                        <p>Type: <strong><%#: Item.Type.ToString()%></strong></p>
                        <p>Gear: <strong><%#: Item.Gear.ToString()%></strong></p>
                        <p>Engine: <strong><%#: Item.Engine.ToString()%></strong></p>
                    </div>
                </div>
            </div>
        </ItemTemplate>

        <LayoutTemplate>
            <asp:PlaceHolder runat="server" ID="CarItem"></asp:PlaceHolder>
        </LayoutTemplate>
    </asp:ListView>

    <asp:ListView 
        ID="RepairsList" 
        runat="server"
        ItemPlaceholderID="RepairItem"
        ItemType="CarServiceRecords.Models.RepairJob">

        <ItemTemplate>
            <div class="col-lg-6">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <%#: Item.CarService.Name%>
                    </div>
                    <div class="panel-body">
                        <p>Description: <strong><%#: Item.Description%></strong></p>
                        <p>Service: <strong><a href="ServiceDetails.aspx?serviceId=<%# Item.CarService.Id%>"><%#: Item.CarService.Name%></a></strong></p>
                    </div>
                </div>
            </div>
        </ItemTemplate>

        <LayoutTemplate>
            <asp:PlaceHolder runat="server" ID="RepairItem"></asp:PlaceHolder>
        </LayoutTemplate>
    </asp:ListView>
</asp:Content>
