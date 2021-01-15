using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLink(Class1 class1) 
        {
          // nó tự động thêm cái biến test là 0 luôn@@~ cay vcl
               // return Json(data: new { success = true, message = "Success" }, JsonRequestBehavior.AllowGet);
            return Json(data: new { success = false, message = "Error" }, JsonRequestBehavior.AllowGet);
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