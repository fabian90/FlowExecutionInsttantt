using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowExecutionInsttantt.Core.DTOs.Request
{
    public class ErrorLogRequestDTO
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        [Required]
        public string? Mensaje { get; set; }
        [Required]
        public string? Detalles { get; set; }
    }
}
