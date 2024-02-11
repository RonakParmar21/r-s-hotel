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
    public partial class addRoom : System.Web.UI.Page
    {
        SqlConnection con;
        //con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        
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
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        protected void add_Click(object sender, EventArgs e)
        {

            con.Close();

            string pimg1 = "~/admin/assets/images/rooms/" + img1.FileName;
            //string pimg1 = "~/img/"+img1.FileName;
            img1.SaveAs(MapPath(pimg1));

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into room(room_no,room_description,room_type,room_capacity,room_price,room_service,room_status,room_img,room_total) values('" + roomNo.Text + "','" + roomDescription.Text + "','" + category.Text + "','" + TextBox1.Text + "','" + roomPrice.Text + "','" + roomService.Text + "','" + roomStatus.Text + "','" + pimg1 + "','" + roomTotal.Text + "')", con);
            cmd.ExecuteNonQuery();
            /*category.Text = "";
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

            Response.Write("<script>alert('Room Add Succsesfully..')</script>");
           
        }

        protected void productimei_TextChanged(object sender, EventArgs e)
        {

        }
    }
}