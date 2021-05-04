using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Resources
{
    public class SaveCompanyResource
    {
        [Required]
        [MaxLength(30)]
        public string NameFantasia { get; set; }
        [Required]
        [MaxLength(30)]
        public string RazaoSocial { get; set; }
        [Required]
        [MaxLength(30)]
        public long Cnpj { get; set; }
    }
}
