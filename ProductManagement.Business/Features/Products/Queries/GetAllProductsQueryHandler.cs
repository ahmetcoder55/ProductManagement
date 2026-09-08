using AutoMapper;
using MediatR;
using ProductManagement.DataAccess.Abstract;
using ProductManagement.Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Business.Features.Products.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductDto?>>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<List<ProductDto?>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _manager.Products.GetAllAsync();
            var values = _mapper.Map<List<ProductDto>>(products);
            return values;
        }
    }
}
