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
                Usuario uDTO=new Usuario();
                uDTO = loginUsuario.GetUsuarioId(loginUsuario.usuario);
                Session["Usuario"] = loginUsuario.usuario;
                Session["UsuarioId"] = uDTO.usuarioId;
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
