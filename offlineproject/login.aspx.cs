using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace offlineproject
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select count(*) from student where rollno='" + Textid.Text + "' and Password='" + Textpwd.Text + "'", con);
            con.Open();
            int m = (int)cmd.ExecuteScalar();
            if (m == 1)
            {
                Session["login"] = Textid.Text;
                Response.Redirect("~/stlog.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login failed')</script>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string s = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select count(*) from student where mobile='" +txtph+ "' and Password='" + txtpwd2.Text + "'", con);
            con.Open();
            int m = (int)cmd.ExecuteScalar();
            if (m == 1)
            {
                Session["login"] = Textid.Text;
                Response.Redirect("~/stlog.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login failed')</script>");
            }
        }

    }
}