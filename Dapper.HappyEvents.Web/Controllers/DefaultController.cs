using Microsoft.AspNetCore.Mvc;

namespace Dapper.HappyEvents.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
