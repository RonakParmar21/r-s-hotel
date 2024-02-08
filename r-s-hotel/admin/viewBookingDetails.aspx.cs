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
                int bookId = int.Parse(args[0]);
                int roomId = int.Parse(args[1]); 
                int roomTotal = int.Parse(args[2]);

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

                    SqlCommand cmd = new SqlCommand("UPDATE room SET room_total = @TotalRoom WHERE room_id = @Id", con);
                    cmd.Parameters.AddWithValue("@TotalRoom", t);
                    cmd.Parameters.AddWithValue("@Id", roomId);

                    //cmd.ExecuteNonQuery();
       
                    cmd.ExecuteNonQuery();


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