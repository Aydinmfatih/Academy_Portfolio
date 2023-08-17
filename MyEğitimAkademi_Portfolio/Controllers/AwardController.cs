using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEğitimAkademi_Portfolio.Models;
namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class AwardController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        
        public ActionResult Index()
        {
            var values = db.Award.ToList();
            return View(values);
        }
        public ActionResult DeleteAward(int id)
        {
            var deleteItem = db.Award.Find(id);
            db.Award.Remove(deleteItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddAward()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAward(Award award)
        {
            db.Award.Add(award);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAward(int id)
        {
            var value = db.Award.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAward(Award award)
        {
            var value = db.Award.Find(award.AwardID);
            value.Title = award.Title;
            value.Description = award.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}