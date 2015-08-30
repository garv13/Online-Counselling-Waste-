using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace offlineproject
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                TextBox8.Focus();
            }

        }
        protected void Button12_Click(object sender, EventArgs e)
        {

            bool isCaptchaValid = false;
            if (Session["CaptchaText"] != null && Session["CaptchaText"].ToString() == txtCaptchaText.Text)
            {
                isCaptchaValid = true;
            }

            if (isCaptchaValid)
            {
                Random random = new Random();
                string ra = Convert.ToString(random.Next(10, 10000));
                lblMessage.Text = "Captcha Validation Success";
                lblMessage.ForeColor = Color.Green;
                string s = ConfigurationManager.ConnectionStrings["connection"].ConnectionString; //using database through web.config file
                SqlConnection con = new SqlConnection(s);
                SqlCommand cmd = new SqlCommand("insert into student values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox8.Text + "','" + TextBox4.Text + "','" + RadioButtonList1.SelectedItem.ToString() + "','" + TextBox6.Text + "','" + DropDownList2.SelectedItem.ToString() + "','" + DropDownList1.SelectedItem.ToString() + "','" + TextBox7.Text + "', '" + ra + "' , 'lol' , '1' , '1')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('User Successfully Registered')</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                txtCaptchaText.Text = "";
                RadioButtonList1.ClearSelection();
                DropDownList1.ClearSelection();
                Response.Redirect("Home.aspx");
                //TextBox1.Focus();
            }
            else
            {
                lblMessage.Text = "Captcha Validation Failed";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Focus();
            }



        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
                TextBox8.Focus();
            }
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox8.Text = Calendar1.SelectedDate.ToString("d");
            Calendar1.Visible = false;
            TextBox8.Focus();
        }
    }
}