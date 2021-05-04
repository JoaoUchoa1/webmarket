using api_webmarket.Domain.Models;
using api_webmarket.Domain.Services;
using api_webmarket.Extensions;
using api_webmarket.Resources;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public PurchaseController(IPurchaseService companyService, IMapper mapper) 
        {
            _purchaseService = companyService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PurchaseResource>> GetAllAsync() 
        {
            var purchases = await _purchaseService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Purchase>, IEnumerable<PurchaseResource>>(purchases);
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SavePurchaseResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var purchase = _mapper.Map<SavePurchaseResource, Purchase>(resource);
            var result = await _purchaseService.SaveAsync(purchase);

            if (!result.Sucess)
                return BadRequest(result.Message);

            var purchaseResource = _mapper.Map<Purchase, PurchaseResource>(result.Purchase);
            return Ok(purchaseResource);
        }
    }
}
