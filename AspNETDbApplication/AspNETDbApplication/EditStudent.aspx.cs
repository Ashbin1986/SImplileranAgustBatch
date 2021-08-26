using BusinessLayer;
using DataTransferModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNETDbApplication
{
    public partial class EditStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        private void UpdateStudent()
        {
            StudentBL studentBl = new StudentBL();

            Student student = new Student
            {

            };

            var students = studentBl.UpdateStudent(student);
        }
    }
}