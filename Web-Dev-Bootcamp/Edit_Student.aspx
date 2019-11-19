<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit_Student.aspx.cs" Inherits="Web_Dev_Bootcamp.EditStudentInfo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Verify all details for Student ID :<span id="target_student_id" runat="server"></span></h2>
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

    <p>**Do Not Forget to Click SUBMIT to save all the changes made.</p>
    <asp:Button runat="server" Text="SUBMIT" />
</asp:Content>
