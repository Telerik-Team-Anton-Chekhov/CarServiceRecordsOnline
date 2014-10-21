<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CarServiceRecords.Application.Administration.SitePages.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AdminContent" runat="server">
    <h3>Pages List</h3>
    <a href="AddEdit.aspx" class="btn btn-primary" role="button">Add New Page</a>
    <hr />
    <div class="bs-component">
        <table class="table table-striped table-hover">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Title</th>
                    <th>Date Created</th>
                    <th>Is Visible</th>
                    <th>-</th>
                    <th>-</th>
                </tr>
            </thead>
            <tbody>

                <asp:Repeater 
                    ID="ItemsList" 
                    runat="server" 
                    ItemType="CarServiceRecords.Models.SitePage">

                    <ItemTemplate>
                        <tr>
                            <td><%#: Item.Id %></td>
                            <td><%#: Item.Title %></td>
                            <td><%#: Item.DateCreated %></td>
                            <td><%#: Item.IsVisible %></td>
                            <td><a href="AddEdit.aspx?itemId=<%# Item.Id %>" class="btn btn-primary" role="button">Edit</a></td>
                            <td>
                                <asp:LinkButton 
                                    ID="deleteItem" 
                                    runat="server" 
                                    class="btn btn-danger"
                                    CommandName="Delete"
                                    OnCommand="Delete_Item"
                                    CommandArgument="<%# Item.Id %>"
                                    OnClientClick = "return confirm('Are you sure you want to delete this item?');"
                                    Text="Delete" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>

            </tbody>
        </table>
    </div>
</asp:Content>
