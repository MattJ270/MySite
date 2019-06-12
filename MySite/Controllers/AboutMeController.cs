using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class AboutMeController : Controller
    {
        [HandleError]
        public ActionResult AboutMe()
        {
            return View();
        }
    }
}