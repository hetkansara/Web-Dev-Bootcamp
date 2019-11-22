﻿<%@ Page Title="Courses" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="Web_Dev_Bootcamp.Courses" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
            <div class="form-row">
                <div class="col-md-12">
                    <h2>
                        <a href="Courses.aspx" class="back-btn" title="Back"><i class="fas fa-arrow-left"></i></a>
                        <span runat="server" id="pageTypeTitle"></span> Course</h2>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="coursecode">Course Code</label>
                    <asp:TextBox runat="server" ID="coursecode" aria-describedby="courseCode" placeholder="Enter course code"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="coursecode"></asp:RequiredFieldValidator>
                    <small id="courseCodeInfo" class="form-text text-muted">Enter course code</small>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="startdate">Start Date</label>
                    <asp:TextBox runat="server" ID="startdate" aria-describedby="startDate" placeholder="Enter start date"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="startdate"></asp:RequiredFieldValidator>
                     <small id="startDateInfo" class="form-text text-muted">Enter course start date</small>
                  
                </div>
                <div class="col-md-4 mb-3">
                    <label for="finishdate">Finish Date</label>
                    <asp:TextBox runat="server" ID="finishdate" aria-describedby="finishDate" placeholder="Enter finish date"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="finishdate"></asp:RequiredFieldValidator>
                    <small id="finishDateInfo" class="form-text text-muted">Enter course finish date</small>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-12">
                    <label for="coursename">Course Name</label>
                    <asp:TextBox runat="server" ID="coursename" aria-describedby="courseName" placeholder="Enter course name"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="coursename"></asp:RequiredFieldValidator>
                    <small id="courseNameInfo" class="form-text text-muted">Enter Course Name</small>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Button runat="server" Text="Submit" class="btn btn-primary"/>
                </div>
            </div>
        </div>
    </asp:Content>
