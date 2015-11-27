using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Atrieflimmer.Models;

namespace Atrieflimmer.Controllers
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
            using (SiteEntities ctx = new SiteEntities())
            {
                ViewBag.Header = page;
                ViewBag.Information = ctx.Sites.First(s => s.Name == page).Text;
                return View();
            }
        }
    }
}