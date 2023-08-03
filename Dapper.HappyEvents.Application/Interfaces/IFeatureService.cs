using Dapper.HappyEvents.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.HappyEvents.Application.Interfaces
{
    public interface IFeatureService:IGenericService<FeatureDto>
    {
    }
}
