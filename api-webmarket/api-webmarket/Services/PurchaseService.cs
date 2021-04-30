using api_webmarket.Domain.Models;
using api_webmarket.Domain.Repositories;
using api_webmarket.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepository;

        public PurchaseService(IPurchaseRepository purchaseRepository) 
        {
            this._purchaseRepository = purchaseRepository;
        }

        public async Task<IEnumerable<Purchase>> ListAsync()
        {
            return await _purchaseRepository.ListAsync();
        }
    }
}
