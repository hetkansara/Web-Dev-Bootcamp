using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Dev_Bootcamp
{
    public partial class Faculties : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string facultyid = Request.QueryString["teacherid"];

            //We will attempt to get the record we need
            if (!String.IsNullOrEmpty(facultyid))
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> faculty_record = db.FindInTable(Int32.Parse(facultyid), "TEACHERS");

                if (faculty_record.Count > 0)
                {
                    pageTypeTitle.InnerHtml = "Edit ";
                    facultyfname.Text = faculty_record["TEACHERFNAME"];
                    facultylname.Text = faculty_record["TEACHERLNAME"];
                    employeenumber.Text = faculty_record["EMPLOYEENUMBER"];
                    hiredate.Text = faculty_record["HIREDATE"];
                    salary.Text = faculty_record["SALARY"];
                }
                else
                {
                    //faculty.InnerHtml = "There was an error finding that facukty.";
                }
            }
            else
            {
                pageTypeTitle.InnerHtml = " Add ";
            }
        }
    }
}