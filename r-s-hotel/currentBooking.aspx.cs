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
    public partial class currentBooking : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {

                int userId = Convert.ToInt32(Request.QueryString["UserId"]);

                con.Open();




                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM book WHERE user_id='" + userId + "'", con))
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
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}