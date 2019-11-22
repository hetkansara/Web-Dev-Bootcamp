using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Web_Dev_Bootcamp
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string studentid = Request.QueryString["studentid"];

            backButton.HRef += "?loginid="+Request.QueryString["loginid"];
            //We will attempt to get the record we need
            if (!String.IsNullOrEmpty(studentid))
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> student_record = db.FindInTable(Int32.Parse(studentid), "STUDENTS");

                if (student_record.Count > 0)
                {
                    pageTypeTitle.InnerHtml = "Edit ";
                    studentfname.Text = student_record["STUDENTFNAME"];
                    studentlname.Text = student_record["STUDENTLNAME"];
                    studentnumber.Text = student_record["STUDENTNUMBER"];
                    enrollmentdate.Text = student_record["ENROLMENTDATE"];
                }
                else
                {
                    //student.InnerHtml = "There was an error finding that student.";
                }
            } else
            {
                pageTypeTitle.InnerHtml = " Add ";
            }
        }
    }
}