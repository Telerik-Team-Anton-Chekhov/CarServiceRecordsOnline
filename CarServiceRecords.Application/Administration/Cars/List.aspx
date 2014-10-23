<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CarServiceRecords.Application.Administration.Cars.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdminContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h3>Cars List</h3>
            <a href="AddEdit.aspx" class="btn btn-primary" role="button">Add New Car</a>
        </div>
    </div>

    <hr />
    <asp:ListView 
        ID="ItemsList" 
        runat="server"
        ItemPlaceholderID="CarItem"
        ItemType="CarServiceRecords.Models.Car">

        <ItemTemplate>
            <div class="col-lg-4">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <%#: Item.Model != null ? Item.Model.Make.Name : "None"%> - <%#: Item.Model != null ? Item.Model.Name : "None"%>
                    </div>
                    <div class="panel-body">
                        VIN: <p><%#: Item.VinNumber%></p>
                        Type: <p><%#: Item.Type.ToString()%></p>
                        Gear: <p><%#: Item.Gear.ToString()%></p>
                        Engine: <p><%#: Item.Engine.ToString()%></p>
                    </div>
                    <div class="panel-footer">
                        <a class="btn btn-primary" href="AddEdit.aspx?itemId=<%#: Item.Id %>">Edit</a>
                    </div>
                </div>
            </div>
        </ItemTemplate>

        <LayoutTemplate>

            <div class="row">
                <asp:PlaceHolder runat="server" ID="CarItem"></asp:PlaceHolder>
            </div>

            <div class="row">
                <asp:DataPager 
                    ID="ItemsPager" 
                    runat="server" 
                    PagedControlID="ItemsList"
                    PageSize="3"
                    class="btn-group">

                    <Fields>
                        <asp:NextPreviousPagerField 
                            ShowFirstPageButton="true"
                            ShowNextPageButton="false" 
                            ShowPreviousPageButton="false" 
                            ButtonCssClass="btn btn-primary"/>

                        <asp:NumericPagerField 
                            CurrentPageLabelCssClass="btn btn-default"
                            NumericButtonCssClass="btn btn-primary"/>

                        <asp:NextPreviousPagerField 
                            ShowLastPageButton="true"
                            ShowNextPageButton="false" 
                            ShowPreviousPageButton="false" 
                            ButtonCssClass="btn btn-primary"/>
                    </Fields>
                </asp:DataPager>
            </div>

        </LayoutTemplate>
    </asp:ListView> 
</asp:Content>
