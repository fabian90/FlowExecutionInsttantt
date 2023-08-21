using FlowExecutionInsttantt.Commons.Repository.Entities;
using FlowExecutionInsttantt.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.Entities
{
    public class Steps : BaseEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public ICollection<StepInputRelations> InputRelations { get; set; }
    }
}
