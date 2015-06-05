using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmericaLittleLeaders.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "America Little Leaders";
            ContentSliderViewModel model = new ContentSliderViewModel()
            {
                ImagesList = new System.IO.DirectoryInfo(Server.MapPath("~/Images/contentSlider/")).GetFiles()
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to America Little Leaders";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}