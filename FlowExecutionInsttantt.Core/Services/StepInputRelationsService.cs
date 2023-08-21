using AutoMapper;
using FlowExecutionInsttantt.Commons.RequestFilter;
using FlowExecutionInsttantt.Commons.Response;
using FlowExecutionInsttantt.Core.DTOs.Response;
using FlowExecutionInsttantt.Core.Entities;
using FlowExecutionInsttantt.Core.Interfaces.Repositories;
using FlowExecutionInsttantt.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.Services
{
    public class StepInputRelationsService : IStepInputRelationsService
    {
        private string table = "StepInputRelation";
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IPasswordService _passwordService;

        public StepInputRelationsService(IUnitOfWork unitOfWork, IMapper mapper, IPasswordService passwordService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _passwordService = passwordService;
        }
        public async Task<RecordsResponse<StepInputRelationResponseDtos>> Get(QueryFilter filter)
        {
            var response = await _unitOfWork.stepInputRelationsRepository.Get(filter);

            return response;
        }
        public async Task <ApiResponse<StepInputRelationResponseDtos>> GetAll()
        {
          var stepInputRelation = _unitOfWork.stepInputRelationsRepository.GetAll();
          var mapper = _mapper.Map <List<StepInputRelationResponseDtos>>(stepInputRelation);

            return new ApiResponse<StepInputRelationResponseDtos>()
            {
                DataList = mapper,
                Success = true,
                Message = "Successfully retrieved the list from "+ table +" table.",
            };
        }
    }
}
