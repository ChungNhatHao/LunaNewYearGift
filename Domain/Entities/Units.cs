using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Units
    {
        [Key]
        [MaxLength(6)]
        public string? unitID { get; set; }
        [MaxLength(10)]
        public string? unitName { get; set; }
        public DateTime createDate { get; set; }
    }
}
