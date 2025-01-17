﻿using api_webmarket.Domain.Models;
using api_webmarket.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Communication
{
    public class CompanyResponse : BaseResponse
    {
        public Company Company { get; private set; }

        private CompanyResponse(bool sucess, string message, Company company) : base(sucess, message) 
        {
            Company = company;
        }

        /// <summary>
        /// Creates a sucess response.
        /// </sumary>
        /// <param name="company">Saved category.</param>
        /// <returns>Response.</returns>

        public CompanyResponse(Company company) : this(true, string.Empty, company)
        { }

        /// <summary>
        /// Creates an error response
        /// </summary>
        /// <param name ="message">Error message</param>
        /// <returns>Response.</returns>

        public CompanyResponse(string message) : this(false, message, null)
        { }
    }
}
