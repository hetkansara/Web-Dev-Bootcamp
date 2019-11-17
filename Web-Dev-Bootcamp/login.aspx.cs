using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Dev_Bootcamp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) {

                Page.Validate();
                
                if (Page.IsValid) {
                    Response.Redirect("Students.aspx");
                }
            }
        }
    }
}