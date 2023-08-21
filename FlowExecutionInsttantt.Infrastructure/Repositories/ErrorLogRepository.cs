using FlowExecutionInsttantt.Commons.Mapping;
using FlowExecutionInsttantt.Commons.Paging;
using FlowExecutionInsttantt.Commons.RequestFilter;
using FlowExecutionInsttantt.Commons.Response;
using FlowExecutionInsttantt.Core.DTOs.Response;
using FlowExecutionInsttantt.Core.Entities;
using FlowExecutionInsttantt.Core.Interfaces.Repositories;
using FlowExecutionInsttantt.Infrastructure.Data;
using monitoreo.Commons.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Infrastructure.Repositories
{
    public class ErrorLogRepository : GenericRepository<ErrorLog, IdentityDBContext>, IErrorLogRepository
    {
        protected new readonly IdentityDBContext _context;

        public ErrorLogRepository(IdentityDBContext context) : base(context)
        {
            _context = context;
        }



        public async Task<RecordsResponse<ErrorLogResponseDTO>> Get(QueryFilter filter)
        {
            var response = await _context.errorLog.OrderBy(x => x.Id).GetPagedAsync(filter.page, filter.take);
            return response.MapTo<RecordsResponse<ErrorLogResponseDTO>>()!;
        }
    }
}
