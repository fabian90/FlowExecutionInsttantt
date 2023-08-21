using FlowExecutionInsttantt.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.DTOs.Request
{
    public class StepInputRelationRequestDtos
    {
        public int Id { get; set; }
        public int StepId { get; set; }
        public int FieldId { get; set; }
        public virtual StepRequestDtos  Step { get; set; } 
        public virtual FieldRequestDtos Fields { get; set; }
    }
}
