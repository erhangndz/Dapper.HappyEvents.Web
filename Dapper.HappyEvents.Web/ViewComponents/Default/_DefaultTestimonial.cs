using Dapper.HappyEvents.Application.Dtos;
using Dapper.HappyEvents.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dapper.HappyEvents.Web.ViewComponents.Default
{
    public class _DefaultTestimonial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _DefaultTestimonial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           var values = await _testimonialService.GetAllAsync();
            return View(values);
        }
    }
}
