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
    public partial class team : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            showStaff();
        }

        private void showStaff()
        {

            SqlCommand staffCmd = new SqlCommand("select * from staff order by staff_id desc", con);
            SqlDataReader staffDr = staffCmd.ExecuteReader();


            DataList2.DataSource = staffDr;
            DataList2.DataBind();
            staffDr.Close();
        }
    }
}