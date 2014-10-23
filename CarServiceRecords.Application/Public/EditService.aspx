<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditService.aspx.cs" Inherits="CarServiceRecords.Application.Public.EditService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="col-md-6">
        <h3>Manage My Car Service</h3>
        <hr />
        <div class="panel panel-default">
            <div class="panel-heading">
                Manage My Car Service
            </div>
            <div class="panel-body">
                <div class="form-horizontal" id="mangeItemForm" runat="server">
                    <fieldset>
                        <div class="form-group">
                            <label for="Name" class="col-lg-2 control-label">Name</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="Name" class="form-control" runat="server" />
                                <asp:RequiredFieldValidator 
                                    runat="server" 
                                    CssClass="text-danger"
                                    ControlToValidate="Name" 
                                    ErrorMessage="Name is required" 
                                    Display="Dynamic"/>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="Town" class="col-lg-2 control-label">Town</label>
                            <div class="col-lg-10">
                                <asp:DropDownList ID="Town" class="form-control" runat="server" DataTextField="Name" DataValueField="Id" />
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="Address" class="col-lg-2 control-label">Address</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="Address" class="form-control" runat="server" />
                                <asp:RequiredFieldValidator 
                                    runat="server" 
                                    CssClass="text-danger"
                                    ControlToValidate="Address" 
                                    ErrorMessage="Address is required" 
                                    Display="Dynamic"/>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="Phone" class="col-lg-2 control-label">Phone</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="Phone" class="form-control" runat="server" />
                                <asp:RequiredFieldValidator 
                                    runat="server" 
                                    CssClass="text-danger"
                                    ControlToValidate="Phone" 
                                    ErrorMessage="Phone is required" 
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
