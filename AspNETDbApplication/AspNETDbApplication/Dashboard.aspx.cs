using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNETDbApplication
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                GetStudents();
            }
            else
            {
                Response.Redirect("Login.aspx?message=unAuthrizedUser");
            }
        }

        private void GetStudents()
        {
            StudentBL student = new StudentBL();
            var students = student.GetStudents();

            gvStudents.DataSource = students;
            gvStudents.DataBind();

        }

        protected void lnkEdit_Command(object sender, CommandEventArgs e)
        {
            LinkButton button = sender as LinkButton;
            if(button.CommandName == "Edit")
            {
                Response.Redirect("EditStudent.aspx?studentid=" + button.CommandArgument);
                //navigate to Edit Page
                //open new page and bidn data into textboxes and call update function from BL->DL
            }

        }
    }
}