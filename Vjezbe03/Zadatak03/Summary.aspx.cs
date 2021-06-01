using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak03
{
    public partial class Summary : System.Web.UI.Page
    {
        public List<string> Cart
        {
            get
            {
                if (Session["cart"] == null)
                    Session["cart"] = new List<string>();
                return (List<string>)Session["cart"];
            }
            set { Session["cart"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] == null)
            {
                Response.Redirect("Order.aspx");
            }

            HttpCookie httpCookie = Request.Cookies["userInfo"];
            if (httpCookie == null)
            {
                Response.Redirect("Login.aspx");
            }

            welcome.InnerText = httpCookie["fullName"];
            dox.InnerText = $"{httpCookie["address"]}, {httpCookie["email"]}";

            Cart.ForEach(pongrac.Items.Add);
        }
    }
}