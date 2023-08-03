using Dapper.HappyEvents.Application.Dtos;
using Dapper.HappyEvents.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dapper.HappyEvents.Web.Controllers
{
    public class AdminTestimonialController : Controller
    {
      private readonly ITestimonialService _testimonialService;

        public AdminTestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IActionResult> Index()
        {
           var values= await _testimonialService.GetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(TestimonialDto model)
        {
            await _testimonialService.AddAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _testimonialService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var values = await _testimonialService.GetByIdAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Update(TestimonialDto p)
        {
            await _testimonialService.UpdateAsync(p);
            return RedirectToAction("Index");
        }


    }
}
