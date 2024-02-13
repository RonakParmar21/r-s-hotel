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

                /*if(dr.Read())
                {
                    int rt = Convert.ToInt32(dr["room_total"]);
                    if(rt==0)
                    {
                        
                    }
                }
                */
                dlRooms.DataSource = dr;
                dlRooms.DataBind();

                viewReview(roomId);

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
            if(e.CommandName == "MakeReview")
            {
                int roomId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"addReview.aspx?RoomId={roomId}");
            }

            /*else if(e.CommandName == "MakeReview")
            {
                string u = Session["user"].ToString();
                int roomId = Convert.ToInt32(e.CommandArgument);

            }*/
        }

        private void viewReview(int r)
        {
            //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //roomId = Convert.ToInt32(e.CommandArgument);
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT user_name, user_email, msg FROM review WHERE room_id='"+r+"'", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        //Response.Redirect($"roomDetails.aspx?RoomId={r}");
                    }
                }
            }
        }
    }
}