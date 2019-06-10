using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error(int id)
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}