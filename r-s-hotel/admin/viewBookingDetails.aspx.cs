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
    public partial class viewBookingDetails : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int bookId, roomId, roomTotal;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["admin"] != null)
            {
                con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                displayData();
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
        public void displayData()
        {
            cmd = new SqlCommand("select * from book", con);

            dr = cmd.ExecuteReader();
            GridView.DataSource = dr;
            GridView.DataBind();
            dr.Close();

        }
        protected void btnUpdate_Command(object sender, CommandEventArgs e)
        {
            string[] args = e.CommandArgument.ToString().Split('|');

            if (args.Length == 3)
            {
                // Safely try to parse the arguments to their respective types
                bookId = int.Parse(args[0]);
                roomId = int.Parse(args[1]); 
                roomTotal = int.Parse(args[2]);

                // Now you have the separate parameters and can use them as needed
                // For example, calling a method that needs these parameters
                updateRecord(bookId, roomId, roomTotal);
            }
        }

        public void updateRecord(int bookId, int roomId, int roomTotal)
        {
            /* SqlCommand cmd = new SqlCommand("UPDATE room SET room_total = room_total+'" + TotalRoom + "' WHERE room_id = '" + Id + "'", con);
             cmd.ExecuteNonQuery();*/

            string sqlQuery2 = "SELECT room_total FROM room WHERE room_id = @roomId";
            using (SqlCommand cmdSelect = new SqlCommand(sqlQuery2, con))
            {
                cmdSelect.Parameters.AddWithValue("@roomId", roomId);
                object result1 = cmdSelect.ExecuteScalar();
                if (result1 != null)
                {
                    //string roomQ = Convert.ToInt32(result1);
                    string roomQ = result1.ToString();

                    int rq = int.Parse(roomQ);
                    int t = roomTotal+rq;

                    SqlCommand cmd = new SqlCommand("SELECT book_id, user_id, room_id, book_checkin_date, book_checkout_date, book_totalday, book_totalprice, book_totalroom, book_roomtype, book_paymentstatus, book_total_person, book_status, book_special_request, book_time FROM book WHERE room_id = @Id AND book_id=@bId", con);
                    cmd.Parameters.AddWithValue("@Id", roomId); 
                    cmd.Parameters.AddWithValue("@bId", bookId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    int book_id = Convert.ToInt32(reader["book_id"]);
                    int user_id = Convert.ToInt32(reader["user_id"]);
                    int room_id = Convert.ToInt32(reader["room_id"]);
                    string checkin = reader.IsDBNull(reader.GetOrdinal("book_checkin_date")) ? string.Empty : reader.GetDateTime(reader.GetOrdinal("book_checkin_date")).ToString("yyyy-MM-dd");
                    string checkout = reader.IsDBNull(reader.GetOrdinal("book_checkout_date")) ? string.Empty : reader.GetDateTime(reader.GetOrdinal("book_checkout_date")).ToString("yyyy-MM-dd");

                    //string checkin = reader["book_checkin_date"].ToString();
                    //string checkout = reader["book_checkout_date"].ToString();
                    int totalday = Convert.ToInt32(reader["book_totalday"]);
                    int tprice = Convert.ToInt32(reader["book_totalprice"]);
                    int troom = Convert.ToInt32(reader["book_totalroom"]);
                    string roomtype = reader["book_roomtype"].ToString();
                    string paymentstatus = reader["book_paymentstatus"].ToString();
                    string tperson = reader["book_total_person"].ToString();
                    string status = reader["book_status"].ToString();
                    string specialreq = reader["book_special_request"].ToString();

                    SqlCommand cmd1 = new SqlCommand("insert into tempbook(book_id, user_id, room_id, checkin, checkout, totalday, totalprice, totalroom, roomtype, paymentstatus, totalperson, status, specialrequest) values('" + book_id + "','" + user_id + "','" + room_id+ "','" + checkin+ "','" + checkout+ "','" + totalday+ "','" + tprice+ "','" + troom +"','" + roomtype + "','"+paymentstatus+"','"+tperson+"','"+status+"','"+specialreq+"')", con);
                    reader.Close();
                    cmd1.ExecuteNonQuery();

                    //SqlCommand cmd2 = new SqlCommand("DELETE FROM room WHERE room_id = @Id", con);
                    SqlCommand cmd2 = new SqlCommand("UPDATE room SET room_total = @TotalRoom WHERE room_id = @Id", con);
                    cmd2.Parameters.AddWithValue("@TotalRoom", t);
                    cmd2.Parameters.AddWithValue("@Id", roomId);



                    //cmd.ExecuteNonQuery();
       
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("DELETE FROM book WHERE book_id = @Id", con);
                    cmd3.Parameters.AddWithValue("@Id", bookId);
                    cmd3.ExecuteNonQuery();

                    Response.Redirect("viewBookingDetails.aspx");
                }
            }



            /*SqlCommand cmd = new SqlCommand("UPDATE room SET room_total = room_total + @TotalRoom WHERE room_id = @Id", con);

            cmd.Parameters.AddWithValue("@TotalRoom", TotalRoom);
            cmd.Parameters.AddWithValue("@Id", Id);

            cmd.ExecuteNonQuery();*/
        }

        protected void btnDelete_Command(object sender, CommandEventArgs e)
        {

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            
        }

        /*public void deleteRecord(int Id, int TotalRoom)
{
   SqlCommand cmd = new SqlCommand("UPDATE room SET room_total = room_total+'"+ TotalRoom+"' WHERE room_id = '"+Id+"'", con);
   cmd.ExecuteNonQuery();

   *//*cmd = new SqlCommand("delete from room where room_id = '" + id + "'", con);
   cmd.ExecuteNonQuery();
   displayData();
   Response.Write("<script>alert('Record Deleted...')</script>");*//*
}*/
    }
}