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
            string s = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            con.Open();
            con.Close();

            ArrayList name = new ArrayList();
            ArrayList rank = new ArrayList();
            ArrayList allot = new ArrayList();
            ArrayList selected = new ArrayList();
            ArrayList namecoll = new ArrayList();
            ArrayList seatsleft = new ArrayList();
            ArrayList branch = new ArrayList();
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
            string s = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("Delete from College values('@seats') Where name = '@name' And branch = '@branch'", con);
            cmd.Parameters.AddWithValue("name", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@branch", DropDownList2.SelectedValue);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
                Response.Write("<script>alert('College Deleted');</script>");
            else
                Response.Write("<script>alert('Error..... Can't Delete ');</script>");
        }
        string s;
        int c = 0;
        protected void resultCalc(object sender, EventArgs e)
        {
            int count = name.Count;
            c = 0;
            for (int i = 0; i < count; i++)
            {
                if (allot[i] != null)
                    break;
                else
                {
                        obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());
                    
                        while (c<10)
                        {
                            c++;
                            if (obj.op1 == namecoll[i])
                            {
                                if (seatsleft[c] != "0")
                                {
                                    int se = int.Parse(seatsleft[c].ToString());
                                    se--;
                                    seatsleft[c] = se.ToString();
                                    allot[i] = obj.op1;
                                    break;
                                }
                              
                            }
                            else 
                            {
                                c++;
                            }
                        }
                    
                }
            }
            c = 0;
            for (int i = 0; i < count; i++)
            {
                if (allot[i] != null)
                    break;
                else
                {
                    obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());

                    while (c < 10)
                    {
                        c++;
                        if (obj.op2 == namecoll[i])
                        {
                            if (seatsleft[c] != "0")
                            {
                                int se = int.Parse(seatsleft[c].ToString());
                                se--;
                                seatsleft[c] = se.ToString();
                                allot[i] = obj.op2;
                                break;
                            }

                        }
                        else
                        {
                            c++;
                        }
                    }

                }
            }
            c = 0;
            for (int i = 0; i < count; i++)
            {
                if (allot[i] != null)
                    break;
                else
                {
                    obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());

                    while (c < 10)
                    {
                        c++;
                        if (obj.op3 == namecoll[i])
                        {
                            if (seatsleft[c] != "0")
                            {
                                int se = int.Parse(seatsleft[c].ToString());
                                se--;
                                seatsleft[c] = se.ToString();
                                allot[i] = obj.op3;
                                break;
                            }

                        }
                        else
                        {
                            c++;
                        }
                    }

                }
            }
            c = 0;
            for (int i = 0; i < count; i++)
            {
                if (allot[i] != null)
                    break;
                else
                {
                    obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());

                    while (c < 10)
                    {
                        c++;
                        if (obj.op4 == namecoll[i])
                        {
                            if (seatsleft[c] != "0")
                            {
                                int se = int.Parse(seatsleft[c].ToString());
                                se--;
                                seatsleft[c] = se.ToString();
                                allot[i] = obj.op4;
                                break;
                            }

                        }
                        else
                        {
                            c++;
                        }
                    }

                }
            }
            c = 0;
            for (int i = 0; i < count; i++)
            {
                if (allot[i] != null)
                    break;
                else
                {
                    obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());

                    while (c < 10)
                    {
                        c++;
                        if (obj.op5 == namecoll[i])
                        {
                            if (seatsleft[c] != "0")
                            {
                                int se = int.Parse(seatsleft[c].ToString());
                                se--;
                                seatsleft[c] = se.ToString();
                                allot[i] = obj.op5;
                                break;
                            }

                        }
                        else
                        {
                            c++;
                        }
                    }

                }
            }
            c = 0;
            for (int i = 0; i < count; i++)
            {
                if (allot[i] != null)
                    break;
                else
                {
                    obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());

                    while (c < 10)
                    {
                        c++;
                        if (obj.op6 == namecoll[i])
                        {
                            if (seatsleft[c] != "0")
                            {
                                int se = int.Parse(seatsleft[c].ToString());
                                se--;
                                seatsleft[c] = se.ToString();
                                allot[i] = obj.op6;
                                break;
                            }

                        }
                        else
                        {
                            c++;
                        }
                    }

                }
            }
            c = 0;
                for (int i = 0; i < count; i++)
                {
                    if (allot[i] != null)
                        break;
                    else
                    {
                        obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());

                        while (c < 10)
                        {
                            c++;
                            if (obj.op7 == namecoll[i])
                            {
                                if (seatsleft[c] != "0")
                                {
                                    int se = int.Parse(seatsleft[c].ToString());
                                    se--;
                                    seatsleft[c] = se.ToString();
                                    allot[i] = obj.op7;
                                    break;
                                }

                            }
                            else
                            {
                                c++;
                            }
                        }

                    }
                }
                c = 0;
                for (int i = 0; i < count; i++)
                {
                    if (allot[i] != null)
                        break;
                    else
                    {
                        obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());

                        while (c < 10)
                        {
                            c++;
                            if (obj.op8 == namecoll[i])
                            {
                                if (seatsleft[c] != "0")
                                {
                                    int se = int.Parse(seatsleft[c].ToString());
                                    se--;
                                    seatsleft[c] = se.ToString();
                                    allot[i] = obj.op8;
                                    break;
                                }

                            }
                            else
                            {
                                c++;
                            }
                        }

                    }
                }
                c = 0;
                for (int i = 0; i < count; i++)
                {
                    if (allot[i] != null)
                        break;
                    else
                    {
                        obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());

                        while (c < 10)
                        {
                            c++;
                            if (obj.op9 == namecoll[i])
                            {
                                if (seatsleft[c] != "0")
                                {
                                    int se = int.Parse(seatsleft[c].ToString());
                                    se--;
                                    seatsleft[c] = se.ToString();
                                    allot[i] = obj.op9;
                                    break;
                                }

                            }
                            else
                            {
                                c++;
                            }
                        }

                    }
                }
                c = 0;
                for (int i = 0; i < count; i++)
                {
                    if (allot[i] != null)
                        break;
                    else
                    {
                        obj = JsonConvert.DeserializeObject<collegeSelected>(selected[i].ToString());

                        while (c < 10)
                        {
                            c++;
                            if (obj.op10 == namecoll[i])
                            {
                                if (seatsleft[c] != "0")
                                {
                                    int se = int.Parse(seatsleft[c].ToString());
                                    se--;
                                    seatsleft[c] = se.ToString();
                                    allot[i] = obj.op10;
                                    break;
                                }

                            }
                            else
                            {
                                c++;
                            }
                        }

                    }
                }
            

        }
    }
}


                            
                  
                    