using FlowExecutionInsttantt.Commons.RequestFilter;
using FlowExecutionInsttantt.Commons.Response;
using FlowExecutionInsttantt.Core.DTOs.Response;
using FlowExecutionInsttantt.Core.Entities;
using monitoreo.Commons.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.Interfaces.Repositories
{
    public interface IErrorLogRepository : IGenericRepository<ErrorLog>
    {
        Task<RecordsResponse<ErrorLogResponseDTO>> Get(QueryFilter filter);

    }
}
