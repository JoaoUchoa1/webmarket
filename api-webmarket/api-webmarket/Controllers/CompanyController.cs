﻿using api_webmarket.Domain.Models;
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
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper; 

        public CompanyController(ICompanyService companyService, IMapper mapper) 
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CompanyResource>> GetAllAsync() 
        {
            var companies = await _companyService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Company>, IEnumerable<CompanyResource>>(companies);
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCompanyResource resource) 
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var company = _mapper.Map<SaveCompanyResource, Company>(resource);
            var result = await _companyService.SaveAsync(company);

            if (!result.Sucess)
                return BadRequest(result.Message);

            var companyResource = _mapper.Map<Company, CompanyResource>(result.Company);
            return Ok(companyResource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCompanyResource resource) 
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var company = _mapper.Map<SaveCompanyResource, Company>(resource);
            var result = await _companyService.UpdateAsync(id, company);

            if (!result.Sucess)
                return BadRequest(result.Message);

            var companyResource = _mapper.Map<Company, CompanyResource>(result.Company);
            return Ok(companyResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id) 
        {
            var result = await _companyService.DeleteAsync(id);

            if (!result.Sucess)
                return BadRequest(result.Message);

            var companyResource = _mapper.Map<Company, CompanyResource>(result.Company);
            return Ok(companyResource);
        }
    }
}
