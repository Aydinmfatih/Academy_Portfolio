using MyEğitimAkademi_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [HttpGet]
        public ActionResult Index()
        {
            var values = db.Contact.ToList();
            ViewBag.description = db.Address.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = db.Address.Select(x => x.Phone).FirstOrDefault();
            ViewBag.addressDetail = db.Address.Select(x => x.AddressDetail).FirstOrDefault();
            ViewBag.mail = db.Address.Select(x => x.Mail).FirstOrDefault();
            return View(values);

        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        public ActionResult DeleteContact(int id)
        {
            var deleteItem = db.Contact.Find(id);
            db.Contact.Remove(deleteItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}