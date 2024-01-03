using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace r_s_hotel
{
    public partial class newUser : System.Web.UI.Page
    {
        static string activationgcode;
        protected void Page_Load(object sender, EventArgs e)
        {
     
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //       smtpClient.Credentials = new NetworkCredential("parmarronak21112003", "edgk duom pynn eyzj");
            //Random random = new Random();
            //activationgcode = random.Next(1001, 9999).ToString();

            Random random = new Random();
            // Generate a random six-digit code
            activationgcode = random.Next(100000, 1000000).ToString();
            // Print or use the generated code
            //Console.WriteLine("Generated Six-Digit Code: " + sixDigitCode);






            sendcode();



            Response.Redirect("verifyEmail.aspx");
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
            catch(Exception e)
            {
                //throw;
                Console.Write(e);
            }
        }
    }

}