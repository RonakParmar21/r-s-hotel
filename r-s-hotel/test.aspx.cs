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
	public partial class test1 : System.Web.UI.Page
	{
		string im;
		string card;
		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}
	}
}