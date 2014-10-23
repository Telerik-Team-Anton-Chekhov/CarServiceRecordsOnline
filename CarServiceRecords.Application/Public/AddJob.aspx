<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddJob.aspx.cs" Inherits="CarServiceRecords.Application.Public.AddJob" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-6">
        <h3>Add Repair Job</h3>
        <hr />
        <div class="panel panel-default">
            <div class="panel-heading">
                Add Repair
            </div>
            <div class="panel-body">
                <div class="form-horizontal" id="mangeItemForm" runat="server">
                    <fieldset>
                        <div class="form-group">
                            <label for="vinNumber" class="col-lg-3 control-label">VIN Number</label>
                            <div class="col-lg-9">
                                <asp:TextBox ID="vinNumber" class="form-control" runat="server" />
                                <asp:RequiredFieldValidator 
                                    runat="server" 
                                    CssClass="text-danger"
                                    ControlToValidate="vinNumber" 
                                    ErrorMessage="The VIN number is required!" 
                                    Display="Dynamic"/>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="Description" class="col-lg-3 control-label">Description</label>
                            <div class="col-lg-9">
                                <asp:TextBox ID="Description" class="form-control" runat="server" />
                                <asp:RequiredFieldValidator 
                                    runat="server" 
                                    CssClass="text-danger"
                                    ControlToValidate="Description" 
                                    ErrorMessage="Description is required!" 
                                    Display="Dynamic"/>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-lg-12">
                                <asp:Button ID="ButtonSubmit" runat="server" class="btn btn-primary" Text="Submit" OnClick="ButtonSubmit_Click" />
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
