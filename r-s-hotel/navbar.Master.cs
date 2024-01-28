using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace r_s_restaurent
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string session;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");

            if (Session["user"] != null)
            {
                session = Session["user"].ToString();
                loginBtn.Text = Session["user"].ToString();

                HyperLink1.Visible = true;
                HyperLink2.Visible = false;
                HyperLink3.Visible = true;


            }
        }
    }
}