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
        Task<PurchaseResponse> SaveAsync(Purchase purchase);
        Task<PurchaseResponse> UpdateAsync(int id, Purchase purchase);
        Task<PurchaseResponse> DeleteAsync(int id);
    }
}
