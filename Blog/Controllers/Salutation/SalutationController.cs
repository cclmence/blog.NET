using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers.Salutation
{
    public class SalutationController : Controller
    {
        // GET: Salutation
        public ActionResult Index()
        {
            Visiteur client = new Visiteur();
            return View(client);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(Visiteur visiteur)
        {
            Visiteur client = new Visiteur();
            string prenom = "";

            prenom = Request.Form["prenom_visiteur"];
            client.Prenom = prenom;
            ViewData["message"] = "Bonjour à toi, " + prenom;
            return View("Index", client);
        }
    }
}