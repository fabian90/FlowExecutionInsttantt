using FlowExecutionInsttantt.Commons.RequestFilter;
using FlowExecutionInsttantt.Commons.Response;
using FlowExecutionInsttantt.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.Interfaces.Services
{
    public interface IStepInputRelationsService
    {
        Task<RecordsResponse<StepInputRelationResponseDtos>> Get(QueryFilter filter);
        Task<ApiResponse<StepInputRelationResponseDtos>> GetAll();
    }
}
