using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace r_s_hotel
{
    public partial class fpassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string em = Request.QueryString["e"];
            //int random = Convert.ToInt32(Request.QueryString["rNo"]);
            string pass = password.Text;
            string cpass = cpassword.Text;

            if(pass == cpass)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update [user] set user_password='"+pass+"' where user_email='"+em+"'", con);
                cmd.ExecuteNonQuery();
                Response.Redirect("login.aspx");
               // Response.Write(em  + "\n\n" + pass + "\n\n" + cpass);
            }
        }
    }
}