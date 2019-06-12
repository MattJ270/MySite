using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class ContactController : Controller
    {
        [HandleError]
        public ViewResult Contact()
        {
            return View();
        }
    }
}