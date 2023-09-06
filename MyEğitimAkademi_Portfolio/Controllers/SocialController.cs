using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEğitimAkademi_Portfolio.Models;
namespace MyEğitimAkademi_Portfolio.Controllers
{
    public class SocialController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            ViewBag.linkedin = db.Social.Select(x => x.LinkedInUrl).FirstOrDefault();
            ViewBag.facebook = db.Social.Select(x => x.FaceBookUrl).FirstOrDefault();
            ViewBag.twitter = db.Social.Select(x => x.TwitterUrl).FirstOrDefault();
            ViewBag.github = db.Social.Select(x => x.GithubUrl).FirstOrDefault();
            return View();
        }
    }
}