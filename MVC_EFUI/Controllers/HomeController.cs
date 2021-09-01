using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpliLearn.BusinessLayer;
namespace MVC_EFUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IService repo = new Service();
            var st = repo.GetStudentEntities();
            
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
    }
}