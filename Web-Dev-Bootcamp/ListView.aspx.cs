using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Dev_Bootcamp
{
    public partial class _ListView : Page
    {  

        protected void Page_Load(object sender, EventArgs e)
        {
            string loginid = Request.QueryString["loginid"];

            //------------------------------------
                //Clearing div with ID "list_view_result".
                list_view_result.InnerHtml = "";

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
                        list_view_result.InnerHtml += "<tr><th scope=\"row\">" + studentid + "</th>";

                        string studentfirstname = row["STUDENTFNAME"];
                        list_view_result.InnerHtml += "<td>" + studentfirstname + "</td>";

                        string studentlastname = row["STUDENTLNAME"];
                        list_view_result.InnerHtml += "<td>" + studentlastname + "</td>";

                        string studentnumber = row["STUDENTNUMBER"];
                        list_view_result.InnerHtml += "<td>" + studentnumber + "</td>";

                        string enrolmentdate = row["ENROLMENTDATE"];
                        list_view_result.InnerHtml += "<td>" + enrolmentdate + "</td>";

//                        list_view_result.InnerHtml += "<td class='action-items'><a href='Edit_Student.aspx?studentid=" + studentid + "' title ='Edit Student'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Student'><i class='fas fa-trash'></i></a></td>";
                        list_view_result.InnerHtml += "<td class='action-items'><a href='Student.aspx?studentid=" + studentid + "&loginid="+loginid+"' title ='Edit Student'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Student' onclick='return confirm(\"Are you sure you want to delete student ["+studentnumber+" - "+studentfirstname+" "+studentlastname+"]?\")'><i class='fas fa-trash'></i></a></td>";

                        list_view_result.InnerHtml += "</td></tr>";
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
                        list_view_result.InnerHtml += "<tr><th scope=\"row\">" + teacherid + "</th>";

                        string teacherfirstname = row["TEACHERFNAME"];
                        list_view_result.InnerHtml += "<td>" + teacherfirstname + "</td>";

                        string teacherlastname = row["TEACHERLNAME"];
                        list_view_result.InnerHtml += "<td>" + teacherlastname + "</td>";

                        string employeenumber = row["EMPLOYEENUMBER"];
                        list_view_result.InnerHtml += "<td>" + employeenumber + "</td>";

                        string hiredate = row["HIREDATE"];
                        list_view_result.InnerHtml += "<td>" + hiredate + "</td>";

//                        studentsResult.InnerHtml += "<td class='action-items'><a href='Edit_Student.aspx?studentid=" + teacherid + "' title ='Edit Student'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Student'><i class='fas fa-trash'></i></a></td>";
                        list_view_result.InnerHtml += "<td>" + employeenumber + "</td>";
                        list_view_result.InnerHtml += "<td class='action-items'><a href='Faculty.aspx?teacherid=" + teacherid + "&loginid="+loginid+"' title ='Edit Faculty'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Faculty' onclick='return confirm(\"Are you sure you want to delete faculty ["+employeenumber+" - "+teacherfirstname+" "+teacherlastname+"]?\")'><i class='fas fa-trash'></i></a></td>";

                        list_view_result.InnerHtml += "</td></tr>";
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
                        list_view_result.InnerHtml += "<tr><th scope=\"row\">" + classid + "</th>";

                        string classcode = row["CLASSCODE"];
                        list_view_result.InnerHtml += "<td>" + classcode + "</td>";

                        string classname = row["CLASSNAME"];
                        list_view_result.InnerHtml += "<td>" + classname + "</td>";

                        string startdate = row["STARTDATE"];
                        list_view_result.InnerHtml += "<td>" + startdate + "</td>";

                        string finishdate = row["FINISHDATE"];
                        list_view_result.InnerHtml += "<td>" + finishdate + "</td>";

//                        list_view_result.InnerHtml += "<td class='action-items'><a href='Edit_Student.aspx?studentid=" + classid + "' title ='Edit Student'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Student'><i class='fas fa-trash'></i></a></td>";
                        list_view_result.InnerHtml += "<td class='action-items'><a href='Course.aspx?classid=" + classid + "&loginid="+loginid+"' title ='Edit Course'><i class='fas fa-edit'></i></a>  <a href='#' title='Delete Course' onclick='return confirm(\"Are you sure you want to delete course ["+classcode+ " - "+classname+"]?\")'><i class='fas fa-trash'></i></a></td>";

                        list_view_result.InnerHtml += "</td></tr>";
                    }
                }

        }
    }
}
