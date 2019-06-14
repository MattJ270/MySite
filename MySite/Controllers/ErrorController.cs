using System.Web.Mvc;

namespace MySite.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error(int id)
        {
            Response.StatusCode = id;
            return View();
        }
    }
}
