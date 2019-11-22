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
                    <label for="studentnumber">Studnet Number</label>
                    <asp:TextBox runat="server" ID="studentnumber" class="form-control"  aria-describedby="studentNumber" placeholder="Enter student number"></asp:TextBox>
                     <asp:RequiredFieldValidator runat="server" ControlToValidate="studentnumber" ErrorMessage="enter student number">
                  </asp:RequiredFieldValidator>
                    <small id="studentNumberInfo" class="form-text text-muted">Enter student number</small>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="studentfname">First Name</label>
                    <asp:TextBox runat="server" ID="studentfname" class="form-control"  aria-describedby="studentFname" placeholder="Enter firstname"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="studentfname" ErrorMessage="enter first name"></asp:RequiredFieldValidator>
                     <small id="studentFnameInfo" class="form-text text-muted">Enter student's firstname</small>
                  
                </div>
                <div class="col-md-4 mb-3">
                    <label for="studentlname">Last Name</label>
                    <asp:TextBox runat="server" ID="studentlname" class="form-control"  aria-describedby="studentLname" placeholder="Enter lastname"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="studentlname" ErrorMessage="enter last name"></asp:RequiredFieldValidator>
                    <small id="studentLnameInfo" class="form-text text-muted">Enter student's lastname</small>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-12">
                    <label for="enrollmentdate">Enrollment Date</label>
                     <asp:TextBox ID="enrollmentdate" runat="server" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="enrollmentdate" ErrorMessage="enter enrollment date"></asp:RequiredFieldValidator>
                    <small id="enrollmentDateInfo" class="form-text text-muted">Select enrollment date</small>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Button runat="server" Text="Submit" class="btn btn-primary"/>
                </div>
            </div>
        </div>
    </asp:Content>