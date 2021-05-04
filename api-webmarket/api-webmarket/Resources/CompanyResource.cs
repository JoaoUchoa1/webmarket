using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Resources
{
    public class CompanyResource
    {
        public int Id { get; set; }
        public string NameFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public long Cnpj { get; set; }
    }
}
