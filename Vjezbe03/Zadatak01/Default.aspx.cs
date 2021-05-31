using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak01
{
    public partial class Default : System.Web.UI.Page
    {
        private int NumberOfColors
        {
            get
            {
                if (Session["NumberOfColors"] == null)
                {
                    Session["NumberOfColors"] = 0;
                }
                return (int)Session["NumberOfColors"];
            }
            set
            {
                Session["NumberOfColors"] = value;
            }
        }

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            if (NumberOfColors != 0)
            {
                ShowInputFields();
                ShowButton();
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            NumberOfColors = int.Parse(tbColors.Text)
            ShowInputFields();
            ShowButton();

            othercontainer.Items.Clear();
        }

        private void ShowInputFields()
        {
            container.Controls.Clear();
            for (int i = 0; i < NumberOfColors; i++)
            {
                container.Controls.Add(new Label { Text = $"Color #{i}" });
                container.Controls.Add(new TextBox { ID = $"txt{i}" });
                container.Controls.Add(new LiteralControl("<br>"));
            }
        }

        private void ShowButton()
        {
            var button = new Button();
            button.ID = "btShowColors";
            button.Text = "Show colors";
            button.Click += showColors_Click;

            container.Controls.Add(new LiteralControl("<br>"));
            container.Controls.Add(button);
        }

        protected void showColors_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumberOfColors; i++)
            {
                TextBox tb = container.FindControl($"txt{i}") as TextBox;
                othercontainer.Items.Add(tb.Text);
            }
        }
    }
}