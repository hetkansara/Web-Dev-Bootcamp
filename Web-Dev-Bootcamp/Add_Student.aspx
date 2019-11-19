<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add_Student.aspx.cs" Inherits="Web_Dev_Bootcamp.Add_Student" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>ADD STUDENT</h1>
    <p>Please enter all "*" required fields.</p>
    <div runat="server">

        <div class="each_field">
            <label>First Name :</label>
            <input type="text" runat="server" id="student_fname" />
        </div>

        <div class="each_field">
            <label>Last Name :</label>
            <input type="text" runat="server" id="student_lname" />
        </div>

        <div class="each_field">
            <label>Studnet ID:</label>
            <input type="text" runat="server" id="student_id" />
        </div>

        <div class="each_field">
            <label>Enrolment Date:</label>
            <input type="text" runat="server" id="enrolment_date" />
        </div>

    </div>

    <p>**Click SUBMIT to save.</p>
    <asp:Button runat="server" Text="SUBMIT" />


</asp:Content>
