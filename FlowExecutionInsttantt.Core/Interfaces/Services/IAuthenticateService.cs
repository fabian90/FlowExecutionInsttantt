using FlowExecutionInsttantt.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.Interfaces.Services
{
    public interface IAuthenticateService
    {
        UserAuthResponseDTO ValidateUser(string username, string password);
    }
}
