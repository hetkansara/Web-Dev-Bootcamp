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

                string enrolmentdate = row["ENROLMENTDATE"];
                students_result.InnerHtml += "<td>" + enrolmentdate + "</td>";

                students_result.InnerHtml += "<td class='action-items'><a href='Edit_Student.aspx?studentid=" + studentid + "' title ='Edit Student'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Student'><i class='fas fa-trash'></i></a></td>";

                students_result.InnerHtml += "</td></tr>";
            }
        }
    }
}