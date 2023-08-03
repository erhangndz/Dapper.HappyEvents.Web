using Microsoft.AspNetCore.Mvc;

namespace Dapper.HappyEvents.Web.ViewComponents.Default
{
    public class _DefaultVideo:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
