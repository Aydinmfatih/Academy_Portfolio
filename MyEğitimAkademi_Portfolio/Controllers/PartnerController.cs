using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEğitimAkademi_Portfolio.Models;
namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class PartnerController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var value = db.Partner.ToList();
            return View(value);
        }
        public ActionResult DeletePartner(int id)
        {
            var value = db.Partner.Find(id);
            db.Partner.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddPartner()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPartner(Partner partner)
        {
            db.Partner.Add(partner);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdatePartner(int id)
        {
            var value = db.Partner.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdatePartner(Partner partner)
        {
            var model = db.Partner.Find(partner.PartnerID);
            model.Title = partner.Title;
            model.Description = partner.Description;
            model.Value = partner.Value;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}