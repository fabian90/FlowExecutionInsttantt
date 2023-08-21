using FlowExecutionInsttantt.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.DTOs.Response
{
    public class StepInputRelationResponseDtos
    {
        public int Id { get; set; }
        public int StepId { get; set; }
        public int FieldId { get; set; }
        public virtual StepResponseDtos Steps { get; set; } = null!;
        public virtual FieldResponseDtos Fields { get; set; } = null!;
    }
}
