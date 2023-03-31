using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customers
    {
        [Key]
        [MaxLength(20)]
        public string? customerID { get; set; }
        [MaxLength(50)]
        public string? customerName { get; set; }
        [MaxLength(20)]
        public string? phone { get; set; }
        [MaxLength(125)]
        public string? email { get; set; }
        [MaxLength(150)]
        public string? address { get; set; }
        public int numberOfOrder { get; set; }
        public DateTime createDate { get; set; }
    }
}
