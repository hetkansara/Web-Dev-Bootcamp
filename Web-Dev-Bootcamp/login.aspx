<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Web_Dev_Bootcamp.login" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title></title>
        <webopt:bundlereference runat="server" path="~/Content/css" />
        <link rel="stylesheet" type="text/css" href="~/Content/style.css" />
    </head>

    <body style="background-color:#eceff1;">
        <form id="loginform" runat="server">
            <asp:ScriptManager runat="server">
                <Scripts>
                    <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                        <%--Framework Scripts--%>
                            <asp:ScriptReference Name="MsAjaxBundle" />
                            <asp:ScriptReference Name="jquery" />
                            <asp:ScriptReference Name="bootstrap" />
                            <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                            <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                            <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                            <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                            <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                            <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                            <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                            <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                            <asp:ScriptReference Name="WebFormsBundle" />
                            <%--Site Scripts--%>
                </Scripts>
            </asp:ScriptManager>
            <div class="container login-form">

                <div class="row login-container">
                    <div class="col-md-8 col-lg-8 col">
                        <!-- 
                            Cover Image taken from: 
                            https://unsplash.com/s/photos/sample - free sample images
                            Image: https://unsplash.com/photos/Imc-IoZDMXc
                        -->
                        <img src="./Content/Images/banner.jpg" class="banner" alt="Banner Image" />
                    </div>
                    <div class="col-md-4 col-lg-4 col login-card">
                        <h2 class="text-center">Web Dev Bootcamp</h2>
                        <section class="login-section">
                            <h3>Login</h3>
                            <div class="input-item">
                                <label>Username:</label>
                                <asp:TextBox ID="user_name" runat="server" ></asp:TextBox>
                                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please enter username" ControlToValidate="user_name"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-item">
                                <label>Password:</label>
                                <asp:TextBox ID="user_password" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please enter password" ControlToValidate="user_password"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-item">
                                <input type="submit" value="Login" name="" id="">
                            </div>
                            <a href="Students.aspx?loginid=Dhanpreet">Login Dhanpreet</a>
                            <a href="#">Forgot Password?</a>
                        </section>
                    </div>
                </div>
            </div>
            <div>
            </div>
        </form>
    </body>

    </html>