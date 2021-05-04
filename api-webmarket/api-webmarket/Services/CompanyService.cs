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
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork) 
        {
            _companyRepository = companyRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _companyRepository.ListAsync();
        }

        public async Task<SaveCompanyResponse> SaveAsync(Company company) 
        {
            try
            {
                await _companyRepository.AddAsync(company);
                await _unitOfWork.CompleteAsync();

                return new SaveCompanyResponse(company);
            }
            catch (Exception ex) 
            { 
                return new SaveCompanyResponse($"An error occurred when saving the company: { ex.Message}");
            }
        }
    }
}
