using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        protected void Button1_Click(object sender, EventArgs e)
        {

            bool isCaptchaValid = false;
            if (Session["CaptchaText"] != null && Session["CaptchaText"].ToString() == txtCaptchaText.Text)
            {
                isCaptchaValid = true;
            }

            if (isCaptchaValid)
            {
                lblMessage.Text = "Captcha Validation Success";
                lblMessage.ForeColor = Color.Green;
                //string s = ConfigurationManager.ConnectionStrings["connect"].ConnectionString; //using database through web.config file
                //SqlConnection con = new SqlConnection(s);
                // SqlCommand cmd = new SqlCommand("insert into UserDetail values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + RadioButtonList1.SelectedItem.ToString() + "','" + TextBox6.Text + "','" + DropDownList1.SelectedItem.ToString() + "','" + TextBox7.Text + "','" + TextBox8.Text + "')", con);
                // con.Open();
                // cmd.ExecuteNonQuery();
                // con.Close();
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
                TextBox1.Focus();
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