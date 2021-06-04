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
            if (Request.Cookies["pero"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (Session["onOffer"] == null && Session["selected"] == null)
            {
                CreateItems();
            }
            if (!IsPostBack)
            {
                CreateListItems();
            }
        }

        private void CreateListItems()
        {
            var sessionOffer = Session["onOffer"] as List<string>;
            var sessionSelected = Session["selected"] as List<string>;

            //onOffer.Items.Clear();
            //selected.Items.Clear();

            sessionOffer.ForEach(x => onOffer.Items.Add(new ListItem(x, x)));
            sessionSelected.ForEach(x => selected.Items.Add(new ListItem(x, x)));
            Response.Write("1st");
        }

        private void CreateItems()
        {
            Session["onOffer"] = new List<string>
            {
                "Car",
                "Bike",
                "Skiis",
                "Rollerblades",
                "Motorcycle",
                "Segway",
                "Hoverboard",
                "Running Shoes"
            };
            Session["selected"] = new List<string>();
        }

        protected void btLeft_Click(object sender, EventArgs e)
        {
            var sessionOffer = Session["onOffer"] as List<string>;
            var sessionSelected = Session["selected"] as List<string>;

            var transfer = selected.SelectedValue;
            sessionSelected.Remove(transfer);
            sessionOffer.Add(transfer);

            selected.Items.Remove(transfer);
            onOffer.Items.Add(new ListItem(transfer, transfer));
        }

        protected void btRight_Click(object sender, EventArgs e)
        {
            var sessionOffer = Session["onOffer"] as List<string>;
            var sessionSelected = Session["selected"] as List<string>;

            var transfer = onOffer.SelectedValue;
            sessionOffer.Remove(transfer);
            sessionSelected.Add(transfer);

            onOffer.Items.Remove(transfer);
            selected.Items.Add(new ListItem(transfer, transfer));
        }
        protected void onOffer_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected.ClearSelection();
        }

        protected void selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            onOffer.ClearSelection();
        }
    }
}