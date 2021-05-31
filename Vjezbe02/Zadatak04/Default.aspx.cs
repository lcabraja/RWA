using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btSend_Click(object sender, EventArgs e)
    {

    }

    protected void customUsernameValidator_ServerValidate(object source, ServerValidateEventArgs args)
    {
        try
        {
            // Test whether the value entered into the text box is even.
            int i = int.Parse(args.Value);
            args.IsValid = ((i % 2) == 0);

        }

        catch (Exception ex)
        {

            args.IsValid = false;

        }

    }
}
