using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace offlineproject
{
    public partial class AllotmentLetter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["rollno"];
            Label2.Text = Request.QueryString["name"];
            Label3.Text = Request.QueryString["add"];
            Label4.Text = Request.QueryString["rank"];
            Label5.Text = Request.QueryString["gender"];
            Label6.Text = Request.QueryString["cat"];
            Label7.Text = Request.QueryString["instname"];
            Label8.Text = Request.QueryString["branch"];
            Label9.Text = Request.QueryString["choiceno"];
        }
    }
}