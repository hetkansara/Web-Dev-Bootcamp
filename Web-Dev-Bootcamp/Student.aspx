<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Web_Dev_Bootcamp.Student" %>


    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
            <div class="form-row">
                <div class="col-md-12">
                    <h2>
                        <a href="Students.aspx" class="back-btn" title="Back"><i class="fas fa-arrow-left"></i></a>
                        <span runat="server" id="pageTypeTitle"></span> Student</h2>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="student_id">Studnet ID</label>
                    <input type="text" class="form-control" id="student_id" runat="server" aria-describedby="studentID" placeholder="Enter studentid">
                    <small id="studentID" class="form-text text-muted">Enter student's id</small>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="student_fname">First Name</label>
                    <input type="text" class="form-control" id="student_fname" runat="server" aria-describedby="studentFname" placeholder="Enter firstname">
                    <small id="studentFname" class="form-text text-muted">Enter student's firstname</small>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="student_lname">Last Name</label>
                    <input type="text" class="form-control" id="student_lname" runat="server" aria-describedby="studentLname" placeholder="Enter lastname">
                    <small id="studentLname" class="form-text text-muted">Enter student's lastname</small>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-12">
                    <label for="enrolment_date">Enrollment Date</label>
                    <input type="text" class="form-control" id="enrolment_date" runat="server" aria-describedby="enrollmentDate" placeholder="Enter enrollment date">
                    <small id="enrollmentDate" class="form-text text-muted">Select enrollment date</small>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-12">
                    <input type="submit" class="btn btn-primary" runat="server" value="Submit" />
                </div>
            </div>
        </div>
        </div>
    </asp:Content>