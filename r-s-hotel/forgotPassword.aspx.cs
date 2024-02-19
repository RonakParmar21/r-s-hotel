using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace r_s_hotel
{
    public partial class forgotPassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-505DFRT;Initial Catalog=rshotel;Integrated Security=True");
        string em;
        int activationgcode;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            em = email.Text;
                    Random random = new Random();
                    activationgcode = random.Next(100000, 1000000);

                    sendcode();
                    string targetUrl = $"verifyForgotPassword.aspx?e={em}&rNo={activationgcode}";

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