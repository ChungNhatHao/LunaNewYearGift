using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TypeGifts
    {
        [Key]
        [MaxLength(6)]
        public string? typeGiftID { get; set; }
        [MaxLength(50)]
        public string? typeGiftImageCode { get; set; }
        public DateTime createDate { get; set; }
    }
}
