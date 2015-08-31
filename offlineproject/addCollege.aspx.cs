using Newtonsoft.Json;
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
    public partial class addCollege : System.Web.UI.Page
    {
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (i == 0)
            {
                main.Visible = true;
                seat.Visible = false;
                coll.Visible = false;
                bran.Visible = false;
            }
            else if(i==1)
            {
                main.Visible = false;
                seat.Visible = true;
                
            }

        }
        protected void back(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addCollege.aspx");
        }
         protected void Button6_Click(object sender, EventArgs e)
         {
            string s = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("Update College set seats = @seats Where ((name = @name) And (branch = @branch))", con);
            cmd.Parameters.AddWithValue("@name", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@branch", DropDownList2.SelectedValue);   
            cmd.Parameters.AddWithValue("@seats",newSeats.Text);
            con.Open();
            int j = cmd.ExecuteNonQuery();
            con.Close();
            if(j==1)
       
                Response.Write("<script>alert('Seats Updated');</script>");
           else
                Response.Write("<script>alert('Error..... Can't Update ');</script>");   
         }
         protected void Button8_Click(object sender, EventArgs e)
         {
             main.Visible = false;
             coll.Visible = true;
             string s = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
             SqlConnection con = new SqlConnection(s);
             SqlCommand cmd = new SqlCommand("Insert into College values(@name,@seats,@branch,@seatsleft)", con);
             cmd.Parameters.AddWithValue("@name", nameColl.Text);
             cmd.Parameters.AddWithValue("@seats", seatColl.Text);
             cmd.Parameters.AddWithValue("@branch", branchColl.Text);
             cmd.Parameters.AddWithValue("@seatsleft", "null");
             con.Open();
            int i= cmd.ExecuteNonQuery();
             con.Close();
             if(i==1)
                 Response.Write("<script>alert('College Added');</script>");
             else
                 Response.Write("<script>alert('Error..... Can't Add ');</script>");
             main.Visible = true;
             coll.Visible = false;
         }
         protected void Button2_Click(object sender, EventArgs e)
         {
             coll.Visible = true;
             main.Visible = false;
         }
        protected void Button4_Click(object sender, EventArgs e)
         {
             seat.Visible = true;
             main.Visible = false;
         }
        protected void Button3_Click(object sender, EventArgs e)
        {
            bran.Visible = true;
            main.Visible = false;
        }
        protected void Button10_Click(object sender, EventArgs e)
        {

            string s = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("insert into College values(@seats,@name,@branch,@seatsleft)", con);
            cmd.Parameters.AddWithValue("@seats", seats.Text);
            cmd.Parameters.AddWithValue("name", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@branch", newBranch.Text);
            cmd.Parameters.AddWithValue("@seatsleft", "null");
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
                Response.Write("<script>alert('Branch Added');</script>");
            else
                Response.Write("<script>alert('Error..... Can't Add ');</script>");
            main.Visible = true;
            bran.Visible = false;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            string s = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("Select * from College", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    seatTotal.Text = dr[2].ToString();
                    seatLeft.Text = dr[4].ToString();
                }
            }

            con.Close();
            main.Visible = false;
            seat.Visible = true;
            i = 1;
        }

        //protected void prefrence(object sender, EventArgs e)
        //{
        //    collegeSelected c = new collegeSelected();
        //    c.op1 = "lol1";
        //    c.op2 = "lol2";
        //    c.op3 = "lol3";
        //    c.op4 = "lol4";
        //    c.op5 = "lol5";
        //    c.op6 = "lol6";
        //    c.op7 = "lol7";
        //    c.op8 = "lol8";
        //    c.op9 = "lol9";
        //    c.op10 = "lol0";
        //  string json = JsonConvert.SerializeObject(c);
        //  string s = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        ////  int a = 1;
        //  SqlConnection con = new SqlConnection(s);
        //  SqlCommand cmd = new SqlCommand("insert into Student values(@rollno,@firstName,@lastName,@age,@mobile,@email,@rank,@allot,@freeze,@selected)", con);
        //  cmd.Parameters.AddWithValue("@rollno", "12345lowadlfsroll");
        //  cmd.Parameters.AddWithValue("firstName", "firstlol");
        //  cmd.Parameters.AddWithValue("@lastName", "lastlol");
        //  cmd.Parameters.AddWithValue("@age", "21");
        //  cmd.Parameters.AddWithValue("@rank", "123");
        //  cmd.Parameters.AddWithValue("@selected",json);
        //  cmd.Parameters.AddWithValue("@mobile", "1231");
        //  cmd.Parameters.AddWithValue("@email", "8123kjsd");
        //  cmd.Parameters.AddWithValue("@allot", "kjsd");
        //  cmd.Parameters.AddWithValue("@freeze", "free" );
        //  con.Open();
        //  cmd.ExecuteNonQuery();
        //  con.Close();
        //  string r = null;
        //  SqlCommand cmd1 = new SqlCommand("Select selected from Student", con);
        //  con.Open();
        //  SqlDataReader dr = cmd1.ExecuteReader();
        //  if (dr.HasRows)
        //  {
        //      while (dr.Read())
        //      {
        //          r = dr[0].ToString();
        //      }
        //  }
        //  con.Close();
        //  var ob = JsonConvert.DeserializeObject<collegeSelected>(r);
        //}
        protected void Button5_Click(object sender, EventArgs e)
        {
            if ((TextBox3.Text == "loltest") && (TextBox4.Text == "lol123"))
            {
                loginForm.Visible = false;
                form1.Visible = true;

            }
            else
            {
                Response.Write("Wrong Password");
            }
        }
    }
}