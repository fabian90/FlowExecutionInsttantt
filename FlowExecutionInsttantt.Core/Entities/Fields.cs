using FlowExecutionInsttantt.Commons.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.Entities
{
    public class Fields : BaseEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<StepInputRelations> InputRelations { get; set; }
    }
}
