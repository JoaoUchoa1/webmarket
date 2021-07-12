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

        public async Task<CompanyResponse> SaveAsync(Company company) 
        {
            try
            {
                await _companyRepository.AddAsync(company);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(company);
            }
            catch (Exception ex) 
            { 
                return new CompanyResponse($"An error occurred when saving the company: { ex.Message}");
            }
        }

        public async Task<CompanyResponse> UpdateAsync(int id, Company company)
        {
            var existingCompany = await _companyRepository.FindByIdAsync(id);

            if (existingCompany == null)
                return new CompanyResponse("Company not found");

            existingCompany.NameFantasia = company.NameFantasia;
            existingCompany.RazaoSocial = company.RazaoSocial;
            existingCompany.Cnpj = company.Cnpj;

            try
            {
                _companyRepository.Update(existingCompany);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(existingCompany);
            }
            catch(Exception ex)
            { 
                return new CompanyResponse($"An error ocurred when updaing the category: { ex.Message}");
            }
        }

        public async Task<CompanyResponse> DeleteAsync(int id)
        {

            var existingCompany = await _companyRepository.FindByIdAsync(id);
            if (existingCompany == null)
                return new CompanyResponse("Company Not Found.");

            try
            {
                _companyRepository.Delete(existingCompany);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(existingCompany);
            }
            catch (Exception ex) 
            {
                return new CompanyResponse($"An error occurred when deleting  the company");

            }
        }

    }
}
