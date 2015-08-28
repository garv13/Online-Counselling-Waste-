using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace offlineproject
{
    public partial class masterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["login"] != null)
                {
                    Label1.Text = "Welcome " + Session["login"].ToString();
                    logb.Text = "Log Out";
                }
                else
                {
                    Label1.Text = "Welcome Guest ";
                    logb.Text = "Log In";
                }
            }
        }
        protected void logb_Click(object sender, EventArgs e)
        {
            if (logb.Text.Equals("Log In"))
            {
                Response.Redirect("~/login.aspx");
            }
            else if (logb.Text.Equals("Log Out"))
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("~/login.aspx");
            }
        }
    }
}