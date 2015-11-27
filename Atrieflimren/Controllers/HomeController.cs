using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Atrieflimren.Models;

namespace Atrieflimren.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Header = "om";
            return View();
        }

        public ActionResult Page(string page)
        {
            using (SiteEntitites ctx = new SiteEntitites())
            {
                ViewBag.Header = page;
                ViewBag.Information = ctx.Sites.First(s => s.Name == page).Text;
                return View();
            }
        }
    }
}