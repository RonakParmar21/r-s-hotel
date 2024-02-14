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
    public partial class profile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {

                //int roomId = Convert.ToInt32(Request.QueryString["id"]);

                con.Open();


                SqlCommand cmd = new SqlCommand("select * from [user] where user_email='" + Session["user"] + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataList1.DataSource = dr;
                DataList1.DataBind();

                /*if(dr.Read())
                {
                    int rt = Convert.ToInt32(dr["room_total"]);
                    if(rt==0)
                    {
                        
                    }
                }
                */
                //dlRooms.DataSource = dr;
                //dlRooms.DataBind();

                //viewReview(roomId);

            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "CBooking")
            {
                int userId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"currentBooking.aspx?UserId={userId}");
            }
            else if(e.CommandName == "HBooking")
            {
                int userId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"bookingHistory.aspx?UserId={userId}");
            }
        }
    }
}