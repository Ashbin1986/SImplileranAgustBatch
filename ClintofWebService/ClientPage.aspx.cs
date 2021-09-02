using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClintofWebService
{
    public partial class ClientPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentClient.StudentServiceSoapClient studentServiceSoapClient = new StudentClient.StudentServiceSoapClient();
           var resonseFromServic  = studentServiceSoapClient.GetRecords();

            StudentClient.Employee employee = new StudentClient.Employee();
            employee.EmpName = "Test";
            studentServiceSoapClient.AddEmployee(employee);

            Response.Write(resonseFromServic.Count);
            
        }

        [WebMethod]
        public static void GetRecords()
        {

        }
    }
}