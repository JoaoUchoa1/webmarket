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
    public class PurchaseController : Controller
    {
        private readonly IPurchaseService _purchaseService;

        public PurchaseController(IPurchaseService companyService) 
        {
            _purchaseService = companyService;
        }

        [HttpGet]
        public async Task<IEnumerable<Purchase>> GetAllAsync() 
        {
            var purchases = await _purchaseService.ListAsync();
            return purchases;
        }
    }
}
