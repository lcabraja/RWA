using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zadatak01.Models.CustomHTMLHelper
{
    public static class CustomHTMLHelpers
    {
        public static MvcHtmlString DDLGradovi(this HtmlHelper html, List<Grad> collection, int selectedAttribute)
        {
            TagBuilder selectTag = new TagBuilder("select");
            selectTag.MergeAttribute("id", "Grad.IDGrad");
            selectTag.MergeAttribute("name", "Grad.IDGrad");
            selectTag.AddCssClass("form-control");

            foreach (Grad grad in collection)
            {
                TagBuilder optionTag = new TagBuilder("option");
                optionTag.MergeAttribute("value", grad.IDGrad.ToString());
                if (selectedAttribute == grad.IDGrad)
                {
                    optionTag.MergeAttribute("selected", true.ToString()); 
                }
                optionTag.SetInnerText(grad.Naziv);
                selectTag.InnerHtml += optionTag.ToString();
            }

            return new MvcHtmlString(selectTag.ToString());
        }
    }
}