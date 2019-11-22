<%@ Page Title="Students Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Web_Dev_Bootcamp._Students" %>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <h1 runat="server" id="page_title"></h1>
        <!-- <h2>List of all registered Students.</h2> -->
        <div class="form-row">
            <div class="col-md-10">
                <asp:TextBox ID="searchText" class="form-control" runat="server" placeholder="Search Students"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <input type="submit" class="btn btn-primary" runat="server" value="Search" />
            </div>
        </div>
        <div runat="server" id="NoResultMsg">
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">#</th>
                    <th scope="col" id="Col1" runat="server"></th>
                    <th scope="col" id="Col2" runat="server"></th>
                    <th scope="col" id="Col3" runat="server"></th>
                    <th scope="col" id="Col4" runat="server"></th>
                    <th scope="col" id="Col5" runat="server">Actions</th>
                </tr>
            </thead>
            <tbody id="students_result" runat="server">
            </tbody>
            <a href="#" runat="server" id="addButton" class="add-btn">
                <i class="fas fa-plus"></i>
            </a>
        </table>

        </div>
    </asp:Content>