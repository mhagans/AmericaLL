using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmericaLittleLeaders.Models;

namespace AmericaLittleLeaders.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "America Little Leaders";
           
            ContentSliderViewModel images = new ContentSliderViewModel()
            {
                ImagesList = new System.IO.DirectoryInfo(Server.MapPath("~/Images/contentSlider/")).GetFiles()
            };

            
            var model = new ContainerModel();
            model.files = FileViewModel.ListFiles();
            model.images = images;
         
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