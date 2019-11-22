<%@ Page Title="Faculties" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Faculties.aspx.cs" Inherits="Web_Dev_Bootcamp.Faculties" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <div class="container">
            <div class="form-row">
                <div class="col-md-12">
                    <h2>
                        <a href="Faculties.aspx" class="back-btn" title="Back"><i class="fas fa-arrow-left"></i></a>
                        <span runat="server" id="pageTypeTitle"></span> Faculty</h2>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="facultyfname">First Name</label>
                    <asp:TextBox runat="server" ID="facultyfname" class="form-control"  aria-describedby="facultyFname" placeholder="Enter firstname"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="facultyfname"></asp:RequiredFieldValidator>
                    <small id="facultyFname" class="form-text text-muted">Enter faculty's firstname</small>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="facultylname">Last Name</label>
                    <asp:TextBox runat="server" ID="facultylname" class="form-control"  aria-describedby="facultyLname" placeholder="Enter lastname"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="facultylname"></asp:RequiredFieldValidator>
                     <small id="facultyLname" class="form-text text-muted">Enter faculty's lastname</small>
                  
                </div>
                <div class="col-md-4 mb-3">
                    <label for="employeenumber">Employee Number</label>
                    <asp:TextBox runat="server" ID="employeenumber" class="form-control"  aria-describedby="employeeNumber" placeholder="Enter employee number"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="employeenumber"></asp:RequiredFieldValidator>
                    <small id="employeeNumber" class="form-text text-muted">Enter employee number</small>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-6">
                    <label for="hiredate">Hire Date</label>
                    <asp:TextBox runat="server" ID="hiredate" class="form-control"  aria-describedby="hireDate" placeholder="Enter hire date"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="hiredate"></asp:RequiredFieldValidator>
                    <small id="hireDate" class="form-text text-muted">Select hire date</small>
                </div>
                <div class="col-md-6">
                    <label for="salary">Salary</label>
                    <asp:TextBox runat="server" ID="salary" class="form-control"  aria-describedby="Salary" placeholder="Enter salary"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="salary"></asp:RequiredFieldValidator>
                    <small id="Salary" class="form-text text-muted">Select hire date</small>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Button runat="server" Text="Submit" class="btn btn-primary"/>
                </div>
            </div>
        </div>
   
</asp:Content>
