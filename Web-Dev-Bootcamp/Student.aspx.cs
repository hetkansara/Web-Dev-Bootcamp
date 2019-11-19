﻿using System;
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
            bool valid = true;
            string studentid = Request.QueryString["target_student_id"];
            
            if (String.IsNullOrEmpty(studentid)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {
                target_student_id.InnerHtml = studentid;
                var db = new SCHOOLDB();
                Dictionary<String, String> student_record = db.FindStudent(Int32.Parse(studentid));

                if (student_record.Count > 0)
                {
                    // student_title_fname.InnerHtml = student_record["STUDENTFNAME"] + " " + student_record["STUDENTLNAME"];
                    // student_fname.InnerHtml = student_record["STUDENTFNAME"];
                    // student_lname.InnerHtml = student_record["STUDENTLNAME"];
                    // student_number.InnerHtml = student_record["STUDENTNUMBER"];
                    // enrolment_date.InnerHtml = student_record["ENROLMENTDATE"];
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                //student.InnerHtml = "There was an error finding that student.";
            }
        }
    }
}