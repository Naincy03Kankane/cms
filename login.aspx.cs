using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var k=db.logchk(TextBox2.Text, TextBox3.Text);
            Response.Redirect("useradmin.aspx");
            if (k < 0)
                Label1.Text = "Check Your Credentials";

        }
    }
}