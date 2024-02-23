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
    public partial class updateStaffDetails : System.Web.UI.Page
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

                int staffId = Convert.ToInt32(Request.QueryString["i"]);

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

        protected void add_Click(object sender, EventArgs e)
        {
            con.Close();

            string pimg1 = "~/admin/assets/images/staff/" + img1.FileName;
            //string pimg1 = "~/img/"+img1.FileName;
            img1.SaveAs(MapPath(pimg1));

            con.Open();
            int staffId = Convert.ToInt32(Request.QueryString["i"]);
            //SqlCommand cmd = new SqlCommand("insert into staff(staff_name, staff_email, staff_mobile, staff_dob, staff_gender, staff_possition, staff_sallary, staff_address, admin_id, staff_img, staff_join_date) values('" + name.Text + "','" + email.Text + "','" + long.Parse(mobile.Text) + "','" + dob.Text + "','" + gender.SelectedValue + "','" + category.Text + "','" + salary.Text + "','" + address.Text + "','" + adid + "', '" + pimg1 + "', '" + TextBox1.Text + "')", con);

            SqlCommand cmd = new SqlCommand("UPDATE staff SET staff_name='" + name.Text + "', staff_email = '" + email.Text + "', staff_mobile = '" + long.Parse(mobile.Text) + "', staff_dob = '" + dob.Text + "', staff_gender = '" + gender.SelectedValue + "', staff_possition = '" + category.Text + "', staff_sallary = '" + salary.Text + "', staff_address = '" + address.Text + "', staff_img = '" + pimg1  + "' WHERE staff_id = '" + staffId + "' ", con);
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
    }
}