using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace r_s_hotel
{
    public partial class verifyForgotPassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = Request.QueryString["e"];

            int random = Convert.ToInt32(Request.QueryString["rNo"]);
            int otp = Convert.ToInt32(TextBox1.Text);

            if (random == otp)
            {
                //string targetUrl = $"fpassword.aspx?e={email}&rNo={random}";
                Response.Redirect($"fpassword.aspx?e={email}");
            }
            else if (random != otp)
            {
                Response.Write("<h1>not done</h1><br/><br/>");
            }
            else
            {
                Response.Write("<h1>Email Already Register</h1><br/><br/>");
            }
        }
    }
}