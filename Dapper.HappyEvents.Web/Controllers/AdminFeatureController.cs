using Dapper.HappyEvents.Application.Dtos;
using Dapper.HappyEvents.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dapper.HappyEvents.Web.Controllers
{
    public class AdminFeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public AdminFeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public async Task<IActionResult> Index()
        {
            
            var values = await _featureService.GetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(FeatureDto model)
        {
           await _featureService.AddAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _featureService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var values = await _featureService.GetByIdAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Update(FeatureDto p)
        {
           await _featureService.UpdateAsync(p);
            return RedirectToAction("Index");
        }


    }
}
