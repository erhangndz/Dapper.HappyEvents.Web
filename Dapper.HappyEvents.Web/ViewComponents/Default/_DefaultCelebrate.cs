using Microsoft.AspNetCore.Mvc;

namespace Dapper.HappyEvents.Web.ViewComponents.Default
{
    public class _DefaultCelebrate:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
