using Dapper.HappyEvents.Application.Dtos;
using Dapper.HappyEvents.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.HappyEvents.Persistance.Repositories
{
    public class TeamRepository : ITeamService
    {
        private readonly string _connection = "server=ERHAN\\SQLEXPRESS;database=HappyEventsDb;integrated security=true";
        public async Task AddAsync(TeamDto t)
        {
            var connection = new SqlConnection(_connection);
            var command = $"insert into Teams (name,Image,facebook, twitter,instagram) values ('{t.Name}','{t.Image}','{t.facebook}','{t.twitter}','{t.instagram}')";
            await connection.ExecuteAsync(command);
        }
        public async Task DeleteAsync(int id)
        {
            var connection = new SqlConnection(_connection);
            var command = $"delete from teams where teamID='{id}'";
            await connection.ExecuteAsync(command);
        }
        public async Task<List<TeamDto>> GetAllAsync()
        {
            var connection = new SqlConnection(_connection);
            var command = "select * from Teams";
            return (List<TeamDto>) await connection.QueryAsync<TeamDto>(command);
        }
        public async Task<TeamDto> GetByIdAsync(int id)
        {
            var connection = new SqlConnection(_connection);
            var command = $"select * from teams where teamID='{id}'";
            return await connection.QueryFirstAsync<TeamDto>(command);
        }

        public async Task UpdateAsync(TeamDto t)
        {
            var connection = new SqlConnection(_connection);
            var command = $"update teams set name='{t.Name}', Image = '{t.Image}', facebook='{t.facebook}', twitter='{t.twitter}', instagram='{t.instagram}' where teamID='{t.TeamID}' ";
            await connection.ExecuteAsync(command);
        }
    }
}
