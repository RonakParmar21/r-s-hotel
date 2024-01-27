using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace r_s_restaurent
{
    public partial class contact : System.Web.UI.Page
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
         
            String nm = name.Text;
            String em = email.Text;
            String sub = subject.Text;
            String msg = message.Text;
            String mo = mobile.Text;
            SqlCommand cmd = new SqlCommand("INSERT INTO [contact] (contact_name, contact_email, contact_mobile, contact_subject, contact_description) VALUES (@Name, @Email, @Mobile, @Subject, @Message)", con);

            cmd.Parameters.AddWithValue("@Name", nm);
            cmd.Parameters.AddWithValue("@Email", em);
            cmd.Parameters.AddWithValue("@Mobile", mo);
            cmd.Parameters.AddWithValue("@Subject", sub);
            cmd.Parameters.AddWithValue("@Message", msg);

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

            Response.Write("<script>alert('Message Sent Succsesfully..')</script>");
            Response.Redirect("default.aspx");
         
        }
    }
}