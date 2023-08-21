using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.DTOs.Response
{
    public class StepResponseDtos
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public ICollection<StepInputRelationResponseDtos> InputRelationsResponseDtos { get; set; }
    }
}
