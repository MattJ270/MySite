using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        
        public ViewResult Home()
        {
            
            return View();
        }
        public FileResult GetResume()
        {
            return File("~/Personal/Resume/Resume.pdf", "application/pdf");
        }
        public FileResult DownloadResume()
        {
            return File("~/Personal/Resume/Resume.pdf", "application/pdf", Server.UrlEncode("../Resume/Resume.pdf"));
        }


    }
}