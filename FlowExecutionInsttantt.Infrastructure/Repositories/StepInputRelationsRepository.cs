using FlowExecutionInsttantt.Commons.Mapping;
using FlowExecutionInsttantt.Commons.Paging;
using FlowExecutionInsttantt.Commons.RequestFilter;
using FlowExecutionInsttantt.Commons.Response;
using FlowExecutionInsttantt.Core.DTOs.Response;
using FlowExecutionInsttantt.Core.Entities;
using FlowExecutionInsttantt.Core.Interfaces.Repositories;
using FlowExecutionInsttantt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using monitoreo.Commons.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Infrastructure.Repositories
{
    public class StepInputRelationsRepository : GenericRepository<StepInputRelations, IdentityDBContext>, IStepInputRelationsRepository
    {
        protected readonly IdentityDBContext _context;

        public StepInputRelationsRepository(IdentityDBContext context) : base(context)
        {
            _context = context;
        }
        public async Task<RecordsResponse<StepInputRelationResponseDtos>> Get(QueryFilter filter)
        {
            var response = await _context.StepInputRelations.OrderBy(x => x.Id).Include(x=>x.Steps).Include(x=>x.Fields).GetPagedAsync(filter.page, filter.take);
            return response.MapTo<RecordsResponse<StepInputRelationResponseDtos>>()!;
        }
    }
}
