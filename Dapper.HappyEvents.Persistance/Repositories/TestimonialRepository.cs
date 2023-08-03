using Dapper.HappyEvents.Application.Dtos;
using Dapper.HappyEvents.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.HappyEvents.Persistance.Repositories
{
    public class TestimonialRepository : ITestimonialService
    {
        private readonly string _connection = "server=ERHAN\\SQLEXPRESS;database=HappyEventsDb;integrated security=true";
        public async Task AddAsync(TestimonialDto t)
        {
            var connection = new SqlConnection(_connection);
            var command = $"insert into testimonials (name,Image,title, comment) values ('{t.Name}','{t.Image}','{t.Title}','{t.Comment}')";
            await connection.ExecuteAsync(command);
        }

        public async Task DeleteAsync(int id)
        {
            var connection = new SqlConnection(_connection);
            var command = $"delete from testimonials where testimonialID='{id}'";
            await connection.ExecuteAsync(command);
        }

        public async Task<List<TestimonialDto>> GetAllAsync()
        {
            var connection = new SqlConnection(_connection);
            var command = "select * from testimonials";
            return (List<TestimonialDto>) await connection.QueryAsync<TestimonialDto>(command);
        }

        public async Task<TestimonialDto> GetByIdAsync(int id)
        {
            var connection = new SqlConnection(_connection);
            var command = $"select * from testimonials where testimonialID='{id}'";
            return await connection.QueryFirstAsync<TestimonialDto>(command);
        }

        public async Task UpdateAsync(TestimonialDto t)
        {
            var connection = new SqlConnection(_connection);
            var command = $"update testimonials set name='{t.Name}', Image = '{t.Image}', title='{t.Title}', comment='{t.Comment}' where testimonialID='{t.TestimonialID}' ";
            await connection.ExecuteAsync(command);
        }
    }
}
