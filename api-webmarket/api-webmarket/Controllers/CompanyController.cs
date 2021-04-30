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
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService) 
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<IEnumerable<Company>> GetAllAsync() 
        {
            var companies = await _companyService.ListAsync();
            return companies;
        }
    }
}
