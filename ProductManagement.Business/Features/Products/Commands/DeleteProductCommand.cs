using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Business.Features.Products.Commands
{
    public record DeleteProductCommand(int Id):IRequest<bool>
    {
    }
}
