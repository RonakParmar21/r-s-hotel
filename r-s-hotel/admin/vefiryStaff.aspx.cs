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
    public partial class vefiryStaff : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Request.QueryString["n"];
            string email = Request.QueryString["e"];
            long mobi = Convert.ToInt64(Request.QueryString["m"]);
            string dob = Request.QueryString["d"];
            string gender = Request.QueryString["g"];
            string possition = Request.QueryString["pos"];
            string sallary = Request.QueryString["sl"];
            string address = Request.QueryString["ad"];
            int random = Convert.ToInt32(Request.QueryString["rNo"]);
            string jdate = Request.QueryString["jdate"];
            int adid=-1;

            /*SqlCommand cmdSelect = new SqlCommand("SELECT admin_id FROM admin WHERE admin_email='"+Session["admin"]+"'");
            adid = (int)cmdSelect.ExecuteScalar();*/

            string sqlQuery = "SELECT admin_id FROM admin WHERE admin_email = @adminEmail";
            using (SqlCommand cmdSelect = new SqlCommand(sqlQuery, con))
            {
                // Add the 'adminEmail' parameter to your command
                cmdSelect.Parameters.AddWithValue("@adminEmail", Session["admin"]);

                // Execute the command and attempt to convert the result to an integer
                object result = cmdSelect.ExecuteScalar();

                if (result != null)
                {
                    adid = Convert.ToInt32(result);
                }
            }
            int otp = Convert.ToInt32(TextBox1.Text);
            string mobile = mobi.ToString();
            string adminid = adid.ToString();

            //Response.Write("<h1>Id is '"+adid+"' </h1><br/>");
            Response.Write("<h1>Name is '"+name+"'</h1><br/>");
                Response.Write("<h1>Email is '"+email+"'</h1><br/>");
                Response.Write("<h1>Mobile is  '"+mobi+"'</h1><br/>");
                Response.Write("<h1>Dob is  '"+dob+"'</h1><br/>");
                Response.Write("<h1>gender is  '"+gender+"'</h1><br/>");
                Response.Write("<h1>possition is '"+possition+"' </h1><br/>");
                Response.Write("<h1>sallary is '"+sallary+"' </h1><br/>");
                Response.Write("<h1>address is '"+address+"'</h1><br/>");
                Response.Write("<h1>admin id is '"+adid+"' </h1><br/>");
                Response.Write("<h1>staff otp is  '"+random+"'</h1><br/>");
                Response.Write("<h1>join date is '"+jdate+"' </h1><br/>");
                Response.Write("<h1>random no  '"+otp+"'</h1><br/>");

            

           

            if (random == otp)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO staff (staff_name, staff_email, staff_mobile, staff_dob, staff_gender, staff_possition, staff_sallary, staff_address, admin_id, staff_otp, staff_join_date) VALUES (@Name, @Email, @Mobile, @Dob, @Gender, @Possition, @Sallary, @Address, @AdminId, @Otp, @JoinDate)", con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mobile", mobile);

                cmd.Parameters.AddWithValue("@Dob", dob);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Possition", possition);
                cmd.Parameters.AddWithValue("@Sallary", sallary);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@AdminId", adid);
                cmd.Parameters.AddWithValue("@Otp", otp);
                cmd.Parameters.AddWithValue("@JoinDate", jdate);
                cmd.ExecuteNonQuery();


                //try
                //{
                //con.Open();
                //cmd.ExecuteNonQuery();
                //}
                /*catch (SqlException se)
                {
                */    // Handle the exception
                      //Console.WriteLine(se.Message);
                //Response.Write(se.Message);
                /*}
                finally
                {
                    con.Close();
                }*/

                Response.Write("<script>alert('Registration Succsesfully..')</script>");
                Response.Redirect("viewStaffDetails.aspx");
            }
            else
            {
                Response.Write("<h1>not done</h1><br/><br/>");
            }

        }
    }
}