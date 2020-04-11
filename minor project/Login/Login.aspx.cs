using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using minor_project;

namespace minor_project.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }
        
        wardy war = new wardy();
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = war.Login(txtUsername.Text, txtPassword.Text);
            if (dt.Rows.Count > 0)
            {

                Response.Redirect("../Admin/Home.aspx");
            }
            else
            {
                Response.Redirect("../Loginfail.aspx");
            }

        }
    }
}