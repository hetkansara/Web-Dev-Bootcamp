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
                
                if (Page.IsValid)
                {
                    string UserName = user_name.Text;
                    string UserPassword = user_password.Text;

                    bool valid = true;
                    if (String.IsNullOrEmpty(UserName) && String.IsNullOrEmpty(UserPassword)) valid = false;

                    if (valid)
                    {
                        if (UserName == "Admin" && UserPassword == "Admin")
                        {
                            Response.Redirect("ListView.aspx?loginid=dhanpree&listType=students");
                        }
                        //else
                        //{
                        //    var db = new SCHOOLDB();
                        //    Dictionary<String, String> student_record = db.CheckPass(UserName);

                        //    if (student_record.Count > 0)
                        //    {
                        //        if ((UserName == student_record["STUDENTNUMBER"]) && (UserPassword == student_record["STUDENTFNAME"]))
                        //        {
                        //            Response.Redirect("Welcome_page.aspx?login_id=student");
                        //        }

                        //    }
                        //    else
                        //    {
                        //        Response.Redirect("login.aspx?");
                        //    }
                        //}
                    }
                }
            }
        }
    }
}