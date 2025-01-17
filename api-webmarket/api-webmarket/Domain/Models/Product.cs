﻿using api_webmarket.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Epayment Payment { get; set; }
        public float Valor { get; set; }
        public string Obs { get; set; }
        
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public IList<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
