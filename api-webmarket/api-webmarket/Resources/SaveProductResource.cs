using api_webmarket.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Resources
{
    public class SaveProductResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string Description { get; set; }

        [Required]
        public Epayment Payment { get; set; }

        [Required]
        public float Valor { get; set; }

        [Required]
        [MaxLength(30)]
        public string Obs { get; set; }
    }
}
