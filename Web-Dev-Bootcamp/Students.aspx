<%@ Page Title="Students Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Web_Dev_Bootcamp._Students" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h2>Students Page</h2>
   
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
    <a href="Student.aspx" class="add-btn" title="Add Student"><i class="fas fa-plus"></i></a>
  </table>
</asp:Content>
