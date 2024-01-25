using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace r_s_hotel
{
    public partial class verifyEmail : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*string randomNo = Request.QueryString["rNo"];

            string otp = TextBox1.Text.ToString();

           

            if(randomNo == otp)
            {
                Response.Write("<br /><br/>done");
            }
            else
            {
                Response.Write("<br /><br/>not ready");
            }
            Response.Write("<h1>Random no is : " + randomNo + " and type is : " + randomNo.GetType() + "</h1><br /><br /><h1>Your entered no is : " + otp + " and type is : " + otp.GetType() + "</h1>");
            */

            /*int randomNo = Convert.ToInt32(Request.QueryString["rNo"]); // Use null-coalescing in case the query string is null
            int otp = Convert.ToInt32(TextBox1.Text);
            Response.Write("<h1>Random no is : " + randomNo + " and type is : " + randomNo.GetType() + "</h1><br /><br /><h1>Your entered no is : " + otp + " and type is : " + otp.GetType() + "</h1>");
            */
            // Compare the trimmed values to ensure there are no leading or trailing whitespaces
            /**if (randomNo.Equals(otp))
            {
                Response.Write("<h1>done</h1>");
            }
            else
            {
                Response.Write("<h1>not ready</h1>");
            }*/


            int random = Convert.ToInt32(Request.QueryString["rNo"]);
            int otp = Convert.ToInt32(TextBox1.Text);

            if(random == otp)
            {
                //Response.Write("<h1>done</h1><br/><br/>");
            }
            else
            {
                //Response.Write("<h1>not done</h1><br/><br/>");
            }


        }
    }
}