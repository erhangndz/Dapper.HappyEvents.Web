using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.HappyEvents.Application.Dtos
{
    public class BlogDto
    {
        public int BlogID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string WriterImage { get; set; }
        public string WriterName { get; set; }
        public string Date { get; set; }
        public string TimeRead { get; set; }
    }
}
