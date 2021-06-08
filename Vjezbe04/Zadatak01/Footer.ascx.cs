using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak01
{
    public partial class Footer : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["FooterStyle"] == null)
            {
                Session["FooterStyle"] = "short";
            }
            PrintDate();
        }

        private void PrintDate()
        {
            changeDate.Text = Session["FooterStyle"].ToString() == "short" ? DateTime.Now.ToShortDateString() : DateTime.Now.ToLongDateString();
        }

        protected void changeDate_Click(object sender, EventArgs e)
        {
            if (Session["FooterStyle"].ToString() == "short")
                Session["FooterStyle"] = "long";
            else
                Session["FooterStyle"] = "short";
            PrintDate();
        }
    }
}