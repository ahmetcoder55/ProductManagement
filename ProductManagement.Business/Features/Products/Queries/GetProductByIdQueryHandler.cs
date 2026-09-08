using AutoMapper;
using MediatR;
using ProductManagement.DataAccess.Abstract;
using ProductManagement.Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Business.Features.Products.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto?>
    {
        private readonly IRepositoryManager _manager;

        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<ProductDto?> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _manager.Products.GetByIdAsync(request.Id);
            if(product is null)
            {
                throw new Exception($"{request.Id} numaralı ürün bulunamadı.");
            }
            var productDto=_mapper.Map<ProductDto>(product);
            return productDto;
        }
    }
}
