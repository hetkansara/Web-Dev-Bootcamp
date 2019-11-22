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

            //------------------------------------
                //Clearing div with ID "students_result".
                students_result.InnerHtml = "";

                //Setting up string to hold list type to be printed
                string ListType = Request.QueryString["listType"];

                var db = new SCHOOLDB();

                //Setting up string to hold the search querry
                string Query = "select * from " + ListType;

                //Setting up string to hold search key, initializing it as empty, as before post back of search submitted string must be empty to show all or complete list.
                string SearchKey = "";

                //If page is post back then setting search key with search input
                if (Page.IsPostBack)
                {
                    SearchKey = searchText.Text;
                    if (ListType == "students")
                    {
                        Query += " WHERE STUDENTFNAME like '%" + SearchKey + "%' or STUDENTLNAME like '%" + SearchKey + "%' or STUDENTNUMBER like '%" + SearchKey + "%'";
                    }
                    if (ListType == "teachers")
                    {
                        Query += " WHERE TEACHERFNAME like '%" + SearchKey + "%' or TEACHERLNAME like '%" + SearchKey + "%' or EMPLOYEENUMBER like '%" + SearchKey + "%'";
                    }
                    if (ListType == "classes")
                    {
                        Query += " WHERE CLASSCODE like '%" + SearchKey + "%' or CLASSNAME like '%" + SearchKey + "%'";
                    }
//                debugQuery.InnerHtml = Query;
                }

                List<Dictionary<String, String>> rs = db.List_Query(Query);
                if (rs.Count == 0)
                {
                    NoResultMsg.InnerHtml = "No Result found.";

                }

                if (ListType == "students")
                {
                    page_title.InnerHtml = "STUDENTS";
                    addButton.HRef = "Student.aspx?loginid=" + loginid;
                    addButton.Title = "Add Student";
                    Col1.InnerHtml = "First Name";
                    Col2.InnerHtml = "Last Name";
                    Col3.InnerHtml = "Student Number";
                    Col4.InnerHtml = "Enrollment Date";

                    foreach (Dictionary<String, String> row in rs)
                    {
                        string studentid = row["STUDENTID"];
                        students_result.InnerHtml += "<tr><th scope=\"row\">" + studentid + "</th>";

                        string studentfirstname = row["STUDENTFNAME"];
                        students_result.InnerHtml += "<td>" + studentfirstname + "</td>";

                        string studentlastname = row["STUDENTLNAME"];
                        students_result.InnerHtml += "<td>" + studentlastname + "</td>";

                        string studentnumber = row["STUDENTNUMBER"];
                        students_result.InnerHtml += "<td>" + studentnumber + "</td>";

                        string enrolmentdate = row["ENROLMENTDATE"];
                        students_result.InnerHtml += "<td>" + enrolmentdate + "</td>";

//                        students_result.InnerHtml += "<td class='action-items'><a href='Edit_Student.aspx?studentid=" + studentid + "' title ='Edit Student'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Student'><i class='fas fa-trash'></i></a></td>";
                        students_result.InnerHtml += "<td class='action-items'><a href='Student.aspx?studentid=" + studentid + "&loginid="+loginid+"' title ='Edit Student'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Student' onclick='return confirm(\"Are you sure you want to delete student ["+studentnumber+" - "+studentfirstname+" "+studentlastname+"]?\")'><i class='fas fa-trash'></i></a></td>";

                        students_result.InnerHtml += "</td></tr>";
                    }
                }

                if (ListType == "teachers")
                {
                    page_title.InnerHtml = "FACULTIES";
                    addButton.HRef = "Faculty.aspx?loginid=" + loginid;
                    addButton.Title = "Add Faculty";
                    Col1.InnerHtml = "First Name";
                    Col2.InnerHtml = "Last Name";
                    Col3.InnerHtml = "Employee Number";
                    Col4.InnerHtml = "Hire Date";
                    foreach (Dictionary<String, String> row in rs)
                    {
                        string teacherid = row["TEACHERID"];
                        students_result.InnerHtml += "<tr><th scope=\"row\">" + teacherid + "</th>";

                        string teacherfirstname = row["TEACHERFNAME"];
                        students_result.InnerHtml += "<td>" + teacherfirstname + "</td>";

                        string teacherlastname = row["TEACHERLNAME"];
                        students_result.InnerHtml += "<td>" + teacherlastname + "</td>";

                        string employeenumber = row["EMPLOYEENUMBER"];
                        students_result.InnerHtml += "<td>" + employeenumber + "</td>";

                        string hiredate = row["HIREDATE"];
                        students_result.InnerHtml += "<td>" + hiredate + "</td>";

//                        studentsResult.InnerHtml += "<td class='action-items'><a href='Edit_Student.aspx?studentid=" + teacherid + "' title ='Edit Student'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Student'><i class='fas fa-trash'></i></a></td>";
                        students_result.InnerHtml += "<td>" + employeenumber + "</td>";
                        students_result.InnerHtml += "<td class='action-items'><a href='Faculty.aspx?teacherid=" + teacherid + "&loginid="+loginid+"' title ='Edit Faculty'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Faculty' onclick='return confirm(\"Are you sure you want to delete faculty ["+employeenumber+" - "+teacherfirstname+" "+teacherlastname+"]?\")'><i class='fas fa-trash'></i></a></td>";

                        students_result.InnerHtml += "</td></tr>";
                    }

                }

                if (ListType == "classes")
                {
                    page_title.InnerHtml = "COURSES";
                    addButton.HRef = "Course.aspx?loginid=" + loginid;
                    addButton.Title = "Add Course";
                    Col1.InnerHtml = "Class Code";
                    Col2.InnerHtml = "Class Name";
                    Col3.InnerHtml = "Start Date";
                    Col4.InnerHtml = "Finish Date";
                    foreach (Dictionary<String, String> row in rs)
                    {
                        string classid = row["CLASSID"];
                        students_result.InnerHtml += "<tr><th scope=\"row\">" + classid + "</th>";

                        string classcode = row["CLASSCODE"];
                        students_result.InnerHtml += "<td>" + classcode + "</td>";

                        string classname = row["CLASSNAME"];
                        students_result.InnerHtml += "<td>" + classname + "</td>";

                        string startdate = row["STARTDATE"];
                        students_result.InnerHtml += "<td>" + startdate + "</td>";

                        string finishdate = row["FINISHDATE"];
                        students_result.InnerHtml += "<td>" + finishdate + "</td>";

//                        students_result.InnerHtml += "<td class='action-items'><a href='Edit_Student.aspx?studentid=" + classid + "' title ='Edit Student'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Student'><i class='fas fa-trash'></i></a></td>";
                        students_result.InnerHtml += "<td class='action-items'><a href='Course.aspx?classid=" + classid + "&loginid="+loginid+"' title ='Edit Course'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Course' onclick='return confirm(\"Are you sure you want to delete course ["+classcode+ " - "+classname+"]?\")'><i class='fas fa-trash'></i></a></td>";

                        students_result.InnerHtml += "</td></tr>";
                    }
                }

        }
    }
}
