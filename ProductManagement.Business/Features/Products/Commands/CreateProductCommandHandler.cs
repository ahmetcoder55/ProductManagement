using AutoMapper;
using MediatR;
using ProductManagement.DataAccess.Abstract;
using ProductManagement.Entities.Concrete;
using ProductManagement.Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Business.Features.Products.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductDto>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request.CreateProductDto);
            await _manager.Products.AddAsync(product);
            await _manager.SaveChangesAsync();
            return _mapper.Map<ProductDto>(product);
        }
    }
}
