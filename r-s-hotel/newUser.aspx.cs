using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace r_s_hotel
{
    public partial class newUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string nm = name.Text;
            string em = email.Text;
            string pass = password.Text;
            string cpass = cpassword.Text;
            string mo = mobile.Text;
        }
    }
}