using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Atrieflimren.Models;

namespace API2._1.Controllers
{
    public class UpdateController : ApiController
    {
        [HttpPut]
        public bool Update(string path, string text)
        {
            using (SiteEntitites ctx = new SiteEntitites())
            {
                Site subSite = ctx.Sites.First(s => s.Name ==path);
                if (subSite != null)
                {
                    subSite.Text = text;
                }
                ctx.SaveChanges();

                return true;
            }
        }

        [HttpGet]
        public string Get(string path)
        {
            using (SiteEntitites ctx = new SiteEntitites())
            {
                return ctx.Sites.FirstOrDefault(s => s.Name == path).Text;
            }
        }
    }
}
