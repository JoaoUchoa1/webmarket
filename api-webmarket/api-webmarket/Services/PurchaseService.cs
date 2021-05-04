using api_webmarket.Communication;
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
        private readonly IUnitOfWork _unitOfWork;

        public PurchaseService(IPurchaseRepository purchaseRepository, IUnitOfWork unitOfWork) 
        {
            _purchaseRepository = purchaseRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Purchase>> ListAsync()
        {
            return await _purchaseRepository.ListAsync();
        }

        public async Task<SavePurchaseResponse> SaveAsync(Purchase purchase)
        {
            try
            {
                await _purchaseRepository.AddAsync(purchase);
                await _unitOfWork.CompleteAsync();

                return new SavePurchaseResponse(purchase);
            }
            catch (Exception ex)
            {
                return new SavePurchaseResponse($"An error occurred when saving the Purchase: { ex.Message}");
            }
        }
    }
}
