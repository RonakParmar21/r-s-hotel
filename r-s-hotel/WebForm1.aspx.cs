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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        string userName, userEmail, userMobile, roomType, srequest, pay;
        int userId, totalP, roomQty, roomId, roomPrice;
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                con.Open();
                roomId = Convert.ToInt32(Request.QueryString["RoomId"]);
                //string roomType = "";
                string sqlQuery1 = "SELECT room_type FROM room WHERE room_id = @roomId";
                using (SqlCommand cmdSelect = new SqlCommand(sqlQuery1, con))
                {
                    // Add the 'adminEmail' parameter to your command
                    cmdSelect.Parameters.AddWithValue("@roomId", roomId);
                    object result = cmdSelect.ExecuteScalar();
                    if (result != null)
                    {
                        roomType = result.ToString();
                    }
                }

                string sqlQuery2 = "SELECT room_price FROM room WHERE room_id = @roomId1";
                using (SqlCommand cmdSelect = new SqlCommand(sqlQuery2, con))
                {
                    // Add the 'adminEmail' parameter to your command
                    cmdSelect.Parameters.AddWithValue("@roomId1", roomId);
                    object result1 = cmdSelect.ExecuteScalar();
                    if (result1 != null)
                    {
                        roomPrice = Convert.ToInt32(result1);
                    }
                }

                string sqlQuery = "SELECT * FROM [user] WHERE user_email = @userEmail";
                using (SqlCommand cmdSelect = new SqlCommand(sqlQuery, con))
                {
                    cmdSelect.Parameters.AddWithValue("@userEmail", Session["user"].ToString());
                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read()) // If at least one row is returned
                        {
                            // Now, you can access each column by its name or index
                            userName = reader["user_name"].ToString(); // Example for name
                            userEmail = reader["user_email"].ToString(); // Example for email
                            userMobile = reader["user_mobile"].ToString();
                            userId = Convert.ToInt32(reader["user_id"]);
                            // Continue for other columns as needed
                            name.Text = userName;
                            email.Text = userEmail;
                            mobile.Text = userMobile;
                            userI.Text = userId.ToString();
                            select1.SelectedValue = roomType;

                            TextBox1.Attributes["min"] = DateTime.Now.ToString("yyyy-MM-dd");

                            DateTime tomorrow = DateTime.Now.AddDays(1);
                            checkout.Attributes["min"] = tomorrow.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            Response.Write("<script>alert('record not found')</script>");
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