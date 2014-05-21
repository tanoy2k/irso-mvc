using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Boolean ses = ValidarSesion();
            if (ses)
            {
                return View(); 
            }
            return RedirectToAction("Index", "Login");

            
        }

        public ActionResult Tickets()
        {
            if (ValidarSesion())
            {
                return View();  
            }
            return RedirectToAction("Index", "Login");
        }

        public ActionResult CreateTicket()
        {
            return View();

        }

        public Boolean ValidarSesion()
        {
            if (Session["Usuario"] == null)
            { return false;}
            return true;
        }
    }
}
