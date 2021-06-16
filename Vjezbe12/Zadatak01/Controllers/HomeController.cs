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

        [HttpGet]
        public ActionResult Uredi(int id)
        {
            ViewBag.gradovi = Repo.GetGradovi();
            return View(Repo.GetKupac(id));
        }
        [HttpPost]
        public ActionResult Uredi(Kupac k)
        {
            if (ModelState.IsValid)
            {
                Repo.UpdateKupac(k);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.gradovi = Repo.GetGradovi();
                return View(k);
            }
        }

        [HttpGet]
        public ActionResult Dodaj()
        {
            ViewBag.gradovi = Repo.GetGradovi();
            return View();
        }
        [HttpPost]
        public ActionResult Dodaj(Kupac k)
        {
            if (ModelState.IsValid)
            {
                Repo.InsertKupac(k);
                return View("Potvrda", k);
            }
            else
            {
                ViewBag.gradovi = Repo.GetGradovi();
                return View(k);
            }
        }
    }
}