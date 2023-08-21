using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.DTOs.Request
{
    public class StepRequestDtos
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public ICollection<StepInputRelationRequestDtos> InputRelationsRequestDtos { get; set; }
    }
}
