using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak02
{
    public partial class Default : System.Web.UI.Page
    {
        public int NumberOfColors
        {
            get
            {
                if (Session["NumberOfColors"] == null)
                {
                    Session["NumberOfColors"] = 1;
                };
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
            ShowFields();
        }

        private void ShowFields()
        {
            container.Controls.Clear();
            for (int i = 0; i < NumberOfColors; i++)
            {
                CreateInputLine(i);
            }
            if (NumberOfColors > 1)
            {
                CreateButton();
            }
        }

        private void CreateButton()
        {
            Button button = new Button();
            button.Text = "Show in DDL control";
            button.ID = "btShowDDL";
            button.Click += btShowDDL_Click;
            form1.Controls.AddAt(form1.Controls.Count - 1, new LiteralControl("<br>"));
            form1.Controls.AddAt(form1.Controls.Count - 1, button);
        }

        private void btShowDDL_Click(object sender, EventArgs e)
        {
            DropDownList dropDownList = new DropDownList();
            ListItem listItem;
            for (int i = 0; i < NumberOfColors; i++)
            {
                listItem = new ListItem(((TextBox)form1.FindControl($"tb{i}")).Text);
                dropDownList.Items.Add(listItem);
            }
            form1.Controls.AddAt(form1.Controls.Count - 1, new LiteralControl("<br>"));
            form1.Controls.AddAt(form1.Controls.Count - 1, dropDownList);
        }

        private void CreateInputLine(int index)
        {
            Label label = new Label();
            label.ID = $"lb{index}";
            label.Text = $"Color #{index}";
            form1.Controls.Add(label);

            TextBox textBox = new TextBox();
            textBox.ID = $"tb{index}";
            form1.Controls.Add(textBox);

            LinkButton linkButton = new LinkButton();
            linkButton.Text = "Add new color";
            linkButton.Click += newClick;
            form1.Controls.Add(linkButton);
            form1.Controls.Add(new LiteralControl("<br/>"));
        }

        private void newClick(object sender, EventArgs e)
        {
            NumberOfColors++;
        }
    }
}