using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.HappyEvents.Application.Dtos
{
    public class TestimonialDto
    {
        public int TestimonialID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
    }
}
