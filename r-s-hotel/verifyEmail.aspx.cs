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
            string name = Request.QueryString["n"];
            string email = Request.QueryString["e"];
            string password = Request.QueryString["p"];
            string cpassword = Request.QueryString["cp"];
            string dob = Request.QueryString["d"];
            string gender = Request.QueryString["g"];

            
            int random = Convert.ToInt32(Request.QueryString["rNo"]);
            int otp = Convert.ToInt32(TextBox1.Text);

            long mobile = Convert.ToInt64(Request.QueryString["m"]);

            if (random == otp)
            {
                Response.Write("<h1>Name is : " + name + "</h1><br /><br />");
                Response.Write("<h1>Email is : " + email + "</h1><br /><br />");
                Response.Write("<h1>Pass is : " + password + "</h1><br /><br />");
                Response.Write("<h1>cpass is : " + cpassword + "</h1><br /><br />");
                Response.Write("<h1>mobile is : " + mobile + "</h1><br /><br />");
                Response.Write("<h1>dob is : " + dob + "</h1><br /><br />");
                Response.Write("<h1>gender is : " + gender+ "</h1><br /><br />");
                Response.Write("<h1>otp is : " + otp + "</h1><br /><br />");
            }
            else
            {
                Response.Write("<h1>not done</h1><br/><br/>");
            }
        }
    }
}