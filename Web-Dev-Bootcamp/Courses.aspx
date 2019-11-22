<%@ Page Title="Courses" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="Web_Dev_Bootcamp.Courses" %>

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
                    <asp:TextBox runat="server" ID="coursecode" class="form-control"  aria-describedby="courseCode" placeholder="Enter course code"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="coursecode" ErrorMessage="enter course code"></asp:RequiredFieldValidator>
                    <small id="courseCodeInfo" class="form-text text-muted">Enter course code</small>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="startdate">Start Date</label>
                    <asp:TextBox runat="server" ID="startdate" class="form-control"  aria-describedby="startDate" placeholder="Enter start date" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="startdate" ErrorMessage="enter start date"></asp:RequiredFieldValidator>
                     <small id="startDateInfo" class="form-text text-muted">Enter course start date</small>
                  
                </div>
                <div class="col-md-4 mb-3">
                    <label for="finishdate">Finish Date</label>
                    <asp:TextBox runat="server" ID="finishdate" class="form-control"  aria-describedby="finishDate" placeholder="Enter finish date" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="finishdate" ErrorMessage="enter finish date"></asp:RequiredFieldValidator>
                    <small id="finishDateInfo" class="form-text text-muted">Enter course finish date</small>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-12">
                    <label for="coursename">Course Name</label>
                    <asp:TextBox runat="server" ID="coursename" class="form-control"  aria-describedby="courseName" placeholder="Enter course name"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="coursename" ErrorMessage="enter course name"></asp:RequiredFieldValidator>
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
