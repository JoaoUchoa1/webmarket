using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string NameFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public long cnpj { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
