using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers.Gestion
{
    [Authorize]
    public class ArticleController : Controller
    {
        // GET: Article
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Articles/Creer
        public ActionResult Creer()
        {
            return View();
        }

        // POST: Articles/Creer
        [HttpPost]
        public ActionResult Creer (FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Articles/Modif/ArticleID
        public ActionResult Modif(int id)
        {
            return View();
        }

        // POST: Article/Modif/ArticleID
        [HttpPost]
        public ActionResult Modif(int id, FormCollection collection)
        {
            try
            {
                // TODO : Add update logic here
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: Article/Suppr/ArticleID
        public ActionResult Suppr(int id)
        {
            return View();
        }

        // POST: Article/Suppr/ArticleID
        [HttpPost]
        public ActionResult Suppr(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}