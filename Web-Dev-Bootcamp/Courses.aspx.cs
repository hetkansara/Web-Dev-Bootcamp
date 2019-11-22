using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Dev_Bootcamp
{
    public partial class Courses : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string classid = Request.QueryString["classid"];

            //We will attempt to get the record we need
            if (!String.IsNullOrEmpty(classid))
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> course_record = db.FindInTable(Int32.Parse(classid), "CLASSES");

                if (course_record.Count > 0)
                {
                    pageTypeTitle.InnerHtml = "Edit ";
                    coursecode.Text = course_record["CLASSCODE"];
                    startdate.Text = course_record["STARTDATE"];
                    finishdate.Text = course_record["FINISHDATE"];
                    coursename.Text = course_record["CLASSNAME"];
                }
                else
                {
                    //course.InnerHtml = "There was an error finding that course.";
                }
            }
            else
            {
                pageTypeTitle.InnerHtml = " Add ";
            }


        }
    }
}