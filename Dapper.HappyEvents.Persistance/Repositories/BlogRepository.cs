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
    public class BlogRepository : IBlogService
    {
        private readonly string _connection = "server=ERHAN\\SQLEXPRESS;database=HappyEventsDb;integrated security=true";
        public async Task AddAsync(BlogDto t)
        {
            var connection = new SqlConnection(_connection);
            var command = $"insert into Blogs (Image, title,description,WriterImage, writername, date, timeread) values ('{t.Image}' ,'{t.Title}','{t.Description}','{t.WriterImage}','{t.WriterName}', '{DateTime.Now.ToShortDateString()}', '{t.TimeRead}')";
            await connection.ExecuteAsync(command);
        }
        public async Task DeleteAsync(int id)
        {
            var connection = new SqlConnection(_connection);
            var command = $"delete from blogs where BlogID='{id}'";
            await connection.ExecuteAsync(command);
        }
        public async Task<List<BlogDto>> GetAllAsync()
        {
            var connection = new SqlConnection(_connection);
            var command = "select * from blogs";
            return (List<BlogDto>)await connection.QueryAsync<BlogDto>(command);
        }
        public async Task<BlogDto> GetByIdAsync(int id)
        {
            var connection = new SqlConnection(_connection);
            var command = $"select * from Blogs where BlogID='{id}'";
           return await connection.QueryFirstAsync<BlogDto>(command);
        }

        public async Task UpdateAsync( BlogDto t)
        {
            var connection = new SqlConnection(_connection);
            var command = $"update Blogs set Image='{t.Image}' ,title='{t.Title}', description = '{t.Description}', writerImage='{t.WriterImage}', writername='{t.WriterName}', date='{t.Date}', timeread='{t.TimeRead}' where BlogID='{t.BlogID}' ";
            await connection.ExecuteAsync(command);
        }
    }
}
