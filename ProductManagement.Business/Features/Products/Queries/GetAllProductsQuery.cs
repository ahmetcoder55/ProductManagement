using MediatR;
using ProductManagement.Entities.Concrete;
using ProductManagement.Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Business.Features.Products.Queries
{
    public record GetAllProductsQuery:IRequest<List<ProductDto?>>
    {
    }
}
