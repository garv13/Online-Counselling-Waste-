using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using Newtonsoft.Json;

namespace offlineproject
{
    public partial class admin : System.Web.UI.Page
    {
        collegeSelected obj;
        ArrayList name = new ArrayList();
        ArrayList rank = new ArrayList();
        ArrayList allot = new ArrayList();
        ArrayList selected = new ArrayList();
        ArrayList namecoll = new ArrayList();
        ArrayList seatsleft = new ArrayList();
        ArrayList branch = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
          
            Label lbl;
            foreach (GridViewRow g in GridView1.Rows)
            {
                lbl = (Label)g.FindControl("lblfirstname");
                name.Add(lbl.Text);
                lbl = (Label)g.FindControl("lblrank");
                rank.Add(lbl.Text);
                lbl = (Label)g.FindControl("lblallot");
                allot.Add(lbl.Text);
                lbl = (Label)g.FindControl("lblselected");
                selected.Add(lbl.Text);
            }

            foreach (GridViewRow g in GridView2.Rows)
            {
                lbl = (Label)g.FindControl("lblname");
                namecoll.Add(lbl.Text);
                lbl = (Label)g.FindControl("lblseatsleft");
                seatsleft.Add(lbl.Text);
                lbl = (Label)g.FindControl("lblbranch");
                branch.Add(lbl.Text);
            }
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("addCollege.aspx");

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            string s = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("Delete from College Where name = '@name' And branch = '@branch'", con);
            cmd.Parameters.AddWithValue("@name", DropDownList1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@branch", DropDownList2.SelectedValue.ToString());
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
                Response.Write("<script>alert('College Deleted');</script>");
            else
                Response.Write("<script>alert('Error..... Can't Delete ');</script>");
        }
       // string s;
        int c = 0;
        protected void resultCalc(object sender, EventArgs e)
        {
            int count = name.Count;
            int coll = namecoll.Count;
            int flag = 0;
            c = 0;
            for (int i = 0; i < count; i++)
            {
                flag = 0;
                if (allot[i].ToString() != "lol")
                    flag = 1;
                    obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                    while (c < coll)
                    {
                        if (flag==1)
                        {
                            break;
                        }
                        if (obj.op1 == (namecoll[c].ToString()))
                        {

                        if (seatsleft[c].ToString() != "0")
                        {
                            int se = int.Parse(seatsleft[c].ToString());
                            se--;
                            seatsleft[c] = se.ToString();
                            allot[i] = obj.op1;
                        }
                       
                            break;
                        }
                        else
                        {
                            c++;
                        }
                    }
            }
            c = 0;
            for (int i = 0; i < count; i++)
            {
                flag = 0;
                if (allot[i].ToString() != "lol")
                    flag = 1;
                obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                while (c < coll)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    if (obj.op2 == (namecoll[c].ToString()))
                    {

                        if (seatsleft[c].ToString() != "0")
                        {
                            int se = int.Parse(seatsleft[c].ToString());
                            se--;
                            seatsleft[c] = se.ToString();
                            allot[i] = obj.op1;
                        }

                        break;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            c = 0; for (int i = 0; i < count; i++)
            {
                flag = 0;
                if (allot[i].ToString() != "lol")
                    flag = 1;
                obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                while (c < coll)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    if (obj.op3 == (namecoll[c].ToString()))
                    {

                        if (seatsleft[c].ToString() != "0")
                        {
                            int se = int.Parse(seatsleft[c].ToString());
                            se--;
                            seatsleft[c] = se.ToString();
                            allot[i] = obj.op1;
                        }

                        break;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            c = 0; for (int i = 0; i < count; i++)
            {
                flag = 0;
                if (allot[i].ToString() != "lol")
                    flag = 1;
                obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                while (c < coll)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    if (obj.op4 == (namecoll[c].ToString()))
                    {

                        if (seatsleft[c].ToString() != "0")
                        {
                            int se = int.Parse(seatsleft[c].ToString());
                            se--;
                            seatsleft[c] = se.ToString();
                            allot[i] = obj.op1;
                        }

                        break;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            c = 0; for (int i = 0; i < count; i++)
            {
                flag = 0;
                if (allot[i].ToString() != "lol")
                    flag = 1;
                obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                while (c < coll)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    if (obj.op5 == (namecoll[c].ToString()))
                    {

                        if (seatsleft[c].ToString() != "0")
                        {
                            int se = int.Parse(seatsleft[c].ToString());
                            se--;
                            seatsleft[c] = se.ToString();
                            allot[i] = obj.op1;
                        }

                        break;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            c = 0; for (int i = 0; i < count; i++)
            {
                flag = 0;
                if (allot[i].ToString() != "lol")
                    flag = 1;
                obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                while (c < coll)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    if (obj.op6 == (namecoll[c].ToString()))
                    {

                        if (seatsleft[c].ToString() != "0")
                        {
                            int se = int.Parse(seatsleft[c].ToString());
                            se--;
                            seatsleft[c] = se.ToString();
                            allot[i] = obj.op1;
                        }

                        break;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            c = 0; for (int i = 0; i < count; i++)
            {
                flag = 0;
                if (allot[i].ToString() != "lol")
                    flag = 1;
                obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                while (c < coll)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    if (obj.op7 == (namecoll[c].ToString()))
                    {

                        if (seatsleft[c].ToString() != "0")
                        {
                            int se = int.Parse(seatsleft[c].ToString());
                            se--;
                            seatsleft[c] = se.ToString();
                            allot[i] = obj.op1;
                        }

                        break;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            c = 0; for (int i = 0; i < count; i++)
            {
                flag = 0;
                if (allot[i].ToString() != "lol")
                    flag = 1;
                obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                while (c < coll)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    if (obj.op8 == (namecoll[c].ToString()))
                    {

                        if (seatsleft[c].ToString() != "0")
                        {
                            int se = int.Parse(seatsleft[c].ToString());
                            se--;
                            seatsleft[c] = se.ToString();
                            allot[i] = obj.op1;
                        }

                        break;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            c = 0; for (int i = 0; i < count; i++)
            {
                flag = 0;
                if (allot[i].ToString() != "lol")
                    flag = 1;
                obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                while (c < coll)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    if (obj.op9 == (namecoll[c].ToString()))
                    {

                        if (seatsleft[c].ToString() != "0")
                        {
                            int se = int.Parse(seatsleft[c].ToString());
                            se--;
                            seatsleft[c] = se.ToString();
                            allot[i] = obj.op1;
                        }

                        break;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            c = 0; for (int i = 0; i < count; i++)
            {
                flag = 0;
                if (allot[i].ToString() != "lol")
                    flag = 1;
                obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                while (c < coll)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    if (obj.op10 == (namecoll[c].ToString()))
                    {

                        if (seatsleft[c].ToString() != "0")
                        {
                            int se = int.Parse(seatsleft[c].ToString());
                            se--;
                            seatsleft[c] = se.ToString();
                            allot[i] = obj.op1;
                        }

                        break;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            c = 0;

            string s = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                SqlConnection con = new SqlConnection(s);
              
            for (int i = 0; i < count; i++)
            {
                SqlCommand cmd = new SqlCommand("update Student set allot=@allot where rank=@rank", con);
                con.Open();
                cmd.Parameters.AddWithValue("@allot", allot[i]);
                cmd.Parameters.AddWithValue("@rank", rank[i]);
                cmd.ExecuteNonQuery();
                con.Close();
            }

           
                for (int j = 0; j < coll; j++)
                {
                SqlCommand cmd1 = new SqlCommand("update College set seatsleft=@seatleft where name=@name", con);
                con.Open();
                cmd1.Parameters.AddWithValue("@seatleft", seatsleft[j]);
                cmd1.Parameters.AddWithValue("@name", namecoll[j]);
                cmd1.ExecuteNonQuery();
                con.Close();
                }        
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if((TextBox3.Text=="loltest")&&(TextBox4.Text=="lol123"))
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


                            
                  
                    