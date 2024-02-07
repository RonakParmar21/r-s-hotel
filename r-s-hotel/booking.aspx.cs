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
    public partial class booking : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        string userName, userEmail, userMobile, roomType, srequest, pay, daysDiff;
        TimeSpan totalDuration;
        protected void tday_TextChanged(object sender, EventArgs e)
        {

        }

        int userId, roomId, roomPrice, tperson;
        protected void roomqty_TextChanged(object sender, EventArgs e)
        {
            int troom = Convert.ToInt32(roomqty.Text);
            string rts = roomTypeSelect.SelectedValue;
            roomId = Convert.ToInt32(Request.QueryString["RoomId"]);
            if (rts.Equals("acs"))
            {
                tperson = troom * 1;
                //Response.Write(tperson);
            }
            else if (rts.Equals("acd"))
            {
                tperson = troom * 2;
            }

            totalPerson.Text = tperson.ToString();
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                con.Open();
                roomId = Convert.ToInt32(Request.QueryString["RoomId"]);
                string sqlQuery1 = "SELECT room_type FROM room WHERE room_id = @roomId";
                using (SqlCommand cmdSelect = new SqlCommand(sqlQuery1, con))
                {
                    cmdSelect.Parameters.AddWithValue("@roomId", roomId);
                    object result = cmdSelect.ExecuteScalar();
                    if (result != null)
                    {
                        roomType = result.ToString();
                        roomTypeSelect.SelectedValue = roomType;
                        roomTypeSelect.Enabled = false;
                        //roomTypeSelect.Text = roomType.ToString();
                    }
                }

                string sqlQuery2 = "SELECT room_price FROM room WHERE room_id = @roomId";
                using (SqlCommand cmdSelect = new SqlCommand(sqlQuery2, con))
                { 
                    cmdSelect.Parameters.AddWithValue("@roomId", roomId);
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

        //protected void roomqty_TextChanged(object sender, EventArgs e)
        //{
            /*int troom = Convert.ToInt32(roomqty.Text);

            if (roomType.Equals("acs"))
            {
                tperson = troom * 1;
                //Response.Write(tperson);
            }
            else if (roomType.Equals("dac"))
            {
                tperson = troom * 2;
            }
            totalPerson.Text = tperson.ToString();*/
          //  UpdateTotalPersons();
        //}

        /*private void UpdateTotalPersons()
        {
            int troom;
            if (int.TryParse(roomqty.Text, out troom))
            {
                int tperson = 0;
                //string roomType = roomType.SelectedValue;

                if (roomType.Equals("acs"))
                {
                    tperson = troom;
                }
                else if (roomType.Equals("dac"))
                {
                    tperson = troom * 2;
                }

                totalPerson.Text = tperson.ToString();
            }
            else
            {
                totalPerson.Text = "Invalid input";
            }
        }
        */
        protected void Button1_Click(object sender, EventArgs e)
        {
            //int daysDiff = Convert.ToInt32(TextBoxDays.Text);
            daysDiff = TextBoxDays.Text.ToString();
            string cin = TextBox1.Text;
            string cout = checkout.Text;
            //string troom = totalPerson.Text;
            int troom = Convert.ToInt32(roomqty.Text);
            string rts = roomTypeSelect.SelectedValue;
            roomId = Convert.ToInt32(Request.QueryString["RoomId"]);
            if (rts.Equals("acs"))
            {
                tperson = troom * 1;
                //Response.Write(tperson);
            }
            else if(rts.Equals("acd"))
            {
                tperson = troom * 2;
            }
           
            totalPerson.Text = tperson.ToString();

            if (!string.IsNullOrWhiteSpace(TextBox1.Text) && !string.IsNullOrWhiteSpace(checkout.Text))
            {
                DateTime checkInDate;
                DateTime checkOutDate;

                // Try to parse the dates from the text boxes
                bool isCheckInDateValid = DateTime.TryParse(TextBox1.Text, out checkInDate);
                bool isCheckOutDateValid = DateTime.TryParse(checkout.Text, out checkOutDate);

                // Proceed if both dates are valid
                if (isCheckInDateValid && isCheckOutDateValid)
                {
                    // Ensure the check-out date is after the check-in date
                    if (checkOutDate > checkInDate)
                    {
                        totalDuration = checkOutDate.Subtract(checkInDate);

                        // Display the total number of days
                        tday.Text = $"{totalDuration.Days}";
                    }
                    else
                    {
                        lblTotalDays.Text = "Check-out date must be after the check-in date.";
                    }
                }
                else
                {
                    lblTotalDays.Text = "Please enter valid dates.";
                }
            }
            else
            {
                lblTotalDays.Text = "Please enter both check-in and check-out dates.";
            }
        


        Response.Redirect($"bookConfirm.aspx?totalDays={tday.Text}&userId={userId}&userName={userName}&userEmail={userEmail}&userMobile={userMobile}&roomId={roomId}&roomType={roomType}&checkIn={cin}&checkOut={cout}&tp={tperson}&roomqt={Convert.ToInt32(roomqty.Text)}&pm={payment.SelectedValue}&re={request.Text}&rp={roomPrice}");
        }

    }
}