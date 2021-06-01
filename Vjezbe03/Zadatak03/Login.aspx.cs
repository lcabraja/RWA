using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak03
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userInfo"] != null)
            {
                Response.Redirect("Order.aspx");
            }
            tbName.Focus();
        }

        protected void btSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userInfo");

            cookie["fullName"] = tbName.Text;
            cookie["address"] = tbAddress.Text;
            cookie["email"] = tbEmail.Text;
            cookie.Expires = DateTime.Now.AddSeconds(30);

            Response.Cookies.Add(cookie);
            Response.Redirect("Order.aspx");
        }
    }
}