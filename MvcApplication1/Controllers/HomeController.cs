using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using MvcApplication1.Models;

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
              TicketDAO uTkt = new TicketDAO();
                
                return View(uTkt.GetAllTicketsDAO());  
            }
            return RedirectToAction("Index", "Login");
        }

        public ActionResult CreateTicket()
        {
            return View();

        }

        [HttpPost]
        public ActionResult AddTicket()
        {
            Boolean ses = ValidarSesion();
            if (ses)
            {


                Ticket t = new Ticket();
                TicketDetalle tdet = new TicketDetalle();
                t.Estado = Convert.ToInt32((Request.Form["Estados"]));
                t.Prioridad = Convert.ToInt32(Request.Form["Prioridades"]);
                t.Usuario = Convert.ToInt32(Session["UsuarioId"]);
                t.UsuarioAsignado = Convert.ToInt32(Request.Form["Usuarios"]);
                tdet.UsuarioDetalle = Convert.ToInt32(Session["UsuarioId"]);
                tdet.Observaciones = Request.Form["Observaciones"];
                tdet.Ticketid = 1;
                t.SaveTicket(t, tdet);
                return Json(t);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }

        public Boolean ValidarSesion()
        {
            if (Session["Usuario"] == null)
            { return false;}
            return true;
        }

        public ActionResult EditTicket(int t)
        {
            Ticket tt=new Ticket();
            return View(tt.ticketDao(t));
            

        }
    }
}
