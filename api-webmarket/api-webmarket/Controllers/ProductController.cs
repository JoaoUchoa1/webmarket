using api_webmarket.Domain.Models;
using api_webmarket.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Controllers
{
    [Route("/api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) 
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAllAsync() 
        {
            var products = await _productService.ListAsync();
            return products;
        }
    }
}
