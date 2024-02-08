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
        protected void btnDelete_Command(object sender, CommandEventArgs e)
        {
            //string Id = e.CommandArgument.ToString();
            //string TotalRoom = e.CommandArgument.ToString();

            int Id = Convert.ToInt32(e.CommandArgument.ToString());
            int TotalRoom = Convert.ToInt32(e.CommandArgument.ToString());
            deleteRecord(Id, TotalRoom);
        }
        public void deleteRecord(int Id, int TotalRoom)
        {
            SqlCommand cmd = new SqlCommand("UPDATE room SET room_total = room_total+'"+ TotalRoom+"' WHERE room_id = '"+Id+"'", con);
            cmd.ExecuteNonQuery();
            
            /*cmd = new SqlCommand("delete from room where room_id = '" + id + "'", con);
            cmd.ExecuteNonQuery();
            displayData();
            Response.Write("<script>alert('Record Deleted...')</script>");*/
        }
    }
}