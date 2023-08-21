using FlowExecutionInsttantt.Commons.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.Entities
{
    public class StepInputRelations : BaseEntity
    {
        public int Id { get; set; }
        public int StepId { get; set; }
        public int FieldId { get; set; }
        public virtual Steps  Steps { get; set; } 
        public virtual Fields Fields { get; set; } 
    }
}
