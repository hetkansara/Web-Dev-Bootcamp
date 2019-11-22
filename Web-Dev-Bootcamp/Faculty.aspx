<%@ Page Title="Faculties" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Faculty.aspx.cs" Inherits="Web_Dev_Bootcamp.Faculties" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <div class="container">
            <div class="form-row">
                <div class="col-md-12">
                    <h2>
                        <a href="Students.aspx" class="back-btn" title="Back" id="backButton" runat="server"><i class="fas fa-arrow-left"></i></a>
                        <span runat="server" id="pageTypeTitle"></span> Faculty</h2>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="facultyfname">First Name</label>
                    <asp:TextBox runat="server" ID="facultyfname" class="form-control"  aria-describedby="facultyFname" placeholder="Enter firstname"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="facultyfname" ErrorMessage="enter faculty first name"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="facultylname">Last Name</label>
                    <asp:TextBox runat="server" ID="facultylname" class="form-control"  aria-describedby="facultyLname" placeholder="Enter lastname"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="facultylname" ErrorMessage="enter faculty last name"></asp:RequiredFieldValidator>
                  
                </div>
                <div class="col-md-4 mb-3">
                    <label for="facultyemployeenumber">Employee Number</label>
                    <asp:TextBox runat="server" ID="facultyemployeenumber" class="form-control"  aria-describedby="facultyEmployeeNumber" placeholder="Enter employee number"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="facultyemployeenumber" ErrorMessage="enter faculty employee number"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-6">
                    <label for="facultyhiredate">Hire Date</label>
                    <asp:TextBox runat="server" ID="facultyhiredate" class="form-control"  aria-describedby="facultyHireDate" placeholder="Enter hire date" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="facultyhiredate" ErrorMessage="enter faculty hire date"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-6">
                    <label for="salary">Salary</label>
                    <asp:TextBox runat="server" ID="salary" class="form-control"  aria-describedby="Salary" placeholder="Enter salary"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="salary" ErrorMessage="enter faculty's salary"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Button runat="server" Text="Submit" class="btn btn-primary"/>
                </div>
            </div>
        </div>
   
</asp:Content>
