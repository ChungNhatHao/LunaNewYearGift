using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Products
    {
        [Key]
        [MaxLength(6)]
        public string? productID { get; set; }
        [MaxLength(6)]
        public string? unitID { get; set; }
        [MaxLength(250)]
        public string? productName { get; set; }
        public int price { get; set; }
        [MaxLength(6)]
        public string? productImageCode { get; set; }
        public DateTime createDate { get; set; }
    }
}
