using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MvcApplication1.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            Session.Clear();
            return View();
        }

        public ActionResult Validate()
        {
            Session["Usuario"] = "Emilio";
            return Json(new {foo="bar", baz="Blech"}, JsonRequestBehavior.AllowGet);
           
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");

        }

        
    }
}
