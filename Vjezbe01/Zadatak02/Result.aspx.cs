using System;
using System.Text;

namespace Zadatak02
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SendAway();
            SendBack();
            ShowCalculation();
        }

        private void SendAway()
        {
            if (Request.QueryString.Count == 0)
            {
                Response.StatusCode = 400;
                Response.End();
            }
        }

        private void SendBack()
        {
            if (Request.QueryString["num1"] == string.Empty || Request.QueryString["num2"] == string.Empty)
            {
                Response.Redirect("Calculator.html");
            }
        }

        private void ShowCalculation()
        {
            try
            {
                int num1 = int.Parse(Request.QueryString["num1"]);
                int num2 = int.Parse(Request.QueryString["num2"]);
                string op = Request.QueryString["operation"];

                StringBuilder sb = new StringBuilder();
                sb.Append($"<h2>{num1} {op} {num2} = ");
                switch (op)
                {
                    case "+":
                        sb.Append((num1 + num2).ToString());
                        break;
                    case "-":
                        sb.Append((num1 - num2).ToString());
                        break;
                    case "*":
                        sb.Append((num1 * num2).ToString());
                        break;
                    case "/":
                        sb.Append(((double)num1 / num2).ToString());
                        break;
                    default:
                        throw new ArgumentException("Incorrect operation selected.");
                }
                sb.Append("</h1>");
                Response.Write(sb.ToString());
            }
            catch (FormatException ex)
            {
                Response.Write(ex.Message);
                Response.StatusCode = 300;
            }
        }
    }
}