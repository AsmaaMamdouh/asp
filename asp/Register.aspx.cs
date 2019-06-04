using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddl_country.Items.Add("Egypt");
                ddl_country.Items.Add("Italy");

            }
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
           // Response.Redirect("home.aspx?uname="+txt_username.Text);
            Session.Add("uname", txt_username.Text);
            Response.Redirect("home.aspx");
        }
    }
}