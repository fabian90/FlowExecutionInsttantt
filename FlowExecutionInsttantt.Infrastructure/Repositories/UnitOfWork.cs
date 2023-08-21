

using FlowExecutionInsttantt.Core.Interfaces.Repositories;
using FlowExecutionInsttantt.Infrastructure.Data;

namespace FlowExecutionInsttantt.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IdentityDBContext _context;
        private readonly IErrorLogRepository _errorLogRepository;
        private readonly IStepInputRelationsRepository _stepInputRelationsRepository;
        
        public UnitOfWork(IdentityDBContext context)
        {
            _context = context;
        }

        //public IUserRepository UserRepository => _userRepository ?? new UserRepository(_context);
        public IErrorLogRepository ErrorLogRepository => _errorLogRepository ?? new ErrorLogRepository(_context);
        public IStepInputRelationsRepository stepInputRelationsRepository=>_stepInputRelationsRepository?? new StepInputRelationsRepository(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
