using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace r_s_hotel
{
    public partial class verifyEmail : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
            int random = Convert.ToInt32(Request.QueryString["rNo"]);
            int otp = Convert.ToInt32(TextBox1.Text);

            string name = Request.QueryString["nm"];
            /*string email = Request.QueryString["em"];
            string password = Request.QueryString["pass"];
            string cpassword = Request.QueryString["cpass"];
            string mobile = Request.QueryString["mo"];
            string dob = Request.QueryString["dob"];
            string gender = Request.QueryString["g"];*/

            if (random == otp)
            {
                Response.Write("<h1>Name is : " + name + "</h1><br /><br />");
                /*Response.Write("<h1>Email is : " + email + "</h1><br /><br />");
                Response.Write("<h1>Password is : " + password + "</h1><br /><br />");
                Response.Write("<h1>Confirm Password is : " + cpassword + "</h1><br /><br />");
                Response.Write("<h1>Mobile is : " + mobile + "</h1><br /><br />");
                Response.Write("<h1>Date of Birth is : " + dob + "</h1><br /><br />");
                Response.Write("<h1>Gender is : " + gender + "</h1><br /><br />");*/
                Response.Write("<h1>otp is : " + otp + "</h1><br /><br />");
            }
            else
            {
                Response.Write("<h1>not done</h1><br/><br/>");
            }
        }
    }
}