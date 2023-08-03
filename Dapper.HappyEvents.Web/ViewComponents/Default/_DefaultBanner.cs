using Microsoft.AspNetCore.Mvc;

namespace Dapper.HappyEvents.Web.ViewComponents.Default
{
    public class _DefaultBanner: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
