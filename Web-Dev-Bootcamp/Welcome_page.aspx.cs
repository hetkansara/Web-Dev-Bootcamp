using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Dev_Bootcamp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool Login_Session = true;
            string Login_Id = Request.QueryString["login_id"];
            if (string.IsNullOrEmpty(Login_Id)) Login_Session = false;

            if (Login_Session == true)
            {
                login_id.InnerHtml = "Dhanpreet Singh";
                login_as.InnerHtml = "Student";
            }
            else
            {
                welcome_page.InnerHtml = "<h1>Error With this page...!</h1>";
                welcome_page.InnerHtml += "<h2><a href='login.aspx'>Back to Login Page</a></h2>";
            }
        }
    }
}