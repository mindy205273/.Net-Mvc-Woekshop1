using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Workshop.Controllers
{
    public class SearchController : Controller
    {
        // GET: Default
        public ActionResult SearchIndex()
        {
            return View();
        }
    }
}