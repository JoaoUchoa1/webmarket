using api_webmarket.Domain.Models;
using api_webmarket.Resources;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile() 
        {
            CreateMap< SaveCompanyResource, Company>();
            CreateMap< SavePurchaseResource, Purchase>();
            CreateMap< SaveUserResource, User>();
            CreateMap< SaveProductResource, Product>();
        }
    }
}
