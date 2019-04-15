using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    
        public partial class WebForm2 : System.Web.UI.Page
    {
            DataClasses2DataContext db = new DataClasses2DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            char g;
            if (male.Checked == true)
                g = 'M';
            else
                g = 'F';
            db.inusr(TextBox1.Text,TextBox2.Text,TextBox3.Text,g,"17-08-1998",TextBox6.Text,'R'.ToString());
            Response.Redirect("login.aspx");
            
        }
    }
}