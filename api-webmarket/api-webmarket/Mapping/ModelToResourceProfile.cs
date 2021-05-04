using api_webmarket.Domain.Models;
using api_webmarket.Resources;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile() 
        {
            CreateMap<Company, CompanyResource>();
            CreateMap<Purchase, PurchaseResource>();
            CreateMap<User, UserResource>();
            CreateMap<Product, ProductResource>();
        }
    }
}
