<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchCar.aspx.cs" Inherits="CarServiceRecords.Application.Public.SearchCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h3>Search For A Car</h3>
            <hr />
            <div class="form-horizontal" id="searchForm" runat="server">
                <div class="row">
                    <div class="col-md-3">
                        <label for="vinNumber" class="col-lg-3 control-label">VIN Number</label>
                        <div class="col-lg-9">
                            <asp:TextBox ID="vinNumber" class="form-control" runat="server" />
                        </div>
                    </div>

                    <div class="col-md-3">
                        <label for="make" class="col-lg-3 control-label">Make</label>
                        <div class="col-lg-9">
                            <asp:DropDownList ID="make" class="form-control" onselectedindexchanged="Make_SelectedIndexChanged" AutoPostBack="true"  runat="server" DataTextField="Name" DataValueField="Id" />
                        </div>
                    </div>

                    <div class="col-md-3">
                        <label for="model" class="col-lg-3 control-label">Model</label>
                        <div class="col-lg-9">
                            <asp:DropDownList ID="model" class="form-control" runat="server" DataTextField="Name" DataValueField="Id" />
                        </div>
                    </div>

                    <div class="col-md-3">
                        <label for="type" class="col-lg-3 control-label">Type</label>
                        <div class="col-lg-9">
                            <asp:DropDownList ID="type" class="form-control" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <label for="engine" class="col-lg-3 control-label">Engine</label>
                        <div class="col-lg-9">
                            <asp:DropDownList ID="engine" class="form-control" runat="server" />
                        </div>
                    </div>

                    <div class="col-md-3">
                        <label for="gear" class="col-lg-3 control-label">Gear</label>
                        <div class="col-lg-9">
                            <asp:DropDownList ID="gear" class="form-control" runat="server" />
                        </div>
                    </div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-6">
                        <asp:Button ID="ButtonSubmit" runat="server" class="btn btn-primary" Text="Search" OnClick="ButtonSearch_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:ListView 
                ID="ItemsList"
                ItemPlaceholderID="CarItem"
                runat="server"
                ItemType="CarServiceRecords.Models.Car">

                <LayoutTemplate>
                    <hr />
                    <table class="table table-striped table-bordered table-hover">
                        <tr runat="server">
                            <th runat="server">Make</th>
                            <th runat="server">Model</th>
                            <th runat="server">Type</th>
                            <th runat="server">Engine</th>
                            <th runat="server">Gear</th>
                            <th runat="server">-</th>
                        </tr>
                        <tr runat="server" id="CarItem" />
                    </table>

                    <hr />

                    <asp:DataPager 
                        ID="ItemsPager" 
                        runat="server" 
                        PagedControlID="ItemsList"
                        PageSize="10"
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

                </LayoutTemplate>

                <ItemTemplate>
                    <tr runat="server">
                    <td>
                        <%#: Item.Model.Make.Name %>
                    </td>
                    <td>
                        <%#: Item.Model.Name %>
                    </td>
                    <td>
                        <%#: Item.Type%>
                    </td>
                        <td>
                        <%#: Item.Engine%>
                    </td>
                        <td>
                        <%#: Item.Gear%>
                    </td>
                    <td>
                        <a class="btn btn-primary btn-sm" href="CarDetails.aspx?itemId=<%#: Item.Id %>">Details</a>
                    </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>

</asp:Content>
