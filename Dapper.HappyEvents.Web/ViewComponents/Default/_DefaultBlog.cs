using Dapper.HappyEvents.Application.Dtos;
using Dapper.HappyEvents.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dapper.HappyEvents.Web.ViewComponents.Default
{
    public class _DefaultBlog:ViewComponent
    {
        private readonly IBlogService _blogService;

        public _DefaultBlog(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            var values = await _blogService.GetAllAsync();
            return View(values);
        }
    }
}
