using AduClub.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AduClub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        
        }

        public ActionResult UserClubs()
        {
            ViewBag.Messagge = "Your Clubs";
            var clubRepo = new ClubRepository();
            var clubs = clubRepo.GetAllClubs();
            return View(clubs);
        }
    }
}