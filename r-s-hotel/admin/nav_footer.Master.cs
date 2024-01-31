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
    public partial class nav_footer : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
            }
            else
            {
                Response.Redirect("login.aspx");
                string nm = Session["admin"].ToString();
                //Label1.Text = nm;
                Label2.Text = nm;
                Label3.Text = nm;
            }

        }
    }
}