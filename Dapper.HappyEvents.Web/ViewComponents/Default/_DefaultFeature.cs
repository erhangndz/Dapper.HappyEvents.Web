using Dapper.HappyEvents.Application.Dtos;
using Dapper.HappyEvents.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dapper.HappyEvents.Web.ViewComponents.Default
{
    public class _DefaultFeature:ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _DefaultFeature(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            var values = await _featureService.GetAllAsync();
     
            return View(values);
        }
    }
}
