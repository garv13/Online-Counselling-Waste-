﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace offlineproject
{
    public partial class stlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                string st = Session["login"].ToString();
                string s = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                SqlConnection con = new SqlConnection(s);
                SqlCommand cmd = new SqlCommand("select * from student where rollno='" + st + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr[11].ToString() != "lol" && dr[11].ToString() != null)
                            Response.Write("<script>alert('Choices Are Already Filled or Allotment Letter Has Been Generated.Click On Allotment Letter To Print it')</script>");
                        else
                            Response.Redirect("~/Prefrences.aspx");
                    }
                }
                con.Close();
            }
            else
                Response.Redirect("~/login.aspx");
        }
          protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                string st = Session["login"].ToString();
                string s = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                SqlConnection con = new SqlConnection(s);
                SqlCommand cmd = new SqlCommand("select * from student where rollno='" + st + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr[11].ToString() != "lol" && dr[11].ToString() != null)
                            Response.Redirect("~/AllotmentLetter.aspx?rollno=" + dr[0].ToString() + "&name=" + dr[1].ToString() + "&add=" + dr[9].ToString() + "&rank=" + dr[10].ToString() + "&gender=" + dr[5].ToString() + "&cat=" + dr[7].ToString() + "&instname=" + dr[11].ToString() + "&branch=" + "&choiceno" + dr[12].ToString());
                        else
                        {
                            Response.Write("<script>alert('Allotment Letter Not Generated')</script>");
                        }
                    }
                }
                con.Close();
            }
            else
                Response.Redirect("~/login.aspx");
          }

    }
}