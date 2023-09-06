using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEğitimAkademi_Portfolio.Models;

namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialQuickContact()
        {
            var values = db.Social.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFeature()
        {
            ViewBag.linkedin = db.Social.Select(x => x.LinkedInUrl).FirstOrDefault();
            ViewBag.facebook = db.Social.Select(x => x.FaceBookUrl).FirstOrDefault();
            ViewBag.twitter = db.Social.Select(x => x.TwitterUrl).FirstOrDefault();
            ViewBag.github = db.Social.Select(x => x.GithubUrl).FirstOrDefault();
            var values = db.About.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = db.Service.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAward()
        {
            var values = db.Award.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var value = db.Testimonial.ToList();
            return PartialView(value);
        } 
        public PartialViewResult PartialPartners()
        {
            var value = db.Partner.ToList();

            return PartialView(value);
        }
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }

    }

}
