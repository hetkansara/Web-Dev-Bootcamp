﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Web_Dev_Bootcamp.Student" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Detail Info for Student ID:<span id="target_student_id" runat="server"></span></h2>
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
</asp:Content>
