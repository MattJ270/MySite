using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        [HandleError]
        public ViewResult Home()
        {
            return View();
        }
        public FileResult GetResume()
        {
            return File("../Resume/lorem-ipsum.pdf", "application/pdf");
        }
        public FileResult DownloadResume()
        {
            return File("../Resume/lorem-ipsum.pdf", "application/pdf", Server.UrlEncode("../Resume/lorem-ipsum.pdf"));
        }

    }
}