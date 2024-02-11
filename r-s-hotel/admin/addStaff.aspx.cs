using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;

namespace r_s_hotel.admin
{
    public partial class addStaff : System.Web.UI.Page
    {
        string nm, em, db, ge, pos, sl, add, joindate, lem, simg;
        int activationgcode;
        SqlConnection con;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            nm = name.Text;
            em = email.Text;
            long mo = long.Parse(mobile.Text);
            db = dob.Text;
            ge = gender.SelectedValue;
            pos = category.Text;
            sl = salary.Text;
            add = address.Text;
            joindate = TextBox1.Text;
            simg = img1.FileName;


            Random random = new Random();
            activationgcode = random.Next(100000, 1000000);
            
            sendcode();
            //string targetUrl = $"verifyEmail.aspx?n={nm}&e={em}&p={pass}&cp={cpass}&d={db}&rNo={activationgcode}&m={mo}";
            string targetUrl = $"vefiryStaff.aspx?n={nm}&e={em}&m={mo}&d={db}&g={ge}&pos={pos}&sl={sl}&ad={add}&rNo={activationgcode}&jdate={joindate}&simg={img1.FileName}";
            con.Close();
            string pimg1 = "~/admin/assets/images/staff/" + img1.FileName;
            //string pimg1 = "~/img/"+img1.FileName;
            img1.SaveAs(MapPath(pimg1));
            con.Open();
            Response.Redirect(targetUrl);

            /*Response.Redirect($"verifyEmail.aspx?nm={n}");
            Response.Redirect($"verifyEmail.aspx?rNo={activationgcode}");
            */
        }
        private void sendcode()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("parmarronak21112003@gmail.com", "edgk duom pynn eyzj");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "activation code to verify email address";
            msg.Body = "Your code is : " + activationgcode;
            string toaddress = email.Text;
            msg.To.Add(toaddress);
            string fromaddress = "rshotel : <parmarronak21112003@gmail.com>";
            msg.From = new MailAddress(fromaddress);
            try
            {
                smtp.Send(msg);
            }
            catch (Exception e)
            {
                //throw;
                Console.Write(e);
            }
        }
    }
}