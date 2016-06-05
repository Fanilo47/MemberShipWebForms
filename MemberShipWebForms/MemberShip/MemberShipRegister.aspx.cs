using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security;

namespace MemberShipWebForms
{
    public partial class MemberShipLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             MembershipCreateStatus createStatus;
             

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            MembershipCreateStatus createStatus = MembershipCreateStatus.Success;
            Membership.CreateUser(CreateUserWizard1.UserName, CreateUserWizard1.Password, CreateUserWizard1.Email,
                CreateUserWizard1.Question, CreateUserWizard1.Answer, true, out createStatus);
            Response.Redirect("Login.aspx");
        }
    }
}