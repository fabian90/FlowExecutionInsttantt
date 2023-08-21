using AutoMapper;
using Azure.Core;
using FlowExecutionInsttantt.Commons.RequestFilter;
using FlowExecutionInsttantt.Commons.Response;
using FlowExecutionInsttantt.Core.DTOs.Request;
using FlowExecutionInsttantt.Core.DTOs.Response;
using FlowExecutionInsttantt.Core.Interfaces.Services;
using FlowExecutionInsttantt.Core.Services;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlowExecutionInsttantt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FlowController : ControllerBase
    {
        private readonly IStepInputRelationsService _stepInputRelationsService;
        private readonly IMapper _mapper;
        //private readonly IValidator<ErrorLogRequestDTO> _validatorErrorLog;
        private readonly IErrorLogService _errorLogService;
        public FlowController(IStepInputRelationsService stepInputRelationsService, IMapper mapper, IErrorLogService errorLogService)
        {
            _stepInputRelationsService = stepInputRelationsService;
            _mapper = mapper;
            //_validatorErrorLog = validatorErrorLog;
            _errorLogService= errorLogService;
        }
        // GET: api/<FlowController>
        [HttpGet]
        public async Task<List<ApiResponse<StepInputRelationResponseDtos>>> Get()
        {
            List<ApiResponse<StepInputRelationResponseDtos>> apiResponses = new List<ApiResponse<StepInputRelationResponseDtos>>();
            ErrorLogRequestDTO errorLog = new ErrorLogRequestDTO();
            ApiResponse<StepInputRelationResponseDtos> response = await _stepInputRelationsService.GetAll();        
        
            try
            {
                var groupedSetp = response.DataList.GroupBy(p => p.StepId)
                                  .Select(StepGroup => new
                                  {
                                      Setp = StepGroup.Key,
                                      Fileds = string.Join(",", StepGroup.OrderBy(x => x.FieldId).Select(p => p.FieldId)),
                                  });


                foreach (var item in groupedSetp)
                {
                    ApiResponse<StepInputRelationResponseDtos> apiResponse = new ApiResponse<StepInputRelationResponseDtos>();
                    string[] parts = item.Fileds.Split(',');               
                        if (!parts.Where(x => x == "1" && x == "2" || (x == "1" && x == "2" && x == "3" && x == "4" && x == "5")).Any())
                        {
                            if (item.Setp == 1)
                            {
                                foreach (string part in parts)
                                {

                                    apiResponse.Pasos = "1";
                                    if (part == "1")
                                    {
                                        apiResponse.Result = "Asigna a F-001 = " + part;
                                    }
                                    else
                                    {
                                        apiResponse.Result += "Asigna a F-002 = " + part;
                                    }

                                }
                                apiResponses.Add(apiResponse);

                            }
                            if (item.Setp == 2)
                            {
                                apiResponse.Pasos = "2";
                            int result = 0;
                            foreach (string part in parts)
                            {
                                result += Convert.ToInt32(part);
                            }
                                apiResponse.Result = "Asigna a F-003 = " + result;
                                apiResponses.Add(apiResponse);
                            }
                            if (item.Setp == 3)
                            {
                                apiResponse.Pasos = "3";
                                double result = 1;
                                foreach (string part in parts)
                                {                                   
                                   result = result/ Convert.ToInt32(part);
                                }
                            apiResponse.Result = "Asigna a F-004 = " + result;
                             apiResponses.Add(apiResponse);
                            }
                            if (item.Setp == 4)
                            {
                                apiResponse.Pasos = "4";
                            double result = 1;
                            foreach (string part in parts)
                            {
                                result= result * Convert.ToInt32(part);
                            }
                            apiResponse.Result = "Asigna a F-005 = " + result;
                                apiResponses.Add(apiResponse);
                            }
                            if (item.Setp == 5)
                            {
                                apiResponse.Pasos = "5";
                            int result = 0;
                            foreach (string part in parts)
                            {
                                result += Convert.ToInt32(part);
                            }
                                apiResponse.Result = "Asigna a F-006 = " + result;
                                 apiResponses.Add(apiResponse);
                            }
                        }
                }
                errorLog.Mensaje = "Exitos";
                errorLog.Detalles = "Get";
                await _errorLogService.Guardar(errorLog);
              
            }
            catch (Exception ex)
            {
                errorLog.Mensaje = ex.Message;
                errorLog.Detalles = ex.StackTrace;
                await _errorLogService.Guardar(errorLog);
            }
            return  apiResponses;
        }
    }
}
