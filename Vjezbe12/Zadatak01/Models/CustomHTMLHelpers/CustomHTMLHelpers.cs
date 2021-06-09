using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zadatak01.Models.CustomHTMLHelper
{
    public static class CustomHTMLHelpers
    {
        public static MvcHtmlString DDLGradovi(this HtmlHelper html, List<Grad> collection)
        {
            TagBuilder selectTag = new TagBuilder("select");

            foreach (Grad grad in collection)
            {
                //selectTag.
                //TODO: TU SMO STALI
            }

            return new MvcHtmlString(selectTag.ToString());
        }
    }
}