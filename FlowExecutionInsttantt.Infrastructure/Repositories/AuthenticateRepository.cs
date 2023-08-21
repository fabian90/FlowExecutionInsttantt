using FlowExecutionInsttantt.Core.Entities;
using FlowExecutionInsttantt.Core.Interfaces.Repositories;
using FlowExecutionInsttantt.Infrastructure.Data;
using monitoreo.Commons.Repository;

namespace FlowExecutionInsttantt.Infrastructure.Repositories
{
    public class AuthenticateRepository : GenericRepository<User, IdentityDBContext>, IAuthenticateRepository
    {
        protected readonly IdentityDBContext _context;

        public AuthenticateRepository(IdentityDBContext context) : base(context)
        {
            _context = context;
        }     
    }
}

