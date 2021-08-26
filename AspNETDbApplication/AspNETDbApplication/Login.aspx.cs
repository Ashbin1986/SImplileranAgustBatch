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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UserBL user = new UserBL();

            UserCredentails credentails = new UserCredentails
            {
                UserName = txtUserName.Value,
                Password = txtPassword.Value
            };

            bool isValidUser = user.GetUserInformation(credentails);
            
            if(isValidUser)
            {
                // Create Cookies
                Session["UserName"] = credentails.UserName;

                Response.Redirect("Dashboard.aspx?Login=success");
            }
            else
            {
                lblMessage.Text = "Username/UserPassword is Invalid!.";
            }
        }
    }
}