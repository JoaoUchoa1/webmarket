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

        public async Task<PurchaseResponse> SaveAsync(Purchase purchase)
        {
            try
            {
                await _purchaseRepository.AddAsync(purchase);
                await _unitOfWork.CompleteAsync();

                return new PurchaseResponse(purchase);
            }
            catch (Exception ex)
            {
                return new PurchaseResponse($"An error occurred when saving the Purchase: { ex.Message}");
            }
        }

        public async Task<PurchaseResponse> UpdateAsync(int id, Purchase purchase)
        {
            var existingPurchase = await _purchaseRepository.FindByIdAsync(id);

            if (existingPurchase == null)
                return new PurchaseResponse("Purchase not found");

            existingPurchase.data = purchase.data;
            existingPurchase.TotalValue = purchase.TotalValue;

            try
            {
                _purchaseRepository.Update(existingPurchase);
                await _unitOfWork.CompleteAsync();

                return new PurchaseResponse(existingPurchase);
            }
            catch (Exception ex) 
            {
                return new PurchaseResponse($"An error ocurred when updating the purchages:  { ex.Message }"); 
            }

        }
        public async Task<PurchaseResponse> DeleteAsync(int id)
        {
            var existingPurchase = await _purchaseRepository.FindByIdAsync(id);

            if (existingPurchase == null)
                return new PurchaseResponse("Product not found");

            try
            {
                _purchaseRepository.Delete(existingPurchase);
                await _unitOfWork.CompleteAsync();

                return new PurchaseResponse(existingPurchase);
            }
            catch (Exception ex)
            {
                return new PurchaseResponse($"An error occurred when deleting the product: {ex.Message}");
            }
        }
    }
}
