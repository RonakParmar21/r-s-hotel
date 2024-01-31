using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace r_s_hotel.admin
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string em = email.Text;
            string pass = password.Text;

            //SqlCommand cmd = new SqlCommand("SELECT * FROM user WHERE user_email='"+em+"' AND user_password='"+pass+"'",con);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [admin] WHERE admin_email='" + em + "' AND admin_password='" + pass + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    string email = dr["admin_email"].ToString();
                    string password = dr["admin_password"].ToString();

                    if (email.Equals(em) && password.Equals(pass))
                    {
                        Session["admin"] = em;
                        Response.Write("<script>alert('Login Success...')</script>");
                        Response.Redirect("default.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('user id and password not matched...')</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('user id and password not matched...')</script>");
            }
        }
    }
}