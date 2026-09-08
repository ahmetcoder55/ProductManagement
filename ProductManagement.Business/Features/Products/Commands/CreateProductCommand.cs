using MediatR;
using ProductManagement.Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Business.Features.Products.Commands
{
    public record CreateProductCommand(CreateProductDto CreateProductDto):IRequest<ProductDto?>
    {
    }
}
