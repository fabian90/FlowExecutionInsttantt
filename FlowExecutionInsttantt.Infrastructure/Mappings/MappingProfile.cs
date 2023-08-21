using AutoMapper;
using FlowExecutionInsttantt.Core.DTOs.Request;
using FlowExecutionInsttantt.Core.DTOs.Response;
using FlowExecutionInsttantt.Core.Entities;

namespace FlowExecutionInsttantt.Infrastructure.Interfaces
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region User
            CreateMap<User, UserRequestDTO>();
            CreateMap<User, UserResponseDTO>();
            CreateMap<UserRequestDTO, User>();
            CreateMap<UserResponseDTO, User>();
            #endregion
            #region StepInputRelations
            CreateMap<StepInputRelations, StepInputRelationRequestDtos>();
            CreateMap<StepInputRelations, StepInputRelationResponseDtos>();
            CreateMap<StepInputRelationRequestDtos, StepInputRelations>();
            CreateMap<StepInputRelationResponseDtos, StepInputRelations>();
            #endregion

            #region ErrorLog
            CreateMap<ErrorLog, ErrorLogRequestDTO>();
            CreateMap<ErrorLog, ErrorLogResponseDTO>();
            CreateMap<ErrorLogRequestDTO, ErrorLog>();
            CreateMap<ErrorLogResponseDTO, ErrorLog>();
            #endregion
        }
    }
}
