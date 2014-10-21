<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="AddEdit.aspx.cs" Inherits="CarServiceRecords.Application.Administration.Users.AddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdminContent" runat="server">
    <div class="col-md-6">
        <h3>Manage User</h3>
        <hr />
        <div class="panel panel-default">
            <div class="panel-heading">
                Manage User
            </div>
            <div class="panel-body">
                <div class="form-horizontal" id="mangeItemForm" runat="server">
                    <fieldset>
                        <div class="form-group">
                            <label for="username" class="col-lg-2 control-label">Username</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="username" class="form-control" runat="server" />
                                <asp:RequiredFieldValidator 
                                    runat="server" 
                                    CssClass="text-danger"
                                    ControlToValidate="username" 
                                    ErrorMessage="Username is required" 
                                    Display="Dynamic"/>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="email" class="col-lg-2 control-label">Email</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="email" class="form-control" runat="server" />
                                <asp:RequiredFieldValidator 
                                    runat="server" 
                                    CssClass="text-danger"
                                    ControlToValidate="email" 
                                    ErrorMessage="Email is required" 
                                    Display="Dynamic"/>
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
