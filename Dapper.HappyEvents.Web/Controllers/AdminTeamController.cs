using Dapper.HappyEvents.Application.Dtos;
using Dapper.HappyEvents.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dapper.HappyEvents.Web.Controllers
{
    public class AdminTeamController : Controller
    {
        private readonly ITeamService _teamService;

        public AdminTeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<IActionResult> Index()
        {
            
            var values = await _teamService.GetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(TeamDto model)
        {
            await _teamService.AddAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _teamService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var values = await _teamService.GetByIdAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Update(TeamDto p)
        {
            await _teamService.UpdateAsync(p);
            return RedirectToAction("Index");
        }
    }
}
