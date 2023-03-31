using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Status
    {
        [Key]
        public int statusID { get; set; }
        [MaxLength(20)]
        public string? statusName { get; set; }
        public DateTime createDate { get; set; }
    }
}
