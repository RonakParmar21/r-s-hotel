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
    public partial class updateRoomDetails : System.Web.UI.Page
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

                int roomId = Convert.ToInt32(Request.QueryString["i"]);

//                getRoomDetails(roomId);

                /*int roomId = Convert.ToInt32(Request.QueryString["i"]);
                SqlCommand cmdSelect = new SqlCommand("select * from room where room_id='" + roomId + "'", con);
                dr = cmdSelect.ExecuteReader();
                if (dr.Read())
                {
                    roomNo.Text = dr["room_no"].ToString();
                    roomDescription.Text = dr["room_description"].ToString();
                    category.SelectedValue = dr["room_type"].ToString();
                    TextBox1.Text = dr["room_capacity"].ToString();
                    roomPrice.Text = dr["room_price"].ToString();
                    roomService.Text = dr["room_service"].ToString();
                    roomStatus.Text = dr["room_status"].ToString();
                    //string imagePath = dr["room_img"].ToString();
                    //img1.se = imagePath;
                }
                dr.Close();*//*int roomId = Convert.ToInt32(Request.QueryString["i"]);
                SqlCommand cmdSelect = new SqlCommand("select * from room where room_id='" + roomId + "'", con);
                dr = cmdSelect.ExecuteReader();
                if (dr.Read())
                {
                    roomNo.Text = dr["room_no"].ToString();
                    roomDescription.Text = dr["room_description"].ToString();
                    category.SelectedValue = dr["room_type"].ToString();
                    TextBox1.Text = dr["room_capacity"].ToString();
                    roomPrice.Text = dr["room_price"].ToString();
                    roomService.Text = dr["room_service"].ToString();
                    roomStatus.Text = dr["room_status"].ToString();
                    //string imagePath = dr["room_img"].ToString();
                    //img1.se = imagePath;
                }
                dr.Close();*/
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void getRoomDetails(int roomId)
        {
            SqlCommand cmdSelect = new SqlCommand("select * from room where room_id='" + roomId + "'", con);
            dr = cmdSelect.ExecuteReader();
            if (dr.Read())
            {
                roomNo.Text = dr["room_no"].ToString();
                roomDescription.Text = dr["room_description"].ToString();
                category.SelectedValue = dr["room_type"].ToString();
                TextBox1.Text = dr["room_capacity"].ToString();
                roomPrice.Text = dr["room_price"].ToString();
                roomService.Text = dr["room_service"].ToString();
                roomStatus.Text = dr["room_status"].ToString();
                //string imagePath = dr["room_img"].ToString();
                //img1.se = imagePath;
            }
            dr.Close();
            Response.Redirect("viewRoomDetails.aspx");
        }
        protected void add_Click(object sender, EventArgs e)
        {
            con.Close();

            string pimg1 = "~/admin/assets/images/rooms/" + img1.FileName;
            //string pimg1 = "~/img/"+img1.FileName;
            img1.SaveAs(MapPath(pimg1));

            con.Open();
            int roomId = Convert.ToInt32(Request.QueryString["i"]);
            SqlCommand cmd = new SqlCommand("UPDATE room SET room_no='"+roomNo.Text+"', room_description = '" + roomDescription.Text + "', room_type = '" + category.SelectedValue + "', room_capacity = '" + TextBox1.Text + "', room_price = '" + roomPrice.Text + "', room_service = '" + roomService.Text + "', room_status = '" + roomStatus.Text + "', room_img = '" + pimg1 + "', room_total = '" + roomTotal.Text +"' WHERE room_id = '" + roomId +"' ",con);
            //SqlCommand cmd = new SqlCommand("insert into room(room_no,room_description,room_type,room_capacity,room_price,room_service,room_status,room_img,room_total) values('" + roomNo.Text + "','" + roomDescription.Text + "','" + category.Text + "','" + TextBox1.Text + "','" + roomPrice.Text + "','" + roomService.Text + "','" + roomStatus.Text + "','" + pimg1 + "','" + roomTotal.Text + "')", con);
            cmd.ExecuteNonQuery();
            /*category.Text = 
            productname.Text = "";
            productimei.Text = "";
            productcolor.Text = "";
            productram.ClearSelection();
            productrom.ClearSelection();
            productqty.Text = "";
            productprice.Text = "";
            productdescription.Text = "";
            img1.Dispose();
            img2.Dispose();
            img3.Dispose();*/

            Response.Write("<script>alert('Room Update Succsesfully..')</script>");

        }

        protected void productimei_TextChanged(object sender, EventArgs e)
        {

        }
    }
}