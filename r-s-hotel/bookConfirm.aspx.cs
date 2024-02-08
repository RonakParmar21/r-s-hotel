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
    public partial class bookConfirm : System.Web.UI.Page
    {
        //    int tday, roomqty, uid, rid, roomPrice, totalPrice;
        //  string request, payment, unm, uem, umo, cin, cout, rtype, tperson;

        int tday, roomqty, uid, rid, roomPrice, totalPrice;
        string request, payment, unm, uem, umo, cin, cout, rtype, tperson;
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
        
                con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");


                con.Open();
                //int tday = Convert.ToInt32(Request.QueryString["totalDays"]);
                //string tday = Request.QueryString["totalDays"];
                tday = Convert.ToInt32(Request.QueryString["totalDays"]);
                roomqty = Convert.ToInt32(Request.QueryString["roomqt"]);
                request = Request.QueryString["re"];
                payment = Request.QueryString["pm"];
                uid = Convert.ToInt32(Request.QueryString["userId"]);
                unm = Request.QueryString["userName"];
                uem = Request.QueryString["userEmail"];
                umo = Request.QueryString["userMobile"];
                cin = Request.QueryString["checkIn"];
                cout = Request.QueryString["checkOut"];

                rid = Convert.ToInt32(Request.QueryString["roomId"]);
                roomPrice = Convert.ToInt32(Request.QueryString["rp"]);
                rtype = Request.QueryString["roomType"];
                tperson = Request.QueryString["tp"];
                totalPrice = roomPrice * tday * roomqty;

                DataTable dt = new DataTable();
                dt.Columns.Add("Parameter", typeof(string));
                dt.Columns.Add("Value", typeof(string));

                // Continue adding rows for each parameter
                dt.Rows.Add("User Id", uid);
                dt.Rows.Add("User Name", unm);
                dt.Rows.Add("User Email", uem);
                dt.Rows.Add("User Mobile", umo);
                //dt.Rows.Add("Room Id", rid);
                dt.Rows.Add("Room Type", rtype);
                dt.Rows.Add("Room Quantity", roomqty);
                dt.Rows.Add("Total Person", tperson);
                dt.Rows.Add("CheckIN Date", cin);
                dt.Rows.Add("Checkout Date", cout);
                dt.Rows.Add("Total Days", tday);
                dt.Rows.Add("Room Price/Night", roomPrice);
                dt.Rows.Add("Total Price", totalPrice);
                dt.Rows.Add("Payment Status", payment);
                dt.Rows.Add("Special Request", request);



                GridView1.DataSource = dt;
                GridView1.DataBind();





                /*Response.Write("<h1>User id '"+uid+"'</h1>");
                Response.Write("<h1>User name '" + unm + "'</h1>");
                Response.Write("<h1>User email '" + uem + "'</h1>");
                Response.Write("<h1>User mobile '" + umo + "'</h1>");
                Response.Write("<h1>Room id '" + rid + "'</h1>");
                Response.Write("<h1>Room Type '" + rtype + "'</h1>");
                Response.Write("<h1>Total Day '" + tday + "'</h1>");
                Response.Write("<h1>Checkin date '" + cin + "'</h1>");
                Response.Write("<h1>Checkout date '" + cout + "'</h1>");
                Response.Write("<h1>Room Price '" + roomPrice + "'</h1>");
                Response.Write("<h1>Total Room Price '" + totalPrice + "'</h1>");
                Response.Write("<h1>Total Person = '"+tperson+"'</h1>");
                Response.Write("<h1>Room Qty = '" + roomqty + "'</h1>");
                Response.Write("<h1>Payment Method = '" + payment + "'</h1>");
                Response.Write("<h1>Request = '" + request + "'</h1>");
                */
            }
            
        


        /*private DataTable CreateDataTable()
        {
            // Create a new DataTable.
            DataTable dt = new DataTable();

            // Define columns in the DataTable.
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));

            // Assuming you have some variables with data.
            int id = 1;
            string name = "John Doe";
            string email = "john.doe@example.com";

            // Add a row to the DataTable with these variables.
            dt.Rows.Add(id, name, email);

            // If you have more data, you can add more rows here.
            // For example, another set of variables or data from a loop.

            return dt;
        }*/

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*SqlCommand cmd2 = new SqlCommand("insert into book(user_id,room_id,book_checkin_date,book_checkout_date,book_totalday,book_totalprice,book_totalroom,book_roomtype,book_paymentstatus,book_total_person, book_status, book_special_request) values('" + uid + "','" + rid + "','" + cin + "','" + cout + "','" + tday + "','" + totalPrice + "','" + roomqty + "','" + rtype + "','" + payment + "', '"+tperson+"','booked','"+request+"')", con);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("UPDATE room SET room_total='"+roomqty+"' WHERE room_id='"+rid+"'",con);
            cmd3.ExecuteNonQuery();*/
            string queryInsertBook = @"INSERT INTO book(user_id, room_id, book_checkin_date, book_checkout_date, book_totalday, book_totalprice, book_totalroom, book_roomtype, book_paymentstatus, book_total_person, book_status, book_special_request) 
VALUES(@uid, @rid, @cin, @cout, @tday, @totalPrice, @roomqty, @rtype, @payment, @tperson, 'booked', @request)";

            using (SqlCommand cmd2 = new SqlCommand(queryInsertBook, con))
            {
                cmd2.Parameters.AddWithValue("@uid", uid);
                cmd2.Parameters.AddWithValue("@rid", rid);
                cmd2.Parameters.AddWithValue("@cin", cin);
                cmd2.Parameters.AddWithValue("@cout", cout);
                cmd2.Parameters.AddWithValue("@tday", tday);
                cmd2.Parameters.AddWithValue("@totalPrice", totalPrice);
                cmd2.Parameters.AddWithValue("@roomqty", roomqty);
                cmd2.Parameters.AddWithValue("@rtype", rtype);
                cmd2.Parameters.AddWithValue("@payment", payment);
                cmd2.Parameters.AddWithValue("@tperson", tperson);
                cmd2.Parameters.AddWithValue("@request", request);

                // Execute the command
                //con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            string queryUpdateRoom = "UPDATE room SET room_total = room_total-@roomqty WHERE room_id = @rid";

            using (SqlCommand cmd3 = new SqlCommand(queryUpdateRoom, con))
            {
                cmd3.Parameters.AddWithValue("@roomqty", roomqty);
                cmd3.Parameters.AddWithValue("@rid", rid);

                // Execute the command
                con.Open();
                cmd3.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}