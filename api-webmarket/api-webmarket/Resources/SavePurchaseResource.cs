using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Resources
{
    public class SavePurchaseResource
    {
        [Required]
        [MaxLength(30)]
        public string TotalValue { get; set; }

        [Required]
        public DateTime data = DateTime.Now;
    }
}
