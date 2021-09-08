using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WCFServiceClient.Service1Client service1Client = new WCFServiceClient.Service1Client();
            var employee = service1Client.GetEmployees();
        }
    }
}