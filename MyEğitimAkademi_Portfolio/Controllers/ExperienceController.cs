using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEğitimAkademi_Portfolio.Models;
namespace MyEğitimAkademi_Portfolio.Controllers
{

    public class ExperienceController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var value = db.Experience.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(Experience experience)
        {
            db.Experience.Add(experience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult DeleteExperience(int id)
        {
            var value = db.Experience.Find(id);
            db.Experience.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var value = db.Experience.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateExperience(Experience experience)
        {
            var value = db.Experience.Find(experience.ExperienceID);
            value.ExperienceID = experience.ExperienceID;
            value.Title = experience.Title;
            value.Description = experience.Description;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}