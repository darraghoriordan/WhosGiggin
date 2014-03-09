using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhosGiggin.Models;
using WhosGiggin.DataContext;
using Ninject;
namespace WhosGiggin.Controllers
{
    public class HomeController : Controller
    {
        [Inject]
        public IUOW Uow { get; set; }
        public ActionResult Index()
        {
            var hp = new HomepageViewModel()
            {
                Events = Uow.EventRepository.All
            };

            return View(hp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        
        }

        public ActionResult Examples()
        {
            ViewBag.Message = "Examples";

            return View("BSExamples");
        }
    }
}
