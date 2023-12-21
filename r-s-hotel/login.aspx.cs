using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace r_s_restaurent
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_click(object sender, EventArgs e)
        {
            string em = email.Text;
            string pass = password.Text;
        }
    }
}