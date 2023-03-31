using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Orders
    {
        [Key]
        [MaxLength(20)]
        public string? orderID { get; set; }
        [MaxLength(20)]
        public string? customerID { get; set; }
        [MaxLength(6)]
        public string? typeGiftID { get; set; }
        public int statusID { get; set; }
        [MaxLength(125)]
        public string? orderCode { get; set; }
        public bool orderConfirm { get; set; }
        [MaxLength(125)]
        public string? note { get; set; }
        public DateTime createDate { get; set; }
    }
}
