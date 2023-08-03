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
    public class ServiceRepository : IServiceService
    {
        private readonly string _connection = "server=ERHAN\\SQLEXPRESS;database=HappyEventsDb;integrated security=true";
        public async Task AddAsync(ServiceDto t)
        {
            var connection = new SqlConnection(_connection);
            var command = $"insert into services (title,description,Icon) values ('{t.Title}','{t.Description}','{t.Icon}')";
            await connection.ExecuteAsync(command);
        }
        public async Task DeleteAsync(int id)
        {
            var connection = new SqlConnection(_connection);
            var command = $"delete from services where serviceID='{id}'";
            await connection.ExecuteAsync(command);
        }

        public async Task<List<ServiceDto>> GetAllAsync()
        {
            var connection = new SqlConnection(_connection);
            var command = "select * from Services";
            return (List<ServiceDto>) await connection.QueryAsync<ServiceDto>(command);
        }

        public async Task<ServiceDto> GetByIdAsync(int id)
        {
            var connection = new SqlConnection(_connection);
            var command = $"select * from services where serviceID='{id}'";
            return await connection.QueryFirstAsync<ServiceDto>(command);
        }

        public async Task UpdateAsync(ServiceDto t)
        {
            var connection = new SqlConnection(_connection);
            var command = $"update services set title='{t.Title}', description = '{t.Description}', Icon='{t.Icon}'  where serviceID='{t.ServiceID}' ";
            await connection.ExecuteAsync(command);
        }
    }
}
