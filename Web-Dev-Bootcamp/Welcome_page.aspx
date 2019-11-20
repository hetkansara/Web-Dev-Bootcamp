<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Welcome_page.aspx.cs" Inherits="Web_Dev_Bootcamp.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="welcome_page" class="welcome_page" runat="server">
        <h1 >Welcome <span id="login_id" runat="server"></span>...!</h1> 
        <h2>You successfully logged In as <span id="login_as" runat="server"></span></h2>
    </div>
</asp:Content>
