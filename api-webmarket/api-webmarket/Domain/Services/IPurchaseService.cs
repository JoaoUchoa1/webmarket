using api_webmarket.Communication;
using api_webmarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Services
{
    public interface IPurchaseService
    {
        Task<IEnumerable<Purchase>> ListAsync();
        Task<SavePurchaseResponse> SaveAsync(Purchase purchase);
        Task<SavePurchaseResponse> UpdateAsync(int id, Purchase purchase);
    }
}
