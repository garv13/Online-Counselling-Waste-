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
                    Button1.Text = "Log Out";
                }
                else
                {
                    Label1.Text = "Welcome Guest ";
                    Button1.Text = "Log In";
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text.Equals("Log In"))
            {
                Response.Redirect("~/login.aspx");
            }
            else if (Button1.Text.Equals("Log Out"))
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("~/login.aspx");
            }
        }
    }
}