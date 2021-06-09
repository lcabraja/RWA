using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak01.Models;

namespace Zadatak01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.kupacCount = Repo.GetKupciCount();
            return View(Repo.GetKupci());
        }

        public ActionResult Uredi(int id)
        {
            return View(Repo.GetKupac(id));
        }
    }
}