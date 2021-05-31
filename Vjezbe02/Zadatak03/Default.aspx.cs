using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zadatak03.Models;
namespace Zadatak03
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btOut_Click(object sender, EventArgs e)
        {
            Person p = new Person { Name = tbName.Text, Surname = tbSurname.Text };
            ViewState["person"] = p;
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            if (IsPostBack)
            {
                Person p = (Person)ViewState["person"];
                lbInfo.Text = $"{p.Name} {p.Surname}";
            }
            base.OnPreRenderComplete(e);
        }
    }
}