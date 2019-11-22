<%@ Page Title="Students Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Web_Dev_Bootcamp._Students" %>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <h1>STUDENTS</h1>
        <!-- <h2>List of all registered Students.</h2> -->
        <div class="form-row">
            <div class="col-md-10">
                <asp:TextBox ID="searchText" class="form-control" runat="server" placeholder="Search Students"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <input type="submit" class="btn btn-primary" runat="server" value="Search" />
            </div>
        </div>
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">First Name</th>
                    <th scope="col">Last Name</th>
                    <th scope="col">Student Number</th>
                    <th scope="col">Enrollment Date</th>
                    <th scope="col">Actions</th>
                </tr>
            </thead>
            <tbody id="students_result" runat="server">
            </tbody>
            <a href="Student.aspx" runat="server" id="addStudentButton" class="add-btn" title="Add Student">
                <i class="fas fa-plus"></i>
            </a>
        </table>
    </asp:Content>