using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak03
{
    public partial class Order : System.Web.UI.Page
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

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            Cart.ForEach(x => tbCart.Text += $"{x}\n");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userInfo"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            HttpCookie cookie = Request.Cookies["userInfo"];
            welcome.InnerText = $"Welcome {cookie["fullName"]}";

        }

        protected void btAddToCart_Click(object sender, EventArgs e)
        {
            if (tbArticle.Text == string.Empty)
            {
                return;
            }
            ResetTooltip();
            Cart.Add(tbArticle.Text.Trim());
            tbCart.Text += $"{Cart.Last()}\n";
        }

        private void ResetTooltip()
        {
            lbTooltip.Text = string.Empty;
        }

        protected void btGoToSummary_Click(object sender, EventArgs e)
        {
            if (Cart.Count == 0)
            {
                lbTooltip.Text = "Must have items in the cart before proceeding...";
                return;
            }
            ResetTooltip();
            Response.Redirect("Summary.aspx");
        }
    }
}