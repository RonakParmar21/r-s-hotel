using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace r_s_restaurent
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String nm = name.Text;
            String em = email.Text;
            String sub = subject.Text;
            String msg = message.Text;
            Response.Write("<script>alert('" + nm + "')</script>");
        }
    }
}