using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string TotalValue { get; set; }
        public DateTime data = DateTime.Now;
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
