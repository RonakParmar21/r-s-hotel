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
    public partial class addReview : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        int roomId, userId;
        string name, email;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                con.Open();
                roomId = Convert.ToInt32(Request.QueryString["RoomId"]);

                string sqlQuery = "SELECT * FROM [user] WHERE user_email = @userEmail";
                using (SqlCommand cmdSelect = new SqlCommand(sqlQuery, con))
                {
                    cmdSelect.Parameters.AddWithValue("@userEmail", Session["user"].ToString());
                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read()) // If at least one row is returned
                        {
                            name= reader["user_name"].ToString(); 
                            email = reader["user_email"].ToString();
                            userId = Convert.ToInt32(reader["user_id"]);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string msg = message.Text;
            roomId = Convert.ToInt32(Request.QueryString["RoomId"]);
            string query = "SELECT * FROM tempbook WHERE room_id = @RoomId AND user_id = @UserId";

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomId", roomId);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();
                    //int result = (int)cmd.ExecuteScalar();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Match found
                        SqlCommand cmd1 = new SqlCommand("insert into review(user_id, user_name, user_email, room_id, msg) values('"+userId+"','"+name+"','"+email+"','"+roomId+"','"+message.Text+"')", conn);
                        cmd1.ExecuteNonQuery();
                        Response.Write("<script>alert('Review Add Successfully...')</script>");
                    }
                    else
                    {
                        // No match found
                        Response.Write("<script>alert('You are not able to add review...')</script>");
                    }
                }
            }
            //Response.Write("Name is : '"+name+"', email is : '"+email+"', Room id is : '"+roomId+"', message is : '"+msg+"'");
        }
    }
}