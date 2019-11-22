using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Dev_Bootcamp
{
    public partial class _Students : Page
    {  

        protected void Page_Load(object sender, EventArgs e)
        {
            string loginid = Request.QueryString["loginid"];
            addStudentButton.HRef += "?loginid=" + loginid;

            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query("select * from students");

            students_result.InnerHtml = "";
            foreach (Dictionary<String, String> row in rs)
            {
                string studentid = row["STUDENTID"];
                students_result.InnerHtml += "<tr><th scope=\"row\">"+ studentid +"</th>";

                string studentfirstname = row["STUDENTFNAME"];
                students_result.InnerHtml += "<td>" + studentfirstname + "</td>";

                string studentlastname = row["STUDENTLNAME"];
                students_result.InnerHtml += "<td>" + studentlastname + "</td>";

                string studentnumber = row["STUDENTNUMBER"];
                students_result.InnerHtml += "<td>" + studentnumber + "</td>";

                DateTime enrolmentdate = Convert.ToDateTime(row["ENROLMENTDATE"]);
                string dayOfMonth = "";
                if(enrolmentdate.Day > 9)
                {
                    dayOfMonth = Convert.ToString(enrolmentdate.Day);
                }
                else
                {
                    dayOfMonth = "0" + Convert.ToString(enrolmentdate.Day);
                }
                string monthOfYear = "";
                if (enrolmentdate.Month > 9)
                {
                    monthOfYear = Convert.ToString(enrolmentdate.Month);
                }
                else
                {
                    monthOfYear = "0" + Convert.ToString(enrolmentdate.Month);
                }

                students_result.InnerHtml += "<td>" + monthOfYear + "-" + dayOfMonth + "-" + enrolmentdate.Year + "</td>";

                students_result.InnerHtml += "<td class='action-items'><a href='Student.aspx?studentid=" + studentid + "&loginid="+loginid+"' title ='Edit Student'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Student' onclick='return confirm(\"Are you sure you want to delete student ["+studentnumber+" - "+studentfirstname+" "+studentlastname+"]?\")'><i class='fas fa-trash'></i></a></td>";

                students_result.InnerHtml += "</td></tr>";
            }
        }
    }
}