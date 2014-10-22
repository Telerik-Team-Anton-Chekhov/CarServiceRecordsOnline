﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="AddEdit.aspx.cs" Inherits="CarServiceRecords.Application.Administration.Towns.AddEdit1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdminContent" runat="server">
    <div class="col-md-6">
        <h3>Manage Town</h3>
        <hr />
        <div class="panel panel-default">
            <div class="panel-heading">
                Manage Town
            </div>
            <div class="panel-body">
                <div class="form-horizontal" id="mangeItemForm" runat="server">
                    <fieldset>
                        <div class="form-group">
                            <label for="title" class="col-lg-2 control-label">Name</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="name" class="form-control" runat="server" />
                                <asp:RequiredFieldValidator 
                                    runat="server" 
                                    CssClass="text-danger"
                                    ControlToValidate="name" 
                                    ErrorMessage="Name is required" 
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
