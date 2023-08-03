using Dapper.HappyEvents.Application.Dtos;
using Dapper.HappyEvents.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dapper.HappyEvents.Web.ViewComponents.Default
{
    public class _DefaultTeam:ViewComponent
    {
        private readonly ITeamService _teamService;

        public _DefaultTeam(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            var values = await _teamService.GetAllAsync();
            return View(values);
        }
    }
}
