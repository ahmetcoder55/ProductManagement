using MediatR;
using ProductManagement.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Business.Features.Products.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IRepositoryManager _manager;

        public DeleteProductCommandHandler(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _manager.Products.GetByIdAsync(request.Id);
            if (product == null) return false;

            _manager.Products.Delete(product);
            await _manager.SaveChangesAsync();
            return true;

        }
    }
}
