using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEğitimAkademi_Portfolio.Models;
namespace MyEğitimAkademi_Portfolio.Controllers
{

    public class SkillController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var value = db.Skill.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        public ActionResult AddSkill(Skill skill)
        {
            db.Skill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSkill(int id)
        {
            var value = db.Skill.Find(id);
            db.Skill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.Skill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            var value = db.Skill.Find(skill.SkillID);
            value.SkillID = skill.SkillID;
            value.SkillName = skill.SkillName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}