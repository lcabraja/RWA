using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vjezbe14.Models;

namespace Vjezbe14.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        //[HttpGet]
        public ActionResult GetAutoCompleteKupci(string term)
        {
            var data = Repo.GetKupci()
                           .Where(x =>
                               (x.Ime.ToLower().Contains(term)) ||
                               (x.Prezime.ToLower().Contains(term))
                           )
                           .Select(x => new { label = x.ToString(), value = x.IDKupac });

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetRacuniKupca(int id)
        {
            return Json(Repo.GetRacuniKupca(id), JsonRequestBehavior.AllowGet);
        }
    }
}