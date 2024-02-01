using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace r_s_hotel.admin
{
    public partial class contactDetails : System.Web.UI.Page
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
            cmd = new SqlCommand("select * from contact", con);
            
                dr = cmd.ExecuteReader();
                GridView.DataSource = dr;
                GridView.DataBind();
                dr.Close();
           
        }

        protected void btnDelete_Command(object sender, CommandEventArgs e)
        {
            string Id = e.CommandArgument.ToString();
            deleteRecord(Id);
        }
        public void deleteRecord(string id)
        {
            cmd = new SqlCommand("delete from contact where contact_id = '" + id + "'", con);
            cmd.ExecuteNonQuery();
            displayData();
            Response.Write("<script>alert('Record Deleted...')</script>");
        }

       /* public void deleteRecord(string id)
        {
            string query = "delete from contact where contact_id = @ContactId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ContactId", id);
            con.Open(); // Ensure your connection is open before executing the command.
            cmd.ExecuteNonQuery();
            con.Close(); // Don't forget to close the connection.
            displayData();
            Response.Write("<script>alert('Record Deleted...')</script>");
        }*/

    }
}