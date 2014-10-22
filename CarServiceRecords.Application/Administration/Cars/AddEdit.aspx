<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="AddEdit.aspx.cs" Inherits="CarServiceRecords.Application.Administration.Cars.AddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AdminContent" runat="server">
    <div class="col-md-6">
        <h3>Manage Cars</h3>
        <hr />
        <div class="panel panel-default">
            <div class="panel-heading">
                Manage Cars
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
                            <label for="make" class="col-lg-3 control-label">Make</label>
                            <div class="col-lg-9">
                                <asp:DropDownList ID="make" class="form-control" onselectedindexchanged="Make_SelectedIndexChanged" AutoPostBack="true"  runat="server" DataTextField="Name" DataValueField="Id" />
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="model" class="col-lg-3 control-label">Model</label>
                            <div class="col-lg-9">
                                <asp:DropDownList ID="model" class="form-control" runat="server" DataTextField="Name" DataValueField="Id" />
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="type" class="col-lg-3 control-label">Type</label>
                            <div class="col-lg-9">
                                <asp:DropDownList ID="type" class="form-control" runat="server" />
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="engine" class="col-lg-3 control-label">Engine</label>
                            <div class="col-lg-9">
                                <asp:DropDownList ID="engine" class="form-control" runat="server" />
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="gear" class="col-lg-3 control-label">Gear</label>
                            <div class="col-lg-9">
                                <asp:DropDownList ID="gear" class="form-control" runat="server" />
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
