using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using MvcApplication1.Models;


namespace MvcApplication1.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/


        public ActionResult Index()
        {
            Boolean ses = ValidarSesion();
            if (!ses)
            {
              Session.Clear();
              return View();

            }

        else
            {

                return RedirectToAction("Index", "Home"); 
            }

           
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

        public ActionResult ValidarLogin()
        {
            Usuario loginUsuario=new Usuario();
            loginUsuario.usuario = Request.QueryString["usuario"];
            loginUsuario.password = Request.QueryString["password"];
            Boolean autorizado = loginUsuario.ValidarUsuario();

            if (autorizado)
            {
                Session["Usuario"] = loginUsuario.usuario;
                Session["UsuarioId"] = loginUsuario.usuarioId;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");   
            }
        }

        public Boolean ValidarSesion()
        {
            if (Session["Usuario"] == null)
            { return false; }
            return true;
        }
        
    }
}
