﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace r_s_hotel
{
    public partial class roomDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["user"] != null)
            {
                
                int roomId = Convert.ToInt32(Request.QueryString["id"]);

                con.Open();


                SqlCommand cmd = new SqlCommand("select * from room where room_id='"+roomId+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();


                dlRooms.DataSource = dr;
                dlRooms.DataBind();

            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void dlRooms_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "BookNow")
            {
                int roomId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"booking.aspx?RoomId={roomId}");
                
            }
        }
    }
}