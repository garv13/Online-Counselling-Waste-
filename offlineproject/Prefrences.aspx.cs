using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace offlineproject
{
    public partial class Prefrences : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {


        }

        public void add(string p)
        {
            while (true)
            {
                if (Label1.Text.Equals(""))
                {
                    Label1.Text = "1." + p;
                    break;
                }
                else if (Label2.Text.Equals(""))
                {
                    Label2.Text = "2." + p;
                    break;

                }
                else if (Label3.Text.Equals(""))
                {
                    Label3.Text = "3." + p;
                    break;
                }
                else if (Label4.Text.Equals(""))
                {
                    Label4.Text = "4." + p;
                    break;
                }
                else if (Label5.Text.Equals(""))
                {
                    Label5.Text = "5." + p;
                    break;
                }
                else if (Label6.Text.Equals(""))
                {
                    Label6.Text = "6." + p;
                    break;
                }
                else if (Label7.Text.Equals(""))
                {
                    Label7.Text = "7." + p;
                    break;
                }
                else if (Label8.Text.Equals(""))
                {
                    Label8.Text = "8." + p;
                    break;
                }
                else if (Label9.Text.Equals(""))
                {
                    Label9.Text = "9." + p;
                    break;
                }
                else if (Label10.Text.Equals(""))
                {
                    Label10.Text = "10." + p;
                    break;
                }
                else
                {
                    SetFocus(Button2);
                    Label21.Visible = true;
                    break;
                }
            }
        }
        protected void button6(object sender, EventArgs e)
        {


            string s = Label11.Text + "-" + DropDownList1.SelectedItem.ToString();
            add(s);
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
            DropDownList4.ClearSelection();
            DropDownList5.ClearSelection();
            DropDownList6.ClearSelection();
            DropDownList7.ClearSelection();
            DropDownList8.ClearSelection();
            DropDownList9.ClearSelection();
            DropDownList10.ClearSelection();
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            string s2 = Label12.Text + "-" + DropDownList2.SelectedItem.ToString();
            add(s2);
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
            DropDownList4.ClearSelection();
            DropDownList5.ClearSelection();
            DropDownList6.ClearSelection();
            DropDownList7.ClearSelection();
            DropDownList8.ClearSelection();
            DropDownList9.ClearSelection();
            DropDownList10.ClearSelection();
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            string s3 = Label13.Text + "-" + DropDownList3.SelectedItem.ToString();
            add(s3);
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
            DropDownList4.ClearSelection();
            DropDownList5.ClearSelection();
            DropDownList6.ClearSelection();
            DropDownList7.ClearSelection();
            DropDownList8.ClearSelection();
            DropDownList9.ClearSelection();
            DropDownList10.ClearSelection();
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            string s4 = Label14.Text + "-" + DropDownList4.SelectedItem.ToString();
            add(s4);
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
            DropDownList4.ClearSelection();
            DropDownList5.ClearSelection();
            DropDownList6.ClearSelection();
            DropDownList7.ClearSelection();
            DropDownList8.ClearSelection();
            DropDownList9.ClearSelection();
            DropDownList10.ClearSelection();
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            string s5 = Label15.Text + "-" + DropDownList5.SelectedItem.ToString();
            add(s5);
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
            DropDownList4.ClearSelection();
            DropDownList5.ClearSelection();
            DropDownList6.ClearSelection();
            DropDownList7.ClearSelection();
            DropDownList8.ClearSelection();
            DropDownList9.ClearSelection();
            DropDownList10.ClearSelection();
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            string s6 = Label16.Text + "-" + DropDownList6.SelectedItem.ToString();
            add(s6);
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
            DropDownList4.ClearSelection();
            DropDownList5.ClearSelection();
            DropDownList6.ClearSelection();
            DropDownList7.ClearSelection();
            DropDownList8.ClearSelection();
            DropDownList9.ClearSelection();
            DropDownList10.ClearSelection();
        }
        protected void Button14_Click(object sender, EventArgs e)
        {
            string s10 = Label20.Text + "-" + DropDownList10.SelectedItem.ToString();
            add(s10);
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
            DropDownList4.ClearSelection();
            DropDownList5.ClearSelection();
            DropDownList6.ClearSelection();
            DropDownList7.ClearSelection();
            DropDownList8.ClearSelection();
            DropDownList9.ClearSelection();
            DropDownList10.ClearSelection();
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            string s7 = Label17.Text + "-" + DropDownList7.SelectedItem.ToString();
            add(s7);
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
            DropDownList4.ClearSelection();
            DropDownList5.ClearSelection();
            DropDownList6.ClearSelection();
            DropDownList7.ClearSelection();
            DropDownList8.ClearSelection();
            DropDownList9.ClearSelection();
            DropDownList10.ClearSelection();
        }
        protected void Button13_Click(object sender, EventArgs e)
        {
            string s8 = Label18.Text + "-" + DropDownList8.SelectedItem.ToString();
            add(s8);
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
            DropDownList4.ClearSelection();
            DropDownList5.ClearSelection();
            DropDownList6.ClearSelection();
            DropDownList7.ClearSelection();
            DropDownList8.ClearSelection();
            DropDownList9.ClearSelection();
            DropDownList10.ClearSelection();
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            string s9 = Label19.Text + "-" + DropDownList9.SelectedItem.ToString();
            add(s9);
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
            DropDownList4.ClearSelection();
            DropDownList5.ClearSelection();
            DropDownList6.ClearSelection();
            DropDownList7.ClearSelection();
            DropDownList8.ClearSelection();
            DropDownList9.ClearSelection();
            DropDownList10.ClearSelection();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            Label10.Text = "";

        }
        protected void Button3_Click(object sender, EventArgs e)
        {

        }
        protected void Button3_Click1(object sender, EventArgs e)
        {
            {
                ImageButton1.Visible = true;
                ImageButton2.Visible = true;
                ImageButton3.Visible = true;
                ImageButton4.Visible = true;
                ImageButton5.Visible = true;
                ImageButton6.Visible = true;
                ImageButton7.Visible = true;
                ImageButton8.Visible = true;
                ImageButton9.Visible = true;
                ImageButton10.Visible = true;
            }
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Label1.Text = "";

        }
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "";
        }
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Label3.Text = "";
        }
        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Label4.Text = "";
        }
        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Label5.Text = "";
        }
        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Label6.Text = "";
        }
        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Label7.Text = "";
        }
        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            Label8.Text = "";
        }
        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            Label9.Text = "";
        }
        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            Label10.Text = "";
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; i < 10; i++)
            {

                i = j - 1;
                Label lbl = new Label();
                Label lb = new Label();
                lbl.ID = "Label" + i;
                lb.ID = "Label" + j;
                if (lb.Text.Equals(lbl.Text))
                {
                    Response.Write("<script> alert('Same Values In Prefrence List')</script>"); Response.Write("<script>alert('Data Inserted')</script>");
                }
            }
        }
    }
}