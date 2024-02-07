using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace r_s_hotel
{
    public partial class bookConfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int tday = Convert.ToInt32(Request.QueryString["totalDays"]);
            //string tday = Request.QueryString["totalDays"];
            int tday = Convert.ToInt32(Request.QueryString["totalDays"]);
            int roomqty = Convert.ToInt32(Request.QueryString["roomqt"]);
            string request = Request.QueryString["re"];
            string payment = Request.QueryString["pm"];
            int uid = Convert.ToInt32(Request.QueryString["userId"]);
            string unm = Request.QueryString["userName"];
            string uem = Request.QueryString["userEmail"];
            string umo = Request.QueryString["userMobile"];
            string cin = Request.QueryString["checkIn"];
            string cout = Request.QueryString["checkOut"];

            int rid = Convert.ToInt32(Request.QueryString["roomId"]);
            int roomPrice = Convert.ToInt32(Request.QueryString["rp"]);
            string rtype = Request.QueryString["roomType"];
            string tperson = Request.QueryString["tp"];
            int totalPrice = roomPrice * tday * roomqty;

            Response.Write("<h1>User id '"+uid+"'</h1>");
            Response.Write("<h1>User name '" + unm + "'</h1>");
            Response.Write("<h1>User email '" + uem + "'</h1>");
            Response.Write("<h1>User mobile '" + umo + "'</h1>");

            Response.Write("<h1>Room id '" + rid + "'</h1>");
            Response.Write("<h1>Room Type '" + rtype + "'</h1>");
            Response.Write("<h1>Total Day '" + tday + "'</h1>");

            Response.Write("<h1>Checkin date '" + cin + "'</h1>");
            Response.Write("<h1>Checkout date '" + cout + "'</h1>");
            Response.Write("<h1>Room Price '" + roomPrice + "'</h1>");
            Response.Write("<h1>Total Room Price '" + totalPrice + "'</h1>");

            Response.Write("<h1>Total Person = '"+tperson+"'</h1>");
            Response.Write("<h1>Room Qty = '" + roomqty + "'</h1>");
            Response.Write("<h1>Payment Method = '" + payment + "'</h1>");
            Response.Write("<h1>Request = '" + request + "'</h1>");

        }
    }
}