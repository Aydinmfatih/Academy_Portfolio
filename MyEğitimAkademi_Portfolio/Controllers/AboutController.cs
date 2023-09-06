using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEğitimAkademi_Portfolio.Models;
namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.About.ToList();
            return View(values);
        }
        public ActionResult DeleteAbout(int id)
        {
            var deleteItem = db.About.Find(id);
            db.About.Remove(deleteItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            db.About.Add(about);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = db.About.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value = db.About.Find(about.AboutId);
            value.Introduction = about.Introduction;
            value.Title = about.Title;
            value.Description = about.Description;
            value.NameSurname = about.NameSurname;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}