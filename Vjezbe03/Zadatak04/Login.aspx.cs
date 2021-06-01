using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak04
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["pero"] != null)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btSubmit_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().ToLower() != "pero")
            {
                lbToolTip.Text = "Only the one known as 'Pero' can enter...";
                lbToolTip.Text += $"\n{tbName.Text.Trim().ToLower()}";
                return;
            }
            lbToolTip.Text = string.Empty;
            if (tbPassword.Text == "123")
            {
                HttpCookie pero = new HttpCookie("pero");
                pero["pero"] = "pero";
                pero.Expires = DateTime.Now.AddMinutes(30);
                Response.Cookies.Add(pero);
            }
        }
    }
}