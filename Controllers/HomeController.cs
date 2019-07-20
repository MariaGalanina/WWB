using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Здесь мы расскажем о нашем проекте";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Наши контакты";

            return View();
        }
    }
}