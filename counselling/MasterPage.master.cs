using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["loginid"] != null)
            {  
                string id = Session["loginid"].ToString();
                string s = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection con = new SqlConnection(s);
                SqlCommand cmd = new SqlCommand("select Name from UserDetail where LoginId='" + id + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Label1.Text = "Welcome " + dr[0].ToString();
                    Button1.Text = "Logout";

                }
            }
            else
            {
                Label1.Text = "Welcome Guest";
                Button1.Text = "Login";
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Button1.Text.Equals("Logout"))
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("~/Login.aspx");

        }
        else if (Button1.Text.Equals("Login"))
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}
