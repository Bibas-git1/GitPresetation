using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitPresetation.Controllers
{
    public class gitController : Controller
    {
        // GET: git
        public ActionResult Index()
        {
            return View("Git is the didstribution version control system");
        }
        public ActionResult Index1()
        {
            return View("Git is the didstribution version control system.  It is used for backup the code for future.");
        }
    }
}