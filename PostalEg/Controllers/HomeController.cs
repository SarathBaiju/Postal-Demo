using Postal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostalEg.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public ActionResult Index()

        {
            dynamic email = new Email("example");
            email.To = "sarath.bu@pitsolutions.com";
            //email.FunnyLink();
            email.Send();
            return View();
        }

    public ActionResult Display()
        {
            return View();
        }
    }
}