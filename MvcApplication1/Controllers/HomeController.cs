using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            
            if (Session["Usuario"]== null)
            {
                return RedirectToAction("Index","Login");
            }
                
            else
            {
                return View();  
            }
            
        }

    }
}
