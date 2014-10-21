<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="AddEdit.aspx.cs" Inherits="CarServiceRecords.Application.Administration.SitePages.AddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AdminContent" runat="server">
    <div class="col-md-6">
        <h3>Manage Page</h3>
        <hr />
        <div class="panel panel-default">
            <div class="panel-heading">
                Manage Page
            </div>
            <div class="panel-body">
                <div class="form-horizontal" id="mangeItemForm" runat="server">
                    <fieldset>
                        <div class="form-group">
                            <label for="title" class="col-lg-2 control-label">Title</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="title" class="form-control" runat="server" />
                                <asp:RequiredFieldValidator 
                                    runat="server" 
                                    CssClass="text-danger"
                                    ControlToValidate="title" 
                                    ErrorMessage="Title is required" 
                                    Display="Dynamic"/>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="title" class="col-lg-2 control-label">Content</label>
                            <div class="col-lg-10">
                                <asp:TextBox  TextMode="multiline" ID="content" Rows="5" class="form-control"  runat="server" />
                                <asp:RequiredFieldValidator 
                                    runat="server" 
                                    CssClass="text-danger"
                                    ControlToValidate="content" 
                                    ErrorMessage="Content is required" 
                                    Display="Dynamic"/>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="title" class="col-lg-2 control-label">Is Visible</label>
                            <div class="col-lg-10">
                                <asp:DropDownList ID="isVisibleSelect" class="form-control" runat="server">
                                    <asp:ListItem Value="0">No</asp:ListItem>
                                    <asp:ListItem Value="1" Selected="True">Yes</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                <asp:Button ID="ButtonSubmit" runat="server" class="btn btn-primary" Text="Submit" OnClick="ButtonSubmit_Click" />
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
