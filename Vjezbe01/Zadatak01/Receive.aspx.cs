using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using vjezbe01lib;

namespace Zadatak01
{
    public partial class Receive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //StopDirectAccess();
            ShowData();
        }

        private void StopDirectAccess()
        {
            if (Request.QueryString.Count == 0 && Request.Form.Count == 0)
            {
                Response.Redirect("Send.aspx");
            }
        }

        private void ShowData()
        {
            var method = Request.HttpMethod.ToLower();
            var paramsCollection = method == "get" ? Request.QueryString : Request.Form;
            Console.WriteLine(Request);
            Person person = new Person
            {
                Name = paramsCollection["name"],
                Surname = paramsCollection["surname"],
                City = paramsCollection["city"]
            };

            Response.Write(GetResponse(person, method));
        }

        private string GetResponse(Person person, string method)
        {
            return $"<div class='container'><h1>Data sent with {method.ToUpper()} method...</h1><br>Name: <b>{person.Name}</b><br>Surname: <b>{person.Surname}</b><br>City: <b>{person.City}</b><br><a href='Send.aspx' class='btn btn-link'>Repeat</a></div>";
        }
    }
}