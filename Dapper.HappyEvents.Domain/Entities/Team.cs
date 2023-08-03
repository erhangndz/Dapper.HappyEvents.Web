using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.HappyEvents.Domain.Entities
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string instagram { get; set; }
    }
}
