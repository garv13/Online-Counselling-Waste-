using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace offlineproject
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //grid visibilty off
        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    string s = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        //    SqlConnection con = new SqlConnection(s);
        //    SqlCommand cmd = new SqlCommand("insert into College values('@seats','@name','@branch')", con);
        //    cmd.Parameters.AddWithValue("@seats", TextBox3.Text);
        //    cmd.Parameters.AddWithValue("name", TextBox1.Text);
        //    cmd.Parameters.AddWithValue("@branch", TextBox2.Text);
        //    con.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();
        //    if (i != 0)
        //        Response.Write("<script>alert('College Added');</script>");
        //    else
        //        Response.Write("<script>alert('Error..... Can't Update ');</script>");   
        //}
        
          protected void Button6_Click(object sender, EventArgs e)
        {
            //main.Visible = false;
            //coll.Visible = true;
            //string s = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            //SqlConnection con = new SqlConnection(s);
            //SqlCommand cmd = new SqlCommand("insert into College values('@seats','@name','@branch')", con);
            //cmd.Parameters.AddWithValue("@seats", TextBox11.Text);
            //cmd.Parameters.AddWithValue("name", DropDownList1.SelectedValue);
            //cmd.Parameters.AddWithValue("@branch", TextBox10.Text);
            //con.Open();
            //int i = cmd.ExecuteNonQuery();
            //con.Close();
            //if (i != 0)
            //    Response.Write("<script>alert('Branch Added');</script>");
            //else
            //    Response.Write("<script>alert('Error..... Can't Add ');</script>");
        }


    }
}