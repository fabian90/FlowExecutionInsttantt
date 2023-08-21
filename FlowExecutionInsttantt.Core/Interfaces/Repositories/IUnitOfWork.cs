﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IErrorLogRepository ErrorLogRepository { get; }
        IStepInputRelationsRepository stepInputRelationsRepository { get; }
        void SaveChanges();

        Task SaveChangesAsync();

    }
}
