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
        //int userId;
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
                con.Open();
                int roomId = Convert.ToInt32(Request.QueryString["RoomId"]);
                string roomType = "";
                string sqlQuery1 = "SELECT room_type FROM room WHERE room_id = @roomId";
                using (SqlCommand cmdSelect = new SqlCommand(sqlQuery1, con))
                {
                    // Add the 'adminEmail' parameter to your command
                    cmdSelect.Parameters.AddWithValue("@roomId", roomId);

                    // Execute the command and attempt to convert the result to an integer
                    object result = cmdSelect.ExecuteScalar();

                    if (result != null)
                    {
                        roomType = result.ToString();
                    }
                }

                

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
                            userName = reader["user_name"].ToString(); // Example for name
                            userEmail = reader["user_email"].ToString(); // Example for email
                            userMobile = reader["user_mobile"].ToString();
                                                                                // Continue for other columns as needed
                            name.Text = userName;
                            email.Text = userEmail;
                            mobile.Text = userMobile;
                            select1.SelectedValue = roomType;
                            TextBox1.Attributes["min"] = DateTime.Now.ToString("yyyy-MM-dd");

                            DateTime tomorrow = DateTime.Now.AddDays(1);
                            checkout.Attributes["min"] = tomorrow.ToString("yyyy-MM-dd");



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