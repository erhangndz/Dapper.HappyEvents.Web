using Dapper.HappyEvents.Application.Dtos;
using Dapper.HappyEvents.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dapper.HappyEvents.Web.ViewComponents.Default
{
    public class _DefaultService:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _DefaultService(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            var values = await _serviceService.GetAllAsync();
            return View(values);
        }
    }
}
