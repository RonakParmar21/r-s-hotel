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
using System.Web.Script.Serialization;

namespace r_s_hotel
{
    public partial class newUser : System.Web.UI.Page
    {
        int activationgcode;

        string n;
        string em;
        string pass;
        string cpass;
        string mo;
        string d;
        string g;
        protected void Page_Load(object sender, EventArgs e)
        {
            n = name.Text;
            em = email.Text;
            pass = password.Text;
            cpass = cpassword.Text;
            mo = mobile.Text;
            d = dob.Text;
            g = gender.SelectedValue;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            activationgcode = random.Next(100000, 1000000);
            
            sendcode();

            

            Response.Redirect($"verifyEmail.aspx?rNo={activationgcode}");

            Response.Redirect($"verifyEmail.aspx?uNm={n}");

            /*Response.Redirect($"verifyEmail.aspx?nm={n}");
            Response.Redirect($"verifyEmail.aspx?em={em}");
            Response.Redirect($"verifyEmail.aspx?pass={pass}");
            Response.Redirect($"verifyEmail.aspx?cpass={cpass}");
            Response.Redirect($"verifyEmail.aspx?mo={mo}");
            Response.Redirect($"verifyEmail.aspx?dob={d}");
            Response.Redirect($"verifyEmail.aspx?g={g}");*/
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