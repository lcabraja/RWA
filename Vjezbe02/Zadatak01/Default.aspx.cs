using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak01
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCities();
                LoadSexes(); 
            }
        }

        private void LoadCities()
        {
            dlCity.Items.Add(new ListItem("Zagreb"));
            dlCity.Items.Add(new ListItem("Split"));
            dlCity.Items.Add(new ListItem("Rijeka"));
            dlCity.Items.Add(new ListItem("Osijek"));
        }
        private void LoadSexes()
        {
            rbSex.Items.Add(new ListItem("Male"));
            rbSex.Items.Add(new ListItem("Female"));
            rbSex.SelectedIndex = 0;
        }

        protected void btOut_Click(object sender, EventArgs e)
        {
            pnOut.Visible = true;
            string driversLicence = "Does not have a drivers licence";
            if (chDrivers.Checked)
            {
                driversLicence = "Has a drivers licence";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("<b>Name:</b>");
            sb.Append(tbName.Text);
            sb.Append("<br/>");
            sb.Append("<b>Surname:</b>");
            sb.Append(tbSurname.Text);
            sb.Append("<br/>");
            sb.Append("<b>City:</b>");
            sb.Append(dlCity.SelectedItem.Text);
            sb.Append("<br/>");
            sb.Append("<b>Sex:</b>");
            sb.Append(rbSex.SelectedItem.Text);
            sb.Append("<br/>");
            sb.Append("<b>Drivers licence:</b>");
            sb.Append(driversLicence);
            sb.Append("<br/>");

            LiteralControl output = new LiteralControl(sb.ToString());
            pnOut.Controls.Add(output);
        }
    }
}