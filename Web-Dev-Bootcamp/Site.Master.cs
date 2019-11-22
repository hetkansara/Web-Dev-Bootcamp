using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Dev_Bootcamp
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string loginid = Request.QueryString["loginid"];
            bool Login_Session = true;

            if (string.IsNullOrEmpty(loginid)) Login_Session = false;

            if (Login_Session == true)
            {
                userName.InnerHtml = loginid + ", Logout?";
                studentLink.HRef += "&loginid="+loginid;
                courseLink.HRef += "&loginid="+loginid;
                facultyLink.HRef += "&loginid="+loginid;
            }
            else
            {
                loginContainer.InnerHtml = "";
                MainContent.Visible = false;

                errorContainer.InnerHtml = "<h1>Error With this page...!</h1>";
                errorContainer.InnerHtml += "<h2><a href='login.aspx'>Back to Login Page</a></h2>";
            }
        }
    }
}