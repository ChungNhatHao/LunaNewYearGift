using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderDetails
    {
        [Key]
        [MaxLength(25)]
        public string? orderDetailID { get; set; }
        [MaxLength(20)]
        public string? orderID { get; set; }
        [MaxLength(6)]
        public string? productID { get; set; }
        public DateTime createDate { get; set; }
    }
}
