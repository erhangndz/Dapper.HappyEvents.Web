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
    public class FeatureRepository:IFeatureService
    {
        private readonly string _connection = "server=ERHAN\\SQLEXPRESS;database=HappyEventsDb;integrated security=true";

        public async Task AddAsync(FeatureDto t)
        {
            var connection = new SqlConnection(_connection);
            var command = $"insert into Features (title,description,Icon, subtitle) values ('{t.Title}','{t.Description}','{t.Icon}','{t.Subtitle}')";
            await connection.ExecuteAsync(command);
        }
        public async Task DeleteAsync(int id)
        {
            var connection = new SqlConnection(_connection);
            var command = $"delete from features where FeatureID='{id}'";
            await connection.ExecuteAsync(command);
        }
        public async Task<List<FeatureDto>> GetAllAsync()
        {
            var connection = new SqlConnection(_connection);
            var command = "select * from Features";
            return (List<FeatureDto>) await connection.QueryAsync<FeatureDto>(command);
        }

        public async Task<FeatureDto> GetByIdAsync(int id)
        {
            var connection = new SqlConnection(_connection);
            var command = $"select * from Features where FeatureID='{id}'";
           return await connection.QueryFirstAsync<FeatureDto>(command);
        }

        public async Task UpdateAsync(FeatureDto t)
        {
            var connection = new SqlConnection(_connection);
            var command = $"update Features set title='{t.Title}', description = '{t.Description}', Icon='{t.Icon}', subtitle='{t.Subtitle}' where FeatureID='{t.FeatureID}' ";
            await connection.ExecuteAsync(command);
        }
    }
}
