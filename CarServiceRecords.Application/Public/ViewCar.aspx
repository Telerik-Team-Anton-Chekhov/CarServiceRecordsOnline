<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewCar.aspx.cs" Inherits="CarServiceRecords.Application.Public.ViewCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>View My Car</h3>
    <a href="EditCar.aspx" class="btn btn-primary" role="button">Edit Car</a>
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

            <div class="row">
                <asp:PlaceHolder runat="server" ID="CarItem"></asp:PlaceHolder>
            </div>

        </LayoutTemplate>
    </asp:ListView>
</asp:Content>
