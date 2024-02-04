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
    public partial class booking : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        string userName, userEmail, userMobile;
        int userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if(Session["user"] != null)
            {
                int roomId = Convert.ToInt32(Request.QueryString["RoomId"]);
                string sqlQuery = "SELECT * FROM user WHERE user_email = @userEmail";
                using (SqlCommand cmdSelect = new SqlCommand(sqlQuery, con))
                {
                    cmdSelect.Parameters.AddWithValue("@userEmail", Session["user"]);
                    object result = cmdSelect.ExecuteScalar();
                    if (result != null)
                    {
                        
                    }
                }
            }*/
            if (Session["user"] != null)
            {
                int roomId = Convert.ToInt32(Request.QueryString["RoomId"]);

                con.Open();

                string sqlQuery = "SELECT * FROM [user] WHERE user_email = @userEmail";

                using (SqlCommand cmdSelect = new SqlCommand(sqlQuery, con))
                {
                    // Add the email parameter from session
                    cmdSelect.Parameters.AddWithValue("@userEmail", Session["user"].ToString());

                    // Use ExecuteReader for fetching multiple columns
                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read()) // If at least one row is returned
                        {
                            // Now, you can access each column by its name or index
                            string userName = reader["user_name"].ToString(); // Example for name
                            string userEmail = reader["user_email"].ToString(); // Example for email
                                                                                // Continue for other columns as needed
                            name.Text = userName;
                            email.Text = userEmail;
                            // Use these details as needed in your application
                            // For example, display them on the page or further process them
                        }
                        else
                        {
                            Response.Write("<script>alert('record not found')</script>");
                            // Handle the case where no user is found
                            // This could involve redirecting the user, showing a message, etc.
                        }
                    }
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}