﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CarServiceRecords.Application.Administration.CarMakes.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdminContent" runat="server">
    <h3>Makes List</h3>
    <a href="AddEdit.aspx" class="btn btn-primary" role="button">Add New Make</a>
    <hr />
    <asp:ListView 
        ID="ItemsList"
        ItemPlaceholderID="CarMakeItem"
        runat="server"
        SelectMethod="GetItems"
        ItemType="CarServiceRecords.Models.CarMake">

        <LayoutTemplate>
            <table class="table table-striped table-bordered table-hover">
                <tr runat="server">
                    <th runat="server">
                        <asp:LinkButton ID="byId" CommandArgument="id" CommandName="Sort" Text="Id" runat="server" />
                    </th>
                    <th runat="server">
                        <asp:LinkButton ID="byName" CommandArgument="name" CommandName="Sort" Text="Name" runat="server" />
                    </th>
                    <th runat="server">
                        Models Count
                    </th>
                    <th runat="server">-</th>
                    <th runat="server">-</th>
                </tr>
                <tr runat="server" id="CarMakeItem" />
            </table>

            <div class="row">
                <asp:DataPager 
                    ID="ItemsPager" 
                    runat="server" 
                    PagedControlID="ItemsList"
                    PageSize="5"
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

        <ItemTemplate>
            <tr runat="server">
            <td>
                <%#: Item.Id %>
            </td>
            <td>
                <%#: Item.Name %>
            </td>
            <td>
                <%#: Item.Models.Count %>
            </td>
            <td>
                <a class="btn btn-primary btn-sm" href="AddEdit.aspx?itemId=<%#: Item.Id %>">Edit</a>
            </td>
            <td>
                <asp:LinkButton 
                    ID="deleteItem" 
                    runat="server" 
                    class="btn btn-danger btn-sm"
                    CommandName="Delete"
                    OnCommand="Delete_Item"
                    CommandArgument="<%# Item.Id %>"
                    OnClientClick = "return confirm('Are you sure you want to delete this item?');"
                    Text="Delete" />
            </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>     
       
</asp:Content>
