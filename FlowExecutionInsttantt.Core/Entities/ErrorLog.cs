using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowExecutionInsttantt.Commons.Repository.Entities;

namespace FlowExecutionInsttantt.Core.Entities
{
    public partial class ErrorLog : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Mensaje { get; set; }
        public string Detalles { get; set; }

    }
}
