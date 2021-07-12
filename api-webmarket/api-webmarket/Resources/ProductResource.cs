using api_webmarket.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Resources
{
    public class ProductResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Epayment Payment { get; set; }
        public float Valor { get; set; }
        public string Obs { get; set; }
    }
}
