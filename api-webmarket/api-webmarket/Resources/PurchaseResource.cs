using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Resources
{
    public class PurchaseResource
    {
        public int Id { get; set; }
        public string TotalValue { get; set; }
        public DateTime data = DateTime.Now;
        
    }
}
