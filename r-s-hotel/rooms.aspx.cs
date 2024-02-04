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
    public partial class rooms : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();


            SqlCommand cmd = new SqlCommand("select * from room order by room_id desc", con);
            SqlDataReader dr = cmd.ExecuteReader();


            dlRooms.DataSource = dr;
            dlRooms.DataBind();
        }

        protected void dlRooms_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "ViewDetail")
            {
                int roomId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"roomDetails.aspx?id={roomId}");
            }
            else if (e.CommandName == "BookNow")
            {
                int roomId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"bookRoom.aspx?RoomId={roomId}");
            }
        }



        /*protected void LinkButton_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "ViewDetail")
            {
                // Retrieve the ID (room_id) from the CommandArgument
                string roomId = (string)e.CommandArgument;

                // Now you can use roomId for further processing, like redirecting
                Response.Redirect($"RoomDetails.aspx?RoomId={roomId}");
            }
        }
*/



        /*
        protected void dlRooms_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "SelectRoom")
            {
                string roomId = e.CommandArgument.ToString();
                // Handle room selection logic, such as displaying more details
            }
            else if (e.CommandName == "ViewDetails")
            {
                string roomId = e.CommandArgument.ToString();
                // Redirect to room details page or display details logic
            }
            else if (e.CommandName == "BookNow")
            {
                string roomId = e.CommandArgument.ToString();
                // Redirect to booking page or handle booking logic
            }
        }*/


        /*private void BindRoomData()
        {
            // Assume GetRooms() fetches a DataTable or List of room objects from the database
            var rooms = GetRooms();
            RepeaterRooms.DataSource = rooms;
            RepeaterRooms.DataBind();
        }*/


    }
}