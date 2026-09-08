using AutoMapper;
using ProductManagement.Entities.Concrete;
using ProductManagement.Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Business.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
        }
    }
}
