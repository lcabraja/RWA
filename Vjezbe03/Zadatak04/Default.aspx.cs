using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak04
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["pero"] == null) {
                Response.Redirect("Login.aspx");
            }

            var onoffer = Request.Cookies["onoffer"];
            var selected = Request.Cookies["selected"];

            var offc = onoffer.Values.Count;
            var selc = selected.Values.Count;

            for (int i = 0; i < offc; i++)
            {
                onOffer.Items.Add(onoffer[$"item{i}"]);
            }
            for (int i = 0; i < selc; i++)
            {
                onOffer.Items.Add(selected[$"item{i}"]);
            }
        }

        protected void btLeft_Click(object sender, EventArgs e)
        {
            var transfer = selected.SelectedItem;
            selected.Items.Remove(transfer);
            onOffer.Items.Add(transfer);
        }

        protected void btRight_Click(object sender, EventArgs e)
        {
            var transfer = onOffer.SelectedItem;
            onOffer.Items.Remove(transfer);
            selected.Items.Add(transfer);
        }
    }
}