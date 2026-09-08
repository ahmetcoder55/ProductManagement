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
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ProductDto?>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<ProductDto?> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {

            var updatedProduct = await _manager.Products.GetByIdAsync(request.UpdateProductDto.Id);
            if(updatedProduct is null)
            {
                return null;
            }
            _mapper.Map(request.UpdateProductDto,updatedProduct);
            updatedProduct.UpdatedDate= DateTime.Now;
            _manager.Products.Update(updatedProduct);
            await _manager.SaveChangesAsync();
            return _mapper.Map<ProductDto>(updatedProduct);
        }
    }
}
