using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestCalculator.Model
{
    public class Log
    {
        public int Id { get; set; }
        [Column(TypeName ="smalldatetime")]
        public DateTime InsertDate { get; set; } = DateTime.Now;
        [Required]
        public string Value { get; set; }

    }
}
