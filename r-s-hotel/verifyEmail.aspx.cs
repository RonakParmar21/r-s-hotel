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
    public partial class verifyEmail : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BPUI4AI;Initial Catalog=rshotel;Integrated Security=True");
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
            string name = Request.QueryString["n"];
            string email = Request.QueryString["e"];
            string password = Request.QueryString["p"];
            string cpassword = Request.QueryString["cp"];
            string dob = Request.QueryString["d"];
            string gender = Request.QueryString["g"];

            
            int random = Convert.ToInt32(Request.QueryString["rNo"]);
            int otp = Convert.ToInt32(TextBox1.Text);

            long mobi = Convert.ToInt64(Request.QueryString["m"]);

            string mobile = mobi.ToString();

            if (random == otp)
            {
                if(password == cpassword)
                {
                    //SqlCommand cmd = new SqlCommand("insert into user(user_name,user_email,user_password,user_mobile,user_dob,user_gender,user_otp) values('"+name+"','"+email+"','"+password+"','"+mobile+"','"+dob+"','"+gender+"','"+otp+"')",con);
                    /*
                                        SqlCommand cmd = new SqlCommand("insert into user(user_name, user_email, user_password, user_mobile, user_dob, user_gender, user_otp) values('" + name + "','" + email + "','" + password + "','" + mobile + "','" + dob + "','" + gender + "','" + otp + "')", con);
                                        cmd.ExecuteNonQuery();
                    */

                    SqlCommand cmd = new SqlCommand("INSERT INTO [user] (user_name, user_email, user_password, user_mobile, user_dob, user_gender, user_otp) VALUES (@Name, @Email, @Password, @Mobile, @Dob, @Gender, @Otp)", con);

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Mobile", mobile);
                    cmd.Parameters.AddWithValue("@Dob", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Otp", otp);

                    try
                    {
                        //con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException se)
                    {
                        // Handle the exception
                        Console.WriteLine(se.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                    Response.Write("<script>alert('Registration Succsesfully..')</script>");
                }
                else
                {
                    Response.Write("<script>alert('both password not matched...')</script>");
                }
                
                /*Response.Write("<h1>Name is : " + name + "</h1><br /><br />");
                Response.Write("<h1>Email is : " + email + "</h1><br /><br />");
                Response.Write("<h1>Pass is : " + password + "</h1><br /><br />");
                Response.Write("<h1>cpass is : " + cpassword + "</h1><br /><br />");
                Response.Write("<h1>mobile is : " + mobile + "</h1><br /><br />");
                Response.Write("<h1>dob is : " + dob + "</h1><br /><br />");
                Response.Write("<h1>gender is : " + gender+ "</h1><br /><br />");
                Response.Write("<h1>otp is : " + otp + "</h1><br /><br />");
                */
            }
            else
            {
                Response.Write("<h1>not done</h1><br/><br/>");
            }
        }
    }
}